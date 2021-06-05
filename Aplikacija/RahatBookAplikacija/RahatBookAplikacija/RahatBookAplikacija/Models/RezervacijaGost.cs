using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public class RezervacijaGost
    {
        #region Properties
        [Key]
        [Required]
        [DisplayName("ID rezervacije:")]
        int idRezervacije { get; set; }

        [Required]
        [DisplayName("ID gosta:")]
        int idGosta { get; set; }

        [Required]
        [DisplayName("ID alergije:")]
        public int idAlergije { get; set; }

        [Required]
        [DisplayName("ID poteškoća:")]
        public int idPoteskoca { get; set; }

        [Required]
        [DisplayName("ID preferencija za hranu:")]
        public int idPrefZaHranu { get; set; }

        #endregion
    }
}
