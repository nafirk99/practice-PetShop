using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInPractice1
{
    public class AppDbContext : DbContext
    {
        private readonly string _connectionString;
        public AppDbContext()
        {
            _connectionString = "Server=.\\SQLEXPRESS;Database=testDb2;User Id=csharpb15;Password=123456; Trust Server Certificate=True";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
                optionsBuilder.UseSqlServer(_connectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<owner>().HasData(GetOwners().ToArray());
        }

        private List<owner> GetOwners()
        {
            return new List<owner> 
            { 
                new owner{ Id= -1, Username = "hasan", Password = "123" } 
            };
        }

        public DbSet<owner> Owners { get; set; }
    }
}
