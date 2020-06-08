namespace KatarzynaKrawczykLab5Zad1.DbContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    /// <summary>
    /// model dla produktu
    /// </summary>
    [Table("Product")]
    public partial class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(64)]
        public string Name { get; set; }

        [StringLength(256)]
        public string Description { get; set; }

        [StringLength(128)]
        public string Photo { get; set; }

        public decimal Price { get; set; }
    }
}
