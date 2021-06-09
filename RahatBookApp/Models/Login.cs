using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public class Login : InterfejsZaRezervaciju
    {
        #region Properties
        [Key]
        [Required]
        [DisplayName("ID:")]
        public int id { get; set; }

        [Required]
        [DisplayName("ID korisnika:")]
        public int idKorisnika { get; set; }
        [Required]
        [DisplayName("Korisničko ime:")]
        String korisnickoIme { get; set; }
        [Required]
        [DisplayName("Lozinka:")]
        String lozinka { get; set; }


        #endregion

        #region Konstruktor
        public Login()
        {
        }
        #endregion

        #region Metode
        public void dioRezervacije()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
