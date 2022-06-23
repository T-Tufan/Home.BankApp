using Home.BankApp.Web.Data.Interfaces;

namespace Home.BankApp.Web.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        IGenericRepository<T> GetRepository<T>() where T : class, new();
        void SaveChanges();
    }
}