using Microsoft.EntityFrameworkCore;
using ProductCatalogue.Data;
using System.Reflection.Metadata;
namespace ProductCatalogue.DataBaseContext
{
	public class ApplicationDBContext : DbContext
	{
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
		{

		}

		public DbSet<Category> Categories { get; set; }
        public DbSet<Products> ProductDetails { get; set; }

        public DbSet<ProductProperties> PropertyDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>()
            .HasOne<Category>()
            .WithMany(p => p.ProductDetails)
            .HasForeignKey(c => c.CategoryID);

            modelBuilder.Entity<ProductProperties>()
           .HasOne<Products>()
           .WithMany(p => p.PropertyDetails)
           .HasForeignKey(c => c.ProductId);
        }

        //protected override void OnModelCreating1(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Products>()
        //    .HasOne<Category>()
        //    .WithMany(p => p.ProductDetails)
        //    .HasForeignKey(c => c.CategoryID);
        //}

    }
}
