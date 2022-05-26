using BlogSiteEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.ViewModel
{
    public class UserWithUserDetailVM
    {
        public User User { get; set; }
        public UserDetail UserDetail { get; set; }
    }
}
