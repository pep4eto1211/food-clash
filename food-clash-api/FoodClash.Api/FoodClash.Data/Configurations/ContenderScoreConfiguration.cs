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
    public class ContenderScoreConfiguration : IEntityTypeConfiguration<ContenderScore>
    {
        public void Configure(EntityTypeBuilder<ContenderScore> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(100);

            builder.HasOne(x => x.Contender)
                .WithOne(x => x.Score)
                .HasForeignKey<ContenderScore>(x => x.ContenderId);
            builder.HasOne(x => x.Scorer)
                .WithMany(x => x.Scores)
                .HasForeignKey(x => x.ScorerId);
        }
    }
}
