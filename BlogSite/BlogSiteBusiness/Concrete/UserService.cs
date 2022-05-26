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
    public class UserService : Services<User>, IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository) : base(userRepository)
        {
            this.userRepository = userRepository;
        }
    }
}
