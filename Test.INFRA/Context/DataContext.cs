using Microsoft.EntityFrameworkCore;
using Test.MODELS.Entities;

namespace Test.INFRA.Context
{
    public partial class DataContext : DbContext
    {
        #region Constructor
        public DataContext()
        {

        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }
        #endregion

        #region DbSet's
        public virtual DbSet<Product> Product { get; set; }
        #endregion

        #region OnConfiguring And ModelCreating

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-B6EH3U6;Database=TestSolution;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.IdProduct)
                    .HasName("PK__Product__2E8946D42915AA10");

                entity.ToTable("Product");

                entity.Property(e => e.DateEnter).HasColumnType("date");

                entity.Property(e => e.DateExit).HasColumnType("date");

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.Property(e => e.State).HasMaxLength(10);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        #endregion
    }
}
