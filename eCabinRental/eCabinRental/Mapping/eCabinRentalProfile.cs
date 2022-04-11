using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCabinRental.Model;
using eCabinRental.Model.Request;
using eCabinRental.Model.Request.Objekat;
using eCabinRental.Model.Request.TipObjektum;
using eCabinRental.Model.Request.DetaljiRezervacije;
using eCabinRental.Model.Request.Klijent;
using eCabinRental.Model.Request.Rezervacija;
using eCabinRental.Model.Request.Uloga;

namespace eCabinRental.Mapping
{
    public class eCabinRentalProfile : Profile
    {
        public eCabinRentalProfile()
        {
            CreateMap<Database.Korisnik, Model.Korisnik>();
            CreateMap<Database.Korisnik,KorisniciInsertRequest>().ReverseMap();
            CreateMap<Database.Korisnik, KorisniciUpdateRequest>().ReverseMap();
            CreateMap<Database.Korisnik, KorisniciSearchRequest>().ReverseMap();
         
            CreateMap<Database.Klijent, Model.Klijent>();
            CreateMap<Database.Klijent, KlijentSearchRequest>().ReverseMap();
            CreateMap<Database.Klijent, KlijentUpdateRequest>().ReverseMap();
            CreateMap<Database.Klijent, KlijentInsertRequest>().ReverseMap();
            CreateMap<Database.Grad, Model.Grad>();
            CreateMap<Database.DetaljiRezervacije, Model.DetaljiRezervacije>().ReverseMap();
            CreateMap<Database.DetaljiRezervacije, DetaljiRezervacijeUpdateRequest>().ReverseMap();
            CreateMap<Database.KorisnikUloge, Model.KorisnikUloge>();
            CreateMap<Database.Objekat, Model.Objekat>();
            CreateMap<Database.Objekat, ObjekatInsertRequest>().ReverseMap();
            CreateMap<Database.Objekat, ObjekatSearchRequest>().ReverseMap();
            CreateMap<Database.Objekat, ObjekatUpdateRequest>().ReverseMap();
            CreateMap<Database.Ocjena, Model.Ocjena>();
            CreateMap<Database.Rezervacija, Model.Rezervacija>();
            CreateMap<Database.Rezervacija, RezervacijaSearchRequest>().ReverseMap();
            CreateMap<Database.Rezervacija, RezervacijaInsertRequest>().ReverseMap();
            CreateMap<Database.Rezervacija, RezervacijaUpdateRequest>().ReverseMap();
            CreateMap<Database.TipObjektaSllike, Model.TipObjektaSllike>();
            CreateMap<Database.TipObjektum, Model.TipObjektum>();
            CreateMap<Database.TipObjektum, TipObjektumSearchRequest>().ReverseMap();
            CreateMap<Database.Uloga, Model.Uloga>();
            CreateMap<Database.Uloga, UlogaSearchRequest>().ReverseMap();
            CreateMap<Database.Uloga, UlogaUpdateRequest>().ReverseMap();
        }
    }
}
