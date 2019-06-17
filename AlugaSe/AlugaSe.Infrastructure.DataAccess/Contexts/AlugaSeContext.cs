using AlugaSe.DomainModel.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlugaSe.Infrastructure.DataAccess.Contexts
{
    public class AlugaSeContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<RentItem> RentItems { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        public AlugaSeContext(DbContextOptions<AlugaSeContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            {
                if (optionsBuilder.IsConfigured == false)
                {
                    optionsBuilder.UseSqlServer(
                   @"Data Source=(localdb)\\mssqllocaldb;Initial Catalog=AlugaSeDB;
                       Integrated Security=True;");
                }
                base.OnConfiguring(optionsBuilder);
            }
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{

        //    //var _optionsBuilder = new DbContextOptionsBuilder<AlugaSeContext>();
        //    //_optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;DataBase=AlugaSeDatabase;Integrated Security=True;Connect Timeout=30");

        //    //base.OnConfiguring(_optionsBuilder);

        //    //optionsBuilder.UseSqlServer(Properties.Resources.
        //    //    ResourceManager.GetString("DbConnectionString"));
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            //modelBuilder
            //    .Entity<Account>()
            //    .Property(account => account.Amount)
            //    .HasConversion(
            //        amount => amount.ToString(),
            //        amount => Amount.Parse(amount))
            //    .HasColumnName("Amount");

            //modelBuilder
            //    .Entity<DbCurrency>()
            //    .Property(dbCurrency => dbCurrency.Currency)
            //    .HasConversion(
            //        currency => currency.ToString(),
            //        currency => new Currency(currency))
            //    .HasColumnName("Currency");

        }
    }
}
