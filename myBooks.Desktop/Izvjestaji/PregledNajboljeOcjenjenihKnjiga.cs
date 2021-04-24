using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myBooks.Desktop.Izvjestaji
{
    public partial class PregledNajboljeOcjenjenihKnjiga : Form
    {
        public PregledNajboljeOcjenjenihKnjiga()
        {
            InitializeComponent();
        }

        private void PregledNajboljeOcjenjenihKnjiga_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsKnjigeOcjene_najbolje.Knjige' table. You can move, or remove it, as needed.
            this.KnjigeTableAdapter.Fill(this.dsKnjigeOcjene_najbolje.Knjige);

            this.reportViewer1.RefreshReport();
        }
    }
}
