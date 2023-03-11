namespace KURSMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SLIDER")]
    public partial class SLIDER
    {
        [Key]
        public int SLIDER_REFNO { get; set; }

        [Required]
        [StringLength(250)]
        public string BASLIK { get; set; }

        public bool DURUMU { get; set; }

        [Required]
        [StringLength(100)]
        public string LINK { get; set; }

        [Required]
        [StringLength(100)]
        public string RESIM { get; set; }
    }
}
