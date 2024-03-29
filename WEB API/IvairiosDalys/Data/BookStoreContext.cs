﻿using ApiMokymai.Models;
using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace L05_Tasks_MSSQL.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //papildoma 
            modelBuilder.Entity<Book>()
            .Property(u => u.ECoverType)
            .HasConversion<string>()
            .HasMaxLength(20);

            //dataseed paduodamas contexte kuriant db lenteles.. overridinant 

            modelBuilder.Entity<Book>()
                .HasData(
                new Book(1, "The Bible", "Several authors", ECoverType.Paperback, 0001),
                new Book(2, "Quotations from Chairman Mao Tse-Tung", "Mao Zedong", ECoverType.Hardcover, 1964),
                new Book(3, "The Quran", "Several authors", ECoverType.Hardcover, 0700),
                new Book(4, "The Lord Of The Rings", "John Tolkien", ECoverType.Hardcover, 1954),
                new Book(5, "Le Petit Prince", "Antoine de Saint-Exupery", ECoverType.Electronic, 1943),
                new Book(6, "Harry Potter and the Philosopher’s Stone", "Joanne Rowling", ECoverType.Paperback, 1997),
                new Book(7, "Scouting for Boys", "Robert Baden-Powell", ECoverType.Paperback, 1908),
                new Book(8, "And Then There Were None", "Agatha Christie", ECoverType.Paperback, 1939),
                new Book(9, "The Hobbit", "John Tolkien ", ECoverType.Hardcover, 1937),
                new Book(10, "The Dream Of The Red Chambe", "Cao Xueqin", ECoverType.Paperback, 1791)
                );
        }
    }
}




