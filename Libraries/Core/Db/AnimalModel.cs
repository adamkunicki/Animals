namespace Animal.Db
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AnimalModel : DbContext
    {
        public AnimalModel()
            : base("name=AnimalModel")
        {
        }

        public AnimalModel(string connectionString)
            : base(connectionString)
        {
        }

        public virtual DbSet<Bowl> Bowls { get; set; }
        public virtual DbSet<Dog> Dogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dog>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Dog>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Dog>()
                .Property(e => e.SadImg)
                .IsUnicode(false);

            modelBuilder.Entity<Dog>()
                .Property(e => e.HappyImg)
                .IsUnicode(false);

            modelBuilder.Entity<Dog>()
                .Property(e => e.SponsorLogo)
                .IsUnicode(false);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
