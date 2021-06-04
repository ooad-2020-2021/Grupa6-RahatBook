using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public class Gost
    {
        [Key]
        [Required]
        public int id;
        [Required]
        String ime;
        [Required]
        String prezime;
        [Required]
        DateTime datumRodjenja;
    }
}
