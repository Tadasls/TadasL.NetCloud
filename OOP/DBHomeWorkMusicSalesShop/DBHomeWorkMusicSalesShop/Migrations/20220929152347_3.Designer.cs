﻿// <auto-generated />
using System;
using DBHomeWorkMusicSalesShop.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DBHomeWorkMusicSalesShop.Migrations
{
    [DbContext(typeof(ChinookContext))]
    [Migration("20220929152347_3")]
    partial class _3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("DBHomeWorkMusicSalesShop.Models.Album", b =>
                {
                    b.Property<long>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("ArtistId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(160)");

                    b.HasKey("AlbumId");

                    b.HasIndex(new[] { "ArtistId" }, "IFK_AlbumArtistId");

                    b.ToTable("albums", (string)null);
                });

            modelBuilder.Entity("DBHomeWorkMusicSalesShop.Models.Artist", b =>
                {
                    b.Property<long>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(120)");

                    b.HasKey("ArtistId");

                    b.ToTable("artists", (string)null);
                });

            modelBuilder.Entity("DBHomeWorkMusicSalesShop.Models.Customer", b =>
                {
                    b.Property<long>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("NVARCHAR(70)");

                    b.Property<string>("City")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("Company")
                        .HasColumnType("NVARCHAR(80)");

                    b.Property<string>("Country")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(60)");

                    b.Property<string>("Fax")
                        .HasColumnType("NVARCHAR(24)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("Phone")
                        .HasColumnType("NVARCHAR(24)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("NVARCHAR(10)");

                    b.Property<string>("State")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<long?>("SupportRepId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CustomerId");

                    b.HasIndex(new[] { "SupportRepId" }, "IFK_CustomerSupportRepId");

                    b.ToTable("customers", (string)null);
                });

            modelBuilder.Entity("DBHomeWorkMusicSalesShop.Models.Employee", b =>
                {
                    b.Property<long>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("NVARCHAR(70)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("DATETIME");

                    b.Property<string>("City")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("Country")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("Email")
                        .HasColumnType("NVARCHAR(60)");

                    b.Property<string>("Fax")
                        .HasColumnType("NVARCHAR(24)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<DateTime?>("HireDate")
                        .HasColumnType("DATETIME");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("Phone")
                        .HasColumnType("NVARCHAR(24)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("NVARCHAR(10)");

                    b.Property<long?>("ReportsTo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("State")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("Title")
                        .HasColumnType("NVARCHAR(30)");

                    b.HasKey("EmployeeId");

                    b.HasIndex(new[] { "ReportsTo" }, "IFK_EmployeeReportsTo");

                    b.ToTable("employees", (string)null);
                });

            modelBuilder.Entity("DBHomeWorkMusicSalesShop.Models.Genre", b =>
                {
                    b.Property<long>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(120)");

                    b.HasKey("GenreId");

                    b.ToTable("genres", (string)null);
                });

            modelBuilder.Entity("DBHomeWorkMusicSalesShop.Models.Invoice", b =>
                {
                    b.Property<long>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BillingAddress")
                        .HasColumnType("NVARCHAR(70)");

                    b.Property<string>("BillingCity")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("BillingCountry")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("BillingPostalCode")
                        .HasColumnType("NVARCHAR(10)");

                    b.Property<string>("BillingState")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<long>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("InvoiceDate")
                        .HasColumnType("DATETIME");

                    b.Property<double?>("Total")
                        .HasColumnType("NUMERIC(10,2)");

                    b.HasKey("InvoiceId");

                    b.HasIndex(new[] { "CustomerId" }, "IFK_InvoiceCustomerId");

                    b.ToTable("invoices", (string)null);
                });

            modelBuilder.Entity("DBHomeWorkMusicSalesShop.Models.InvoiceItem", b =>
                {
                    b.Property<long>("InvoiceLineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("InvoiceId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<long>("TrackId")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("UnitPrice")
                        .HasColumnType("NUMERIC(10,2)");

                    b.HasKey("InvoiceLineId");

                    b.HasIndex(new[] { "InvoiceId" }, "IFK_InvoiceLineInvoiceId");

                    b.HasIndex(new[] { "TrackId" }, "IFK_InvoiceLineTrackId");

                    b.ToTable("invoice_items", (string)null);
                });

            modelBuilder.Entity("DBHomeWorkMusicSalesShop.Models.MediaType", b =>
                {
                    b.Property<long>("MediaTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(120)");

                    b.HasKey("MediaTypeId");

                    b.ToTable("media_types", (string)null);
                });

            modelBuilder.Entity("DBHomeWorkMusicSalesShop.Models.Playlist", b =>
                {
                    b.Property<long>("PlaylistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(120)");

                    b.HasKey("PlaylistId");

                    b.ToTable("playlists", (string)null);
                });

            modelBuilder.Entity("DBHomeWorkMusicSalesShop.Models.Track", b =>
                {
                    b.Property<long>("TrackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("AlbumId")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("Bytes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Composer")
                        .HasColumnType("NVARCHAR(220)");

                    b.Property<long?>("GenreId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("MediaTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Milliseconds")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(200)");

                    b.Property<double?>("UnitPrice")
                        .HasColumnType("NUMERIC(10,2)");

                    b.HasKey("TrackId");

                    b.HasIndex(new[] { "AlbumId" }, "IFK_TrackAlbumId");

                    b.HasIndex(new[] { "GenreId" }, "IFK_TrackGenreId");

                    b.HasIndex(new[] { "MediaTypeId" }, "IFK_TrackMediaTypeId");

                    b.ToTable("tracks", (string)null);
                });

            modelBuilder.Entity("PlaylistTrack", b =>
                {
                    b.Property<long>("PlaylistId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("TrackId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PlaylistId", "TrackId");

                    b.HasIndex(new[] { "TrackId" }, "IFK_PlaylistTrackTrackId");

                    b.ToTable("playlist_track", (string)null);
                });

            modelBuilder.Entity("DBHomeWorkMusicSalesShop.Models.Album", b =>
                {
                    b.HasOne("DBHomeWorkMusicSalesShop.Models.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .IsRequired();

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("DBHomeWorkMusicSalesShop.Models.Customer", b =>
                {
                    b.HasOne("DBHomeWorkMusicSalesShop.Models.Employee", "SupportRep")
                        .WithMany("Customers")
                        .HasForeignKey("SupportRepId");

                    b.Navigation("SupportRep");
                });

            modelBuilder.Entity("DBHomeWorkMusicSalesShop.Models.Employee", b =>
                {
                    b.HasOne("DBHomeWorkMusicSalesShop.Models.Employee", "ReportsToNavigation")
                        .WithMany("InverseReportsToNavigation")
                        .HasForeignKey("ReportsTo");

                    b.Navigation("ReportsToNavigation");
                });

            modelBuilder.Entity("DBHomeWorkMusicSalesShop.Models.Invoice", b =>
                {
                    b.HasOne("DBHomeWorkMusicSalesShop.Models.Customer", "Customer")
                        .WithMany("Invoices")
                        .HasForeignKey("CustomerId")
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("DBHomeWorkMusicSalesShop.Models.InvoiceItem", b =>
                {
                    b.HasOne("DBHomeWorkMusicSalesShop.Models.Invoice", "Invoice")
                        .WithMany("InvoiceItems")
                        .HasForeignKey("InvoiceId")
                        .IsRequired();

                    b.HasOne("DBHomeWorkMusicSalesShop.Models.Track", "Track")
                        .WithMany("InvoiceItems")
                        .HasForeignKey("TrackId")
                        .IsRequired();

                    b.Navigation("Invoice");

                    b.Navigation("Track");
                });

            modelBuilder.Entity("DBHomeWorkMusicSalesShop.Models.Track", b =>
                {
                    b.HasOne("DBHomeWorkMusicSalesShop.Models.Album", "Album")
                        .WithMany("Tracks")
                        .HasForeignKey("AlbumId");

                    b.HasOne("DBHomeWorkMusicSalesShop.Models.Genre", "Genre")
                        .WithMany("Tracks")
                        .HasForeignKey("GenreId");

                    b.HasOne("DBHomeWorkMusicSalesShop.Models.MediaType", "MediaType")
                        .WithMany("Tracks")
                        .HasForeignKey("MediaTypeId")
                        .IsRequired();

                    b.Navigation("Album");

                    b.Navigation("Genre");

                    b.Navigation("MediaType");
                });

            modelBuilder.Entity("PlaylistTrack", b =>
                {
                    b.HasOne("DBHomeWorkMusicSalesShop.Models.Playlist", null)
                        .WithMany()
                        .HasForeignKey("PlaylistId")
                        .IsRequired();

                    b.HasOne("DBHomeWorkMusicSalesShop.Models.Track", null)
                        .WithMany()
                        .HasForeignKey("TrackId")
                        .IsRequired();
                });

            modelBuilder.Entity("DBHomeWorkMusicSalesShop.Models.Album", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("DBHomeWorkMusicSalesShop.Models.Artist", b =>
                {
                    b.Navigation("Albums");
                });

            modelBuilder.Entity("DBHomeWorkMusicSalesShop.Models.Customer", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("DBHomeWorkMusicSalesShop.Models.Employee", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("InverseReportsToNavigation");
                });

            modelBuilder.Entity("DBHomeWorkMusicSalesShop.Models.Genre", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("DBHomeWorkMusicSalesShop.Models.Invoice", b =>
                {
                    b.Navigation("InvoiceItems");
                });

            modelBuilder.Entity("DBHomeWorkMusicSalesShop.Models.MediaType", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("DBHomeWorkMusicSalesShop.Models.Track", b =>
                {
                    b.Navigation("InvoiceItems");
                });
#pragma warning restore 612, 618
        }
    }
}
