using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodClash.Data.Entities
{
    public class ContenderScore
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public long ContenderId { get; set; }
        public long ScorerId { get; set; }

        public Contender Contender { get; set; }
        public User Scorer { get; set; }
    }
}
