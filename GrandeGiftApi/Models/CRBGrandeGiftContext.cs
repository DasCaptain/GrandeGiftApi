using Microsoft.EntityFrameworkCore;

namespace GrandeGiftApi.Models
{
    public partial class CRBGrandeGiftContext : DbContext
    {
        public CRBGrandeGiftContext()
        {
        }

        public CRBGrandeGiftContext(DbContextOptions<CRBGrandeGiftContext> options)
            : base(options)
        {
        }
        public virtual DbSet<HamperCategory> HamperCategory { get; set; }
        public virtual DbSet<HamperImages> HamperImages { get; set; }
        public virtual DbSet<HamperItems> HamperItems { get; set; }
        public virtual DbSet<Hampers> Hampers { get; set; }
        public virtual DbSet<Products> Products { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CRBGrandeGift;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<HamperImages>(entity =>
            {
                entity.HasIndex(e => e.HamperId)
                    .IsUnique();

                entity.HasOne(d => d.Hamper)
                    .WithOne(p => p.HamperImages)
                    .HasForeignKey<HamperImages>(d => d.HamperId);
            });

            modelBuilder.Entity<HamperItems>(entity =>
            {
                entity.HasKey(e => new { e.HamperId, e.ProductId });

                entity.HasIndex(e => e.ProductId);

                entity.Property(e => e.HamperId).HasColumnName("HamperID");

                entity.HasOne(d => d.Hamper)
                    .WithMany(p => p.HamperItems)
                    .HasForeignKey(d => d.HamperId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.HamperItems)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<Hampers>(entity =>
            {
                entity.HasIndex(e => e.HamperCategoryId);

                entity.Property(e => e.HamperName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.HasOne(d => d.HamperCategory)
                    .WithMany(p => p.Hampers)
                    .HasForeignKey(d => d.HamperCategoryId);
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.HasIndex(e => e.CategoryId);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId);
            });




        }
    }
}
