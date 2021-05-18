using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public class Popust
    {
        int id;
        int idSJ;
        Tuple<DateTime, DateTime> periodRezervacije;
        DateTime pocetakObracuna;
        DateTime krajObracuna;
        double vrijednost;
    }
}
