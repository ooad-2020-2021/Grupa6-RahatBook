using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookApp.Models
{
    public enum TipSmjestajneJedinice
    {
        [Display(Name = "Apartman")]
        Apartman,
        [Display(Name = "Hotel")]
        Hotel,
        [Display(Name = "Kuća")]
        Kuca
    }
}
