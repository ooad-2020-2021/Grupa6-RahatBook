﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public class Administrator : RegistrovaniKorisnik
    {
        int id;
        int idLokacije;
        DateTime datumRodjenja;
        String ime;
        String prezime;
    }
}