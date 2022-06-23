using Home.BankApp.Web.Data.Context;
using Home.BankApp.Web.Data.Interfaces;
using Home.BankApp.Web.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home.BankApp.Web.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BankContext _context;

        public UnitOfWork(BankContext context)
        {
            _context = context;
        }

        public IGenericRepository<T> GetRepository<T>() where T:class,new()
        {
            return new GenericRepository<T>(_context);
        }
        public void SaveChanges()
        {
            _context.SaveChanges();  
        }
    }
}
