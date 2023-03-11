namespace KURSMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KATEGORI")]
    public partial class KATEGORI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KATEGORI()
        {
            EGITIM = new HashSet<EGITIM>();
        }

        [Key]
        public int KATEGORI_REFNO { get; set; }

        [Required]
        [StringLength(30)]
        public string KATEGORI_ADI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EGITIM> EGITIM { get; set; }
        public virtual ICollection<ALT_KATEGORI> ALT_KATEGORIs { get; set; }
    }
}
