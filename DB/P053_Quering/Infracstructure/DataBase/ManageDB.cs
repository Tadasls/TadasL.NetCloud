using Domains.Models;
using Infracstructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P053_QueryingSqliteDb.Infrastrusture.DataBase
{
    public class ManageDB
    {

        public ManageDB()
        {
            using var context = new BloggingContext();
            context.Database.EnsureCreated();   
        }

        public void AddBlog(string name)
        {
            using var context = new BloggingContext();
            context.Blogs.Add(new Blog { Name = name });
            context.SaveChanges();
        }


        public void AddPost(string title, int blogId)
        {
            using var context = new BloggingContext();
            var blog = context.Blogs.Find(blogId);
            blog.Posts.Add(new Post { Title = title });
            context.SaveChanges();  


        }

        public void AddAuthor(string firstName, string lastName, int blogId)
        {
            using var context = new BloggingContext();
            context.AuthorBlogs.Add(new AuthorBlog
            {
                Author = new Author
                {
                    FirstName = firstName,
                    LastName = lastName,
                },
                BlogId = blogId
            });

            context.SaveChanges();

        }


        public void GetBlogs_EagerLoading()
        {

            using var context = new BloggingContext();
            var blogs = context.Blogs
                .Include(b => b.Posts);
            foreach (var blog in blogs)
            {
                Console.WriteLine($" {blog.BlogId} {blog.Name}");
            }
        }

        public void LazyLoading()
        {

            using var context = new BloggingContext();
            var blogs = context.Blogs.ToList();
            foreach (var blog in blogs)
            {
                Console.WriteLine($" {blog.BlogId} {blog.Name}");
            }
        }




    }
}
