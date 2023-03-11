namespace KURSMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GRUP_KAYIT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GRUP_KAYIT()
        {
            TAKSIT = new HashSet<TAKSIT>();
        }

        [Key]
        public int GRUP_KAYIT_REFNO { get; set; }

        public int GRUP_REFNO { get; set; }

        public int KURSIYER_REFNO { get; set; }

        [Column(TypeName = "date")]
        public DateTime KAYIT_TARIHI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AYRILIS_TARIHI { get; set; }

        public int DURUMU { get; set; }

        [StringLength(500)]
        public string ACIKLAMA { get; set; }

        public int? UCRET { get; set; }

        public virtual GRUP GRUP { get; set; }

        public virtual KURSIYER KURSIYER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAKSIT> TAKSIT { get; set; }
    }
}
