using System;
using Microsoft.EntityFrameworkCore;

namespace myBooks.API.Database
{

    public partial class myBooksContext
    {

        //'The INSERT statement conflicted with the FOREIGN KEY constraint "FK_Knjige_Jezici".
        //The conflict occurred in database "myBooks2", table "dbo.Jezici", column 'JezikId'.
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autori>().HasData(
                new Autori() { AutorId = 2, Ime = "Albert", Prezime = "Camus", DatumRodjenja = new DateTime(1950, 03, 22), Biografija = "Albert Camus francuski je filozof, romanopisac, dramatičar, esejist i dobitnik Nobelove nagrade. Ostao je poznat po posebnom načinu pisanja doživljaja ljudskog postojanja, budući da je modernog čovjeka smatrao čudovištem." },
                new Autori() { AutorId = 3, Ime = "Meša", Prezime = "Selimović", DatumRodjenja = new DateTime(1944, 06, 13), Biografija = "Mehmedalija Meša Selimović je rođen u Tuzli 1910. Nakon završenih studija na Filozofskom fakultetu u Beogradu, do početka Drugog svetskog rata, radio je kao profesor gimnazije u rodnom gradu. Zatvoren 1942, a 1943. g. nasao se na slobodnoj teritoriji. Učestvovao je do kraja rata u borbi protiv okupatora. Preminuo je poslije duže bolesti 11. jula 1982. godine u Beogradu, jedan je od najznačajnijih jugoslovenskih pisaca ranga evropskog klasika druge polovine XX veka." },
                new Autori() { AutorId = 4, Ime = "Nikolas", Prezime = "Sparks", DatumRodjenja = new DateTime(1965, 12, 31), Biografija = "Nikolas Sparks, rođen 1965. godine, je američki autor međunarodnih bestselera, poznat je po romanima u kojima se bavi temama kao što su hrišćanstvo, ljubav, tragedija i sudbina. Iako je sredinom osamdesetih godina napisao dva romana, svoj prvi uspeh Sparks je postigao 2001. godine romanom The Notebook. Do sada je objavio dvanaest romana, koji su prevedeni na preko trideset jezika, a neki od njih su i filmovani(The Notebook, Message in a Bottle i A Walk to Remember)." },
                new Autori() { AutorId = 5, Ime = "Haruki", Prezime = "Murakami", DatumRodjenja = new DateTime(1949, 01, 12), Biografija = "Murakami je započeo s pisanjem u svojim ranim tridesetim godinama. Kako je sam rekao, gledajući bejzbol utakmicu odjednom je osjetio neobjašnjivu inspiraciju za pisanjem svog prvog romana (Hear the Wind Sing, 1979.). Nekoliko narednih mjeseci pisao je samo nekoliko sati nakon završenog radnog dana u baru, tako da je uspijevao pisati samo kratka poglavlja. Nakon što ga je završio, roman je poslao na jedini natječaj koji je htio prihvatiti rad takve dužine i osvojio je nagradu." },
                new Autori() { AutorId = 6, Ime = "Agata", Prezime = "Kristi", DatumRodjenja = new DateTime(1890, 09, 15), Biografija = "Agata Kristi je najobjavljivanija autorka svih vremena. Jedino Biblija i Šekspir premašuju ukupni tiraž njenih dela – prodato ih je milijardu na engleskom jeziku i još milijardu u prevodu na stotinu drugih jezika. Napisala je osamdeset detektivskih romana i zbirki priča, devetnaest pozorišnih komada, dva memoarska dela i šest ljubavnih romana pod pseudonimom Meri Vestmakot.U pisanju detektivske proze prvi put se okušala dok je za vreme Prvog svetskog rata radila u jednom bolničkom dispanzeru. Već u svom prvencu, naslovljenom Tajanstveni događaj u Stajlsu, stvorila je sada legendarnog Herkula Poaroa. Potom je u romanu Ubistvo u parohijskom dvoru, objavljenom 1930.godine, uvela među čitalaštvom mnogo voljenu gospođicu Džejn Marpl. Od ostalih likova koji se pojavljuju u više njenih romana tu su Tomi i Mrvica Beresford, privatni detektiv Parker Pajn i detektivi Skotland jarda viši inspektor Batl i inspektor Džap." }
            );

