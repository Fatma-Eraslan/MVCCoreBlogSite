using BlogSiteCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteEntity.Concrete
{
  public  class Article:BaseEntity
    {
        public Article()
        {
            Topics = new HashSet<Topic>();
        }
        
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }
        public string ArticlePhoto { get; set; }
        public ICollection<Topic> Topics { get; set; }

        public int? UserID { get; set; }
        public User User { get; set; }
    }
}
