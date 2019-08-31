using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SponsorLoeb.Data.Entities;
using SponsorLoeb.Data.EntityFrameworkCore;

namespace SponsorLoeb.Data.Mappers
{
    class Deltager_SponsorBetalingMapper : EntityTypeConfiguration<Deltager_SponsorBetaling>
    {
        public override void Map(EntityTypeBuilder<Deltager_SponsorBetaling> builder)
        {
            builder.ToTable("Deltager_SponsorBetaling");

            builder.HasKey(b => new { b.Deltager_Id, b.Sponsorbetaling_Id });

            builder.HasOne(b => b.Deltager).WithMany(b => b.Deltager_SponsorBetalinger).HasForeignKey(b => b.Deltager_Id);

            builder.HasOne(b => b.SponsorBetaling).WithMany(b => b.Deltager_SponsorBetalinger).HasForeignKey(b => b.Sponsorbetaling_Id);
        }

    }
}
