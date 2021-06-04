using RahatBookAplikacija.Models;
using System;
using System.ComponentModel.DataAnnotations;

public class Uplata : InterfejsZaRezervaciju
{
    #region Properties
    [Key]
    [Required]
    public int idRezervacije { get; set; }
    [Required]
    public SredstvoPlacanja sredstvoPlacanja { get; set; }

    [Required]
    public NacinPlacanja nacinPlacanja { get; set; }

    public int brojRata { get; set; }

    public int idPopusta { get; set; }

    #endregion

    #region Metode
    public void dioRezervacije()
    {
        throw new NotImplementedException();
    }
    #endregion
}
