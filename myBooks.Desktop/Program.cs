using System;
using System.Windows.Forms;

using myBooks.Model;

namespace myBooks.Desktop
{

    public static class Program
    {
        public static Korisnici PrijavljeniKorisnik;

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PrijavaForm());
        }
    }
}
