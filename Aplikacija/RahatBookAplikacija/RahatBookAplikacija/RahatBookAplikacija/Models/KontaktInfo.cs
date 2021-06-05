using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("ID smještajne jedinice:")]
        public int idSJ { get; set; }
        [Required]
        [DisplayName("Ime:")]
        public String ime { get; set; }
        [Required]
        [DisplayName("Prezime:")]
        public String prezime { get; set; }
        [Required]
        [DisplayName("E-mail:")]
        public String email { get; set; }
        [Required]
        [DisplayName("Telefon:")]
        public String telefon { get; set; }

        #endregion

        #region Konstruktor
        public KontaktInfo()
        {
        }
        #endregion 

    }
}
