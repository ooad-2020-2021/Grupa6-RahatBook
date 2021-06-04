using System;
using System.Collections.Generic;
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
        int id { get; set; }
        [Required]
        int idKorisnika { get; set; }
        [Required]
        String korisnickoIme { get; set; }
        [Required]
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
