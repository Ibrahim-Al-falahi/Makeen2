using CodeAcademyShop.Configuration;
using CodeAcademyShop.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademyShop.Context
{
    internal class ApplicationDbContext:DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=CodeAcademyShop;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                .HasMany<Tag>()
                .WithMany();
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Catagory> Catagory { get; set; }
        public DbSet<Tag> Tag { get; set; }
    }
}
