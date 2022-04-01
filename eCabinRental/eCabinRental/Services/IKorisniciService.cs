using eCabinRental.Database;
using eCabinRental.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCabinRental.Services
{
    public interface IKorisniciService
    {
        List<Model.Korisnik> Get();
        Model.Korisnik GetById(int id);
        bool Delete(int id);
        Model.Korisnik Insert(KorisniciInsertRequest request);
    }
}
