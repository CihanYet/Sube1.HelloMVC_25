using Microsoft.EntityFrameworkCore;

namespace Sube1.HelloMVC.Models
{
    public class OkulDbContext : DbContext
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=okulDBMVCSube1_25;Integrated Security=true;TrustServerCertificate=true");
        }
    }
}
