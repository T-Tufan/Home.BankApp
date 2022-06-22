using Home.BankApp.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home.BankApp.Web.Data.Interfaces
{
    public interface IUserRepository
    {
        List<ApplicationUser> GetAll();
        ApplicationUser GetFilterById(int id);
    }
}
