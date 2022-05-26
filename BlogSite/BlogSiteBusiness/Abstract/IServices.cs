using BlogSiteCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteBusiness.Abstract
{
    public interface IServices<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();

        T GetById(int id);

        bool Add(T entity);

        bool Update(T entity);

        bool Delete(T entity);
    }
}
