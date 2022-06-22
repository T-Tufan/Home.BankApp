using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home.BankApp.Web.Data.Interfaces
{
    public interface IGenericRepository<T> where T : class, new()
    {

        List<T> GetAll();

        T GetById(object id);

        void Create(T entity);

        void Remove(T entity);

        void Update(T entity);

        IQueryable<T> GetQuerable();

    }
}
