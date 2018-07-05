using System.Collections.Generic;

namespace WorldCup.Data.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);

        void Add(TEntity obj);

        void Remove(TEntity obj);

        void Update(TEntity obj);

    }
}
