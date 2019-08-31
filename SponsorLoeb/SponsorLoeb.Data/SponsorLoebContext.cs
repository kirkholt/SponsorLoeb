using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using SponsorLoeb.Data.EntityFrameworkCore;
using SponsorLoeb.Data.Mappers;

namespace SponsorLoeb.Data
{
    public class SponsorLoebContext : DbContext
    {
        public DbSet<Entities.Bruger> Brugere{ get; set; }
        public DbSet<Entities.Deltager> Deltagere { get; set; }
        public DbSet<Entities.Deltager_SponsorBetaling> Deltager_SponsorBetalinger { get; set; }

        public SponsorLoebContext(DbContextOptions<SponsorLoebContext> options) : base(options)
        { }
        
        //static LoggerFactory object
        public static readonly ILoggerFactory loggerFactory = new LoggerFactory(new[] {
              new ConsoleLoggerProvider((_, __) => true, true)
        });

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Demo;Trusted_Connection=True;");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new PostByMapper());
            modelBuilder.AddConfiguration(new BrugerMapper());
            modelBuilder.AddConfiguration(new DeltagerMapper());
            modelBuilder.AddConfiguration(new Deltager_SponsorBetalingMapper());
        }
    }
}
