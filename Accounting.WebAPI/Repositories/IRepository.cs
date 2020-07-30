using System.Collections.Generic;

namespace Accounting.WebAPI.Repositories
{
    public interface IRepository<T> where T : class
    {
        List<T> Get();
        T GetByID(int id);
        int Post(T t);
        int Delete(int id);
    }
}
