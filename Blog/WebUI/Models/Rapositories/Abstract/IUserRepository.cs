using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Entites;

namespace WebUI.Repositories.Abstract
{
    interface IUserRepository:IRepository<Users>
    {
        //article id ye göre user return et
        //getAllIncludeArticles
        //getAllIncludeTopics
        IEnumerable<Users> GetAllIncludeArticles();
        IEnumerable<Users> GetAllIncludeTopics();
        Users GetByIdIncludeArticles(int id);
    }
}
