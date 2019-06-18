using AlugaSe.DomainModel.Entities;
using AlugaSe.DomainModel.ValueObjects;
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

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    {
        //        if (optionsBuilder.IsConfigured == false)
        //        {
        //            optionsBuilder.UseSqlServer(
        //           @"Data Source=(localdb)\\mssqllocaldb;Initial Catalog=AlugaSeDB;
        //               Integrated Security=True;");
        //        }
        //        base.OnConfiguring(optionsBuilder);
        //    }
        //}

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

            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<Vendor>()
                .Property(gender => gender.Gender)
                .HasConversion(
                    gender => gender.ToString(),
                    gender => Gender.Parse(gender))
                .HasColumnName("Gender");

            modelBuilder
                .Entity<Vendor>()
                .Property(identification => identification.Identification)
                .HasConversion(
                    identification => identification.ToString(),
                    identification => Identification.Parse(identification))
                .HasColumnName("Identification");

            modelBuilder
                .Entity<Customer>()
                .Property(gender => gender.Gender)
                .HasConversion(
                    gender => gender.ToString(),
                    gender => Gender.Parse(gender))
                .HasColumnName("Gender");

            modelBuilder
                .Entity<Customer>()
                .Property(identification => identification.Identification)
                .HasConversion(
                    identification => identification.ToString(),
                    identification => Identification.Parse(identification))
                .HasColumnName("Identification");

        }
    }
}
