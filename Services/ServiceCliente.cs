using System.Collections.Generic;
using System.Linq;
using ManagerSalon.Models;
using Microsoft.EntityFrameworkCore;

namespace ManagerSalon.Services
{
    public class ServiceCliente<T> : IService<T> where T: class
    {
        private ApplicationContext _context;
        private DbSet<T> dbSet;

        public ServiceCliente(ApplicationContext context)
        {
            _context = context;
            dbSet = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetById(object id)
        {
            return dbSet.Find(id);
        }

        public void Save(T entity)
        {
            dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Entry<T>(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }
    }
}