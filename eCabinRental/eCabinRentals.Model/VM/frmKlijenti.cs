using System;
using System.Collections.Generic;
using System.Text;

namespace eCabinRental.Model.VM
{
    public class frmKlijenti
    {
        public int KlijentId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int? GradID { get; set; }
        public string Grad{ get; set; }
        public string Telefon { get; set; }
        public string Username { get; set; }
        public byte[] Slika { get; set; }

        ///public  Grad Grad { get; set; }


    }
}
