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
    }
}
