using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public class DatumIzProšlosti : RangeAttribute
    {
        public DatumIzProšlosti() : base(typeof(DateTime), DateTime.MinValue.ToString(), DateTime.Now.ToString())
        {
        }
    }
    public class Gost
    {
        #region Properties
        [Key]
        [Required]
        [DisplayName("ID:")]
        public int id { get; set; }
        [Required]
        [DisplayName("Ime gosta:")]
        public String ime { get; set; }
        [Required]
        [DisplayName("Prezime gosta:")]
        public String prezime { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DatumIzProšlosti(ErrorMessage = "Datum rođenja mora biti u prošlosti!")]
        [DisplayName("Datum rođenja:")]
        public DateTime datumRodjenja { get; set; }
        #endregion


        #region Konstruktor
        public Gost()
        {
        }
        #endregion
    }
}
