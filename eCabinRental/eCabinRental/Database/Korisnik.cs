using System;
using System.Collections.Generic;

#nullable disable

namespace eCabinRental.Database
{
    public partial class Korisnik
    {
        public Korisnik()
        {
            KorisnikUloges = new HashSet<KorisnikUloge>();
            Objekats = new HashSet<Objekat>();
        }

        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public byte[] Slika { get; set; }

        public virtual ICollection<KorisnikUloge> KorisnikUloges { get; set; }
        public virtual ICollection<Objekat> Objekats { get; set; }
    }
}
