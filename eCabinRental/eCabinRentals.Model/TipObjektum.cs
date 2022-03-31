using System;
using System.Collections.Generic;
using System.Text;

namespace eCabinRental.Model
{
    public partial class TipObjektum
    {
        public TipObjektum()
        {
           // Objekats = new HashSet<Objekat>();
        }

        public int TipObjektaId { get; set; }
        public string Tip { get; set; }

        //public virtual ICollection<Objekat> Objekats { get; set; }
    }
}
