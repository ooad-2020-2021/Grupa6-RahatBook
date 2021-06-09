using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public enum Karakteristika
    {
        [Display(Name = "Klima")]
        Klima,
        [Display(Name = "Bazen")] 
        Bazen, 
        [Display(Name = "Bar")] 
        Bar,
        [Display(Name = "Posluga u sobu")]
        PoslugaUSobu,
        [Display(Name = "Restoran")] 
        Restoran,
        [Display(Name = "Fitness")]
        Fitness,
        [Display(Name = "WiFi")]
        WiFi, 
        [Display(Name = "Sauna")] 
        Sauna,
        [Display(Name = "Terasa")] 
        Terasa,
        [Display(Name = "Spa")] 
        Spa,
        [Display(Name = "Besplatan parking")] 
        BesplatanParking,
        [Display(Name = "Parking uz naplatu")]
        ParkingUzNaplatu
    }
}
