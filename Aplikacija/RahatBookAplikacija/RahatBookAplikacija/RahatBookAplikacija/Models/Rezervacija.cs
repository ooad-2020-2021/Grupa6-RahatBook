﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public class Rezervacija : IRezervacija, InterfejsZaRezervaciju
    {
        #region Properties
        public static int brojRezervacija { get; set; }

        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public int idKorisnika { get; set; }
        [Required]
        public int idSJ { get; set; }
        [Required]
        public Tuple<DateTime, DateTime> dolazakOdlazak { get; set; }
        [Required]
        public bool ekskurzija { get; set; }

       
        #endregion

        #region Metode
        public double izracunajCijenu()
        {
            throw new NotImplementedException();
        }
        public void dioRezervacije()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
