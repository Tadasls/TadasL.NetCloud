﻿// <auto-generated />
using Infracstructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace P053_QueryingSqliteDb.Infrastrusture.Migrations
{
    [DbContext(typeof(BloggingContext))]
    partial class BloggingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("Domains.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.HasKey("AuthorId");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("Domains.Models.AuthorBlog", b =>
                {
                    b.Property<int>("AuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BlogId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AuthorId", "BlogId");

                    b.HasIndex("BlogId");

                    b.ToTable("AuthorBlogs");
                });

            modelBuilder.Entity("Domains.Models.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(0);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("BlogName")
                        .HasColumnOrder(1);

                    b.Property<decimal>("Rating")
                        .HasColumnType("TEXT")
                        .HasColumnOrder(2);

                    b.HasKey("BlogId");

                    b.ToTable("Blog");
                });

            modelBuilder.Entity("Domains.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BlogId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PostId");

                    b.HasIndex("BlogId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Domains.Models.AuthorBlog", b =>
                {
                    b.HasOne("Domains.Models.Author", "Author")
                        .WithMany("AuthorBlogs")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domains.Models.Blog", "Blog")
                        .WithMany("AuthorBlogs")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("Domains.Models.Post", b =>
                {
                    b.HasOne("Domains.Models.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("Domains.Models.Author", b =>
                {
                    b.Navigation("AuthorBlogs");
                });

            modelBuilder.Entity("Domains.Models.Blog", b =>
                {
                    b.Navigation("AuthorBlogs");

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
