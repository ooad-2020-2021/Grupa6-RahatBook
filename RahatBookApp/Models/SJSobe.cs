using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RahatBookAplikacija.Models
{
    public class SJSobe
    {
        #region Properties
        [Key]
        [Required]
        [DisplayName("ID smještajne jedinice:")]
        public int idSJ { get; set; }

        [Required]
        [DisplayName("ID vrste sobe:")]
        public int idVrstaSobe { get; set; }

        [Required]
        [DisplayName("Ukupan broj soba:")]
        public int ukupanBrojSoba { get; set; }

        [Required]
        [DisplayName("Ukupan broj zauzetih soba:")]
        public int ukupanBrojZauzetihSoba { get; set; }

        #endregion
    }
}
