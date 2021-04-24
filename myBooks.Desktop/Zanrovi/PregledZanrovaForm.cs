using System;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

using myBooks.Model.Requests;

namespace myBooks.Desktop.Zanrovi
{
    public partial class PregledZanrovaForm : Form
    {
        private readonly ApiService _zanroviService = new ApiService("Zanrovi");

        public PregledZanrovaForm()
        {
            InitializeComponent();
        }

        private async void PregledZanrovaForm_Load(object sender, EventArgs e)
        {
            ZanroviDGV.AutoGenerateColumns = false;

            await UcitajZanrove();
        }

        private async void DodajButton_Click(object sender, EventArgs e)
        {
            new UpravljanjeZanromForm().ShowDialog();

            await UcitajZanrove();
        }

        private async void PretragaButton_Click(object sender, EventArgs e)
        {
            await UcitajZanrove();
        }

        private async void ZanroviDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabraniJezikId = int.Parse(ZanroviDGV.Rows[e.RowIndex].Cells[0].Value.ToString());

            new UpravljanjeZanromForm(odabraniJezikId).ShowDialog();

            await UcitajZanrove();
        }

        private async Task UcitajZanrove()
        {
            var request = new ZanroviSearchRequest
            {
                Naziv = NazivTextBox.Text,
            };

            var zanrovi = await _zanroviService.Get<List<Model.Zanrovi>>(request);

            ZanroviDGV.DataSource = zanrovi;
        }
    }
}
