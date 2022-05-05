using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Models;
using Web.Customer.Data;

namespace Web.Customer.Data
{
    public  class WebDbContext:DbContext
    {
        public WebDbContext (DbContextOptions<WebDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<BookedTable> BookedTables { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Table>(model =>
            {
                model.ToTable("Table","dbo");
            });
            modelBuilder.Entity<Food>(model =>
            {
                model.ToTable("Food", "dbo");
            });
            modelBuilder.Entity<FoodCategory>(model =>
            {
                model.ToTable("FoodCategory", "dbo");
            });
            modelBuilder.Entity<DrinkCategory>(model =>
            {
                model.ToTable("DrinkCategory", "dbo");
            });
            modelBuilder.Entity<Drink>(model =>
            {
                model.ToTable("Drink", "dbo");
            });
            modelBuilder.Entity<BookedTable>(model =>
            {
                model.ToTable("BookedTable", "dbo");
            });
        }
        public DbSet<Web.Customer.Models.BookedTableEditViewModel> BookedTableEditViewModel { get; set; }
        public DbSet<Web.Customer.Data.BookedTable> BookedTable { get; set; }
    }
}
