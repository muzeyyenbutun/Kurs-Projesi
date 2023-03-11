namespace KURSMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GRUP")]
    public partial class GRUP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GRUP()
        {
            GRUP_KAYIT = new HashSet<GRUP_KAYIT>();
            ONKAYIT = new HashSet<ONKAYIT>();
        }

        [Key]
        public int GRUP_REFNO { get; set; }

        public int EGITIM_REFNO { get; set; }

        [Required]
        [StringLength(50)]
        public string GUNLER { get; set; }

        [Column(TypeName = "date")]
        public DateTime BASLANGIC_TARIHI { get; set; }

        [Column(TypeName = "date")]
        public DateTime BITIS_TARIHI { get; set; }

        public TimeSpan BASLANGIC_SAAT { get; set; }

        public TimeSpan BITIS_SAAT { get; set; }

        public int DURUMU { get; set; }

        public int KONTENJAN { get; set; }

        public int UCRET { get; set; }

        public virtual EGITIM EGITIM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRUP_KAYIT> GRUP_KAYIT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ONKAYIT> ONKAYIT { get; set; }
    }
}
