﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home.BankApp.Web.Models
{
    public class AccountCreateModel
    {
        public decimal Balance { get; set; }
        public int AccountNumber { get; set; }
        public int ApplicationUserId { get; set; }
    }
}