            modelBuilder.Entity<Drzave>().HasData(
                new Drzave() { DrzavaId = 1, Naziv = "Bosna i Hercegovina" },
                new Drzave() { DrzavaId = 2, Naziv = "Hrvatska" },
                new Drzave() { DrzavaId = 3, Naziv = "Srbija" },
                new Drzave() { DrzavaId = 4, Naziv = "Austrija" },
                new Drzave() { DrzavaId = 5, Naziv = "Crna Gora" }
            );

            modelBuilder.Entity<Gradovi>().HasData(
                new Gradovi() { GradId = 2, Naziv = "Mostar", DrzavaId = 1 },
                new Gradovi() { GradId = 3, Naziv = "Sarajevo", DrzavaId = 1 },
                new Gradovi() { GradId = 4, Naziv = "Sanski Most", DrzavaId = 1 },
                new Gradovi() { GradId = 5, Naziv = "Zagreb", DrzavaId = 2 },
                new Gradovi() { GradId = 6, Naziv = "Beograd", DrzavaId = 3 },
                new Gradovi() { GradId = 7, Naziv = "Podgorica", DrzavaId = 5 }
            );

            modelBuilder.Entity<IzdavackeKuce>().HasData(
                new IzdavackeKuce() { IzdavackaKucaId = 1, Naziv = "Svijetlost", GradId = 3 },
                new IzdavackeKuce() { IzdavackaKucaId = 3, Naziv = "Publishing", GradId = 3 },
                new IzdavackeKuce() { IzdavackaKucaId = 4, Naziv = "Laguna", GradId = 2 },
                new IzdavackeKuce() { IzdavackaKucaId = 5, Naziv = "Geopoetika", GradId = 6 },
                new IzdavackeKuce() { IzdavackaKucaId = 6, Naziv = "Nova knjiga", GradId = 7 }
            );

            modelBuilder.Entity<Jezici>().HasData(
                new Jezici() { JezikId = 1, Naziv = "Bosanski" },
                new Jezici() { JezikId = 2, Naziv = "Hrvatski" },
                new Jezici() { JezikId = 3, Naziv = "Srpski" }
            );

            modelBuilder.Entity<Zanrovi>().HasData(
                new Zanrovi() { ZanrId = 1, Naziv = "Romantika" },
                new Zanrovi() { ZanrId = 2, Naziv = "Horor" },
                new Zanrovi() { ZanrId = 3, Naziv = "Triler" },
                new Zanrovi() { ZanrId = 4, Naziv = "Ratni" },
                new Zanrovi() { ZanrId = 5, Naziv = "Drama" },
                new Zanrovi() { ZanrId = 6, Naziv = "Krimi" }
            );

