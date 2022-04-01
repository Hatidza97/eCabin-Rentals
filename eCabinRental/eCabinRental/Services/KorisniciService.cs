using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using eCabinRental.Database;
using eCabinRental.Model.Request;
using Microsoft.AspNetCore.Mvc;

namespace eCabinRental.Services
{
    public class KorisniciService: IKorisniciService
    {
        protected readonly IMapper _mapper;
        public BSContext context { get; set; }
        public KorisniciService(BSContext Context, IMapper mapper)
        {
            context = Context;
            _mapper = mapper;
        }
        public List<Model.Korisnik> Get()
        {
            return context.Korisniks.ToList().Select(x=>_mapper.Map<Model.Korisnik>(x)).ToList();

        }
        public Model.Korisnik GetById(int id)
        {
            var entity = context.Korisniks.Find(id);
            return _mapper.Map<Model.Korisnik>(entity);
        }
        public bool Delete(int id)
        {
            var entity = context.Korisniks.Find(id);
            if (entity != null)
            {
                context.Korisniks.Remove(entity);
                return true;
            }
            return false;
        }
        [HttpPost]
        public Model.Korisnik Insert(KorisniciInsertRequest request)
        {
            var entity = _mapper.Map<Database.Korisnik>(request);
            entity.Ime = request.Ime;
            entity.Email = request.Email;
            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Sifra);
            context.Korisniks.Add(entity);

            context.SaveChanges();
            return _mapper.Map<Model.Korisnik>(entity);
        }
        public static string GenerateSalt()
        {
            var buff = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buff);
            return Convert.ToBase64String(buff);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);

        }
        
    }
}
