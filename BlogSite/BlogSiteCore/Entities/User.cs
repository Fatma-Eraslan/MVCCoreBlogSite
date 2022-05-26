using BlogSiteCore.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteEntity.Concrete
{
   public class User : BaseEntity
    {
        public User()
        {
            Article = new HashSet<Article>();
            Topics = new HashSet<Topic>();
        }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string EMail { get; set; }

        public UserDetail UserDetail { get; set; }

        public ICollection<Topic> Topics { get; set; }
        public ICollection<Article> Article { get; set; }
    }
}
