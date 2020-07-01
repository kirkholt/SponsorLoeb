using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SponsorLoeb.Data.Entities;


namespace SponsorLoeb.Data.Mappers
{
    class BrugerMapper : IEntityTypeConfiguration<Bruger>
    {
        public void Configure(EntityTypeBuilder<Bruger> builder)
        {
            builder.HasKey(b => b.Id).HasName("PK_Bruger");

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

            // Indexes
            builder.HasIndex(b => b.Email).IsUnique().HasName("IX_Bruger_Email");

            // Foreign key relationer
            builder.HasOne(b => b.PostBy).WithMany(b => b.Brugere).HasForeignKey(b => b.PostBy_Id);

        }

    }
}
