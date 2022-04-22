using FoodClash.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodClash.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }

        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {

        }

        #region DbSets
        public DbSet<Category> Categories { get; set; }
        public DbSet<Clash> Clashes { get; set; }
        public DbSet<Contender> Contenders { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<AuthorDescription> AuthorDescriptions { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ContenderScore> ContenderScores { get; set; }
        public DbSet<ArticleSectionType> ArticleSectionTypes { get; set; }
        public DbSet<ArticleSection> ArticleSections { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
