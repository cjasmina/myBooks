using System;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

using myBooks.Model.Requests;
using myBooks.Desktop.Helpers;

namespace myBooks.Desktop.Gradovi
{
    public partial class UpravljanjeGradomForm : Form
    {
        private readonly int? _gradId;
        private readonly ApiService _drzaveService;
        private readonly ApiService _gradoviService;

        public UpravljanjeGradomForm(int? gradId = null)
        {
            _gradId = gradId;
            _drzaveService = new ApiService("Drzave");
            _gradoviService = new ApiService("Gradovi");

            InitializeComponent();
        }

        private async void UpravljanjeGradomForm_Load(object sender, EventArgs e)
        {
            await UcitajDrzave();

            if (_gradId != null)
            {
                var grad = await _gradoviService.GetById<Model.Gradovi>(_gradId);

                NazivTextBox.Text = grad.Naziv;

                DrzavaComboBox.SelectedItem = DrzavaComboBox.Items.Cast<Model.Drzave>().First(d => d.DrzavaId == grad.DrzavaId);
            }
        }

        private void NazivTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validacija.ValidirajTextBox(e, ErrorProvider, NazivTextBox, "Naziv grada je obavezan!");
        }

        private async void SpremiButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var odabranaDrzavaid = int.Parse(DrzavaComboBox.SelectedValue.ToString());

                var request = new GradoviUpsertRequest
                {
                    DrzavaId = odabranaDrzavaid,
                    Naziv = NazivTextBox.Text,
                };

                if (_gradId == null)
                {
                    await _gradoviService.Insert<Model.Gradovi>(request);
                }
                else
                {
                    await _gradoviService.Update<Model.Gradovi>(_gradId, request);
                }
                MessageBox.Show(_gradId == null ? "Grad uspješno dodan!" : "Grad uspješno izmijenjen!", "Gradovi", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

                Close();
            }
        }

        private async Task UcitajDrzave()
        {
            var drzave = await _drzaveService.Get<List<Model.Drzave>>();

            DrzavaComboBox.DataSource = drzave;
            DrzavaComboBox.DisplayMember = nameof(Model.Drzave.Naziv);
            DrzavaComboBox.ValueMember = nameof(Model.Drzave.DrzavaId);
        }

        private void UpravljanjeGradomForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ErrorProvider.Clear();
            e.Cancel = false;
        }
    }
}
