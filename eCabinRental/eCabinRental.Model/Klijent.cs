using System;
using System.Collections.Generic;
using System.Text;

namespace eCabinRental.Model
{
    public partial class Klijent
    {
        public Klijent()
        {
            //DetaljiRezervacijes = new HashSet<DetaljiRezervacije>();
            //Ocjenas = new HashSet<Ocjena>();
        }

        public int KlijentId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public byte[] Slika { get; set; }
        public int GradId { get; set; }

        //public virtual Grad Grad { get; set; }
        //public virtual ICollection<DetaljiRezervacije> DetaljiRezervacijes { get; set; }
        //public virtual ICollection<Ocjena> Ocjenas { get; set; }
    }
}
