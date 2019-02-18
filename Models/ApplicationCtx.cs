using Microsoft.EntityFrameworkCore;
using Blog.Models.Entities;

namespace Blog.Models
{
    public class ApplicationCtx :  DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseMySQL("Server=127.0.0.1;Database=Blog;Uid=root;Pwd=my-secret-pw;");
        }
        public DbSet<Post> Posts {get; set;}
        public DbSet<Comment> Comments {get; set;}
        public DbSet<User> Users {get; set;}
    }
}