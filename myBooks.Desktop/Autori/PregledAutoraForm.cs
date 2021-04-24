using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

using myBooks.Model.Requests;

namespace myBooks.Desktop.Autori
{
    public partial class PregledAutoraForm : Form
    {
        private readonly ApiService _autoriService = new ApiService("Autori");

        public PregledAutoraForm()
        {
            InitializeComponent();
        }

        private async void PregledAutoraForm_Load(object sender, EventArgs e)
        {
            AutoriDGV.AutoGenerateColumns = false;

            await UcitajAutore();
        }

        private async void DodajButton_Click(object sender, EventArgs e)
        {
            new UpravljanjeAutoromForm().ShowDialog();

            await UcitajAutore();
        }

        private async void PretragaButton_Click(object sender, EventArgs e)
        {
            await UcitajAutore();
        }

        private async void AutoriDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabraniAutorId = int.Parse(AutoriDGV.Rows[e.RowIndex].Cells[0].Value.ToString());

            new UpravljanjeAutoromForm(odabraniAutorId).ShowDialog();

            await UcitajAutore();
        }

        private async Task UcitajAutore()
        {
            var request = new AutoriSearchRequest
            {
                Ime = ImeTextBox.Text,
                Prezime = PrezimeTextBox.Text
            };

            var autori = await _autoriService.Get<List<Model.Autori>>(request);

            AutoriDGV.DataSource = autori;
        }
    }
}
