using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public class KontaktInfo
    {
        #region Properties
        [Key]
        [Required]
        public int idSJ { get; set; }
        [Required]
        public String ime { get; set; }
        [Required]
        public String prezime { get; set; }
        [Required]
        public String email { get; set; }
        [Required]
        public String telefon { get; set; }

        #endregion

        #region Konstruktor
        public KontaktInfo()
        {
        }
        #endregion 

    }
}
