﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public class Upit
    {
        #region Properties 
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public int idOd { get; set; }
        [Required]
        public int idZa { get; set; }
        public bool procitan { get; set; }
        [Required]
        public String pitanje { get; set; }
        public String odgovor { get; set; }
        #endregion
    }
}
