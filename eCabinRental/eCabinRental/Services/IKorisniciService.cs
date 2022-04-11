using eCabinRental.Database;
using eCabinRental.Model.Request;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCabinRental.Services
{
    public interface IKorisniciService
    {
        //List<Model.Korisnik> Get();
        Model.Korisnik GetById(int id);
        bool Delete(int id);
        Model.Korisnik Insert(KorisniciInsertRequest request);
        List<Model.Korisnik> Get(KorisniciSearchRequest request);
        List<Model.Korisnik> GetRegistracija(KorisniciSearchRequest request);
        Model.Korisnik Update(int id, KorisniciUpdateRequest request);
        //Korisnik GetById(int id);
        //Model.Korisnik Insert(KorisnikUpsert request);
        //Data.Model.Korisnik Update(int id, KorisnikUpsert request);

        Task<Model.Korisnik> Login(KorisniciLoginRequest request);
        ActionResult<Model.Korisnik> SignUp(KorisniciUpdateRequest request);
    }
}
