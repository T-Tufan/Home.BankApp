using Home.BankApp.Web.Data.Entities;

namespace Home.BankApp.Web.Data.Interfaces
{
    public interface IAccountRepository
    {
        void Create(Account account);
    }
}
