using System;
using System.Collections.Generic;

#nullable disable

namespace eCabinRental
{
    public partial class TipObjektaSllike
    {
        public int TipObjektaSlikeId { get; set; }
        public byte[] ImageData { get; set; }
        public int ObjekatId { get; set; }

        public virtual Objekat Objekat { get; set; }
    }
}
