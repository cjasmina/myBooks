using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

using myBooks.Model.Requests;

namespace myBooks.Desktop.Knjige
{
    public partial class PregledKnjigaForm : Form
    {
        private readonly ApiService _zanroviService = new ApiService("Zanrovi");
        private readonly ApiService _jeziciService = new ApiService("Jezici");
        private readonly ApiService _izdavackeKuceService = new ApiService("IzdavackeKuce");
        private readonly ApiService _knjigeService = new ApiService("Knjige");

        public PregledKnjigaForm()
        {
            InitializeComponent();
        }

        private async void PregledKnjigaForm_Load(object sender, EventArgs e)
        {
            KnjigeDGV.AutoGenerateColumns = false;

            await UcitajZanrove();
            await UcitajJezike();
            await UcitajIzdavackeKuce();
            await UcitajKnjige();
        }

        private async void DodajButton_Click(object sender, EventArgs e)
        {
            new UpravljanjeKnjigomForm().ShowDialog();

            await UcitajKnjige();
        }

        private async void PretragaButton_Click(object sender, EventArgs e)
        {
            await UcitajKnjige();
        }

        private async void KnjigeDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabranaKnjigaId = int.Parse(KnjigeDGV.Rows[e.RowIndex].Cells[0].Value.ToString());

            new UpravljanjeKnjigomForm(odabranaKnjigaId).ShowDialog();

            await UcitajKnjige();
        }

        private async Task UcitajZanrove()
        {
            var zanrovi = await _zanroviService.Get<List<Model.Zanrovi>>();
            zanrovi.Insert(0, new Model.Zanrovi()
            {
                Naziv = "Odaberite žanr"
            });

            ZanrComboBox.DataSource = zanrovi;
            ZanrComboBox.DisplayMember = nameof(Model.Zanrovi.Naziv);
            ZanrComboBox.ValueMember = nameof(Model.Zanrovi.ZanrId);
        }

        private async Task UcitajJezike()
        {
            var jezici = await _jeziciService.Get<List<Model.Jezici>>();
            jezici.Insert(0, new Model.Jezici()
            {
                Naziv = "Odaberite jezik"
            });

            JezikComboBox.DataSource = jezici;
            JezikComboBox.DisplayMember = nameof(Model.Jezici.Naziv);
            JezikComboBox.ValueMember = nameof(Model.Jezici.JezikId);
        }

        private async Task UcitajIzdavackeKuce()
        {
            var izdavackeKuce = await _izdavackeKuceService.Get<List<Model.IzdavackeKuce>>();
            izdavackeKuce.Insert(0, new Model.IzdavackeKuce()
            {
                Naziv = "Odaberite izdavačku kuću"
            });

            IzdavackaKucaComboBox.DataSource = izdavackeKuce;
            IzdavackaKucaComboBox.DisplayMember = nameof(Model.IzdavackeKuce.Naziv);
            IzdavackaKucaComboBox.ValueMember = nameof(Model.IzdavackeKuce.IzdavackaKucaId);
        }

        private async Task UcitajKnjige()
        {
            var odabraniZanrId = int.Parse(ZanrComboBox.SelectedValue.ToString());
            var odabraniJezikId = int.Parse(JezikComboBox.SelectedValue.ToString());
            var odabranaIzdavackaKuceId = int.Parse(IzdavackaKucaComboBox.SelectedValue.ToString());

            var request = new KnjigeSearchRequest
            {
                ZanrId = odabraniZanrId == 0 ? (int?)null : odabraniZanrId,
                JezikId = odabraniJezikId == 0 ? (int?)null : odabraniJezikId,
                IzdavackaKucaId = odabranaIzdavackaKuceId == 0 ? (int?)null : odabranaIzdavackaKuceId,
                ISBN = ISBNTextBox.Text,
            };

            var knjige = await _knjigeService.Get<List<Model.Knjige>>(request);

            KnjigeDGV.DataSource = knjige;
        }
    }
}
