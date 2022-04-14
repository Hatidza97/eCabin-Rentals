using AutoMapper;
using eCabinRental.Database;
using eCabinRental.Model.Request.Grad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCabinRental.Services
{
    public class GradService : BaseService<Model.Grad, GradSearchRequest, eCabinRental.Database.Grad>
    {
        protected readonly IMapper _mapper;
        public BSContext _context;
        
        //public List<Model.Grad> Get()
        //{
        //    return _context.Grads.ToList().Select(x => _mapper.Map<Model.Grad>(x)).ToList();
        //}
        public GradService(BSContext context, IMapper mapper) : base(context, mapper)
        {

        }
        //public Model.Grad GetById(int id)
        //{
        //    var entity = _context.Grads.Find(id);
        //    return _mapper.Map<Model.Grad>(entity);
        //}
        public List<Model.Grad> Get(GradSearchRequest search = null)
        {
            var entity = _context.Set<Database.Grad>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.NazivGrada))
            {
                entity = entity.Where(x => x.Naziv.Contains(search.NazivGrada));
            }
            if (search.GradId.HasValue)
            {
                entity = entity.Where(x => x.GradId == search.GradId);
            }
            var list = entity.ToList();
            return _mapper.Map<List<Model.Grad>>(list);

        }

    }
}
