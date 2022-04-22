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
    public class ClashConfiguration : IEntityTypeConfiguration<Clash>
    {
        public void Configure(EntityTypeBuilder<Clash> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(100);
            builder.Property(x => x.Description).HasColumnType("ntext");

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Clashes)
                .HasForeignKey(x => x.CategoryId);
        }
    }
}
