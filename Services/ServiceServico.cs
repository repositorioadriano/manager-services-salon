using System;
using System.Collections.Generic;
using System.Linq;
using ManagerSalon.Models;
using Microsoft.EntityFrameworkCore;

namespace ManagerSalon.Services
{
    public class ServiceServico<T> : IService<T> where T : class
    {
        private readonly ApplicationContext _dbContext;

        private DbSet<T> dbSet;

        public ServiceServico(ApplicationContext context)
        {
            _dbContext = context;
            dbSet = _dbContext.Set<T>();

        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
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
            _dbContext.Entry<T>(entity).State = EntityState.Added;
            _dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbContext.Entry<T>(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}