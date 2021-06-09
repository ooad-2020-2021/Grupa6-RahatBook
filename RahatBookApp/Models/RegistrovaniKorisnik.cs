using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public class RegistrovaniKorisnik : IPosmatrac
    {
        #region Properties
        [Key]
        [Required]
        [DisplayName("Ime:")]
        public int id { get; set; }
        [Required]
        [DisplayName("ID lokacije:")]
        public int idLokacije { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Datum rođenja:")]
        public DateTime datumRodjenja { get; set; }
        [Required]
        [DisplayName("Ime:")]
        public String ime { get; set; }
        [Required]
        [DisplayName("Prezime:")]
        public String prezime { get; set; }
        [Required]
        [EnumDataType(typeof(Status))]
        [DisplayName("Status korisnika:")]
        public Status status { get; set; }

        #endregion

        #region Metode

        public void primiObavijest()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
