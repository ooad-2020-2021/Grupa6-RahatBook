using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public class Upit
    {
        #region Properties 
        [Key]
        [Required]
        [DisplayName("ID upita:")]
        public int id { get; set; }

        [Required]
        [DisplayName("ID korisnika:")]
        public int idOd { get; set; }

        [Required]
        [DisplayName("ID smještajne jedinice:")]
        public int idZa { get; set; }

        [DisplayName("Pročitano:")]
        public bool procitan { get; set; }

        [Required]
        [DisplayName("Pitanje:")]
        public String pitanje { get; set; }

        [DisplayName("Odgovor:")]
        public String odgovor { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayName("Datum postavljanja upita:")]
        public DateTime datumKreiranja { get; set; }
        
        [DataType(DataType.DateTime)]
        [DisplayName("Datum odgovora:")]
        public DateTime datumOdgovora { get; set; }


        #endregion

        #region Konstruktor
        public Upit ()
        {
            obavijestiOPitanju();
        }
        #endregion

        #region Metode
        private void obavijestiOPitanju() 
        {
        }
        private void obavijestiOOdgovoru() 
        { 
        }
        private void obavijestiOPrijavi() 
        {
        }
        public void odgovori(String odgovor)
        {
            this.odgovor = odgovor;
            this.obavijestiOOdgovoru();
        }
        public void prijavi ()
        {
            obavijestiOPrijavi();
        }
        #endregion
    }
}
