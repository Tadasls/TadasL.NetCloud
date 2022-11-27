﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P004_EF_Application.Data;

#nullable disable

namespace P004EFApplication.Migrations
{
    [DbContext(typeof(RestaurantContext))]
    partial class RestaurantContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("P004_EF_Application.Models.Dish", b =>
                {
                    b.Property<int>("DishId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SpiceLevel")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("DishId");

                    b.ToTable("Dishes");

                    b.HasData(
                        new
                        {
                            DishId = 1,
                            Country = "Lithuania",
                            CreatedDateTime = new DateTime(2022, 11, 23, 21, 58, 23, 178, DateTimeKind.Local).AddTicks(9991),
                            ImagePath = "",
                            Name = "Fried Bread Sticks",
                            SpiceLevel = "Mild",
                            Type = "Snacks"
                        },
                        new
                        {
                            DishId = 2,
                            Country = "Lithuania",
                            CreatedDateTime = new DateTime(2022, 11, 23, 21, 58, 23, 179, DateTimeKind.Local).AddTicks(39),
                            ImagePath = "",
                            Name = "Potato dumplings",
                            SpiceLevel = "low",
                            Type = "Main dish"
                        },
                        new
                        {
                            DishId = 3,
                            Country = "Lithuania",
                            CreatedDateTime = new DateTime(2022, 11, 23, 21, 58, 23, 179, DateTimeKind.Local).AddTicks(41),
                            ImagePath = "",
                            Name = "Kibinai",
                            SpiceLevel = "low",
                            Type = "Street Food"
                        });
                });

            modelBuilder.Entity("P004_EF_Application.Models.RecipeItem", b =>
                {
                    b.Property<int>("RecipeItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Calories")
                        .HasColumnType("REAL");

                    b.Property<int>("DishId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("RecipeItemId");

                    b.HasIndex("DishId");

                    b.ToTable("RecipyItems");

                    b.HasData(
                        new
                        {
                            RecipeItemId = 1,
                            Calories = 150.0,
                            DishId = 1,
                            Name = "Duona"
                        },
                        new
                        {
                            RecipeItemId = 2,
                            Calories = 300.0,
                            DishId = 1,
                            Name = "Chhese"
                        },
                        new
                        {
                            RecipeItemId = 3,
                            Calories = 300.0,
                            DishId = 1,
                            Name = "Mayo"
                        },
                        new
                        {
                            RecipeItemId = 4,
                            Calories = 50.0,
                            DishId = 1,
                            Name = "Garlic"
                        },
                        new
                        {
                            RecipeItemId = 5,
                            Calories = 400.0,
                            DishId = 2,
                            Name = "Potatos"
                        },
                        new
                        {
                            RecipeItemId = 6,
                            Calories = 500.0,
                            DishId = 2,
                            Name = "Meat"
                        },
                        new
                        {
                            RecipeItemId = 7,
                            Calories = 300.0,
                            DishId = 2,
                            Name = "SourCream"
                        },
                        new
                        {
                            RecipeItemId = 8,
                            Calories = 300.0,
                            DishId = 3,
                            Name = "Dought"
                        },
                        new
                        {
                            RecipeItemId = 9,
                            Calories = 300.0,
                            DishId = 3,
                            Name = "Meat"
                        },
                        new
                        {
                            RecipeItemId = 10,
                            Calories = 300.0,
                            DishId = 3,
                            Name = "Salt"
                        });
                });

            modelBuilder.Entity("P004_EF_Application.Models.RecipeItem", b =>
                {
                    b.HasOne("P004_EF_Application.Models.Dish", "Dish")
                        .WithMany("RecipeItems")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");
                });

            modelBuilder.Entity("P004_EF_Application.Models.Dish", b =>
                {
                    b.Navigation("RecipeItems");
                });
#pragma warning restore 612, 618
        }
    }
}
