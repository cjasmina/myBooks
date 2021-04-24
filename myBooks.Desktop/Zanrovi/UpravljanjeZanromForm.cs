using System;
using System.Windows.Forms;
using System.ComponentModel;

using myBooks.Model.Requests;
using myBooks.Desktop.Helpers;

namespace myBooks.Desktop.Zanrovi
{
    public partial class UpravljanjeZanromForm : Form
    {
        private readonly int? _zanrId;
        private readonly ApiService _zanrService = new ApiService("Zanrovi");

        public UpravljanjeZanromForm(int? zanrId = null)
        {
            _zanrId = zanrId;

            InitializeComponent();
        }

        private async void UpravljanjeZanromForm_Load(object sender, EventArgs e)
        {
            if (_zanrId != null)
            {
                var zanr = await _zanrService.GetById<Model.Zanrovi>(_zanrId);

                NazivTextBox.Text = zanr.Naziv;
            }
        }

        private async void SpremiButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var request = new ZanroviInsertRequest
                {
                    Naziv = NazivTextBox.Text,
                };

                if (_zanrId == null)
                {
                    await _zanrService.Insert<Model.Zanrovi>(request);
                }
                else
                {
                    await _zanrService.Update<Model.Zanrovi>(_zanrId, request);
                }

                MessageBox.Show(_zanrId == null ? "Žanr uspješno dodan!" : "Žanr uspješno izmijenjen!", "Žanrovi", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

                Close();
            }
        }

        private void NazivTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validacija.ValidirajTextBox(e, ErrorProvider, NazivTextBox, "Naziv žanra je obavezan!");
        }

        private void UpravljanjeZanromForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ErrorProvider.Clear();
            e.Cancel = false;
        }
    }
}
