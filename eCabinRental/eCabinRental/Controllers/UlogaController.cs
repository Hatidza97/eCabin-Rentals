using eCabinRental.Model;
using eCabinRental.Model.Request.Uloga;
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
    public class UlogaController:ControllerBase
    {
        private readonly IUlogaService _service;
        public UlogaController(IUlogaService service)
        {
            _service = service;
        }
        [HttpGet("{id}")]
        public Uloga GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _service.Delete(id);
        }
        [HttpGet]
        public ActionResult<List<Model.Uloga>> Get([FromQuery] UlogaSearchRequest search = null)
        {
            return _service.Get(search);
        }
        [HttpPut("{id}")]
        public ActionResult<Model.Uloga> Update(int id, [FromBody] UlogaUpdateRequest request)
        {
            return _service.Update(id, request);
        }
    }
}
