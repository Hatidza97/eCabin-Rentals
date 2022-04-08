using eCabinRental.Model.Request.TipObjektum;
using eCabinRental.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCabinRental.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   // [Route("[controller]")]
    public class TipObjektumController: ControllerBase
    {
        private readonly ITipObjektumService _service;
        public TipObjektumController(ITipObjektumService service)
        {
            _service = service;
        }
        [HttpGet]
        public IList<Model.TipObjektum> Get()
        {
            return _service.Get();
        }
        [HttpGet("{id}")]
        public Model.TipObjektum GetById(int id)
        {
            return _service.GetById(id);
        }
        //[HttpGet]
        //[HttpGet(Name = nameof(Get1))]
        //public ActionResult<List<Model.TipObjektum>> Get1([FromQuery] TipObjektumSearchRequest request)
        //{
        //    return _service.Get1(request);
        //}
    }
}
