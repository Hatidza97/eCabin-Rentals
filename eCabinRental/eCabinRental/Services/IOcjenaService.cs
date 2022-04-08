using AutoMapper;
using eCabinRental.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCabinRental.Services
{
    public interface IOcjenaService
    {
        List<Model.Ocjena> Get();
        Model.Ocjena GetById(int id);

    }
}
