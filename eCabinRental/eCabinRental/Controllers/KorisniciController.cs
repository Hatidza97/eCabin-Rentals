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
    public class KorisniciController:ControllerBase
    {
        private readonly IKorisniciService _service;
        public KorisniciController(IKorisniciService service)
        {
            _service = service;
            
        }
        [HttpGet]
        public IList<Model.Korisnik> Get()
        {
            return _service.Get();
        }
    }
}
