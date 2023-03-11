namespace KURSMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAKVIM")]
    public partial class TAKVIM
    {
        [Key]
        public int TAKVIM_REFNO { get; set; }

        [Required]
        [StringLength(100)]
        public string BASLIK { get; set; }

        public DateTime TARIH_SAAT { get; set; }

        public bool? DURUMU { get; set; }

        public int? KULLANICI_REFNO { get; set; }

        public bool? TIPI { get; set; }
    }
}
