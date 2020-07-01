using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

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
        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Demo;Trusted_Connection=True;");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //https://stackoverflow.com/questions/51842709/modelbuilder-configurations-addfromassembly-in-ef-core
            base.OnModelCreating(modelBuilder);
            // Tilføj alle Configuration (Mappers) i assembly
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SponsorLoebContext).Assembly);
        }
    }
}
