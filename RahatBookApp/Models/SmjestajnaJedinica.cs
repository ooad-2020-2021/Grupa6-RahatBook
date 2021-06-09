using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public class SmjestajnaJedinica : IPosmatrac
    {
        #region Properties
        [Key]
        [Required]
        [DisplayName("ID:")]
        public int id { get; set; }

        [Required]
        [DisplayName("Naziv smještajne jedinice:")]
        public String naziv { get; set; }
        [DisplayName("Broj zvjezdica:")]
        public int brojZvjezdica { get; set; }

        [Required]
        [DisplayName("ID lokacije:")]
        public int idLokacije { get; set; }

        [Required]
        [DisplayName("ID karakteristike:")]
        public int idKarakteristike { get; set; }

        [Required]
        [DisplayName("ID usluge:")]
        public int idUsluge { get; set; }

        [Required]
        [EnumDataType(typeof(Status))]
        [DisplayName("Status smještajne jedinice:")]
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
