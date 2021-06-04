using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public class Recenzija
    {
        #region Properties
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public int idSJ { get; set; }

        public String komentar { get; set; }
        [Required]
        public int ocjena { get; set; }
        #endregion 
    }
}
