using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SponsorLoeb.Data.Entities;
using SponsorLoeb.Data.EntityFrameworkCore;

//https://github.com/aspnet/EntityFrameworkCore/issues/2805

namespace SponsorLoeb.Data.Mappers
{
    class BrugerMapper : EntityTypeConfiguration<Bruger>
    {
        public override void Map(EntityTypeBuilder<Bruger> builder)
        {
            builder.Property(b => b.Email)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(b => b.Navn)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(b => b.Adresse)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(b => b.Telefon)
                .IsRequired()
                .HasMaxLength(20);

            // Foreign key relationer
            builder.HasOne(b => b.PostBy).WithMany(b => b.Brugere).HasForeignKey(b => b.PostBy_Id);

        }

    }
}
