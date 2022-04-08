﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eCabinRental.Model.Request.Objekat
{
    public class ObjekatUpdateRequest
    {
       // public int ObjekatId { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Naziv { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Povrsina { get; set; }
        public int BrojMjestaDjeca { get; set; }
        [Required(AllowEmptyStrings = false)]
        public int BrojMjestaOdrasli { get; set; }
        [Required(AllowEmptyStrings =false)]
        public int BrojMjestaUkupno { get; set; }
        public string Opis { get; set; }
        [Required]
        public double Cijena { get; set; }
    }

}
