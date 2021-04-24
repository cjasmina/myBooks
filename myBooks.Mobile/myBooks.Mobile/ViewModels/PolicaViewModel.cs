using myBooks.Model;
using System;

namespace myBooks.Mobile.ViewModels
{
    public class PolicaViewModel
    {
        public Police Polica { get; set; }

        public PolicaViewModel(Police polica)
        {
            Polica = polica;
        }

        public bool CiljIspunjen
        {
            get
            {
                if (!ImaCilj)
                    return false;

                var procitanoDovoljnoKnjiga = Polica.BrojProcitanihKnjiga >= Polica.CiljniBroj;
                var datumNijePrekoracen = Polica.KrajnjiDatumCilja.Value.Date >= DateTime.Now.Date;

                return procitanoDovoljnoKnjiga && datumNijePrekoracen;
            }
        }

        public bool ImaCilj => Polica.CiljniBroj != null && Polica.KrajnjiDatumCilja != null;
        public string BrojKnjiga => ImaCilj ? $"Pročitano {Polica.BrojProcitanihKnjiga} od {Polica.BrojKnjiga} knjiga" : $"{Polica.BrojKnjiga} knjiga";
        public string Cilj => ImaCilj ? $"Želim pročitati {Polica.CiljniBroj.Value} knjiga do {Polica.KrajnjiDatumCilja.Value.ToString("dd.MM.yyyy.")}" : "Nema cilja";
    }
}
