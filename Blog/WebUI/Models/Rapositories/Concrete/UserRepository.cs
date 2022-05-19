using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Entites;
using WebUI.Repositories.Abstract;

namespace WebUI.Repositories.Concrete
{
    public class UserRepository : GenericRepository<Users>, IUserRepository
    {
        private readonly ApplicationDbContext db;

        public UserRepository(ApplicationDbContext db):base(db)
        {
            this.db = db;
        }
        public IEnumerable<Users> GetAllIncludeArticles()
        {
            return db.Users.Include(u => u.Articles);
        }

        public IEnumerable<Users> GetAllIncludeTopics()
        {
            return db.Users.Include(u => u.Topics);
        }

        public Users GetByIdIncludeArticles(int id)
        {
            return db.Users.Include(u => u.Articles).FirstOrDefault(a => a.Id == id);
        }
    }
}
