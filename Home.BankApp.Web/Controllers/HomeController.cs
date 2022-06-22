using Home.BankApp.Web.Data.Context;
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
    public class HomeController : Controller
    {
        private readonly BankContext _context;
        private readonly IUserRepository _userRepository;
        private readonly IUserMapping _userMapping;
        public HomeController(BankContext bankContext , IUserRepository userRepository, IUserMapping userMapping)
        {
            _context = bankContext;
            _userRepository = userRepository;
            _userMapping = userMapping;
        }
        public IActionResult Index()
        {
            //var userlist = _context.ApplicationUsers.Select(x => new UserListModel { Id = x.Id , Name = x.Name , Surname = x.Surname }).ToList();
            return View(_userMapping.MapToListOfUserList(_userRepository.GetAll()));
        }
    }
}
