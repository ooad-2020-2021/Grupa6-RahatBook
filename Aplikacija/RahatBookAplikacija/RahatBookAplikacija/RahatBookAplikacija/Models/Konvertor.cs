using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public class Konvertor
    {
        static Konvertor instanca;


        #region Konstruktor
        public Konvertor()
        {
        }

        #endregion

        #region Metode
        public Konvertor dajInstancu()
        {
            if (instanca == null)
            {
                instanca = new Konvertor();
            }
            return instanca;
        }
        #endregion
    }
}
