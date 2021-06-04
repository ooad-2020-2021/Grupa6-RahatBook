using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public class Gost
    {
        #region Properties
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public String ime { get; set; }
        [Required]
        public String prezime { get; set; }
        [Required]
        public DateTime datumRodjenja { get; set; }
        #endregion


        #region Konstruktor
        public Gost()
        {
        }
        #endregion
    }
}
