using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

//https://github.com/aspnet/EntityFrameworkCore/issues/2805

namespace SponsorLoeb.Data.EntityFrameworkCore
{
    public static class ModelBuilderExtensions
    {
        public static void AddConfiguration<TEntity>(this ModelBuilder modelBuilder, EntityTypeConfiguration<TEntity> configuration)
            where TEntity : class
        {
            configuration.Map(modelBuilder.Entity<TEntity>());
        }
    }
}
