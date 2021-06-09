using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public enum StatusRezervacije
    {
        [Display(Name = "U toku")]
        UToku,
        [Display(Name = "Finalizirana")] 
        Finalizirana,
        [Display(Name = "Korisnik odustao")] 
        KorisnikOdustao, 
        [Display(Name = "Neaktivna")] 
        Neaktivna
    }
}
