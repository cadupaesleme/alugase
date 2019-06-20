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

            Seeding(modelBuilder);

        }

        private void Seeding(ModelBuilder modelBuilder)
        {

            var vendor1 = new Vendor { Id = Guid.Parse("7159143A-AB92-4A47-85D0-6768560E6504"), Name = "Casa de Festas", Address = "Rua Teste 124", Gender = Gender.ListAll()[1], Identification = new Identification(Identification.ListTypes()[1], "5345345435") };
            var vendor2 = new Vendor { Id = Guid.Parse("611658E4-461D-4DE6-8A5E-4899A306DEE2"), Name = "João", Address = "Rua João 124", Gender = Gender.ListAll()[0], BirthDay = new DateTime(1988, 2, 9), Identification = new Identification(Identification.ListTypes()[0], "5345345435") };

            modelBuilder.Entity<Vendor>().HasData(vendor1);
            modelBuilder.Entity<Vendor>().HasData(vendor2);

            modelBuilder.Entity<Product>().HasData(new Product { VendorId = vendor1.Id, Id = Guid.Parse("C0BC4B28-2D10-4951-8EA7-B0A4EBF81648"), Name = "Carrocinha de Pizza", Description = "Carrocinha para fazer pizza", UnitPrice = 200 });
            modelBuilder.Entity<Product>().HasData(new Product { VendorId = vendor1.Id, Id = Guid.Parse("2EFA35C5-BEFE-42D1-AFBE-017A1FEF314C"), Name = "Pula Pula", Description = "Pula Pula", UnitPrice = 300 });


            modelBuilder.Entity<Product>().HasData(new Product { VendorId = vendor2.Id, Id = Guid.Parse("30BC9B1F-999A-4E14-895D-A02C010A2C6F"), Name = "BMW", Description = "Carro BMW", UnitPrice = 10000 });
            modelBuilder.Entity<Product>().HasData(new Product { VendorId = vendor2.Id, Id = Guid.Parse("56021D7B-30CC-46E8-BA39-18D022928F50"), Name = "Projetor", Description = "Projeto de Video", UnitPrice = 100 });


            var customer1 = new Customer { Id = Guid.Parse("A4DC10FF-77DC-4260-B109-27AC65A75D54"), Name = "Carlos", Address = "Rua Carlos 124", Gender = Gender.ListAll()[0], BirthDay = new DateTime(1990, 7, 12), Identification = new Identification(Identification.ListTypes()[1], "5345345435") };
            var customer2 = new Customer { Id = Guid.Parse("D1BD9CDB-D519-411B-B320-49962B02FE28"), Name = "Maria", Address = "Rua Maria 124", Gender = Gender.ListAll()[1], BirthDay = new DateTime(1986, 4, 9), Identification = new Identification(Identification.ListTypes()[0], "5345345435") };

            modelBuilder.Entity<Customer>().HasData(customer1);
            modelBuilder.Entity<Customer>().HasData(customer2);

        }
    }
}
