using System;
using System.Windows.Forms;
using System.ComponentModel;

using myBooks.Model.Requests;
using myBooks.Desktop.Helpers;

namespace myBooks.Desktop.Autori
{
    public partial class UpravljanjeAutoromForm : Form
    {
        private readonly int? _autorId;
        private readonly ApiService _autoriService = new ApiService("Autori");

        public UpravljanjeAutoromForm(int? autorId = null)
        {
            _autorId = autorId;

            InitializeComponent();
        }

        private async void UpravljanjeAutoromForm_Load(object sender, EventArgs e)
        {
            if (_autorId != null)
            {
                var autor = await _autoriService.GetById<Model.Autori>(_autorId);

                ImeTextBox.Text = autor.Ime;
                PrezimeTextBox.Text = autor.Prezime;
                DatumRodjenjaPicker.Value = autor.DatumRodjenja;
                BiografijaTextBox.Text = autor.Biografija;
            }
        }

        private void ImeTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validacija.ValidirajTextBox(e, ErrorProvider, ImeTextBox, "Ime autora je obavezan!");
        }

        private void PrezimeTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validacija.ValidirajTextBox(e, ErrorProvider, PrezimeTextBox, "Prezime autora je obavezan!");
        }

        private async void SpremiButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var request = new AutoriUpsertRequest
                {
                    Ime = ImeTextBox.Text,
                    Prezime = PrezimeTextBox.Text,
                    DatumRodjenja = DatumRodjenjaPicker.Value,
                    Biografija = BiografijaTextBox.Text,
                };

                if (_autorId == null)
                {
                    await _autoriService.Insert<Model.Autori>(request);
                }
                else
                {
                    await _autoriService.Update<Model.Autori>(_autorId, request);
                }

                MessageBox.Show(_autorId == null ? "Autor uspješno dodan!" : "Autor uspješno izmijenjen!", "Autori", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

                Close();
            }
        }

        private void UpravljanjeAutoromForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ErrorProvider.Clear();
            e.Cancel = false;
        }
    }
}
