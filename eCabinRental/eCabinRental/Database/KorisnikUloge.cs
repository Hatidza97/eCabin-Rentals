using System;
using System.Collections.Generic;

#nullable disable

namespace eCabinRental
{
    public partial class KorisnikUloge
    {
        public int KorisnikUlogeId { get; set; }
        public int KorisnikId { get; set; }
        public int UlogaId { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual Uloga Uloga { get; set; }
    }
}
