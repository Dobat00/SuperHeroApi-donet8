using Microsoft.EntityFrameworkCore;
using SuperHeroApi_donet8.Entities;
namespace SuperHeroApi_donet8.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
 