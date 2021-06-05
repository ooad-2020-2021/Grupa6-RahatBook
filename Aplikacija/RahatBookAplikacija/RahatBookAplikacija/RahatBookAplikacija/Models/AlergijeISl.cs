using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public enum AlergijeISl
    {
        [Display(Name = "Gluten")]
        Gluten,
        [Display(Name = "Orašasti plodovi")]
        OrasastiPlodovi,
        [Display(Name = "Laktoza")]
        Laktoza,
        [Display(Name = "Drugo")]
        Drugo
    }
}
