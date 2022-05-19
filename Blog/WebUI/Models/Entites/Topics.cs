using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Entites
{
    public class Topics:BaseEntity
    {
        public Topics()
        {
            Articles = new HashSet<Articles>();
            Users = new HashSet<Users>();
        }        
        public string Title { get; set; }
        public string TopicPhoto { get; set; }

        public ICollection<Articles> Articles { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
