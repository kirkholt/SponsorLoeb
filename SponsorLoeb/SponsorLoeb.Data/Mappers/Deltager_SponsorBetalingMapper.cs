using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SponsorLoeb.Data.Entities;

namespace SponsorLoeb.Data.Mappers
{
    class Deltager_SponsorBetalingMapper : IEntityTypeConfiguration<Deltager_SponsorBetaling>
    {
        public void Configure(EntityTypeBuilder<Deltager_SponsorBetaling> builder)
        {
            builder.ToTable("Deltager_SponsorBetaling");

            builder.HasKey(b => new { b.Deltager_Id, b.Sponsorbetaling_Id });

            builder.HasOne(b => b.Deltager).WithMany(b => b.Deltager_SponsorBetalinger).HasForeignKey(b => b.Deltager_Id);

            builder.HasOne(b => b.SponsorBetaling).WithMany(b => b.Deltager_SponsorBetalinger).HasForeignKey(b => b.Sponsorbetaling_Id);
        }

    }
}
