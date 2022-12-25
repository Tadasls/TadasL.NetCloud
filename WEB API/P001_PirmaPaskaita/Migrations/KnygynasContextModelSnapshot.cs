﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppMSSQL.Data;

#nullable disable

namespace WebAppMSSQL.Migrations
{
    [DbContext(typeof(KnygynasContext))]
    partial class KnygynasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("WebAppMSSQL.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EBookStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("ECoverType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("PublishYear")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Stock")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Several authors",
                            EBookStatus = "Registed",
                            ECoverType = "Paperback",
                            PublishYear = 1,
                            Stock = 1,
                            Title = "The Bible",
                            Updated = new DateTime(2022, 12, 24, 23, 1, 45, 379, DateTimeKind.Local).AddTicks(7413)
                        },
                        new
                        {
                            Id = 2,
                            Author = "Mao Zedong",
                            EBookStatus = "Registed",
                            ECoverType = "Hardcover",
                            PublishYear = 1964,
                            Stock = 2,
                            Title = "Quotations from Chairman Mao Tse-Tung",
                            Updated = new DateTime(2022, 12, 24, 23, 1, 45, 379, DateTimeKind.Local).AddTicks(7444)
                        },
                        new
                        {
                            Id = 3,
                            Author = "Several authors",
                            EBookStatus = "Registed",
                            ECoverType = "Hardcover",
                            PublishYear = 700,
                            Stock = 3,
                            Title = "The Quran",
                            Updated = new DateTime(2022, 12, 24, 23, 1, 45, 379, DateTimeKind.Local).AddTicks(7447)
                        },
                        new
                        {
                            Id = 4,
                            Author = "John Tolkien",
                            EBookStatus = "Registed",
                            ECoverType = "Hardcover",
                            PublishYear = 1954,
                            Stock = 4,
                            Title = "The Lord Of The Rings",
                            Updated = new DateTime(2022, 12, 24, 23, 1, 45, 379, DateTimeKind.Local).AddTicks(7449)
                        },
                        new
                        {
                            Id = 5,
                            Author = "Antoine de Saint-Exupery",
                            EBookStatus = "Registed",
                            ECoverType = "Electronic",
                            PublishYear = 1943,
                            Stock = 5,
                            Title = "Le Petit Prince",
                            Updated = new DateTime(2022, 12, 24, 23, 1, 45, 379, DateTimeKind.Local).AddTicks(7451)
                        },
                        new
                        {
                            Id = 6,
                            Author = "Joanne Rowling",
                            EBookStatus = "Registed",
                            ECoverType = "Paperback",
                            PublishYear = 1997,
                            Stock = 6,
                            Title = "Harry Potter and the Philosopher’s Stone",
                            Updated = new DateTime(2022, 12, 24, 23, 1, 45, 379, DateTimeKind.Local).AddTicks(7453)
                        },
                        new
                        {
                            Id = 7,
                            Author = "Robert Baden-Powell",
                            EBookStatus = "WishListed",
                            ECoverType = "Paperback",
                            PublishYear = 1908,
                            Stock = 1,
                            Title = "Scouting for Boys",
                            Updated = new DateTime(2022, 12, 24, 23, 1, 45, 379, DateTimeKind.Local).AddTicks(7455)
                        },
                        new
                        {
                            Id = 8,
                            Author = "Agatha Christie",
                            EBookStatus = "WishListed",
                            ECoverType = "Paperback",
                            PublishYear = 1939,
                            Stock = 1,
                            Title = "And Then There Were None",
                            Updated = new DateTime(2022, 12, 24, 23, 1, 45, 379, DateTimeKind.Local).AddTicks(7457)
                        },
                        new
                        {
                            Id = 9,
                            Author = "John Tolkien ",
                            EBookStatus = "WishListed",
                            ECoverType = "Hardcover",
                            PublishYear = 1937,
                            Stock = 1,
                            Title = "The Hobbit",
                            Updated = new DateTime(2022, 12, 24, 23, 1, 45, 379, DateTimeKind.Local).AddTicks(7459)
                        },
                        new
                        {
                            Id = 10,
                            Author = "Cao Xueqin",
                            EBookStatus = "WishListed",
                            ECoverType = "Paperback",
                            PublishYear = 1791,
                            Stock = 1,
                            Title = "The Dream Of The Red Chambe",
                            Updated = new DateTime(2022, 12, 24, 23, 1, 45, 379, DateTimeKind.Local).AddTicks(7461)
                        });
                });

            modelBuilder.Entity("WebAppMSSQL.Models.LocalUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ExpirationDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("HasAmountOfBooks")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LoyaltyPoints")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserLevel")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("WasOnline")
                        .HasColumnType("TEXT");

                    b.Property<int>("WasOnlineWeekNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("LocalUsers");
                });

            modelBuilder.Entity("WebAppMSSQL.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ActualReturnDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BorrowDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("LocalUserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PaidWithPoints")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("LocalUserId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("WebAppMSSQL.Models.UNotification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsSeen")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LocalUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("LocalUserId");

                    b.ToTable("UNotification");
                });

            modelBuilder.Entity("WebAppMSSQL.Models.Reservation", b =>
                {
                    b.HasOne("WebAppMSSQL.Models.Book", "Book")
                        .WithMany("Reservations")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("WebAppMSSQL.Models.LocalUser", "LocalUser")
                        .WithMany("Reservations")
                        .HasForeignKey("LocalUserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("LocalUser");
                });

            modelBuilder.Entity("WebAppMSSQL.Models.UNotification", b =>
                {
                    b.HasOne("WebAppMSSQL.Models.LocalUser", "LocalUser")
                        .WithMany("UNotifications")
                        .HasForeignKey("LocalUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LocalUser");
                });

            modelBuilder.Entity("WebAppMSSQL.Models.Book", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("WebAppMSSQL.Models.LocalUser", b =>
                {
                    b.Navigation("Reservations");

                    b.Navigation("UNotifications");
                });
#pragma warning restore 612, 618
        }
    }
}
