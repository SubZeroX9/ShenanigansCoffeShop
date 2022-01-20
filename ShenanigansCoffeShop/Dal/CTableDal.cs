using ShenanigansCoffeShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShenanigansCoffeShop.Dal
{
    public class CTableDal : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CTableModel>().ToTable("c_table");
        }
        public DbSet<CTableModel> Tables { get; set; }
    }
}