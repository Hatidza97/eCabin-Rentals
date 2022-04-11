using System;
using System.Collections.Generic;
using System.Text;

namespace eCabinRental.Model.Request.Rezervacija
{
    public class RezervacijaUpdateRequest
    {
        public int Id { get; set; }
        public int Otkazano { get; set; }
    }
}
