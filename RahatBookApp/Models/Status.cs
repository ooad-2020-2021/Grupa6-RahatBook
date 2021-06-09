using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public enum Status
    {
        [Display(Name = "Aktivan")]
        Aktivan,
        [Display(Name = "Neaktivan")] 
        Neaktivan,
        [Display(Name = "Banovan")] 
        Banovan
    }
}
