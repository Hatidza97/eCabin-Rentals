using System;
using System.Collections.Generic;
using System.Text;

namespace eCabinRental.Model.VM
{
    public class frmObjekti
    {
        public int ObjekatId { get; set; }
        public string Naziv { get; set; }
        public string Povrsina { get; set; }
        public string BrojMjestaDjeca { get; set; }
        public string BrojMjestaOdrasli { get; set; }
        public string Cijena { get; set; }
        public int TipObjektaId { get; set; }
    }
}