            modelBuilder.Entity<Knjige>().HasData(
                new Knjige() { KnjigaId = 5, NaslovnaFotografija = System.IO.File.ReadAllBytes("Helpers/Knjige/stranac.jpg"), Naziv = "Stranac", KratakOpis = "Kratak opis", Opis = "Opis", DatumIzdavanja = new DateTime(2016, 06, 22), Isbn = "1236546532", ZanrId = 2, IzdavackaKucaId = 3, JezikId = 1 },
                new Knjige() { KnjigaId = 7, NaslovnaFotografija = System.IO.File.ReadAllBytes("Helpers/Knjige/na_prvi_pogled.jpg"), Naziv = "Na prvi pogled", KratakOpis = "Govori o patnjama, napetosti, romansi i iznenađenjima.", Opis = "Džeremi Marš je pouzdano znao da nikad neće otići iz Njujorka, da svoje srce više nikome neće dati pošto je jedva preživeo raspad prvog braka i da nikada neće imati decu. Sada Džeremi živi u malenom gradu Bun Kriku u Severnoj Karolini, veren je sa Leksi Darnel, ljubavlju svog života, i očekuje da začnu porodicu. Ali upravo kad sve naizgled blaženo teče, tajanstven i uznemirujući imejl će pokrenuti niz događaja koji će uticati na vezu mladog para.", DatumIzdavanja = new DateTime(2016, 05, 10), Isbn = "978-86-521-2096-3", ZanrId = 1, IzdavackaKucaId = 4, JezikId = 3 },
                new Knjige() { KnjigaId = 8, NaslovnaFotografija = System.IO.File.ReadAllBytes("Helpers/Knjige/setnja_za_pamcenje.jpg"), Naziv = "Šetnja za pamćenje", KratakOpis = "Spoznavanje prave ljudske dobrote.", Opis = "Godina je 1958. i sedamnaestogodišnji Landon uživa u svojoj razuzdanoj mladosti: izlazi sa brojnim devojkama, a ponekoj i izjavljuje ljubav. On je potpuna suprotnost u odnosu na nju, Džejmi Salivan, kćerku lokalnog sveštenika, koja se stara o svom ocu, ne odvaja se od Biblije čak ni u školi i volontira u sirotištu. Ali sudbina će umešati svoje prste. Kada budu prinuđeni da na školski ples dođu kao partneri, Landon i Džejmi će otkriti strasnu ljubav i osetiti preveliki gubitak. U potonjim mesecima Landon će spoznati prave razmere ljudske dobrote i doneti odluku koja će mnoge iznenaditi, a njega bespovratno odvesti u surovi svet odraslih", DatumIzdavanja = new DateTime(2016, 03, 08), Isbn = "978-86-521-2135-9", ZanrId = 1, IzdavackaKucaId = 4, JezikId = 3 },
                new Knjige() { KnjigaId = 9, NaslovnaFotografija = System.IO.File.ReadAllBytes("Helpers/Knjige/biljeznica.jpg"), Naziv = "Bilježnica", KratakOpis = "Beskrajno topla i snažna ljubavna priča", Opis = "Beskrajno topla i snažna ljubavna priča koja ne ostavlja čitaoce ravnodušnim. Dirljiva ispovijest o dvoje ljudi koji se sretaju poslije 14 godina lutanja i potrage za pravom ljubavi. Ni vihor Drugog svjetskog rata, nepredvidljive životne okolnosti i iskovani planovi za budućnost nisu uspjeli da raskinu ljubavne niti koje su više od decenije vezivali Noa i Ali. Bilježnica, koju glavni lik čuva, kao da oživljava davno minulu romansu i vraća vjeru u snagu osjećanja i privrženosti. Roman Bilježnica afirmiše ljubav koja prevazilazi vremenske i prostorne granice.", DatumIzdavanja = new DateTime(2013, 02, 19), Isbn = "9788674704110", ZanrId = 1, IzdavackaKucaId = 5, JezikId = 2 },
                new Knjige() { KnjigaId = 10, NaslovnaFotografija = System.IO.File.ReadAllBytes("Helpers/Knjige/kafka_na_obali_mora.jpg"), Naziv = "Kafka na obali mora", KratakOpis = "Sve se u ovom romanu odvija u onom vakuum prostoru između sna i jave.", Opis = "Paralelna dva putovanja – jedno, petnaestogodišnjeg dečaka Kafke Tamure, koji napušta dom bežeći od oca s kojim nema nikakav odnos i od njegove edipovske kletve, i drugo, vremešnog Nakate, koji se nikada nije oporavio od neobjašnjivog gubitka svesti u detinjstvu, za vreme Drugog svetskog rata, što je imalo za posledicu da ne zna da čita i piše, ali ima sposobnost da komunicira s mačkama, čine zbunjujuću fabulu ovog remek-dela magičnog realizma koje nas od prve do poslednje stranice zapljuskuje slojevima najrazličitijih tema i motiva, čudnovatim, nadrealnim, uzbudljivim događajima i likovima. Džoni Voker koji ubija mačke da bi njihove duše smeštao u svirale, kiše riba i pijavica, koje se obrušuju s neba, vešta prostitutka koja citira Hegela, a čiji je makro – Sanders, lik kojeg je Murakami „pozajmio“ sa plakata američkog pilećeg carstva KFC, vojnici iz Drugog svetskog rata, i dalje mladići, za koje je vreme stalo a prostor ima drugu dimenziju...Sve se u ovom romanu odvija u onom vakuum prostoru između sna i jave, gde uprkos surovim ubistvima i incestu, nema ni krivice ni greha, jer su ljudi samo prazne ljušture, promenljivi oblici koje popunjavaju duše u prolazu.", DatumIzdavanja = new DateTime(2017, 10, 10), Isbn = "978-86-521-2135-9", ZanrId = 3, IzdavackaKucaId = 6, JezikId = 3 },
                new Knjige() { KnjigaId = 11, NaslovnaFotografija = System.IO.File.ReadAllBytes("Helpers/Knjige/norveska_suma.jpg"), Naziv = "Norveška šuma", KratakOpis = "Japanski bestseler.", Opis = "Čuvši pjesmu Beattesa, Toru Vatanabe sjeti se svoje prve ljubavi Naoko, djevojke svoga najboljeg prijatelja Kizukija. Istoga časa u mislima se vraća u prošlost, kad je prije gotovo dvadeset godina u Tokiju provodio studentske dane, izgubljen u svijetu tjeskobnih prijateljstava, usputnog seksa, strasti, gubitaka i žudnje - u vrijeme kad je u njegov život umarširala neobuzdana mlada žena po imenu Midori, i on je morao birati zmeđu budućnosti i prošlosti.Norveška šuma najpoznatiji je roman Harukija Murakamija, kultna knjiga koja je sve donedavno bila najveći japanski bestseler uopšte. Samo u Japanu ukupno je prodano preko četiri milijuna primjeraka.", DatumIzdavanja = new DateTime(2007, 05, 14), Isbn = "978-86-7666-113-8", ZanrId = 5, IzdavackaKucaId = 5, JezikId = 3 },
                new Knjige() { KnjigaId = 12, NaslovnaFotografija = System.IO.File.ReadAllBytes("Helpers/Knjige/neocekivani_gost.jpg"), Naziv = "Neočekivani gost", KratakOpis = "Lična istraga ubistva.", Opis = "Tražeći pomoć zbog nezgode sa automobilom, koju je usled guste magle doživeo, Majkl Starkveder pojavljuje se na vratima obližnje kuće. Kuca, ali odgovora nema. Hvata kvaku balkonskih vrata i ulazi u sobu u kojoj zatiče čoveka u invalidskim kolicima. Ljubazno mu se obraća i prilazi, ali shvata da je čovek mrtav. U uglu, uplašena i bleda, stoji mlada žena sa pištoljem u ruci. Sve ukazuje na to da je ona počinila ubistvo, a da je neočekivani gost naišao u pogrešnom trenutku i postao svedok nemile scene. Međutim, neznancu je sve suviše logično i jednostavno, pa se upušta u ličnu istragu ubistva…", DatumIzdavanja = new DateTime(2020, 11, 04), Isbn = "978-86-6012-061-0", ZanrId = 6, IzdavackaKucaId = 1, JezikId = 1 },
                new Knjige() { KnjigaId = 13, NaslovnaFotografija = System.IO.File.ReadAllBytes("Helpers/Knjige/paukova_mreza.jpg"), Naziv = "Paukova mreža", KratakOpis = "Bizararan motiv ubistva.", Opis = "Nakon kraće rasprave, Klarisa Hejšlam Braun ispratila je partnera bivše supruge svoga sadašnjeg muža da bi ubrzo zatim zatekla njegov leš u salonu kuće koju su iznajmili. Uplašena saznanjem da je ubistvo počinila njena pastorka, Klarisa odlučuje da je zaštiti, pa plete mrežu kako bi devojčicu izvukla iz teške situacije u kojoj se zadesila. U tome joj bezrezervno pomažu trojica kućnih prijatelja, inače izuzetno uglednih pripadnika višeg društvenog sloja.Čitav niz okolnosti koje se smenjuju u samo jednoj večeri, dovode do neočekivanog raspleta, ali i krajnje bizarnog motiva ubistva.", DatumIzdavanja = new DateTime(2021, 04, 22), Isbn = "978-86-6012-054-2", ZanrId = 6, IzdavackaKucaId = 1, JezikId = 1 },
                new Knjige() { KnjigaId = 14, NaslovnaFotografija = System.IO.File.ReadAllBytes("Helpers/Knjige/ubistvo_u_orijent_ekspresu.jpg"), Naziv = "Ubistvo u Orijent ekspresu", KratakOpis = "Najčuveniji slučaj Herkula Poaroa.", Opis = "Agata Kristi je najobjavljivanija autorka svih vremena. Jedino Biblija i Šekspirov opus premašuju ukupni tiraž njenih dela - prodato ih je milijardu na engleskom jeziku i još milijardu u prevodu na stotinu drugih jezika.Najčuveniji slučaj Herkula Poaroa.Nešto posle ponoći snežni smetovi zaustavili su Orijent ekspres. Ovaj raskošni voz iznenađujuće je pun za to doba godine, ali jutro dočekuje s jednim putnikom manje. Američki magnat leži mrtav u svom kupeu, proboden dvanaest puta, a vrata su zaključana iznutra. Ubica je zarobljen u vozu s ostalim putnicima i detektiv Herkul Poaro mora da ga otkrije pre nego što se desi novo ubistvo.", DatumIzdavanja = new DateTime(2017, 02, 21), Isbn = "978-86-521-2875-4", ZanrId = 6, IzdavackaKucaId = 5, JezikId = 3 }
            );

