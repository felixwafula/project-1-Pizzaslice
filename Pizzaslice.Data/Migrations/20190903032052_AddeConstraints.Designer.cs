﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pizzaslice.Data;

namespace Pizzaslice.Data.Migrations
{
    [DbContext(typeof(PizzasliceDbContext))]
    [Migration("20190903032052_AddeConstraints")]
    partial class AddeConstraints
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Pizzaslice.Domain.Models.Cheese", b =>
                {
                    b.Property<int>("CheeseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CheeseName");

                    b.Property<double>("CheesePrice");

                    b.HasKey("CheeseId");

                    b.ToTable("Cheeses");
                });

            modelBuilder.Entity("Pizzaslice.Domain.Models.Crust", b =>
                {
                    b.Property<int>("CrustId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CrustName");

                    b.Property<double>("CrustPrice");

                    b.HasKey("CrustId");

                    b.ToTable("Crusts");
                });

            modelBuilder.Entity("Pizzaslice.Domain.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LocationAddress");

                    b.Property<string>("LocationName");

                    b.Property<int>("LocationZipCode");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Pizzaslice.Domain.Models.Meat", b =>
                {
                    b.Property<int>("MeatId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MeatName");

                    b.Property<double>("MeatPrice");

                    b.HasKey("MeatId");

                    b.ToTable("Meats");
                });

            modelBuilder.Entity("Pizzaslice.Domain.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LocationId");

                    b.Property<int>("UserId");

                    b.Property<double>("totalPrice");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Pizzaslice.Domain.Models.Pizza", b =>
                {
                    b.Property<int>("PizzaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MyCheeseCheeseId");

                    b.Property<int>("MyCrustCrustId");

                    b.Property<int?>("MyMeatMeatId");

                    b.Property<int?>("MySauceSauceId");

                    b.Property<int>("MySizeSizeId");

                    b.Property<int?>("MyVeggieVeggieId");

                    b.Property<int?>("OrderId");

                    b.HasKey("PizzaId");

                    b.HasIndex("MyCheeseCheeseId");

                    b.HasIndex("MyCrustCrustId");

                    b.HasIndex("MyMeatMeatId");

                    b.HasIndex("MySauceSauceId");

                    b.HasIndex("MySizeSizeId");

                    b.HasIndex("MyVeggieVeggieId");

                    b.HasIndex("OrderId");

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("Pizzaslice.Domain.Models.Sauce", b =>
                {
                    b.Property<int>("SauceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SauceName");

                    b.Property<double>("SaucePrice");

                    b.HasKey("SauceId");

                    b.ToTable("Sauces");
                });

            modelBuilder.Entity("Pizzaslice.Domain.Models.Size", b =>
                {
                    b.Property<int>("SizeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SizeName");

                    b.Property<double>("SizePrice");

                    b.HasKey("SizeId");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("Pizzaslice.Domain.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("UserEmail");

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("UserZipCode");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Pizzaslice.Domain.Models.Veggie", b =>
                {
                    b.Property<int>("VeggieId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("VeggieName");

                    b.Property<double>("VeggiePrice");

                    b.HasKey("VeggieId");

                    b.ToTable("Veggies");
                });

            modelBuilder.Entity("Pizzaslice.Domain.Models.Pizza", b =>
                {
                    b.HasOne("Pizzaslice.Domain.Models.Cheese", "MyCheese")
                        .WithMany()
                        .HasForeignKey("MyCheeseCheeseId");

                    b.HasOne("Pizzaslice.Domain.Models.Crust", "MyCrust")
                        .WithMany()
                        .HasForeignKey("MyCrustCrustId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pizzaslice.Domain.Models.Meat", "MyMeat")
                        .WithMany()
                        .HasForeignKey("MyMeatMeatId");

                    b.HasOne("Pizzaslice.Domain.Models.Sauce", "MySauce")
                        .WithMany()
                        .HasForeignKey("MySauceSauceId");

                    b.HasOne("Pizzaslice.Domain.Models.Size", "MySize")
                        .WithMany()
                        .HasForeignKey("MySizeSizeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pizzaslice.Domain.Models.Veggie", "MyVeggie")
                        .WithMany()
                        .HasForeignKey("MyVeggieVeggieId");

                    b.HasOne("Pizzaslice.Domain.Models.Order")
                        .WithMany("MyOrderList")
                        .HasForeignKey("OrderId");
                });
#pragma warning restore 612, 618
        }
    }
}
