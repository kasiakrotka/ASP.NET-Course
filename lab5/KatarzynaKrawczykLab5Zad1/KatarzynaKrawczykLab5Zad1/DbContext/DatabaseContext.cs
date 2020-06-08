namespace KatarzynaKrawczykLab5Zad1.DbContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    /// <summary>
    /// Baza danych 
    /// </summary>
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }

        public virtual DbSet<Art> Art { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Client> Client { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Art>()
                .Property(e => e.Photo)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);
        }
    }
}
