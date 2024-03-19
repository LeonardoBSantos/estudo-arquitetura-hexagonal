using Domain.entities;
using Microsoft.EntityFrameworkCore;

namespace InMemoryDb
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Entity1> Entity1 { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Entity1>().HasKey(x => x.IdExemplo);
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "SumNumsAb");
        }

    }
}