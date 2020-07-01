using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SponsorLoeb.Data.Entities;



namespace SponsorLoeb.Data.Mappers
{
    class PostByMapper : IEntityTypeConfiguration<PostBy>
    {
        public void Configure(EntityTypeBuilder<PostBy> builder)
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
