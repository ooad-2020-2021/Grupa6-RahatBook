using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public class KontaktInfo
    {
        [Key]
        [Required]
        public int idSJ { get; set; }
        [Required]
        String ime { get; set; }
        [Required]
        String prezime { get; set; }
        [Required]
        String email { get; set; }
        [Required]
        String telefon { get; set; }
    }
}
