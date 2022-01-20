using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ShenanigansCoffeShop.Models;

namespace ShenanigansCoffeShop.Dal
{
    public class ItemDal : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ItemModel>().ToTable("item");
        }
        public DbSet<ItemModel> Items { get; set; }
    }
}