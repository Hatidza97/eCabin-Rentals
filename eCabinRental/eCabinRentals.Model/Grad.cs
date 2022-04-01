using System;
using System.Collections.Generic;
using System.Text;

namespace eCabinRental.Model
{
    public partial class Grad
    {
        public Grad()
        {
        //    Klijents = new HashSet<Klijent>();
        //    Objekats = new HashSet<Objekat>();
        }

        public int GradId { get; set; }
        public string Naziv { get; set; }
        public string PostBroj { get; set; }

        //public virtual ICollection<Klijent> Klijents { get; set; }
        //public virtual ICollection<Objekat> Objekats { get; set; }
    }
}
