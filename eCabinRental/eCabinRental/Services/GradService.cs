using AutoMapper;
using eCabinRental.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCabinRental.Services
{
    public class GradService : IGradService
    {
        protected readonly IMapper _mapper;
        public BSContext _context;
        public GradService(BSContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Model.Grad> Get()
        {
            return _context.Grads.ToList().Select(x => _mapper.Map<Model.Grad>(x)).ToList();
        }
        public Model.Grad GetById(int id)
        {
            var entity = _context.Grads.Find(id);
            return _mapper.Map<Model.Grad>(entity);
        }


    }
}
