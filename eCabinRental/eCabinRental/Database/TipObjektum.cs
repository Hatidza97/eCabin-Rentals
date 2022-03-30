﻿using System;
using System.Collections.Generic;

#nullable disable

namespace eCabinRental
{
    public partial class TipObjektum
    {
        public TipObjektum()
        {
            Objekats = new HashSet<Objekat>();
        }

        public int TipObjektaId { get; set; }
        public string Tip { get; set; }

        public virtual ICollection<Objekat> Objekats { get; set; }
    }
}
