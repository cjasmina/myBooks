using System;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

using myBooks.Model.Requests;

namespace myBooks.Desktop.IzdavackeKuce
{
    public partial class PregledIzdavackihKucaForm : Form
    {
        private readonly ApiService _gradoviService = new ApiService("Gradovi");
        private readonly ApiService _izdavackeKuceService = new ApiService("IzdavackeKuce");

        public PregledIzdavackihKucaForm()
        {
            InitializeComponent();
        }
        private async void PregledIzdavackihKucaForm_Load(object sender, EventArgs e)
        {
            IzdavackeKuceDGV.AutoGenerateColumns = false;

            await UcitajGradove();
            await UcitajIzdavackeKuce();

        }

        private async void DodajButton_Click(object sender, EventArgs e)
        {
            new UpravljanjeIzdavackomKucomForm().ShowDialog();

            await UcitajIzdavackeKuce();
        }

        private async void PretragaButton_Click(object sender, EventArgs e)
        {
            await UcitajIzdavackeKuce();
        }

        private async void IzdavackeKuceDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabranaIzdavackaKucaId = int.Parse(IzdavackeKuceDGV.Rows[e.RowIndex].Cells[0].Value.ToString());

            new UpravljanjeIzdavackomKucomForm(odabranaIzdavackaKucaId).ShowDialog();

            await UcitajIzdavackeKuce();
        }

        private async Task UcitajGradove()
        {
            var gradovi = await _gradoviService.Get<List<Model.Gradovi>>();
            gradovi.Insert(0, new Model.Gradovi()
            {
                Naziv = "Odaberite grad"
            });

            GradComboBox.DataSource = gradovi;
            GradComboBox.DisplayMember = nameof(Model.Gradovi.Naziv);
            GradComboBox.ValueMember = nameof(Model.Gradovi.GradId);
        }

        private async Task UcitajIzdavackeKuce()
        {
            var odabraniGradId = int.Parse(GradComboBox.SelectedValue.ToString());

            var request = new IzdavackeKuceSearchRequest
            {
                GradId = odabraniGradId == 0 ? (int?)null : odabraniGradId,
                Naziv = NazivTextBox.Text,
            };

            var IzdavackeKuce = await _izdavackeKuceService.Get<List<Model.IzdavackeKuce>>(request);

            IzdavackeKuceDGV.DataSource = IzdavackeKuce;
        }
    }
}
