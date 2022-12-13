using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using WebAppMSSQL.Models;
using WebAppMSSQL.Models.Enums;

namespace WebAppMSSQL.Data
{
    public class KnygynasContext : DbContext
    {
        public KnygynasContext(DbContextOptions<KnygynasContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }
        public DbSet<LocalUser> LocalUsers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
            .Property(u => u.ECoverType)
            .HasConversion<string>()
            .HasMaxLength(50);

            modelBuilder.Entity<Book>()
                .HasData(
                new Book(1, "The Bible", "Several authors", ECoverType.Paperback, 0001,1),
                new Book(2, "Quotations from Chairman Mao Tse-Tung", "Mao Zedong", ECoverType.Hardcover, 1964, 2),
                new Book(3, "The Quran", "Several authors", ECoverType.Hardcover, 0700, 3),
                new Book(4, "The Lord Of The Rings", "John Tolkien", ECoverType.Hardcover, 1954, 4),
                new Book(5, "Le Petit Prince", "Antoine de Saint-Exupery", ECoverType.Electronic, 1943, 5),
                new Book(6, "Harry Potter and the Philosopher’s Stone", "Joanne Rowling", ECoverType.Paperback, 1997, 6),
                new Book(7, "Scouting for Boys", "Robert Baden-Powell", ECoverType.Paperback, 1908, 7),
                new Book(8, "And Then There Were None", "Agatha Christie", ECoverType.Paperback, 1939, 8),
                new Book(9, "The Hobbit", "John Tolkien ", ECoverType.Hardcover, 1937, 9),
                new Book(10, "The Dream Of The Red Chambe", "Cao Xueqin", ECoverType.Paperback, 1791, 10)
                );


        }

    }
}




