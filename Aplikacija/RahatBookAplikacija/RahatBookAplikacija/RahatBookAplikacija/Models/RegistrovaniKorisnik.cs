using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public class RegistrovaniKorisnik
    {
        #region Properties
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public int idLokacije { get; set; }
        [Required]
        public DateTime datumRodjenja { get; set; }
        [Required]
        public String ime { get; set; }
        [Required]
        public String prezime { get; set; }
        [Required]
        public Status status { get; set; }

        #endregion
    }
}
