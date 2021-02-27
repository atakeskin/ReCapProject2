using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    /// <summary>
    /// Context : Db tabloları ile proje classlarını bağlamak
    /// Varsa diğer nesneler için DbSet'ler buraya yazılır.
    /// </summary>
    public class DevRentACarContext : DbContext
    {
        //public DevRentACarContext()
        //{
        //    Database.SetInitializer<NorthwindContext>(null);
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"
                                        Server=.;
                                        Database=DevRentACar;
                                        User=sa;
                                        Password=981210013;");
            // Bu şekildede yazılabilinir. Data Source=localhost;Initial Catalog = DevRentACar;User ID = SA;Password = 981210013;
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<CarImage> CarImages { get; set; }

    }
}
