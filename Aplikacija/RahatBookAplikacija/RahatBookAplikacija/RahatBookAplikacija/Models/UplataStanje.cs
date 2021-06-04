using System;
using System.Collections.Generic;
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
        public int idUplate { get; set; }
        [Required]
        public double cijena { get; set; }
        [Required]
        public double doSadPlaceno { get; set; }
        public bool zavrseno { get; set; }
        #endregion

        #region Konstruktor
        public UplataStanje()
        {
        }
        #endregion


    }
}
