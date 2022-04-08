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
            CreateMap<Database.Grad, Model.Grad>();
            CreateMap<Database.DetaljiRezervacije, Model.DetaljiRezervacije>();
            CreateMap<Database.DetaljiRezervacije, DetaljiRezervacijeUpdateRequest>();
            CreateMap<Database.KorisnikUloge, Model.KorisnikUloge>();
            CreateMap<Database.Objekat, Model.Objekat>();
            CreateMap<Database.Objekat, ObjekatInsertRequest>().ReverseMap();
            CreateMap<Database.Objekat, ObjekatSearchRequest>().ReverseMap();
            CreateMap<Database.Objekat, ObjekatUpdateRequest>().ReverseMap();
            CreateMap<Database.Ocjena, Model.Ocjena>();
            CreateMap<Database.Rezervacija, Model.Rezervacija>();
            CreateMap<Database.TipObjektaSllike, Model.TipObjektaSllike>();
            CreateMap<Database.TipObjektum, Model.TipObjektum>();
            CreateMap<Database.TipObjektum, TipObjektumSearchRequest>().ReverseMap();
            CreateMap<Database.Uloga, Model.Uloga>();

        }
    }
}
