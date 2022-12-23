using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
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

            modelBuilder.Entity<Reservation>()
         .HasKey(d => d.Id);

            modelBuilder.Entity<Reservation>()
                .Property(d => d.Id)
                .ValueGeneratedOnAdd();


            modelBuilder.Entity<Reservation>()
                .HasOne(dio => dio.Book)
                .WithMany(d => d.Reservations)
                .HasForeignKey(d => d.BookId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Reservation>()
             .HasOne(dio => dio.LocalUser)
             .WithMany(d => d.Reservations)
             .HasForeignKey(d => d.LocalUserId)
             .OnDelete(DeleteBehavior.NoAction);




            modelBuilder.Entity<Book>()
            .Property(u => u.ECoverType)
            .HasConversion<string>()
            .HasMaxLength(50);

            modelBuilder.Entity<Book>()
          .Property(u => u.EBookStatus)
          .HasConversion<string>()
          .HasMaxLength(50);


            modelBuilder.Entity<Book>()
            .HasData(
                new Book(1, "The Bible", "Several authors", ECoverType.Paperback, 0001,1, DateTime.Now, EBookStatus.Registed),
                new Book(2, "Quotations from Chairman Mao Tse-Tung", "Mao Zedong", ECoverType.Hardcover, 1964, 2, DateTime.Now, EBookStatus.Registed),
                new Book(3, "The Quran", "Several authors", ECoverType.Hardcover, 0700, 3, DateTime.Now, EBookStatus.Registed),
                new Book(4, "The Lord Of The Rings", "John Tolkien", ECoverType.Hardcover, 1954, 4, DateTime.Now, EBookStatus.Registed),
                new Book(5, "Le Petit Prince", "Antoine de Saint-Exupery", ECoverType.Electronic, 1943, 5, DateTime.Now, EBookStatus.Registed),
                new Book(6, "Harry Potter and the Philosopher’s Stone", "Joanne Rowling", ECoverType.Paperback, 1997, 6, DateTime.Now, EBookStatus.Registed),
                new Book(7, "Scouting for Boys", "Robert Baden-Powell", ECoverType.Paperback, 1908, 7, DateTime.Now, EBookStatus.WishListed),
                new Book(8, "And Then There Were None", "Agatha Christie", ECoverType.Paperback, 1939, 8, DateTime.Now, EBookStatus.WishListed),
                new Book(9, "The Hobbit", "John Tolkien ", ECoverType.Hardcover, 1937, 9, DateTime.Now, EBookStatus.OnSale),
                new Book(10, "The Dream Of The Red Chambe", "Cao Xueqin", ECoverType.Paperback, 1791, 10, DateTime.Now, EBookStatus.OnSale)
                );




        }

    }
}




