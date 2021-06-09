using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public enum NacinPlacanja
    {
        [Display(Name = "Jednokratno")]
        Jednokratno,
        [Display(Name = "Na rate")] 
        NaRate
    }
}
