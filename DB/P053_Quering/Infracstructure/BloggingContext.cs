using Domains.Models;
using Microsoft.EntityFrameworkCore;

namespace Infracstructure
{
    public class BloggingContext : DbContext
    {
        public BloggingContext()
        {
            // %LOCALAPPDATA%
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            ConnectionString = Path.Join(path, "QueringBloggingDB.db");
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorBlog> AuthorBlogs { get; set; }


        public string ConnectionString { get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            

            optionsBuilder.UseSqlite($"Data Source = {ConnectionString}");
            optionsBuilder.UseLazyLoadingProxies();


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AuthorBlog>()
                        .HasKey(ab => new { ab.AuthorId, ab.BlogId});

            modelBuilder.Entity<AuthorBlog>()
                .HasOne<Author>(ab => ab.Author)
                .WithMany(ab => ab.AuthorBlogs)
                .HasForeignKey(ab => ab.AuthorId);

            modelBuilder.Entity<AuthorBlog>()
           .HasOne<Blog>(ab => ab.Blog)
           .WithMany(ab => ab.AuthorBlogs)
           .HasForeignKey(ab => ab.BlogId);
        }


    }
}