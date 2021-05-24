using System;
using System.Windows.Forms;

using Flurl.Http;

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

                var korisnik = await _apiService.GetAction<Korisnici>("Prijava");
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
            catch (FlurlHttpException ex)
            {
                if (ex.StatusCode == 401)
                {
                    MessageBox.Show("Korisničko ime i/ili lozinka nisu ispravni.", "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ex.StatusCode == 403)
                {
                    MessageBox.Show("Pristup nedozvoljen.", "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                throw;
            }
            catch(Exception ex)
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
