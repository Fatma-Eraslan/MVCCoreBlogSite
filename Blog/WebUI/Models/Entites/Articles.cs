using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Entites
{
    public class Articles:BaseEntity
    {
        public Articles()
        {
            Topics = new HashSet<Topics>();
        }     
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }
        public string ArticlePhoto { get; set; }
        public ICollection<Topics> Topics { get; set; }

        public int? UserID { get; set; }
        public Users User { get; set; }
    }
}
