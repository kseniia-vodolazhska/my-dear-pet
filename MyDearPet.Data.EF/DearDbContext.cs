using System;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using MyDearPet.Data.EF.Models;

namespace MyDearPet.Data.EF
{
    public class DearDbContext : DbContext
    {
        public DearDbContext(DbContextOptions<DearDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pet> Pets { get; set; }

        public DbSet<Shelter> Shelters { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Media> Media { get; set; }

        public DbSet<RoleArea> RoleAreas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseEntityTypeConfiguration();
        }
    }
}
