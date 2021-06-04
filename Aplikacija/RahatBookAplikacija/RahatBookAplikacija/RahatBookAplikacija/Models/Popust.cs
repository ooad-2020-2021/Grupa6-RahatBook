using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public class Popust
    {

        #region Properties
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public int idSJ { get; set; }
        [Required]
        public Tuple<DateTime, DateTime> periodRezervacije { get; set; }
        [Required]
        public DateTime pocetakObracuna { get; set; }
        [Required]
        public DateTime krajObracuna { get; set; }
        [Required]
        public double vrijednost { get; set; }

        #endregion
    }
}
