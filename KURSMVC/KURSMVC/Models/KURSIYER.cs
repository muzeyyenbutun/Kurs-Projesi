namespace KURSMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KURSIYER")]
    public partial class KURSIYER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KURSIYER()
        {
            GRUP_KAYIT = new HashSet<GRUP_KAYIT>();
        }

        [Key]
        public int KURSIYER_REFNO { get; set; }

        [Required]
        [StringLength(20)]
        public string ADI { get; set; }

        [Required]
        [StringLength(20)]
        public string SOYADI { get; set; }

        [StringLength(1)]
        public string CINSIYET { get; set; }

        public int? OGRENIM_REFNO { get; set; }
    

        [Required]
        [StringLength(150)]
        public string ADRES { get; set; }

        [Required]
        [StringLength(11)]
        public string TELEFON { get; set; }

        [Required]
        [StringLength(11)]
        public string CEP { get; set; }

        [Required]
        [StringLength(50)]
        public string MAIL { get; set; }

        [StringLength(500)]
        public string ACIKLAMA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRUP_KAYIT> GRUP_KAYIT { get; set; }
        public virtual OGRENIM OGRENIM { get; set; }
    }
}
