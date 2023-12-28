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

            // One-to-Many relationship between Seller and Animal
            modelBuilder.Entity<Seller>()
                .HasMany(s => s.Animals)
                .WithOne(a => a.Seller)
                .HasForeignKey(a => a.SellerId);

            // One-to-Many relationship between Seller and Fish
            modelBuilder.Entity<Seller>()
                .HasMany(s => s.Fishes)
                .WithOne(f => f.Seller)
                .HasForeignKey(f => f.SellerId);

            // Many-to-One relationship between Animal and Cage
            modelBuilder.Entity<Animal>()
                .HasOne(a => a.Cage)
                .WithMany(c => c.Animals)
                .HasForeignKey(a => a.CageId);

            // Many-to-One relationship between Fish and Aquarium
            modelBuilder.Entity<Fish>()
                .HasOne(f => f.Aquarium)
                .WithMany(aq => aq.Fishes)
                .HasForeignKey(f => f.AquariumId);
        }

        private List<owner> GetOwners()
        {
            return new List<owner> 
            { 
                new owner{ Id= -1, Username = "hasan", Password = "123" } 
            };
        }

        public DbSet<owner> Owners { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Fish> Fishes { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Cage> Cages { get; set; }
        public DbSet<Aquarium> Aquariums { get; set; }
    }
}
