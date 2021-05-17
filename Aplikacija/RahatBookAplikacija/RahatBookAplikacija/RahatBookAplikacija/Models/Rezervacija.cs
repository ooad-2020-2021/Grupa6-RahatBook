using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public class Rezervacija
    {
        static int brojRezervacija;
        int id;
        int idKorisnika;
        int idSJ;
        Tuple<DateTime, DateTime> dolazakOdlazak;
        bool ekskurzija;
    }
}
