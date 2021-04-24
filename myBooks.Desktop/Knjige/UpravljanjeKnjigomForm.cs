using System;
using System.Windows.Forms;
using System.ComponentModel;

using System.IO;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using myBooks.Model.Requests;
using myBooks.Desktop.Helpers;

namespace myBooks.Desktop.Knjige
{
    public partial class UpravljanjeKnjigomForm : Form
    {
        private readonly int? _knjigaId;
        private readonly ApiService _autoriService = new ApiService("Autori");
        private readonly ApiService _zanroviService = new ApiService("Zanrovi");
        private readonly ApiService _knjigeService = new ApiService("Knjige");
        private readonly ApiService _jeziciService = new ApiService("Jezici");
        private readonly ApiService _izdavackeKuceService = new ApiService("IzdavackeKuce");

        KnjigeUpsertRequest _request = new KnjigeUpsertRequest();

        public UpravljanjeKnjigomForm(int? knjigaId = null)
        {
            _knjigaId = knjigaId;

            InitializeComponent();
        }

        private async void UpravljanjeKnjigomForm_Load(object sender, EventArgs e)
        {
            await UcitajAutore();
            await UcitajZanrove();
            await UcitajJezike();
            await UcitajIzdavackeKuce();

            if (_knjigaId != null)
            {
                var knjiga = await _knjigeService.GetById<Model.Knjige>(_knjigaId);

                NazivTextBox.Text = knjiga.Naziv;
                KratakOpisTextBox.Text = knjiga.KratakOpis;
                DatumIzdavanjaPicker.Value = knjiga.DatumIzdavanja;
                ISBNTextBox.Text = knjiga.ISBN;
                OpisTextBox.Text = knjiga.Opis;
                ZanrComboBox.SelectedValue = knjiga.ZanrId;
                JezikComboBox.SelectedValue = knjiga.JezikId;
                IzdavackaKucaComboBox.SelectedValue = knjiga.IzdavackaKucaId;

                var autori = AutoriListBox.Items.Cast<Model.Autori>().ToList();
                for (int i = 0; i < autori.Count; i++)
                {
                    if (knjiga.Autori.Any(a => a.AutorId == autori[i].AutorId))
                    {
                        AutoriListBox.SetItemChecked(i, true);
                    }
                }

                if (knjiga.NaslovnaFotografija.Any())
                {
                    _request.NaslovnaFotografija = knjiga.NaslovnaFotografija;

                    var memoryStream = new MemoryStream(knjiga.NaslovnaFotografija);
                    NaslovnaFotografijaPictureBox.Image = Image.FromStream(memoryStream);
                }
            }
        }

        private void UpravljanjeKnjigomForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ErrorProvider.Clear();
            e.Cancel = false;
        }

        private void OdaberiButton_Click(object sender, EventArgs e)
        {
            var rezultat = OpenFileDialog.ShowDialog();
            if (rezultat == DialogResult.OK)
            {
                var nazivOdabraneSlike = OpenFileDialog.FileName;
                var odabranaSlika = File.ReadAllBytes(nazivOdabraneSlike);
                _request.NaslovnaFotografija = odabranaSlika;

                NaslovnaFotografijaPictureBox.Image = Image.FromFile(nazivOdabraneSlike);
            }
        }

        private async void SpremiButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                _request.Naziv = NazivTextBox.Text;
                _request.Opis = OpisTextBox.Text;
                _request.KratakOpis = KratakOpisTextBox.Text;
                _request.DatumIzdavanja = DatumIzdavanjaPicker.Value;
                _request.ISBN = ISBNTextBox.Text;
                _request.ZanrId = Convert.ToInt32(ZanrComboBox.SelectedValue);
                _request.JezikId = Convert.ToInt32(JezikComboBox.SelectedValue);
                _request.IzdavackaKucaId = Convert.ToInt32(IzdavackaKucaComboBox.SelectedValue);
                _request.Autori = AutoriListBox.CheckedItems.Cast<Model.Autori>().Select(x => x.AutorId).ToList();

                if (_knjigaId == null)
                {
                    await _knjigeService.Insert<Model.Knjige>(_request);
                }
                else
                {
                    await _knjigeService.Update<Model.Knjige>(_knjigaId, _request);
                }

                MessageBox.Show(_knjigaId == null ? "Knjiga uspješno dodana!" : "Knjiga uspješno izmijenjena!", "Knjige", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
        }

        private async Task UcitajAutore()
        {
            var autori = await _autoriService.Get<List<Model.Autori>>();

            AutoriListBox.DataSource = autori;
            AutoriListBox.DisplayMember = nameof(Model.Autori.ImePrezime);
            AutoriListBox.ValueMember = nameof(Model.Autori.AutorId);
        }

        private async Task UcitajZanrove()
        {
            var zanrovi = await _zanroviService.Get<List<Model.Zanrovi>>();

            ZanrComboBox.DataSource = zanrovi;
            ZanrComboBox.DisplayMember = nameof(Model.Zanrovi.Naziv);
            ZanrComboBox.ValueMember = nameof(Model.Zanrovi.ZanrId);
        }

        private async Task UcitajJezike()
        {
            var jezici = await _jeziciService.Get<List<Model.Jezici>>();

            JezikComboBox.DataSource = jezici;
            JezikComboBox.DisplayMember = nameof(Model.Jezici.Naziv);
            JezikComboBox.ValueMember = nameof(Model.Jezici.JezikId);
        }

        private async Task UcitajIzdavackeKuce()
        {
            var izdavackeKuce = await _izdavackeKuceService.Get<List<Model.IzdavackeKuce>>();

            IzdavackaKucaComboBox.DataSource = izdavackeKuce;
            IzdavackaKucaComboBox.DisplayMember = nameof(Model.IzdavackeKuce.Naziv);
            IzdavackaKucaComboBox.ValueMember = nameof(Model.IzdavackeKuce.IzdavackaKucaId);
        }

        private void NazivTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validacija.ValidirajTextBox(e, ErrorProvider, NazivTextBox, "Naziv knjige je obavezan!");
        }

        private void KratakOpisTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validacija.ValidirajTextBox(e, ErrorProvider, KratakOpisTextBox, "Kratak opis knjige je obavezan!");
        }

        private void ISBNTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validacija.ValidirajTextBox(e, ErrorProvider, ISBNTextBox, "ISBN knjige je obavezan!");
        }

        private void OpisTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validacija.ValidirajTextBox(e, ErrorProvider, OpisTextBox, "Opis knjige je obavezan!");
        }

        private void NaslovnaFotografijaPictureBox_Validating(object sender, CancelEventArgs e)
        {
            Validacija.ValidirajPictureBox(e, ErrorProvider, NaslovnaFotografijaPictureBox, "Naslovna fotografija je obavezna!");
        }

        private void AutoriListBox_Validating(object sender, CancelEventArgs e)
        {
            Validacija.ValidirajCheckedListBox(e, ErrorProvider, AutoriListBox, "Morate odabrate barem jednog autora.");
        }
    }
}
