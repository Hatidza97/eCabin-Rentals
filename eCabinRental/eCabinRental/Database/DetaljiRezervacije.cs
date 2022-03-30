using System;
using System.Collections.Generic;

#nullable disable

namespace eCabinRental
{
    public partial class DetaljiRezervacije
    {
        public int DetaljiRezervacijeId { get; set; }
        public int RezervacijaId { get; set; }
        public int TipObjektaId { get; set; }
        public int KlijentId { get; set; }
        public int ObjekatId { get; set; }
        public DateTime? Datum { get; set; }
        public double? Cijena { get; set; }

        public virtual Klijent Klijent { get; set; }
        public virtual Objekat Objekat { get; set; }
        public virtual Rezervacija Rezervacija { get; set; }
    }
}
