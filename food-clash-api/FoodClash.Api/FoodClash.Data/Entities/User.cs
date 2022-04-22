using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodClash.Data.Entities
{
    public class User
    {
        public long Id { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }
        public long RoleId { get; set; }

        public Role Role { get; set; }
        public AuthorDescription AuthorDescription { get; set; }

        public List<Article> Articles { get; set; }
        public List<ContenderScore> Scores { get; set; }
    }
}
