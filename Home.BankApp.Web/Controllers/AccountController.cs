using Home.BankApp.Web.Data.Context;
using Home.BankApp.Web.Data.Entities;
using Home.BankApp.Web.Data.Interfaces;
using Home.BankApp.Web.Data.Repositories;
using Home.BankApp.Web.Mapping;
using Home.BankApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home.BankApp.Web.Controllers
{
    public class AccountController : Controller
    {
        //private readonly BankContext _context;
        //private readonly IUserRepository _userRepository;
        //private readonly IUserMapping _userMapping;
        //private readonly IAccountRepository _accountRepository;
        //private readonly IAccountMapper _accountMapper;

        //public AccountController(IUserRepository userRepository, IUserMapping userMapping, IAccountRepository accountRepository, IAccountMapper accountMapper)
        //{
        //    //_context = context;
        //    _userRepository = userRepository;
        //    _userMapping = userMapping;
        //    _accountRepository = accountRepository;
        //    _accountMapper = accountMapper;
        //}

        private readonly IGenericRepository<Account> _accountRepository;
        private readonly IGenericRepository<ApplicationUser> _userRepository;

        public AccountController(IGenericRepository<Account> accountRepository, IGenericRepository<ApplicationUser> userRepository)
        {
            _accountRepository = accountRepository;
            _userRepository = userRepository;
        }
        public IActionResult Create(int id)
        {
            //var userInfo = _context.ApplicationUsers.Select(x => new UserListModel { Id = x.Id , Name = x.Name , Surname = x.Surname }).SingleOrDefault(x => x.Id == id);

            //return View(_userMapping.MapToUserList(_userRepository.GetFilterById(id)));

            var userInfo = _userRepository.GetById(id);

            return View(new UserListModel { Id = userInfo.Id, Name = userInfo.Name, Surname = userInfo.Surname });
        }


        [HttpPost]
        public IActionResult Create(AccountCreateModel model)
        {
            //_accountRepository.Create(_accountMapper.MapToAccount(model));

            _accountRepository.Create(new Account
            {
                ApplicationUserId = model.ApplicationUserId,
                Balance = model.Balance,
                AccountNumber = model.AccountNumber,
            });

            //_context.Accounts.Add(new Account
            //{
            //    AccountNumber = model.AccountNumber,
            //    Balance = model.Balance,
            //    ApplicationUserId = model.ApplicationUserId
            //});

            //_context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult GetByUserId(int userId)
        {
            var query =  _accountRepository.GetQuerable();

            var accounts = query.Where(x => x.ApplicationUserId == userId).ToList();

            var userInfo = _userRepository.GetById(userId);

            ViewBag.FullName = userInfo.Name + " " + userInfo.Surname;

            var accountList = new List<AccountListModel>();

            foreach (var account in accounts)
            {
                accountList.Add(new AccountListModel { Id = account.Id, AccountNumber = account.AccountNumber, ApplicationUserId = account.ApplicationUserId, Balance = account.Balance });
            }

            return View(accountList);
        }

    }
}
