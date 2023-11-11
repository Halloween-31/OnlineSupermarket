using Microsoft.EntityFrameworkCore;
using webapi.Models.Implementations;

namespace webapi.Data
{
    /// <summary>
    /// Represent context which provide work with database
    /// </summary>
    public class OnlineSupermarket_DbContext : DbContext
    {
        /// <summary>
        /// Defauly constructor
        /// </summary>
        /// <param name="options"></param>
        public OnlineSupermarket_DbContext(DbContextOptions<OnlineSupermarket_DbContext> options):
            base(options) { }

        /// <summary>
        /// Represent table of categories
        /// </summary>
        public virtual DbSet<Category> Categories { get; set; }
        /// <summary>
        /// Represent table of customer
        /// </summary>
        public virtual DbSet<Customer> Customers { get; set; }
        /// <summary>
        /// Represent table of discounts
        /// </summary>
        public virtual DbSet<Discount> Discounts { get; set; }
        /// <summary>
        /// Represent table of employees
        /// </summary>
        public virtual DbSet<Employee> Employees { get; set; }
        /// <summary>
        /// Represent table of products
        /// </summary>
        public virtual DbSet<Product> Products { get; set; }
        /// <summary>
        /// Represent table of sales
        /// </summary>
        public virtual DbSet<Sale> Sales { get; set; }
        /// <summary>
        /// Represent table of spendings
        /// </summary>
        public virtual DbSet<Spending> Spendings { get; set; }
        /// <summary>
        /// Represent table of stores
        /// </summary>
        public virtual DbSet<StoreBranch> StoreBranches { get; set; }
        /// <summary>
        /// Represent table of suppliers
        /// </summary>
        public virtual DbSet<Supplier> Suppliers { get; set; }

        /// <inheritdoc/>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=OnlineSupermarlet;Trusted_Connection=True;Encrypt=False");
            optionsBuilder.EnableDetailedErrors();
            optionsBuilder.EnableSensitiveDataLogging();
        }

        /// <inheritdoc/>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("CategoryID");
            });

            modelBuilder.Entity<Customer>(entity =>
            {                
                entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("CustomerID");                

                entity.HasMany(d => d.Discounts).WithMany(p => p.Customers)
                    .UsingEntity<Dictionary<string, object>>(
                        "CustomerDiscount",
                        r => r.HasOne<Discount>().WithMany().HasForeignKey("DiscountsDiscountId"),
                        l => l.HasOne<Customer>().WithMany().HasForeignKey("CustomersCustomerId"),
                        j =>
                        {
                            j.HasKey("CustomersCustomerId", "DiscountsDiscountId");
                            j.ToTable("CustomerDiscount");
                            j.HasIndex(new[] { "DiscountsDiscountId" }, "IX_CustomerDiscount_DiscountsDiscountId");
                        });

                entity.HasOne(c => c.Sale).WithOne(s => s.Customer)
                    .HasForeignKey<Sale>(e => e.CustomerId);
            });

            modelBuilder.Entity<Discount>(entity =>
            {               
                entity.Property(e => e.Id).HasColumnName("DiscountID").ValueGeneratedOnAdd();

                entity.HasIndex(e => e.ProductId, "IX_Discounts_ProductID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Product).WithMany(p => p.Discounts)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Discounts_Products");
            });

            modelBuilder.Entity<Employee>(entity =>
            {                
                entity.Property(e => e.Id).HasColumnName("EmployeeID").ValueGeneratedOnAdd();

                entity.HasIndex(e => e.StoreId, "IX_Employees_StoreID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.HasOne(d => d.Store).WithMany(p => p.Employees)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Employees_StoreBranches");
            });

            modelBuilder.Entity<Product>(entity =>
            {                
                entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("ProductID");

                entity.HasIndex(e => e.CategoryId, "IX_Products_CategoryID");
                entity.HasIndex(e => e.SpendingId, "IX_Products_SpendingId");                
                entity.HasIndex(e => e.SupplierId, "IX_Products_SupplierID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");                
                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Category).WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Products_Categories");

                entity.HasOne(d => d.Spending).WithMany(p => p.Products)
                    .HasForeignKey(d => d.SpendingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products_Spendings");                

                entity.HasMany(p => p.StoreBranches).WithMany(p => p.Products)
                    .UsingEntity<Dictionary<string, object>>(
                        "ProductStoreBranch",
                        r => r.HasOne<StoreBranch>().WithMany().HasForeignKey("StoreBranchesStoreBranchId"),
                        l => l.HasOne<Product>().WithMany().HasForeignKey("ProductsProductId"),
                        j =>
                        {
                            j.HasKey("ProductsProductId", "StoreBranchesStoreBranchId");
                            j.ToTable("ProductStoreBranches");
                            j.HasIndex(new[] { "StoreBranchesStoreBranchId" }, "IX_ProductStoreBranch_StoreBranchesStoreBranchId");
                        });

                entity.HasOne(d => d.Supplier).WithMany(p => p.Products)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products_Suppliers");

                entity.HasMany(d => d.Sales).WithMany(p => p.Products)
                    .UsingEntity<Dictionary<string, object>>(
                        "ProductSale",
                        r => r.HasOne<Sale>().WithMany().HasForeignKey("SalesSaleId"),
                        l => l.HasOne<Product>().WithMany().HasForeignKey("ProductsProductId"),
                        j =>
                        {
                            j.HasKey("ProductsProductId", "SalesSaleId");
                            j.ToTable("ProductSale");
                            j.HasIndex(new[] { "SalesSaleId" }, "IX_ProductSale_SalesSaleId");
                        });
            });

            modelBuilder.Entity<Sale>(entity =>
            {                
                entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("SaleID");

                entity.HasIndex(e => e.CustomerId, "IX_Sales_CustomerId");
                entity.HasIndex(e => e.EmployeeId, "IX_Sales_EmployeeID");
                
                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Employee).WithMany(p => p.Sales)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sales_Employees");                
            });

            modelBuilder.Entity<Spending>(entity =>
            {                
                entity.Property(e => e.Id).HasColumnName("SpendingID").ValueGeneratedOnAdd();

                entity.HasIndex(e => e.EmployeeId, "IX_Spendings_EmployeeID");
                entity.HasIndex(e => e.SupplierId, "IX_Spendings_SupplierID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");                
                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Employee).WithMany(p => p.Spendings)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Spendings_Employees");

                entity.HasOne(d => d.Supplier).WithMany(p => p.Spendings)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Spendings_Suppliers");
            });

            modelBuilder.Entity<StoreBranch>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("StoreBranchID");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("SupplierID").ValueGeneratedOnAdd();
            });
        }
    }
}
