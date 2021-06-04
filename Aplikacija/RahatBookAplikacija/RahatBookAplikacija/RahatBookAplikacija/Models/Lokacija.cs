using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public class Lokacija
    {
        #region Properties
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public String drzava { get; set; }
        [Required]
        public String grad { get; set; }
        [Required]
        public String postanskiBroj { get; set; }
        [Required]
         public String adresa { get; set; }
        #endregion
    }
}
