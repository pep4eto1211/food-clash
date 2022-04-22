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
    public class ContenderConfiguration : IEntityTypeConfiguration<Contender>
    {
        public void Configure(EntityTypeBuilder<Contender> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.Property(x => x.Description).HasColumnType("ntext");

            builder.HasOne(x => x.Clash)
                .WithMany(x => x.Contenders)
                .HasForeignKey(x => x.ClashId);
        }
    }
}
