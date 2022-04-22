using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodClash.Data.Entities
{
    public class Clash
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public long CategoryId { get; set; }

        public Category Category { get; set; }
        public Article Article { get; set; }

        public List<Contender> Contenders { get; set; }
    }
}
