using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public class VrstaSobe
    {
        #region Properties
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        double[] cijena = new double[12];
        [Required]
        public int brojGostiju { get; set; }

        #endregion
    }
}
