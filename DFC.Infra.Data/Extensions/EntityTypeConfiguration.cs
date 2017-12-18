﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DFC.Infra.Data.Extensions
{
    public abstract class EntityTypeConfiguration<TEntity> where TEntity : class
    {
        public abstract void Map(EntityTypeBuilder<TEntity> builder);
    }
}