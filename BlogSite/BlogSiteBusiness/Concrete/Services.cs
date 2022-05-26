using BlogSiteBusiness.Abstract;
using BlogSiteCore.Entities;
using BlogSiteDataAccess.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteBusiness.Concrete
{
    public class Services<T> : IServices<T> where T : BaseEntity
    {
        private readonly IRepository<T> repository;
        public Services(IRepository<T> repository)
        {
            this.repository = repository;
        }
        public bool Add(T entity)
        {
            return repository.Add(entity);
        }

        public bool Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
