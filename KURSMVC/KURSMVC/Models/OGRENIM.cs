namespace KURSMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OGRENIM")]
    public partial class OGRENIM
    {
        [Key]
        public int OGRENIM_REFNO { get; set; }

        [Required]
        [StringLength(20)]
        public string OGRENIM_ADI { get; set; }
        public virtual ICollection<KURSIYER> KURSIYERs { get; set; }
    }
}
