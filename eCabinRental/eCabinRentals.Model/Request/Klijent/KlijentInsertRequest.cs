using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eCabinRental.Model.Request.Klijent
{
    public class KlijentInsertRequest
    {
        //public int KlijentId { get; set; }
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public byte[] Slika { get; set; }
        public int? GradId { get; set; }
        public string Lozinka { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
    }
}
