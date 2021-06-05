using RahatBookAplikacija.Models;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class Uplata : InterfejsZaRezervaciju
{
    #region Properties
    [Key]
    [Required]
    [DisplayName("ID rezervacije:")]
    public int idRezervacije { get; set; }

    [Required]
    [EnumDataType(typeof(SredstvoPlacanja))]
    [DisplayName("Sredstvo plaćanja:")]
    public SredstvoPlacanja sredstvoPlacanja { get; set; }

    [Required]
    [EnumDataType(typeof(NacinPlacanja))]
    [DisplayName("Način plaćanja:")]
    public NacinPlacanja nacinPlacanja { get; set; }
    [DisplayName("Broj rata:")]
    public int brojRata { get; set; }

    [DisplayName("ID popusta:")]
    public int idPopusta { get; set; }

    #endregion

    #region Metode
    public void dioRezervacije()
    {
        throw new NotImplementedException();
    }
    #endregion
}
