using System;
using System.Windows.Forms;

using myBooks.Desktop.Drzave;
using myBooks.Desktop.Autori;
using myBooks.Desktop.Gradovi;
using myBooks.Desktop.Knjige;
using myBooks.Desktop.Jezici;
using myBooks.Desktop.Zanrovi;
using myBooks.Desktop.IzdavackeKuce;
using myBooks.Desktop.Prijedlozi;
using myBooks.Desktop.Izvjestaji;

namespace myBooks.Desktop
{
    public partial class PocetnaForm : Form
    {
        public PocetnaForm()
        {
            InitializeComponent();
        }

        private void OdjavaMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void GradoviMenuItem_Click(object sender, EventArgs e)
        {
            var pregledGradova = new PregledGradovaForm
            {
                MdiParent = this
            };

            pregledGradova.Show();
        }

        private void IzdavackeKuceMenuItem_Click(object sender, EventArgs e)
        {
            var pregledIzdavackihKuca = new PregledIzdavackihKucaForm
            {
                MdiParent = this
            };

            pregledIzdavackihKuca.Show();
        }

        private void DrzaveMenuItem_Click(object sender, EventArgs e)
        {
            var pregledDrzava = new PregledDrzavaForm
            {
                MdiParent = this
            };

            pregledDrzava.Show();
        }

        private void AutoriMenuItem_Click(object sender, EventArgs e)
        {
            var pregledAutora = new PregledAutoraForm
            {
                MdiParent = this
            };

            pregledAutora.Show();
        }

        private void JeziciMenuItem_Click(object sender, EventArgs e)
        {
            var pregledJezika = new PregledJezikaForm
            {
                MdiParent = this
            };

            pregledJezika.Show();
        }

        private void ZanroviMenuItem_Click(object sender, EventArgs e)
        {
            var pregledZanrova = new PregledZanrovaForm
            {
                MdiParent = this
            };

            pregledZanrova.Show();
        }

        private void KnjigeMenuItem_Click(object sender, EventArgs e)
        {
            var pregledKnjiga = new PregledKnjigaForm
            {
                MdiParent = this
            };

            pregledKnjiga.Show();
        }

        private void PrijedloziMenuItem_Click(object sender, EventArgs e)
        {
            var pregledPrijedloga = new PregledPrijedlogaForm
            {
                MdiParent = this
            };

            pregledPrijedloga.Show();
        }

        private void PocetnaForm_Load(object sender, EventArgs e)
        {
            PrijavljeniKorisnikLabel.Text = $"Prijavljeni korisnik: {Program.PrijavljeniKorisnik.Ime} {Program.PrijavljeniKorisnik.Prezime}";
        }

        private void NajpopularnijeKnjigeMenuItem_Click(object sender, EventArgs e)
        {
            var pregledIzvjestaja = new PregledNajpopularnijihKnjiga
            {
                MdiParent = this
            };

            pregledIzvjestaja.Show();
        }

        private void NajboljeOcjenjeneKnjigeMenuItem_Click(object sender, EventArgs e)
        {
            var pregledIzvjestaja = new PregledNajboljeOcjenjenihKnjiga
            {
                MdiParent = this
            };

            pregledIzvjestaja.Show();
        }

        private void NajgoreOcjenjeneKnjigeMenuItem_Click(object sender, EventArgs e)
        {
            var pregledIzvjestaja = new PregledNajgoreOcjenjenihKnjiga
            {
                MdiParent = this
            };

            pregledIzvjestaja.Show();
        }

        private void NajpopularnijiAutoriMenuItem_Click(object sender, EventArgs e)
        {
            var pregledIzvjestaja = new PregledNajpopularnijihAutora
            {
                MdiParent = this
            };

            pregledIzvjestaja.Show();
        }
    }
}
