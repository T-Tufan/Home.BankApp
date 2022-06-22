using Home.BankApp.Web.Data.Configurations;
using Home.BankApp.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home.BankApp.Web.Data.Context
{
    public class BankContext : DbContext
    {
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public BankContext(DbContextOptions<BankContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationUserConfiguration());
        }
    }
}
