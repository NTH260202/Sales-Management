using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace BusinessObject
{
    public partial class ManagementContext : DbContext
    {
        public string GetConnectionString()
        {
            string connectionString = null;
            IConfiguration config = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json", true, true)
                                    .Build();
            connectionString = config["ConnectionStrings:DefaultConnection"];
            return connectionString;
        }

        public TblMember GetDefaultUser()
        {
            TblMember admin = new TblMember();
            IConfiguration config = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json", true, true)
                                    .Build();
            admin.MemberId = 0;
            admin.Email = config["DefaultUser:Email"];
            admin.Password = config["DefaultUser:Password"];
            admin.City = config["DefaultUser:City"];
            admin.CompanyName = config["DefaultUser:CompanyName"];
            admin.Country = config["DefaultUser:Country"];
            return admin;
        }

        public ManagementContext()
        {

        }

        public ManagementContext(DbContextOptions<ManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblMember> TblMembers { get; set; } = null!;
        public virtual DbSet<TblOrder> TblOrders { get; set; } = null!;
        public virtual DbSet<TblOrderDetail> TblOrderDetails { get; set; } = null!;
        public virtual DbSet<TblProduct> TblProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString(), builder => builder.EnableRetryOnFailure());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblMember>(entity =>
            {
                entity.HasKey(e => e.MemberId)
                    .HasName("PK__tblMembe");
                entity.ToTable("tblMember");
                entity.Property(e => e.MemberId).ValueGeneratedNever();

                entity.Property(e => e.City).HasMaxLength(15);

                entity.Property(e => e.CompanyName).HasMaxLength(40);

                entity.Property(e => e.Country).HasMaxLength(15);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(30);
            });

            modelBuilder.Entity<TblOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__TblOrder__C3905BCFAE23F83E");

                entity.ToTable("tblOrder");

                entity.Property(e => e.OrderId).ValueGeneratedNever();

                entity.Property(e => e.Freight).HasColumnType("money");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.ShippedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.TblOrders)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TblOrder_tblMember");
            });
            modelBuilder.Entity<TblOrderDetail>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__tblOrder");

                entity.ToTable("tblOrderDetail");

                entity.Property(e => e.OrderId).ValueGeneratedNever();

                entity.Property(e => e.UnitPrice).HasColumnType("money");

                entity.HasOne(d => d.Order)
                    .WithOne(p => p.TblOrderDetail)
                    .HasForeignKey<TblOrderDetail>(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblOrderDetail_TblOrder");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblOrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblOrderDetail_tblProduct");
            });

            modelBuilder.Entity<TblProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__tblProduct");

                entity.ToTable("tblProduct");

                entity.Property(e => e.ProductId).ValueGeneratedNever();

                entity.Property(e => e.ProductName).HasMaxLength(40);

                entity.Property(e => e.UnitPrice).HasColumnType("money");

                entity.Property(e => e.Weight).HasMaxLength(20);

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}