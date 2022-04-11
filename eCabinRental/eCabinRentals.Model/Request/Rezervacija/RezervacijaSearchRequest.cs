using System;
using System.Collections.Generic;
using System.Text;

namespace eCabinRental.Model.Request.Rezervacija
{
    public class RezervacijaSearchRequest
    {
        public int RezervacijaId { get; set; }
        public DateTime Datum { get; set; }
        public DateTime DatumPrijave { get; set; }
        public DateTime DatumOdjave { get; set; }
        public int BrojOdraslih { get; set; }
        public int BrojDjece { get; set; }
        public int? Otkazano { get; set; }

    }
}
