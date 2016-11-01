using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EventCourses.Models.Entidades
{
    public class Context : DbContext, IUnitOfWork
    {

        public DbSet<Ministrante> Ministrantes { get; set; }

        public void Save()
        {
            base.SaveChanges();
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }

    }
}