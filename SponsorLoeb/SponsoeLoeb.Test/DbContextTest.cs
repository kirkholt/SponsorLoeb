using Microsoft.EntityFrameworkCore;
using SponsorLoeb.Data;
using Xunit;

namespace SponsoeLoeb.Test
{
    public class DbContextTest
    {
        [Fact]
        public void TestDatabaseoprettelse()
        {
            var options = new DbContextOptionsBuilder<SponsorLoebContext>()
                 //.UseSqlServer(@"Server =OLE-WIN10\sql2017;Database=SponsorLoeb;Trusted_Connection=True")
                .UseSqlite(@"Data Source=e:\temp\SponsorLoeb.db")
                .UseLoggerFactory(SponsorLoebContext.MyLoggerFactory)
                .EnableSensitiveDataLogging()
                .Options;

            // Run the test against one instance of the context
            using (var context = new SponsorLoebContext(options))
            {
                context.Database.EnsureDeleted();
                Assert.True(context.Database.EnsureCreated(), "Test at database er oprettet");
            }
        }
    }
}
