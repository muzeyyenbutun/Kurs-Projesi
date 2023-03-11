namespace KURSMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class K_DURUMU
    {
        [Key]
        public int K_DURUMU_REFNO { get; set; }

        [Required]
        [StringLength(50)]
        public string ACIKLAMA { get; set; }
    }
}
