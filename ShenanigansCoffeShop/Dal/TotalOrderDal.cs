using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ShenanigansCoffeShop.Models;

namespace ShenanigansCoffeShop.Dal
{
    public class TotalOrderDal : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TotalOrderModel>().ToTable("totalOrder");
        }
        public DbSet<TotalOrderModel> TotalOrderList { get; set; }
    }
}