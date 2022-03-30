using System;
using System.Collections.Generic;

#nullable disable

namespace eCabinRental
{
    public partial class Objekat
    {
        public Objekat()
        {
            DetaljiRezervacijes = new HashSet<DetaljiRezervacije>();
            Ocjenas = new HashSet<Ocjena>();
            TipObjektaSllikes = new HashSet<TipObjektaSllike>();
        }

        public int ObjekatId { get; set; }
        public string Naziv { get; set; }
        public string Povrsina { get; set; }
        public int BrojMjestaDjeca { get; set; }
        public int BrojMjestaOdrasli { get; set; }
        public int BrojMjestaUkupno { get; set; }
        public string Opis { get; set; }
        public double Cijena { get; set; }
        public int TipObjektaId { get; set; }
        public int GradId { get; set; }
        public int KorisnikId { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public virtual TipObjektum TipObjekta { get; set; }
        public virtual ICollection<DetaljiRezervacije> DetaljiRezervacijes { get; set; }
        public virtual ICollection<Ocjena> Ocjenas { get; set; }
        public virtual ICollection<TipObjektaSllike> TipObjektaSllikes { get; set; }
    }
}
