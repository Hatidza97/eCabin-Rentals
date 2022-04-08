using AutoMapper;
using eCabinRental.Database;
using eCabinRental.Model.Request;
using eCabinRental.Model.Request.Objekat;
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
    public class ObjekatController: ControllerBase
    {
        private readonly IObjekatService _service;
        public ObjekatController(IObjekatService service)
        {
            _service = service;
        }
        [HttpGet]
        public IList<Model.Objekat> Get()
        {
            return _service.Get();
        }
        [HttpGet("{id}")]
        public Model.Objekat GetByID(int id)
        {
            return _service.GetByID(id);
        }
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _service.Delete(id);
        }
        [HttpPut("{id}")]
        public ActionResult<Model.Objekat> Update(int id, [FromBody] ObjekatUpdateRequest request)
        {
            return _service.Update(id, request);
        }
        [HttpPost]
        public ActionResult<Model.Objekat> Insert(ObjekatInsertRequest request)
        {
            return _service.Insert(request);
        }
    }
}
