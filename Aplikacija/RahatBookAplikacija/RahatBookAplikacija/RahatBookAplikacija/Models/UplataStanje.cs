using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public class UplataStanje
    {
        #region Properties
        [Key]
        [Required]
        [DisplayName("ID uplate:")]
        public int idUplate { get; set; }

        [Required]
        [DisplayName("Cijena:")]
        public double cijena { get; set; }

        [Required]
        [DisplayName("Uplaćeno:")]
        public double doSadPlaceno { get; set; }

        [DisplayName("Plaćanje završeno:")]
        public bool zavrseno { get; set; }

        #endregion

        #region Konstruktor
        public UplataStanje()
        {
        }
        #endregion


    }
}
