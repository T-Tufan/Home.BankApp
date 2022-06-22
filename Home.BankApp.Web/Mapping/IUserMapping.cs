using Home.BankApp.Web.Data.Entities;
using Home.BankApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home.BankApp.Web.Mapping
{
    public interface IUserMapping
    {
        List<UserListModel> MapToListOfUserList(List<ApplicationUser> applicationUsers);
        UserListModel MapToUserList(ApplicationUser applicationUser);
    }
}
