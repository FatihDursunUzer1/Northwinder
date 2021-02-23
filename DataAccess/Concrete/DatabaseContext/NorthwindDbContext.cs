using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.DatabaseContext
{
    public class NorthwindDbContext:DbContext
    {

        /// <summary>
        /// Veritabanı bağlantısının kurulduğu yer. 
        /// Override edilen bu method'un içeriğini kendi veritabanı bilgilerinize ve yapısına göre düzenlemeniz gerekmektedir.
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-QRTORO2;Database=Northwind;Trusted_connection=true;");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
