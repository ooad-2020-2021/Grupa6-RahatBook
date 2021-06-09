using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("ID:")]
        public int id { get; set; }

        [Required]
        [DisplayName("ID smještajne jedinice:")]
        public int idSJ { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Početak perioda rezervacija:")]
        [DateGreaterThanAttribute(otherPropertyName = "pocetakObracuna", 
            ErrorMessage = "Datum za početak perioda rezervacija mora biti nakon datuma za početak obračuna popusta!")]
        public DateTime zaRezervacijeOD { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DateGreaterThanAttribute(otherPropertyName = "zaRezervacijeOD", 
            ErrorMessage = "Datum za kraj rezervacija mora biti nakon datuma za početak rezervacija!")]
        [DisplayName("Kraj perioda rezervacija:")]
        public DateTime zaRezervacijeDO { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Početak obračuna popusta:")]
        public DateTime pocetakObracuna { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DateGreaterThanAttribute(otherPropertyName = "pocetakObracuna", 
            ErrorMessage = "Datum za kraj obračuna popusta mora biti nakon datuma za početak obračuna popusta!")]
        [DisplayName("Početak obračuna popusta:")]
        public DateTime krajObracuna { get; set; }
        [Required]
        [DisplayName("Iznos popusta:")]
        [Range(0, 100, ErrorMessage = "Vrijednost popusta mora biti između 0 i 100%!")]
        public double procenat { get; set; }

        #endregion
    }
}
