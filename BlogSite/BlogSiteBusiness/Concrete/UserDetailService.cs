using BlogSiteBusiness.Abstract;
using BlogSiteDataAccess.Repositories.Abstract;
using BlogSiteEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteBusiness.Concrete
{
    public class UserDetailService:Services<UserDetail>,IUserDetailService
    {
        private readonly IUserDetailRepository userDetailRepository;
        public UserDetailService(IUserDetailRepository userDetailRepository):base (userDetailRepository)
        {
            this.userDetailRepository = userDetailRepository;
        }
    }
}
