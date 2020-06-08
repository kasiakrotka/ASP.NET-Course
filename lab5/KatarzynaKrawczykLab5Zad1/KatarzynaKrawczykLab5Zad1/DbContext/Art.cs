namespace KatarzynaKrawczykLab5Zad1.DbContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    /// <summary>
    /// model dla obrazu
    /// </summary>
    [Table("Art")]
    public partial class Art
    {
        public int Id { get; set; }

        [Required]
        [StringLength(64)]
        public string ArtName { get; set; }

        [StringLength(256)]
        public string ArtDescription { get; set; }

        [StringLength(128)]
        public string Photo { get; set; }
    }
}
