using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SponsorLoeb.Data.Entities;
using SponsorLoeb.Data.EntityFrameworkCore;

namespace SponsorLoeb.Data.Mappers
{
    class DeltagerMapper : EntityTypeConfiguration<Deltager>
    {
        public override void Map(EntityTypeBuilder<Deltager> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Navn)
                .IsRequired()
                .HasMaxLength(50);

            // Foreign key relationer
            builder.HasOne(b => b.Hold).WithMany(b => b.Deltagere).HasForeignKey(b => b.Hold_Id);
            builder.HasOne(b => b.Bruger).WithMany(b => b.Deltagere).HasForeignKey(b => b.Bruger_Id);
        }
    }
}
