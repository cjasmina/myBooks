using AutoMapper;

using System.Linq;
using myBooks.API.Database;

namespace myBooksWebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Gradovi, myBooks.Model.Requests.GradoviUpsertRequest>().ReverseMap();
            CreateMap<Gradovi, myBooks.Model.Gradovi>().ReverseMap();

            CreateMap<Drzave, myBooks.Model.Requests.DrzaveUpsertRequest>().ReverseMap();
            CreateMap<Drzave, myBooks.Model.Drzave>().ReverseMap();

            CreateMap<Autori, myBooks.Model.Requests.AutoriUpsertRequest>().ReverseMap();
            CreateMap<Autori, myBooks.Model.Autori>().ReverseMap();

            CreateMap<IzdavackeKuce, myBooks.Model.Requests.IzdavackeKuceInsertRequest>().ReverseMap();
            CreateMap<IzdavackeKuce, myBooks.Model.IzdavackeKuce>().ReverseMap();

            CreateMap<Zanrovi, myBooks.Model.Requests.ZanroviInsertRequest>().ReverseMap();
            CreateMap<Zanrovi, myBooks.Model.Zanrovi>().ReverseMap();

            CreateMap<Jezici, myBooks.Model.Requests.JeziciUpsertRequest>().ReverseMap();
            CreateMap<Jezici, myBooks.Model.Jezici>().ReverseMap();

            CreateMap<Police, myBooks.Model.Requests.PoliceInsertRequest>().ReverseMap();
            CreateMap<Police, myBooks.Model.Police>()
                .ForMember(k => k.BrojKnjiga, opt => opt.MapFrom(c => c.PoliceKnjige.Any() ? c.PoliceKnjige.Count() : 0))
                .ForMember(k => k.BrojProcitanihKnjiga, opt => opt.MapFrom(c => c.PoliceKnjige.Any() ? c.PoliceKnjige.Count(pk => pk.Procitano) : 0))
                .ReverseMap();

            CreateMap<Prijedlozi, myBooks.Model.Requests.PrijedloziInsertRequest>().ReverseMap();
            CreateMap<Prijedlozi, myBooks.Model.Prijedlozi>();

            CreateMap<PoliceKnjige, myBooks.Model.Requests.PoliceKnjigeUpsertRequest>().ReverseMap();
            CreateMap<PoliceKnjige, myBooks.Model.PoliceKnjige>().ReverseMap();

            CreateMap<Ocjene, myBooks.Model.Requests.OcjeneInsertRequest>().ReverseMap();
            CreateMap<Ocjene, myBooks.Model.Ocjene>().ReverseMap();

            CreateMap<KnjigeAutori, myBooks.Model.Requests.KnjigeAutoriInsertRequest>().ReverseMap();
            CreateMap<KnjigeAutori, myBooks.Model.KnjigeAutori>().ReverseMap();

            CreateMap<Knjige, myBooks.Model.Requests.KnjigeUpsertRequest>().ReverseMap();
            CreateMap<Knjige, myBooks.Model.Knjige>()
                .ForMember(k => k.Autori, opt => opt.MapFrom(c => c.KnjigeAutori.Select(ka => ka.Autor).ToList()))
                .ForMember(k => k.ZanrNaziv, opt => opt.MapFrom(c => c.Zanr.Naziv))
                .ForMember(k => k.JezikNaziv, opt => opt.MapFrom(c => c.Jezik.Naziv))
                .ForMember(k => k.IzdavackaKucaNaziv, opt => opt.MapFrom(c => c.IzdavackaKuca.Naziv))
                .ForMember(k => k.ProsjecnaOcjena, opt => opt.MapFrom(c => c.Ocjene.Any() ? c.Ocjene.Average(o => o.Ocjena) : 0))
                .ReverseMap();

            CreateMap<Korisnici, myBooks.Model.Requests.KorisniciUpsertRequest>().ReverseMap();
            CreateMap<Korisnici, myBooks.Model.Korisnici>().ReverseMap();
            CreateMap<Korisnici, myBooks.Model.PrijavljeniKorisnik>().ReverseMap();
            CreateMap<Korisnici, myBooks.Model.RecenzijeKorisnici>().ReverseMap();

            CreateMap<Recenzije, myBooks.Model.Requests.RecenzijeInsertRequest>().ReverseMap();
            CreateMap<Recenzije, myBooks.Model.Recenzije>()
                .ForMember(r => r.Korisnik, opt => opt.MapFrom(c => c.Korisnik))
                .ReverseMap();
        }
    }
}
