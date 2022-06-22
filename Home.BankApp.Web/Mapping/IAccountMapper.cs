using Home.BankApp.Web.Data.Entities;
using Home.BankApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home.BankApp.Web.Mapping
{
    public interface IAccountMapper
    {
        Account MapToAccount(AccountCreateModel accountCreateModel);
    }
}
