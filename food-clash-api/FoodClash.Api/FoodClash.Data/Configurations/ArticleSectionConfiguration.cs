using FoodClash.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodClash.Data.Configurations
{
    public class ArticleSectionConfiguration : IEntityTypeConfiguration<ArticleSection>
    {
        public void Configure(EntityTypeBuilder<ArticleSection> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Content).HasColumnType("ntext");

            builder.HasOne(x => x.Article)
                .WithMany(x => x.Sections)
                .HasForeignKey(x => x.ArticleId);
            builder.HasOne(x => x.Type)
                .WithMany(x => x.Sections)
                .HasForeignKey(x => x.TypeId);
        }
    }
}
