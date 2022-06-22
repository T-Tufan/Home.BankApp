using Home.BankApp.Web.Data.Entities;
using Home.BankApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home.BankApp.Web.Mapping
{
    public class UserMapping : IUserMapping
    {
        public List<UserListModel> MapToListOfUserList(List<ApplicationUser> applicationUsers)
        {
            return applicationUsers.Select(x => new UserListModel { Id = x.Id, Name = x.Name, Surname = x.Surname }).ToList();
        }

        public UserListModel MapToUserList(ApplicationUser applicationUser)
        {
            return new UserListModel { Id = applicationUser.Id, Name = applicationUser.Name, Surname = applicationUser.Surname };
        }
    }
}
