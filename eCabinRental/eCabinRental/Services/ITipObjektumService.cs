using eCabinRental.Model.Request.TipObjektum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCabinRental.Services
{
    public interface ITipObjektumService
    {
        //List<Model.TipObjektum> Get();
        Model.TipObjektum GetById(int id);
        List<Model.TipObjektum> Get(TipObjektumSearchRequest search);


    }
}
