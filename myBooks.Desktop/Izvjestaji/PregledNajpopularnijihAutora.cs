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
    public partial class PregledNajpopularnijihAutora : Form
    {
        public PregledNajpopularnijihAutora()
        {
            InitializeComponent();
        }

        private void PregledNajpopularnijihAutora_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsNajpopularnijiAutori.Ocjene' table. You can move, or remove it, as needed.
            this.OcjeneTableAdapter.Fill(this.dsNajpopularnijiAutori.Ocjene);

            this.reportViewer1.RefreshReport();
        }
    }
}
