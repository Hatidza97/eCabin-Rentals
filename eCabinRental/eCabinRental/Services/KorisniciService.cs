using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eCabinRental.Database;
namespace eCabinRental.Services
{
    public class KorisniciService: IKorisniciService
    {
        protected readonly IMapper _mapper;
        public BSContext context { get; set; }
        public KorisniciService(BSContext Context, IMapper mapper)
        {
            context = Context;
            _mapper = mapper;
        }
        public List<Model.Korisnik> Get()
        {
            return context.Korisniks.ToList().Select(x=>_mapper.Map<Model.Korisnik>(x)).ToList();

        }
        //private Model.Korisnik ToModel(Korisnik entity)
        //{
        //    return new Model.Korisnik()
        //    {
        //        KorisnikId = entity.KorisnikId,
        //        Ime = entity.Ime,
        //        Prezime = entity.Prezime,
        //        Email = entity.Email,
        //        KorisnickoIme = entity.Email,
        //        Slika = entity.Slika,
        //        Telefon = entity.Telefon
        //    };
        //}
    }
}
