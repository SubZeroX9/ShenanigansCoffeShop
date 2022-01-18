using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ShenanigansCoffeShop.Models;

namespace ShenanigansCoffeShop.Dal
{
    public class UserDal : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserModel>().ToTable(""); // need to add somthing in " "
        }
        public DbSet<UserModel> Users { get; set; }
    }
}