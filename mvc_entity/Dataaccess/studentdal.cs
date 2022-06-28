using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using mvc_entity.Models;

namespace mvc_entity.Dataaccess
{
    public class studentdal:DbContext
    {
        public studentdal():base("name=customerdal")
        {

        }
        public DbSet<student> stud { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
    }
    
}