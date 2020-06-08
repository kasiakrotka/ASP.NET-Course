namespace KatarzynaKrawczykLab5Zad1.DbContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    /// <summary>
    /// model dla klienta
    /// </summary>
    [Table("Client")]
    public partial class Client
    {
        public int Id { get; set; }

        [Required]
        [StringLength(32)]
        public string Name { get; set; }

        [Required]
        [StringLength(32)]
        public string Surname { get; set; }

        [Required]
        [StringLength(128)]
        public string Adress { get; set; }

        [Required]
        [StringLength(32)]
        public string City { get; set; }

        [StringLength(32)]
        public string Email { get; set; }
    }
}
