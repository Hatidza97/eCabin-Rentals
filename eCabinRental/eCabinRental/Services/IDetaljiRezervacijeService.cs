using eCabinRental.Model;
using eCabinRental.Model.Request.DetaljiRezervacije;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCabinRental.Services
{
    public interface IDetaljiRezervacijeService
    {
        List<Model.DetaljiRezervacije> Get();
        Model.DetaljiRezervacije GetById(int id);
        List<Model.DetaljiRezervacije> Update(int id, DetaljiRezervacijeUpdateRequest request);
        //Model.Korisnik Update(int id, DetaljiRezervacijeUpdateRequest request);
        //Model.Korisnik Update(int id, DetaljiRezervacijeUpdateRequest request);

    }
}
