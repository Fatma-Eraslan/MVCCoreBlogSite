using BlogSiteDataAccess.Concrete;
using BlogSiteDataAccess.Repositories.Abstract;
using BlogSiteEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteDataAccess.Repositories.Concrete
{
    public class UserDetailRepository : GenericRepository<UserDetail>, IUserDetailRepository
    {
        private readonly Context db;
        public UserDetailRepository(Context db) : base(db)
        {
            this.db = db;
        }
    }
}
