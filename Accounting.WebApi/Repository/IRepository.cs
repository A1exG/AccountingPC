using System.Collections.Generic;

namespace Accounting.WebApi.Repository
{
    public interface IRepository<T> where T:class
    {
        List<T> Get();
        T GetByID(int id);
        int Insert(T t);
        int Update(T t);
    }
}
