using System;
using System.Windows.Forms;
using System.ComponentModel;

using myBooks.Model.Requests;
using myBooks.Desktop.Helpers;

namespace myBooks.Desktop.Drzave
{
    public partial class UpravljanjeDrzavomForm : Form
    {
        private readonly int? _drzavaId;
        private readonly ApiService _drzaveService = new ApiService("Drzave");

        public UpravljanjeDrzavomForm(int? drzavaId = null)
        {
            _drzavaId = drzavaId;

            InitializeComponent();
        }

        private async void UpravljanjeDrzavomForm_Load(object sender, EventArgs e)
        {
            if (_drzavaId != null)
            {
                var drzava = await _drzaveService.GetById<Model.Drzave>(_drzavaId);

                NazivTextBox.Text = drzava.Naziv;
            }
        }

        private void NazivTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validacija.ValidirajTextBox(e, ErrorProvider, NazivTextBox, "Naziv države je obavezan!");
        }

        private async void SpremiButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var request = new DrzaveUpsertRequest
                {
                    Naziv = NazivTextBox.Text,
                };

                if (_drzavaId == null)
                {
                    await _drzaveService.Insert<Model.Drzave>(request);
                }
                else
                {
                    await _drzaveService.Update<Model.Drzave>(_drzavaId, request);
                }

                MessageBox.Show(_drzavaId == null ? "Država uspješno dodana!" : "Država uspješno izmijenjena!", "Države", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

                Close();
            }
        }

        private void UpravljanjeDrzavomForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ErrorProvider.Clear();
            e.Cancel = false;
        }
    }
}
