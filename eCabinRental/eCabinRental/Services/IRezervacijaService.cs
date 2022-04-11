using eCabinRental.Model.Request.Rezervacija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCabinRental.Services
{
    public interface IRezervacijaService
    {
        Model.Rezervacija GetById(int id);
        bool Delete(int id);
        List<Model.Rezervacija> Get(RezervacijaSearchRequest request);
        Model.Rezervacija Insert(RezervacijaInsertRequest request);
        Model.Rezervacija Update(int id, RezervacijaUpdateRequest request);


    }
}
