using Microsoft.EntityFrameworkCore;
using PetShop2023.Data;

namespace PetStore.Data
{
	public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; } = null!;

		public string DbPath { get; }

		public ProductContext()
		{
			var folder = Environment.SpecialFolder.LocalApplicationData;
			var path = Environment.GetFolderPath(folder);
			DbPath = System.IO.Path.Join(path, "product.db");
		}
		protected override void OnConfiguring(DbContextOptionsBuilder options)
			=> options.UseSqlite($"Data Source={DbPath}");
	}
}
