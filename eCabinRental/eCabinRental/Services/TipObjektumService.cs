using AutoMapper;
using eCabinRental.Database;
using eCabinRental.Model.Request.TipObjektum;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCabinRental.Services
{
    public class TipObjektumService:ITipObjektumService
    {
        protected readonly IMapper _mapper;
        public BSContext _context;
        public TipObjektumService(BSContext context,IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        //public List<Model.TipObjektum> Get()
        //{
        //    return _context.TipObjekta.ToList().Select(x => _mapper.Map<Model.TipObjektum>(x)).ToList();
        //}
        public Model.TipObjektum GetById(int id)
        {
            var entity = _context.TipObjekta.Find(id);
            return _mapper.Map<Model.TipObjektum>(entity);
        }
        public List<Model.TipObjektum> Get(TipObjektumSearchRequest search)
        {
            var query = _context.TipObjekta
                .AsQueryable();
            if (!string.IsNullOrWhiteSpace(search.Tip))
            {
                query = query.Where(x => x.Tip.StartsWith(search.Tip));
            }

            var list = query.ToList();
            return _mapper.Map<List<Model.TipObjektum>>(list);
        }

     
    }
}
