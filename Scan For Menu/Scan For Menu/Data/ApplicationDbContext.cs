using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Text;
using Scan_For_Menu.Models;

namespace Scan_For_Menu.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<MenuItem> MenuItem { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<CustomerOrder> CustomerOrder { get; set; }
        public DbSet<FoodCategory> FoodCategory { get; set; }
        public DbSet<OrderLine> OrderLine { get; set; }
    }
}
