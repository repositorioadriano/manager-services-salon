using System.Collections.Generic;

namespace ManagerSalon.Services
{
    public interface IService<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Save(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
