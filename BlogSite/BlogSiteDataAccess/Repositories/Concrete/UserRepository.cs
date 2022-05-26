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
    public class UserRepository:GenericRepository<User>,IUserRepository
    {
        private readonly Context db;
        public UserRepository(Context db):base(db)
        {
            this.db = db;
        }
    }
}
