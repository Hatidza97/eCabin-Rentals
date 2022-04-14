using eCabinRental.Model;
using eCabinRental.Model.Request.Grad;
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
    public class GradController : BaseController<Model.Grad, Model.Request.Grad.GradSearchRequest>
    {
        public GradController(IService<Grad, GradSearchRequest> service) : base(service)
        {

        }
    }
}
