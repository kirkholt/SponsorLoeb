using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SponsorLoeb.Data.Entities;
using SponsorLoeb.Data.EntityFrameworkCore;


namespace SponsorLoeb.Data.Mappers
{
    class PostByMapper : EntityTypeConfiguration<PostBy>
    {
        public override void Map(EntityTypeBuilder<PostBy> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.PostNr)
                .IsRequired()
                .HasMaxLength(4);

            builder.Property(b => b.Bynavn)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
