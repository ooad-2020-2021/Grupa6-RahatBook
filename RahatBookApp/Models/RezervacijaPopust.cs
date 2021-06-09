using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public class RezervacijaPopust : IRezervacija
    {
        #region Properties
        [Required]
        [DisplayName("Rezervacija:")]
        public IRezervacija rezervacija { get; set; }
        [Required]
        [DisplayName("ID popusta:")]
        public int idPopusta { get; set; }
        #endregion



        #region Metode
        public double izracunajCijenu()
        {
            throw new NotImplementedException();
        }

        public double obracunajPopust()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Konstruktor 

        public RezervacijaPopust(IRezervacija rezervacija)
        {
            this.rezervacija = rezervacija;
        }

        #endregion
    }
}
