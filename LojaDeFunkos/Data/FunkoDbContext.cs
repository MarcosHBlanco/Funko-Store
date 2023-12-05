using Microsoft.EntityFrameworkCore;
using LojaDeFunkos.Models;

namespace LojaDeFunkos.Data
{
	public class FunkoDbContext : DbContext
	{
        public DbSet<Funko> Funko { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            var stringConn = config.GetConnectionString("StringConn");

            optionsBuilder.UseSqlite(stringConn);
        }
    }
}

