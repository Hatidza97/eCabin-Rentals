using AutoMapper;
using eCabinRental.Database;
using eCabinRental.Model.Request.Uloga;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCabinRental.Services
{
    public class UlogaService:IUlogaService
    {
        protected readonly IMapper _mapper;
        public BSContext context { get; set; }
        public UlogaService(BSContext Context, IMapper mapper)
        {
            context = Context;
            _mapper = mapper;
        }
        
        public Model.Uloga GetById(int id)
        {
            var entity = context.Ulogas.Find(id);
            return _mapper.Map<Model.Uloga>(entity);
        }
        public bool Delete(int id)
        {
            var entity = context.Ulogas.Find(id);
            if (entity != null)
            {
                context.Ulogas.Remove(entity);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public List<Model.Uloga> Get(UlogaSearchRequest request)
        {
            var query = context.Ulogas
                //.Include(x => x.UlogaId)
                .AsQueryable();
            if (!string.IsNullOrWhiteSpace(request.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(request.Naziv));
            }
            

            var list = query.ToList();
            return _mapper.Map<List<Model.Uloga>>(list);
        }
        public Model.Uloga Update(int id, UlogaUpdateRequest request)
        {
            var entity = context.Ulogas.Find(id);

            context.Ulogas.Attach(entity);
            context.Ulogas.Update(entity);

            _mapper.Map(request, entity);
            context.SaveChanges();

            return _mapper.Map<Model.Uloga>(entity);
        }
    }
}
