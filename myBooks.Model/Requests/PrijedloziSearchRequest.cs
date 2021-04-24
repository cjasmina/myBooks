namespace myBooks.Model.Requests
{
    public class PrijedloziSearchRequest
    {
        public string Naziv { get; set; }
        public string Autor { get; set; }
        public int? KorisnikId { get; set; }
    }
}
