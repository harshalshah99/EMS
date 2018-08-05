using EMS.Data.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Data.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private PracticeDBEntities _db;
        private IDbSet<T> _dbSet;
        
        public GenericRepository(PracticeDBEntities db)
        {
            _db = db;
            _dbSet = _db.Set<T>();
        }

        public T Get(int id)
        {
            return _dbSet.Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public T Delete(T obj)
        {
            return _dbSet.Remove(obj);
        }
        
        public T Insert(T obj)
        {
            return _dbSet.Add(obj);
        }

        public T Update(T obj)
        {
            return _dbSet.Attach(obj);
        }

        
    }
}
