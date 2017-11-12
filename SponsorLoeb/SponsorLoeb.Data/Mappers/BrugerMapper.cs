using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SponsorLoeb.Data.Entities;
using SponsorLoeb.Data.EntityFrameworkCore;

namespace Microsoft.EntityFrameworkCore//SponsorLoeb.Data.Mappers
{
    class BrugerMapper : EntityTypeConfiguration<Bruger>
    {
        public override void Map(EntityTypeBuilder<Bruger> builder)
        {
            builder.ToTable("Bruger");

            builder.Property(b => b.Navn)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(b => b.Adresse)
                .IsRequired()
                .HasMaxLength(500);

        }

    }
}
