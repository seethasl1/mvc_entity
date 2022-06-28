using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using mvc_entity.Models;
namespace mvc_entity.Dataaccess
{
    public class customerdal:DbContext
    {
     //database table is mapped with customer class using OnModelCreating method
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().ToTable("newcust");
            
            
        }
        public customerdal() : base("customerdal")
        {

        }
        public DbSet<Customer> customers { get; set; }
      

        

    }
}