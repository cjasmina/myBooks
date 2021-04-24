using System;
using System.Linq;
using System.Windows.Forms;

using myBooks.Model;
using myBooks.Model.Requests;

namespace myBooks.Desktop
{
    public partial class PrijavaForm : Form
    {
        private readonly ApiService _apiService = new ApiService("Korisnici");

        public PrijavaForm()
        {
            InitializeComponent();
        }

        private async void PrijavaButton_Click(object sender, EventArgs e)
        {
            ApiService.KorisnickoIme = KorisnickoImeTextBox.Text;
            ApiService.Lozinka = LozinkaTextBox.Text;

            try
            {
                KorisnickoImeTextBox.Enabled = false;
                LozinkaTextBox.Enabled = false;
                PrijavaButton.Enabled = false;

                var korisnik = await _apiService.GetAction<Korisnici>("Prijava", new KorisniciPrijavaRequest
                {
                    KorisnickoIme = KorisnickoImeTextBox.Text,
                    Uloga = Uloge.Administrator
                });
                if (korisnik == null)
                {
                    MessageBox.Show("Korisničko ime i/ili lozinka nisu ispravni.", "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Program.PrijavljeniKorisnik = korisnik;

                Hide();
                new PocetnaForm().ShowDialog();
                Close();

            }
            catch
            {
                MessageBox.Show("Dogodila se greška.", "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Close();
            }
            finally
            {
                KorisnickoImeTextBox.Enabled = true;
                LozinkaTextBox.Enabled = true;
                PrijavaButton.Enabled = true;
            }
        }
    }
}
