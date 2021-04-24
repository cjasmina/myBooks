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
    public partial class PregledNajgoreOcjenjenihKnjiga : Form
    {
        public PregledNajgoreOcjenjenihKnjiga()
        {
            InitializeComponent();
        }

        private void PregledNajgoreOcjenjenihKnjiga_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsKnjigeOcjene_najgore.Knjige' table. You can move, or remove it, as needed.
            this.KnjigeTableAdapter.Fill(this.dsKnjigeOcjene_najgore.Knjige);

            this.reportViewer1.RefreshReport();
        }
    }
}
