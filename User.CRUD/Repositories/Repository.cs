using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

using User.CRUD.Infrastructure;

namespace User.CRUD.Repositories
{
    public class Repository<TEntity> : IDisposable, IRepository<TEntity> where TEntity : class
    {
        private readonly UserContext _context;

        public Repository(UserContext context)
        {
            _context = context;
        }

        public IQueryable<TEntity> All()
        {

            return _context.Set<TEntity>();
        }

        public void Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public TEntity Find(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Delete(int id)
        {
            var entity = _context.Set<TEntity>().Find(id);
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}