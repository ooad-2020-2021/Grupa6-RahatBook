using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public class SJSobe
    {
        #region Properties
        [Key]
        [Required]
        public int idSJ { get; set; }
        [Required]
        public int idVS { get; set; }
        [Required]
        public int ukupanBrojSoba { get; set; }
        [Required]
        public int ukupanBrojZauzetihSoba { get; set; }
        #endregion
    }
}
