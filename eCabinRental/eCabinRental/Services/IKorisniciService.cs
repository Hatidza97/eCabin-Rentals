using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCabinRental.Services
{
    public interface IKorisniciService
    {
        List<Model.Korisnik> Get();
    }
}
