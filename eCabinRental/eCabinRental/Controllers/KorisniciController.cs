using eCabinRental.Model;
using eCabinRental.Model.Request;
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
        [HttpGet("{id}")]
        public Korisnik GetById(int id)
        {
            return _service.GetById(id) ;
        }
        [HttpDelete("{id}")]
        public ActionResult<bool>Delete(int id)
        {
            return _service.Delete(id);
        }
        [HttpPost]
        public ActionResult<Model.Korisnik> Insert(KorisniciInsertRequest request)
        {
            return _service.Insert(request);
        }
    }
}
