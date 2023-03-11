namespace KURSMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAKSIT")]
    public partial class TAKSIT
    {
        [Key]
        public int TAKSIT_REFNO { get; set; }

        public int GRUP_KAYIT_REFNO { get; set; }

        public int DURUMU { get; set; }

        [Column(TypeName = "date")]
        public DateTime TARIH { get; set; }

        public int BORC { get; set; }

        public int ODENEN { get; set; }

        [StringLength(500)]
        public string ACIKLAMA { get; set; }

        public virtual GRUP_KAYIT GRUP_KAYIT { get; set; }
    }
}
