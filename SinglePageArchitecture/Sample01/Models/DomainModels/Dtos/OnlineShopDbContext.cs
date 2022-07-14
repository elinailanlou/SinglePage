using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


namespace Sample01.Models.DomainModels.Dtos
{
    public class OnlineShopDbContext : DbContext
    {
        public OnlineShopDbContext()
          : base("name=OnlineStoreEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Category> Category { get; set; }

    }
}