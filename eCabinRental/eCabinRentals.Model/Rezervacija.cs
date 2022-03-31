using System;
using System.Collections.Generic;
using System.Text;

namespace eCabinRental.Model
{
    public partial class Rezervacija
    {
        public Rezervacija()
        {
           // DetaljiRezervacijes = new HashSet<DetaljiRezervacije>();
        }

        public int RezervacijaId { get; set; }
        public DateTime Datum { get; set; }
        public DateTime DatumPrijave { get; set; }
        public DateTime DatumOdjave { get; set; }
        public int BrojOdraslih { get; set; }
        public int BrojDjece { get; set; }
        public int Otkazano { get; set; }

        //public virtual ICollection<DetaljiRezervacije> DetaljiRezervacijes { get; set; }
    }
}
