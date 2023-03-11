namespace KURSMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ONKAYIT")]
    public partial class ONKAYIT
    {
        [Key]
        public int ONKAYIT_REFNO { get; set; }

        public int GRUP_REFNO { get; set; }

        [Required]
        [StringLength(50)]
        public string ADI_SOYADI { get; set; }

        [Required]
        [StringLength(11)]
        public string TELEFON { get; set; }

        [Required]
        [StringLength(50)]
        public string EPOSTA { get; set; }

        [Column(TypeName = "date")]
        public DateTime TARIH { get; set; }

        [StringLength(500)]
        public string ACIKLAMA { get; set; }

        public int? DURUMU { get; set; }

        public virtual GRUP GRUP { get; set; }
    }
}