            modelBuilder.Entity<KnjigeAutori>().HasData(
                new KnjigeAutori() { KnjigaAutorId = 2, AutorId = 2, KnjigaId = 5 },
                new KnjigeAutori() { KnjigaAutorId = 4, AutorId = 4, KnjigaId = 7 },
                new KnjigeAutori() { KnjigaAutorId = 5, AutorId = 4, KnjigaId = 8 },
                new KnjigeAutori() { KnjigaAutorId = 6, AutorId = 4, KnjigaId = 9 },
                new KnjigeAutori() { KnjigaAutorId = 7, AutorId = 5, KnjigaId = 10 },
                new KnjigeAutori() { KnjigaAutorId = 8, AutorId = 5, KnjigaId = 11 },
                new KnjigeAutori() { KnjigaAutorId = 9, AutorId = 6, KnjigaId = 12 },
                new KnjigeAutori() { KnjigaAutorId = 10, AutorId = 6, KnjigaId = 13 },
                new KnjigeAutori() { KnjigaAutorId = 11, AutorId = 6, KnjigaId = 14 }
            );

            modelBuilder.Entity<Korisnici>().HasData(
                new Korisnici() { KorisnikId = 1, Ime = "Administrator", Prezime = "Prvi", Email = "administrator1@edu.fit.ba", DatumRodjenja = new DateTime(1997, 11, 07), Telefon = "+38762156296", KorisnickoIme = "administrator1", LozinkaHash = "Hkygp3aJFIgOMtbHckDaXN5HYBA=", LozinkaSalt = "DMUTs++b9XRsy8TQxXWtzw==", Uloga = myBooks.Model.Uloge.Administrator },
                new Korisnici() { KorisnikId = 3, Ime = "Korisnik", Prezime = "Prvi", Email = "korisnik1@edu.fit.ba", DatumRodjenja = new DateTime(1995, 02, 13), Telefon = "+38761123456", KorisnickoIme = "korisnik1", LozinkaHash = "Hkygp3aJFIgOMtbHckDaXN5HYBA=", LozinkaSalt = "DMUTs++b9XRsy8TQxXWtzw==", Uloga = myBooks.Model.Uloge.Korisnik },
                new Korisnici() { KorisnikId = 4, Ime = "Korisnik", Prezime = "Drugi", Email = "korisnik2@edu.fit.ba", DatumRodjenja = new DateTime(1985, 02, 13), Telefon = "+38761654321", KorisnickoIme = "korisnik2", LozinkaHash = "Hkygp3aJFIgOMtbHckDaXN5HYBA=", LozinkaSalt = "DMUTs++b9XRsy8TQxXWtzw==", Uloga = myBooks.Model.Uloge.Korisnik }
            );
        }
    }
}
