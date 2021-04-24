namespace myBooks.Model.Requests
{
    public class KnjigeSearchRequest
    {
        public int? KnjigaId { get; set; }
        public int? PolicaId { get; set; }
        public int? ZanrId { get; set; }
        public int? JezikId { get; set; }
        public int? AutorId { get; set; }
        public int? IzdavackaKucaId { get; set; }
        public string Naziv { get; set; }
        public string ISBN { get; set; }
    }
}
