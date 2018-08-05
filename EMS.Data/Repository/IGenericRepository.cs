using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Data.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();

        T Get(int id);

        T Insert(T obj);

        T Update(T obj);

        T Delete(T obj);

        int Save();

    }
}
