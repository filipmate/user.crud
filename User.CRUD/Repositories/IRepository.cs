using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace User.CRUD.Repositories
{
    public interface IRepository<TEntity>
    {
        IQueryable<TEntity> All();

        void Create(TEntity entity);

        void Update(TEntity entity);

        TEntity Find(int id);

        void Delete(int id);

    }
}