using System;
using System.Windows.Forms;
using System.ComponentModel;

using myBooks.Model.Requests;
using myBooks.Desktop.Helpers;

namespace myBooks.Desktop.Jezici
{
    public partial class UpravljanjeJezikomForm : Form
    {
        private readonly int? _jezikId;
        private readonly ApiService _jezikService = new ApiService("Jezici");

        public UpravljanjeJezikomForm(int? jezikId = null)
        {
            _jezikId = jezikId;

            InitializeComponent();
        }

        private async void UpravljanjeJezikomForm_Load(object sender, EventArgs e)
        {
            if (_jezikId != null)
            {
                var jezik = await _jezikService.GetById<Model.Jezici>(_jezikId);

                NazivTextBox.Text = jezik.Naziv;
            }
        }

        private async void SpremiButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var request = new JeziciUpsertRequest
                {
                    Naziv = NazivTextBox.Text,
                };

                if (_jezikId == null)
                {
                    await _jezikService.Insert<Model.Jezici>(request);
                }
                else
                {
                    await _jezikService.Update<Model.Jezici>(_jezikId, request);
                }

                MessageBox.Show(_jezikId == null ? "Jezik uspješno dodan!" : "Jezik uspješno izmijenjen!", "Jezici", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

                Close();
            }
        }

        private void UpravljanjeJezikomForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ErrorProvider.Clear();
            e.Cancel = false;
        }

        private void NazivTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validacija.ValidirajTextBox(e, ErrorProvider, NazivTextBox, "Naziv jezika je obavezan!");
        }
    }
}
