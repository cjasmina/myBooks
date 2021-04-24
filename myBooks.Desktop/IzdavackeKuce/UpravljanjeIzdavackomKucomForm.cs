using System;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

using myBooks.Model.Requests;
using myBooks.Desktop.Helpers;

namespace myBooks.Desktop.IzdavackeKuce
{
    public partial class UpravljanjeIzdavackomKucomForm : Form
    {

        private readonly int? _izdavackaKucaId;
        private readonly ApiService _gradoviService;
        private readonly ApiService _izdavackeKuceService;

        public UpravljanjeIzdavackomKucomForm(int? izdavackaKucaId = null)
        {
            _izdavackaKucaId = izdavackaKucaId;
            _gradoviService = new ApiService("Gradovi");
            _izdavackeKuceService = new ApiService("IzdavackeKuce");

            InitializeComponent();
        }

        private async void UpravljanjeIzdavackomKucomForm_Load(object sender, EventArgs e)
        {
            await UcitajGradove();

            if (_izdavackaKucaId != null)
            {
                var izdavackaKuca = await _izdavackeKuceService.GetById<Model.IzdavackeKuce>(_izdavackaKucaId);

                NazivTextBox.Text = izdavackaKuca.Naziv;

                GradComboBox.SelectedItem = GradComboBox.Items.Cast<Model.Gradovi>().First(d => d.GradId == izdavackaKuca.GradId);
            }
        }

        private void NazivTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validacija.ValidirajTextBox(e, ErrorProvider, NazivTextBox, "Naziv izdavačke kuće je obavezan!");
        }

        private async void SpremiButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var odabraniGradid = int.Parse(GradComboBox.SelectedValue.ToString());

                var request = new IzdavackeKuceUpsertRequest
                {
                    GradId = odabraniGradid,
                    Naziv = NazivTextBox.Text,
                };

                if (_izdavackaKucaId == null)
                {
                    await _izdavackeKuceService.Insert<Model.IzdavackeKuce>(request);
                }
                else
                {
                    await _izdavackeKuceService.Update<Model.IzdavackeKuce>(_izdavackaKucaId, request);
                }

                MessageBox.Show(_izdavackaKucaId == null ? "Izdavačka kuća uspješno dodana!" : "Izdavačka kuća uspješno izmijenjena!", "Izdavačke kuće", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

                Close();
            }
        }

        private async Task UcitajGradove()
        {
            var gradovi = await _gradoviService.Get<List<Model.Gradovi>>();

            GradComboBox.DataSource = gradovi;
            GradComboBox.DisplayMember = nameof(Model.Gradovi.Naziv);
            GradComboBox.ValueMember = nameof(Model.Gradovi.GradId);
        }

        private void UpravljanjeIzdavackomKucomForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ErrorProvider.Clear();
            e.Cancel = false;
        }
    }
}
