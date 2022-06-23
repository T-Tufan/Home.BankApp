using Home.BankApp.Web.Data.Context;
using Home.BankApp.Web.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home.BankApp.Web.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class , new()
    {
        public readonly BankContext _context;

        public GenericRepository(BankContext context)
        {
            _context = context;
        }
        //Ortak Methodlar
        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        public T GetById(object id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Create(T entity)
        {
            //_context.ApplicationUsers.Add(user);
            _context.Set<T>().Add(entity);
            //_context.SaveChanges();
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
            //_context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }

        public IQueryable<T> GetQuerable()
        {
            return _context.Set<T>().AsQueryable();
        }
    }
}
