using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public class RezervacijaGost
    {
        int idRezervacije;
        int idGosta;
        Tuple<int, int, int> idPref;
    }
}
