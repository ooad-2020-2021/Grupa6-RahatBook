using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("ID:")]
        public int id { get; set; }
        [Required]
        [DisplayName("ID smještajne jedinice:")]
        public int idSJ { get; set; }
        [DisplayName("Komentar:")]
        public String komentar { get; set; }
        [Required]
        [DisplayName("Ocjena:")]
        [Range(0, 5, ErrorMessage = "Ocjena mora biti između 1 i 5!")]
        public int ocjena { get; set; }
        #endregion 
    }
}
