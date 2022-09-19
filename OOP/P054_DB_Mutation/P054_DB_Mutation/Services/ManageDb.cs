using Domains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P054_DB_Mutation.Services

{
    public class ManageDb
    {
        public ManageDb()
        {

            using (var context = new BloggingContext())
            {
                context.Database.EnsureCreated();   


            }

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




    }
}
