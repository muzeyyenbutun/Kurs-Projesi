namespace KURSMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    [Table("EGITIM")]
    public partial class EGITIM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EGITIM()
        {
            GRUP = new HashSet<GRUP>();
        }

        [Key]
        public int EGITIM_REFNO { get; set; }

        [Required]
        [StringLength(100)]
        public string EGITIM_ADI { get; set; }

        public int KATEGORI_REFNO { get; set; }
        public int ALT_KATEGORI_REFNO { get; set; }
        public int DURUMU { get; set; }
        [AllowHtml]
        [Required]
        public string ICERIK { get; set; }

        [StringLength(500)]
        public string OZET { get; set; }

        public virtual KATEGORI KATEGORI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRUP> GRUP { get; set; }
    }
}
