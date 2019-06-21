﻿// <auto-generated />
using System;
using AlugaSe.Infrastructure.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlugaSe.Infrastructure.DataAccess.Migrations
{
    [DbContext(typeof(AlugaSeContext))]
    [Migration("20190620220129_AdjustRentItemQuantity")]
    partial class AdjustRentItemQuantity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlugaSe.DomainModel.Entities.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime?>("BirthDay");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnName("Gender");

                    b.Property<string>("Identification")
                        .IsRequired()
                        .HasColumnName("Identification");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new { Id = new Guid("a4dc10ff-77dc-4260-b109-27ac65a75d54"), Address = "Rua Carlos 124", BirthDay = new DateTime(1990, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), Gender = "Masculino", Identification = "CNPJ 5345345435", Name = "Carlos" },
                        new { Id = new Guid("d1bd9cdb-d519-411b-b320-49962b02fe28"), Address = "Rua Maria 124", BirthDay = new DateTime(1986, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), Gender = "Feminino", Identification = "CPF 5345345435", Name = "Maria" }
                    );
                });

            modelBuilder.Entity("AlugaSe.DomainModel.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<decimal>("UnitPrice");

                    b.Property<Guid>("VendorId");

                    b.HasKey("Id");

                    b.HasIndex("VendorId");

                    b.ToTable("Products");

                    b.HasData(
                        new { Id = new Guid("c0bc4b28-2d10-4951-8ea7-b0a4ebf81648"), Description = "Carrocinha para fazer pizza", Name = "Carrocinha de Pizza", UnitPrice = 200m, VendorId = new Guid("7159143a-ab92-4a47-85d0-6768560e6504") },
                        new { Id = new Guid("2efa35c5-befe-42d1-afbe-017a1fef314c"), Description = "Pula Pula", Name = "Pula Pula", UnitPrice = 300m, VendorId = new Guid("7159143a-ab92-4a47-85d0-6768560e6504") },
                        new { Id = new Guid("30bc9b1f-999a-4e14-895d-a02c010a2c6f"), Description = "Carro BMW", Name = "BMW", UnitPrice = 10000m, VendorId = new Guid("611658e4-461d-4de6-8a5e-4899a306dee2") },
                        new { Id = new Guid("56021d7b-30cc-46e8-ba39-18d022928f50"), Description = "Projeto de Video", Name = "Projetor", UnitPrice = 100m, VendorId = new Guid("611658e4-461d-4de6-8a5e-4899a306dee2") }
                    );
                });

            modelBuilder.Entity("AlugaSe.DomainModel.Entities.Rent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CustomerId");

                    b.Property<DateTime>("Date");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Rents");
                });

            modelBuilder.Entity("AlugaSe.DomainModel.Entities.RentItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime>("InitialDate");

                    b.Property<Guid>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<Guid>("RentId");

                    b.Property<decimal>("UnitPrice");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("RentId");

                    b.ToTable("RentItems");
                });

            modelBuilder.Entity("AlugaSe.DomainModel.Entities.Vendor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime?>("BirthDay");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnName("Gender");

                    b.Property<string>("Identification")
                        .IsRequired()
                        .HasColumnName("Identification");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Vendors");

                    b.HasData(
                        new { Id = new Guid("7159143a-ab92-4a47-85d0-6768560e6504"), Address = "Rua Teste 124", Gender = "Feminino", Identification = "CNPJ 5345345435", Name = "Casa de Festas" },
                        new { Id = new Guid("611658e4-461d-4de6-8a5e-4899a306dee2"), Address = "Rua João 124", BirthDay = new DateTime(1988, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), Gender = "Masculino", Identification = "CPF 5345345435", Name = "João" }
                    );
                });

            modelBuilder.Entity("AlugaSe.DomainModel.Entities.Product", b =>
                {
                    b.HasOne("AlugaSe.DomainModel.Entities.Vendor", "Vendor")
                        .WithMany("Products")
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AlugaSe.DomainModel.Entities.Rent", b =>
                {
                    b.HasOne("AlugaSe.DomainModel.Entities.Customer", "Customer")
                        .WithMany("Rents")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AlugaSe.DomainModel.Entities.RentItem", b =>
                {
                    b.HasOne("AlugaSe.DomainModel.Entities.Product", "Product")
                        .WithMany("RentItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AlugaSe.DomainModel.Entities.Rent", "Rent")
                        .WithMany("RentItems")
                        .HasForeignKey("RentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
