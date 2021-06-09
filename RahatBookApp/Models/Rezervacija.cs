using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public class DatumUBudućnosti : RangeAttribute
    {
        public DatumUBudućnosti() : base(typeof(DateTime), DateTime.Now.ToString(),  DateTime.MaxValue.ToString())
        {
        }
    }

    public class Rezervacija : IRezervacija, InterfejsZaRezervaciju
    {
        #region Properties
        public static int brojRezervacija { get; set; }

        [Key]
        [Required]
        [DisplayName("ID:")]
        public int id { get; set; }

        [Required]
        [DisplayName("ID korisnika:")]
        public int idKorisnika { get; set; }

        [Required]
        [DisplayName("ID smještajne jedinice:")]
        public int idSJ { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DatumUBudućnosti(ErrorMessage = "Datum rezervacije mora biti u budućnosti!")]
        [DisplayName("Datum dolaska:")]
        public DateTime dolazak { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DatumUBudućnosti(ErrorMessage = "Datum rezervacije mora biti u budućnosti!")]
        [DateGreaterThanAttribute(otherPropertyName = "dolazak", ErrorMessage = "Datum odjave mora biti poslije datuma prijave")]
        [DisplayName("Datum odjave:")]
        public DateTime odlazak { get; set; }

        [Required]
        [DisplayName("Ekskurzija:")]
        public bool ekskurzija { get; set; }

       
        #endregion

        #region Metode
        public double izracunajCijenu()
        {
            throw new NotImplementedException();
        }
        public void dioRezervacije()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
