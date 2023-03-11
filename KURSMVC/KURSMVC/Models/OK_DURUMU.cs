namespace KURSMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OK_DURUMU
    {
        [Key]
        public int OK_DURUMU_REFNO { get; set; }

        [Required]
        [StringLength(20)]
        public string ACIKLAMA { get; set; }
    }
}
