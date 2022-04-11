using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCabinRental.Services;
using eCabinRental.Model.Request.DetaljiRezervacije;

namespace eCabinRental.Controllers
{
    public class DetaljiRezervacijeController:ControllerBase
    {
        private readonly IDetaljiRezervacijeService _service;
        public DetaljiRezervacijeController(IDetaljiRezervacijeService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<Model.DetaljiRezervacije> Get()
        {
            return _service.Get();
        }
        [HttpGet("{id}")]
        public Model.DetaljiRezervacije GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPut("{id}")]
        public Model.DetaljiRezervacije Update(int id, [FromBody] DetaljiRezervacijeUpdateRequest request)
        {
            return _service.Update(id, request);
        }
       
    }
}
