using Home.BankApp.Web.Data.Entities;
using Home.BankApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home.BankApp.Web.Mapping
{
    public class AccountMapper : IAccountMapper
    {
        public Account MapToAccount(AccountCreateModel accountCreateModel)
        {
            return new Account { AccountNumber = accountCreateModel.AccountNumber, ApplicationUserId = accountCreateModel.ApplicationUserId, Balance = accountCreateModel.Balance };
        }
    }
}
