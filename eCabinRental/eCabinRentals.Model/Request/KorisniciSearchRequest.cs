using System;
using System.Collections.Generic;
using System.Text;

namespace eCabinRental.Model.Request
{
    public class KorisniciSearchRequest
    {

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        //public int? TipKorisnikaId
        //{
        //    get; set;
        //}
    }
}
