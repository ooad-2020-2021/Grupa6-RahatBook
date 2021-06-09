using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public enum PrefZaHranu
    {
        [Display(Name = "Vegetarijanska")]
        Vegetarijanska,
        [Display(Name = "Vegan")] 
        Vegan,
        [Display(Name = "Halal")] 
        Halal,
        [Display(Name = "Kosher")] 
        Kosher,
        [Display(Name = "Drugo")] 
        Drugo
    }
}
