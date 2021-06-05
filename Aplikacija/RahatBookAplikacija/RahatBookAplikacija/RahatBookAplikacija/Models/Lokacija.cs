using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("ID:")]
        public int id { get; set; }
        [Required]
        [DisplayName("Država:")]
        public String drzava { get; set; }
        [Required]
        [DisplayName("Grad:")]
        public String grad { get; set; }
        [Required]
        [DisplayName("Poštanski broj:")]
        public String postanskiBroj { get; set; }
        [Required]
        [DisplayName("Adresa:")]
        public String adresa { get; set; }
        #endregion
    }
}
