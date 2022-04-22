using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodClash.Data.Entities
{
    public class Article
    {
        public long Id { get; set; }
        public long ClashId { get; set; }
        public long AuthorId { get; set; }

        public Clash Clash { get; set; }
        public User Author { get; set; }

        public List<ArticleSection> Sections { get; set; }
    }
}
