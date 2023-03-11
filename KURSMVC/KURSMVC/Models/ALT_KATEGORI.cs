namespace KURSMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALT_KATEGORI
    {
        [Key]
        public int ALT_KATEGORI_REFNO { get; set; }

        public int KATEGORI_REFNO { get; set; }

        [Required]
        [StringLength(30)]
        public string ALT_KATEGORI_ADI { get; set; }
        public virtual KATEGORI KATEGORI { get; set; }
    }
}
