using RahatBookApp.Models;
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
        [Required(ErrorMessage = "Ovo polje je obavezno")]
        [DisplayName("ID:")]
        public int id { get; set; }

        [Required(ErrorMessage = "Ovo polje je obavezno")]
        [DisplayName("Naziv smještajne jedinice:")]
        public String naziv { get; set; }
        [DisplayName("Broj zvjezdica:")]
        [Range(1,5, ErrorMessage ="Broj zvjezdica mora biti između 1 i 5!")]
        public int brojZvjezdica { get; set; }

        [Required(ErrorMessage = "Ovo polje je obavezno")]
        [DisplayName("ID lokacije:")]
        public int idLokacije { get; set; }

        [Required(ErrorMessage = "Ovo polje je obavezno")]
        [DisplayName("ID karakteristike:")]
        public int idKarakteristike { get; set; }

        [Required(ErrorMessage = "Ovo polje je obavezno")]
        [DisplayName("ID usluge:")]
        public int idUsluge { get; set; }

        [Required(ErrorMessage = "Ovo polje je obavezno")]
        [EnumDataType(typeof(Status))]
        [DisplayName("Status smještajne jedinice:")]
        public Status status { get; set; }

        [Required(ErrorMessage = "Ovo polje je obavezno")]
        [EnumDataType(typeof(TipSmjestajneJedinice))]
        [DisplayName("Tip smještajne jedinice:")]
        public TipSmjestajneJedinice tip { get; set; }

        #endregion

        #region Metode 
        public void primiObavijest()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
