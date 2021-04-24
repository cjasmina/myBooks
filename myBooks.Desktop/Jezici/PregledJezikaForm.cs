using System;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

using myBooks.Model.Requests;

namespace myBooks.Desktop.Jezici
{
    public partial class PregledJezikaForm : Form
    {
        private readonly ApiService _jeziciService = new ApiService("Jezici");

        public PregledJezikaForm()
        {
            InitializeComponent();
        }

        private async void PregledJezikaForm_Load(object sender, EventArgs e)
        {
            JeziciDGV.AutoGenerateColumns = false;

            await UcitajJezike();
        }

        private async void DodajButton_Click(object sender, EventArgs e)
        {
            new UpravljanjeJezikomForm().ShowDialog();

            await UcitajJezike();
        }

        private async void PretragaButton_Click(object sender, EventArgs e)
        {
            await UcitajJezike();
        }

        private async void JeziciDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabraniJezikId = int.Parse(JeziciDGV.Rows[e.RowIndex].Cells[0].Value.ToString());

            new UpravljanjeJezikomForm(odabraniJezikId).ShowDialog();

            await UcitajJezike();
        }

        private async Task UcitajJezike()
        {
            var request = new JeziciSearchRequest
            {
                Naziv = NazivTextBox.Text,
            };

            var jezici = await _jeziciService.Get<List<Model.Jezici>>(request);

            JeziciDGV.DataSource = jezici;
        }
    }
}
