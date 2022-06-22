using Home.BankApp.Web.Data.Context;
using Home.BankApp.Web.Data.Entities;
using Home.BankApp.Web.Data.Interfaces;
using Home.BankApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home.BankApp.Web.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public readonly BankContext _context;

        public AccountRepository(BankContext context)
        {
            _context = context;
        }

        //Ortak Methodlar
        public List<Account> GetAll()
        {

            return _context.Set<Account>().ToList();
        }
        public void Create(Account account)
        {
            //_context.Accounts.Add(account);
            _context.Set<Account>().Add(account);
            _context.SaveChanges();
        }
        public void Remove(Account account)
        {
            _context.Set<Account>().Remove(account);
            _context.SaveChanges();
        }
    }
}
