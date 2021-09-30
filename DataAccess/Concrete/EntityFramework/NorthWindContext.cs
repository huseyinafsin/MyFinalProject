using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthWindContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-KRNCUB4\SQLEXPRESS;Database=Northwind;Trusted_Connection=True") ;
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Catrgories { get; set; }
        public DbSet<Customer> Customers  { get; set; }
    }
}
