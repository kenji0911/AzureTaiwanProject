using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

using AzureLibrary.Entity.Blog;
using AzureLibrary.Entity.Post;

namespace AzureLibrary.DBModel.AzureDBContext
{
    public class AzureContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=db_ip, db_port;Database=db_name;user=yourUserName;password=yourPassWord;");
        }
    }    
}