using eCabinRental.Model;
using eCabinRental.Model.Request;
using eCabinRental.Model.Request.Objekat;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCabinRental.Services
{
    public interface IObjekatService
    {
        //List<Model.Objekat> Get();
        Model.Objekat GetByID(int id);
        bool Delete(int id);
        List<Model.Objekat> Get(ObjekatSearchRequest request);
        Model.Objekat Update(int id,ObjekatUpdateRequest request);
        Model.Objekat Insert(ObjekatInsertRequest request);
        //ActionResult<Korisnik> Insert(KorisniciInsertRequest request);
    }
}
