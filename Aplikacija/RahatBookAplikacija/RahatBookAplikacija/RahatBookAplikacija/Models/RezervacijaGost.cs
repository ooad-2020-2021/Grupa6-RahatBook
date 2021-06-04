using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public class RezervacijaGost
    {
        #region Properties
        [Key]
        [Required]
        int idRezervacije { get; set; }
        [Required]
        int idGosta { get; set; }
        [Required]
        public int idAlergije { get; set; }
        [Required]
        public int idPoteskoca { get; set; }
        [Required]
        public int idPrefZaHranu { get; set; }
        #endregion
    }
}
