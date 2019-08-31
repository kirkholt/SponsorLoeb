using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

//https://github.com/aspnet/EntityFrameworkCore/issues/2805

namespace SponsorLoeb.Data.EntityFrameworkCore
{
  

    public abstract class EntityTypeConfiguration<TEntity>
       where TEntity : class
    {
        public abstract void Map(EntityTypeBuilder<TEntity> builder);
    }
}
