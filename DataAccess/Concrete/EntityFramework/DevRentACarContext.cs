using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    /// <summary>
    /// Context : Db tabloları ile proje classlarını bağlamak
    /// </summary>
    public class DevRentACarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"
                                        Data Source=localhost;
                                        Initial Catalog=DevRentACar;
                                        User ID=SA;
                                        Password=981210013;");

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
    }
}
