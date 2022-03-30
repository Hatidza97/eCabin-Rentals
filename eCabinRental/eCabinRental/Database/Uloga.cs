using System;
using System.Collections.Generic;

#nullable disable

namespace eCabinRental
{
    public partial class Uloga
    {
        public Uloga()
        {
            KorisnikUloges = new HashSet<KorisnikUloge>();
        }

        public int UlogaId { get; set; }
        public string Naziv { get; set; }
        public string OpisUloge { get; set; }

        public virtual ICollection<KorisnikUloge> KorisnikUloges { get; set; }
    }
}
