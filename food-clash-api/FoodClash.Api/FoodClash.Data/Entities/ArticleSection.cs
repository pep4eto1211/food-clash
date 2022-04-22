using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodClash.Data.Entities
{
    public class ArticleSection
    {
        public long Id { get; set; }
        public int Order { get; set; }
        public string Content { get; set; }
        public long ArticleId { get; set; }
        public long TypeId { get; set; }

        public Article Article { get; set; }
        public ArticleSectionType Type { get; set; }
    }
}
