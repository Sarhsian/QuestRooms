using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IGenericRepository<TEntity> where TEntity: class
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        IEnumerable<TEntity> GetAll();

        // (x => x.Price>100)

        // public bool Func1(Product p)
        // {
        //      if(p.Price>100) return true;
        //      else            return false;
        // }

        // GetAll(x=>x.Price>100)

        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        TEntity Find(int Id);
    }
}