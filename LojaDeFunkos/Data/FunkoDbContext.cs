using Microsoft.EntityFrameworkCore;
using LojaDeFunkos.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace LojaDeFunkos.Data
{
	public class FunkoDbContext : IdentityDbContext
	{
        public DbSet<Funko> Funko { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Universo> Universo { get; set; }

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

