namespace myBooks.Model.Requests
{
    public class RecenzijeSearchRequest
    {
        public string Sadrzaj { get; set; }
        public int? KorisnikId { get; set; }
        public int? KnjigaId { get; set; }
    }
}
