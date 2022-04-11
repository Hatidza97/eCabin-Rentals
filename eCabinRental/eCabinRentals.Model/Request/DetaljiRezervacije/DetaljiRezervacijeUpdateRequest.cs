using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eCabinRental.Model.Request.DetaljiRezervacije
{
    public class DetaljiRezervacijeUpdateRequest
    {
        [Required]
        public DateTime? Datum { get; set; }
        [Required]
        public double? Cijena { get; set; }
        public int DetaljiRezervacijeId { get; set; }
        public int RezervacijaId { get; set; }
        public int TipObjektaId { get; set; }
        public int KlijentId { get; set; }
        public int ObjekatId { get; set; }

    }
}
