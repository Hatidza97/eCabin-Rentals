using eCabinRental.Database;
using eCabinRental.Model.Request.Rezervacija;
using eCabinRental.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCabinRental.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RezervacijaController:ControllerBase
    {
        private readonly IRezervacijaService _service;
        public RezervacijaController(IRezervacijaService service)
        {
            _service = service;

        }
        [HttpGet("{id}")]
        public Model.Rezervacija GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _service.Delete(id);
        }
        [HttpGet]
        public ActionResult<List<Model.Rezervacija>> Get([FromQuery] RezervacijaSearchRequest search = null)
        {
            return _service.Get(search);
        }
        [HttpPost]
        public ActionResult<Model.Rezervacija> Insert(RezervacijaInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public ActionResult<Model.Rezervacija> Update(int id, [FromBody] RezervacijaUpdateRequest request)
        {
            return _service.Update(id, request);
        }
    }
}
