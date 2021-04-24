using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

using myBooks.Model.Requests;

namespace myBooks.Desktop.Prijedlozi
{
    public partial class PregledPrijedlogaForm : Form
    {
        private readonly ApiService _korisniciService = new ApiService("Korisnici");
        private readonly ApiService _prijedloziService = new ApiService("Prijedlozi");

        public PregledPrijedlogaForm()
        {
            InitializeComponent();
        }

        private async void PregledPrijedlogaForm_Load(object sender, EventArgs e)
        {
            PrijedloziDGV.AutoGenerateColumns = false;

            await UcitajKorisnike();
            await UcitajPrijedloge();
        }

        private async void PretragaButton_Click(object sender, EventArgs e)
        {
            await UcitajPrijedloge();
        }

        private async Task UcitajKorisnike()
        {
            var drzave = await _korisniciService.Get<List<Model.Korisnici>>();
            drzave.Insert(0, new Model.Korisnici()
            {
                Ime = "Odaberite",
                Prezime = "korisnika"
            });

            KorisnikComboBox.DataSource = drzave;
            KorisnikComboBox.DisplayMember = nameof(Model.Korisnici.ImePrezime);
            KorisnikComboBox.ValueMember = nameof(Model.Korisnici.KorisnikId);
        }

        private async Task UcitajPrijedloge()
        {
            var odabraniKorisnikId = int.Parse(KorisnikComboBox.SelectedValue.ToString());

            var request = new PrijedloziSearchRequest
            {
                KorisnikId = odabraniKorisnikId == 0 ? (int?)null : odabraniKorisnikId,
                Naziv = NazivTextBox.Text,
                Autor = AutorTextBox.Text
            };

            var prijedlozi = await _prijedloziService.Get<List<Model.Prijedlozi>>(request);

            PrijedloziDGV.DataSource = prijedlozi;
        }
    }
}
