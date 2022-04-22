using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodClash.Data.Entities
{
    public class Contender
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long ClashId { get; set; }

        public Clash Clash { get; set; }
        public ContenderScore Score { get; set; }
    }
}
