using eCabinRental.Model.Request.Klijent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCabinRental.Services
{
    public interface IKlijentService
    {
        Model.Klijent GetById(int id);
        bool Delete(int id);
        Model.Klijent Update(int id, KlijentUpdateRequest request);
        List<Model.Klijent> Get(KlijentSearchRequest request);
        Model.Klijent Insert(KlijentInsertRequest request);

        //List<Model.Korisnik> GetRegistracija(KorisniciSearchRequest request);
        //Model.Korisnik Update(int id, KorisniciUpdateRequest request);
    }
}
