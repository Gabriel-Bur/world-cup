using WorldCup.Data.Context;
using WorldCup.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;


namespace WorldCup.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {

        protected WorldCupContext db = new WorldCupContext();

        public IEnumerable<TEntity> GetAll()
        {
           return db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return db.Set<TEntity>().Find(id);

        }

        public void Add(TEntity obj)
        {
            db.Set<TEntity>().Add(obj);
            db.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            db.Set<TEntity>().Remove(obj);
            db.SaveChanges();

        }

        public void Update(TEntity obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
