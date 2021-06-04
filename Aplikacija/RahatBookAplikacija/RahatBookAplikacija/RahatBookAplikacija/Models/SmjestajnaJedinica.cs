using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public class SmjestajnaJedinica
    {
        #region Properties
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public String naziv { get; set; }
        public int brojZvjezdica { get; set; }
        [Required]
        public int idLokacije { get; set; }
        [Required]
        public int idKarakteristike { get; set; }
        [Required]
        public int idUsluge { get; set; }
        [Required]
        public Status status { get; set; }
        #endregion
    }
}
