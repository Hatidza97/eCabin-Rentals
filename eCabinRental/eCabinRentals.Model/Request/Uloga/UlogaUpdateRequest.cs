using System;
using System.Collections.Generic;
using System.Text;

namespace eCabinRental.Model.Request.Uloga
{
    public class UlogaUpdateRequest
    {
        public int UlogaId { get; set; }
        public string Naziv { get; set; }
        public string OpisUloge { get; set; }
    }
}
