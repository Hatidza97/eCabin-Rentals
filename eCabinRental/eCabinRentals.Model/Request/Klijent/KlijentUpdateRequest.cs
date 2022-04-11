using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eCabinRental.Model.Request.Klijent
{
    public class KlijentUpdateRequest
    {
        // public int KlijentId { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Ime { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Prezime { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string KorisnickoIme { get; set; }
    }
}
