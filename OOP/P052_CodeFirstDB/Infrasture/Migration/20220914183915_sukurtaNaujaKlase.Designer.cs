﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P052_CodeFirstSqliteDb.Infrastructure.Database;

#nullable disable

namespace P052_CodeFirstSqliteDb.Infrastructure.Migrations
{
    [DbContext(typeof(BloggingContext))]
    [Migration("20220914183915_sukurtaNaujaKlase")]
    partial class sukurtaNaujaKlase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("P052_CodeFirstSqliteDb.Domain.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Biografy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");
                });
#pragma warning restore 612, 618
        }
    }
}
