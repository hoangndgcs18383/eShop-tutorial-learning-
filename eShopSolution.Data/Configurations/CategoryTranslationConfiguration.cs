﻿using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class CategoryTranslationConfiguration : IEntityTypeConfiguration<CategoryTranslation>
    {
        public void Configure(EntityTypeBuilder<CategoryTranslation> builder)
        {
            builder.ToTable("CategoryTranslation");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x => x.SeoAlias).IsRequired().HasMaxLength(200);
            builder.Property(x => x.SeoDescription).HasMaxLength(200);
            builder.Property(x => x.SeoTitle).HasMaxLength(200);
            builder.Property(x => x.LanguageId).IsRequired(false).IsRequired().HasMaxLength(5);

            builder.HasOne(l => l.Language)
                .WithMany(ct => ct.CategoryTranslations)
                .HasForeignKey(l => l.LanguageId);
            builder.HasOne(c => c.Category)
                .WithMany(ct => ct.CategoryTranslations)
                .HasForeignKey(c => c.CategoryId);
        }
    }
}
