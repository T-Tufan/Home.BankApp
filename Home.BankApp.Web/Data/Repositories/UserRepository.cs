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
    public class UserRepository : IUserRepository
    {
        private readonly BankContext _context;
        public UserRepository(BankContext context)
        {
            _context = context;
        }
        public ApplicationUser GetFilterById(int id)
        {
            return _context.ApplicationUsers.SingleOrDefault(x => x.Id == id);
        }


        //Ortak Methodlar
        public List<ApplicationUser> GetAll() {

            return _context.Set<ApplicationUser>().ToList();
        }

        public void Create(ApplicationUser user)
        {
            //_context.ApplicationUsers.Add(user);
            _context.Set<ApplicationUser>().Add(user);
            _context.SaveChanges();
        }

        public void Remove(ApplicationUser user)
        {
            _context.Set<ApplicationUser>().Remove(user);
            _context.SaveChanges();
        }
    }
}
