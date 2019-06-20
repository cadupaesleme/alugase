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
    [Migration("20190620051814_Seed")]
    partial class Seed
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
                });

            modelBuilder.Entity("AlugaSe.DomainModel.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<decimal>("UnitPrice");

                    b.Property<Guid?>("VendorId");

                    b.HasKey("Id");

                    b.HasIndex("VendorId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("AlugaSe.DomainModel.Entities.Rent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CustomerId");

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

                    b.Property<Guid?>("ProductId");

                    b.Property<decimal>("Quantity");

                    b.Property<Guid?>("RentId");

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
                        new { Id = new Guid("e823d093-e99b-4837-9bcc-e763d9d27647"), Address = "Rua Teste 124", Gender = "Feminino", Identification = "CNPJ 5345345435", Name = "Casa de Festa" }
                    );
                });

            modelBuilder.Entity("AlugaSe.DomainModel.Entities.Product", b =>
                {
                    b.HasOne("AlugaSe.DomainModel.Entities.Vendor", "Vendor")
                        .WithMany("Products")
                        .HasForeignKey("VendorId");
                });

            modelBuilder.Entity("AlugaSe.DomainModel.Entities.Rent", b =>
                {
                    b.HasOne("AlugaSe.DomainModel.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("AlugaSe.DomainModel.Entities.RentItem", b =>
                {
                    b.HasOne("AlugaSe.DomainModel.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("AlugaSe.DomainModel.Entities.Rent", "Rent")
                        .WithMany("RentItems")
                        .HasForeignKey("RentId");
                });
#pragma warning restore 612, 618
        }
    }
}