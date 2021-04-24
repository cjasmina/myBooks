using System;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

using myBooks.Model.Requests;

namespace myBooks.Desktop.Drzave
{
    public partial class PregledDrzavaForm : Form
    {
        private readonly ApiService _drzaveService = new ApiService("Drzave");

        public PregledDrzavaForm()
        {
            InitializeComponent();
        }

        private async void PregledDrzavaForm_Load(object sender, EventArgs e)
        {
            DrzaveDGV.AutoGenerateColumns = false;

            await UcitajDrzave();
        }

        private async void DodajButton_Click(object sender, EventArgs e)
        {
            new UpravljanjeDrzavomForm().ShowDialog();

            await UcitajDrzave();
        }

        private async void PretragaButton_Click(object sender, EventArgs e)
        {
            await UcitajDrzave();
        }

        private async void DrzaveDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabranaDrzavaId = int.Parse(DrzaveDGV.Rows[e.RowIndex].Cells[0].Value.ToString());

            new UpravljanjeDrzavomForm(odabranaDrzavaId).ShowDialog();

            await UcitajDrzave();
        }

        private async Task UcitajDrzave()
        {
            var request = new DrzaveSearchRequest
            {
                Naziv = NazivTextBox.Text,
            };

            var drzave = await _drzaveService.Get<List<Model.Drzave>>(request);

            DrzaveDGV.DataSource = drzave;
        }
    }
}
