using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteEntity.Concrete
{
   public class Topic
    {
        public Topic()
        {
            Articles = new HashSet<Article>();
            Users = new HashSet<User>();
        }
        public int TopicsID { get; set; }
        public string Title { get; set; }
        public string TopicPhoto { get; set; }

        public ICollection<Article> Articles { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
