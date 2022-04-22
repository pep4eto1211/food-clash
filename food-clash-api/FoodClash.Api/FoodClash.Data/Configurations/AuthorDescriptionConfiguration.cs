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
    public class AuthorDescriptionConfiguration : IEntityTypeConfiguration<AuthorDescription>
    {
        public void Configure(EntityTypeBuilder<AuthorDescription> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Description).HasColumnType("ntext");

            builder.HasOne(x => x.User)
                .WithOne(x => x.AuthorDescription)
                .HasForeignKey<AuthorDescription>(x => x.UserId);
        }
    }
}
