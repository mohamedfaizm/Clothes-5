using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ClothesStore.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ClothesStore.DAL
{
    public class BusinessContext : DbContext
    {

        public BusinessContext() : base("BusinessContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}