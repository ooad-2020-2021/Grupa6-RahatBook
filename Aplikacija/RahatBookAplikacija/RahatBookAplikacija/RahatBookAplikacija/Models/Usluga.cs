using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public enum Usluga
    {
        [Display(Name = "Noćenje")]
        Nocenje,
        [Display(Name = "Noćenje s doručkom")]
        NocenjeSDoruckom,
        [Display(Name = "Polupansion")]
        Polupansion,
        [Display(Name = "Puni pansion")]
        PuniPansion,
        [Display(Name = "All inclusive")]
        AllInclusive
    }
}
