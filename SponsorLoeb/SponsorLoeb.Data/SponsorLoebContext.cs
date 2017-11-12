using Microsoft.EntityFrameworkCore;
using SponsorLoeb.Data.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SponsorLoeb.Data
{
    public class SponsorLoebContext : DbContext
    {
        public DbSet<Entities.Bruger> Brugers{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Demo;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new BrugerMapper());
        }
    }
}
