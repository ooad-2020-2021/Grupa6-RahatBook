using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public enum SredstvoPlacanja
    {
        [Display(Name = "Gotovina")]
        Gotovina,
        [Display(Name = "Kartica")]
        Kartica
    }
}
