using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCabinRental.Services
{
   
        public interface IService<Tmodel, Tsearch> where Tsearch : class
        {
            List<Tmodel> Get(Tsearch search = null);
            Tmodel GetByID(int id);
        }
    
}
