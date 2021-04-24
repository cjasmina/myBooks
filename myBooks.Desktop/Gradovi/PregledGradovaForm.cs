using System;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

using myBooks.Model.Requests;

namespace myBooks.Desktop.Gradovi
{
    public partial class PregledGradovaForm : Form
    {
        private readonly ApiService _drzaveService = new ApiService("Drzave");
        private readonly ApiService _gradoviService = new ApiService("Gradovi");

        public PregledGradovaForm()
        {
            InitializeComponent();
        }

        private async void PregledGradovaForm_Load(object sender, EventArgs e)
        {
            GradoviDGV.AutoGenerateColumns = false;

            await UcitajDrzave();
            await UcitajGradove();
        }

        private async void DodajButton_Click(object sender, EventArgs e)
        {
            new UpravljanjeGradomForm().ShowDialog();

            await UcitajGradove();
        }

        private async void PretragaButton_Click(object sender, EventArgs e)
        {
            await UcitajGradove();
        }

        private async void GradoviDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabraniGradId = int.Parse(GradoviDGV.Rows[e.RowIndex].Cells[0].Value.ToString());

            new UpravljanjeGradomForm(odabraniGradId).ShowDialog();

            await UcitajGradove();
        }

        private async Task UcitajDrzave()
        {
            var drzave = await _drzaveService.Get<List<Model.Drzave>>();
            drzave.Insert(0, new Model.Drzave()
            {
                Naziv = "Odaberite državu"
            });

            DrzavaComboBox.DataSource = drzave;
            DrzavaComboBox.DisplayMember = nameof(Model.Drzave.Naziv);
            DrzavaComboBox.ValueMember = nameof(Model.Drzave.DrzavaId);
        }

        private async Task UcitajGradove()
        {
            var odabranaDrzavaId = int.Parse(DrzavaComboBox.SelectedValue.ToString());

            var request = new GradoviSearchRequest
            {
                DrzavaId = odabranaDrzavaId == 0 ? (int?)null : odabranaDrzavaId,
                Naziv = NazivTextBox.Text,
            };

            var gradovi = await _gradoviService.Get<List<Model.Gradovi>>(request);

            GradoviDGV.DataSource = gradovi;
        }
    }
}
