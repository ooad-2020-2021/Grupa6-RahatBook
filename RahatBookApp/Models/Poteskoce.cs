using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public enum Poteskoce
    {
        [Display(Name = "Slijep")]
        Slijep,
        [Display(Name = "Gluhonijem")] 
        Gluhonijem,
        [Display(Name = "Nepokretan")] 
        Nepokretan,
        [Display(Name = "Dijabetes")] 
        Dijabetes, 
        [Display(Name = "Drugo")] 
        Drugo
    }
}
