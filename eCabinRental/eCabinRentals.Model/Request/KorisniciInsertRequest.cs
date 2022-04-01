using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace eCabinRental.Model.Request
{
    public class KorisniciInsertRequest
    {
    //    public int KorisnikId { get; set; }
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        public string Email { get; set; }
        [Required]
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string Sifra { get; set; }
        public byte[] Slika { get; set; }
    }
}
