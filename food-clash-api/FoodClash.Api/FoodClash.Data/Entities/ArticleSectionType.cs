using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodClash.Data.Entities
{
    public class ArticleSectionType
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public List<ArticleSection> Sections { get; set; }
    }
}
