using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCabinRental.Services
{
    public class KorisniciService: IKorisniciService
    {
        public BSContext context { get; set; }
        public KorisniciService(BSContext Context)
        {
            context = Context;
        }
        public List<Korisnik> Get()
        {
            return context.Korisniks.ToList();

        }
    }
}
