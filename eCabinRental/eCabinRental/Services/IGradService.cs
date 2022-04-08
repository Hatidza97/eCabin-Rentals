using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCabinRental.Services
{
    public interface IGradService
    {
        List<Model.Grad> Get();
        Model.Grad GetById(int id);

    }
}
