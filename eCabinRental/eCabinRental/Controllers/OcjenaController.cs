using eCabinRental.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCabinRental.Controllers
{   [ApiController]
    [Route("[controller]")]
    public class OcjenaController:ControllerBase
    {
        private readonly IOcjenaService _service;
        public OcjenaController(IOcjenaService service)
        {
            _service = service;
        }
        [HttpGet]
        public IList<Model.Ocjena> Get()
        {
            return _service.Get();
        }
        [HttpGet("{id}")]
        public Model.Ocjena GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
