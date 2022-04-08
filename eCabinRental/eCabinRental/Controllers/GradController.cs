using eCabinRental.Model;
using eCabinRental.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCabinRental.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GradController: ControllerBase
    {
        private readonly IGradService _service;
        public GradController(IGradService service)
        {
            _service = service;

        }
        [HttpGet]
        public IList<Model.Grad> Get()
        {
            return _service.Get();
        }
        [HttpGet("{id}")]
        public Model.Grad GetById(int id)
        {
            return _service.GetById(id);
        }

    }
}
