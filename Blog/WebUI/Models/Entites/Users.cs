using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Entites
{
    public class Users:BaseEntity
    {
        public Users()
        {
            Articles = new HashSet<Articles>();
            Topics = new HashSet<Topics>();
        }
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }

        public UserDetail UserDetail { get; set; }

        public ICollection<Topics> Topics { get; set; }
        public ICollection<Articles> Articles { get; set; }
    }
}
