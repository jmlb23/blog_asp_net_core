using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blog.Models.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Blog.Models.Repositories
{
    public class EfMysqlPostRepository : IRepository<Post>
    {
        public ApplicationCtx Context { get; set; }

        public EfMysqlPostRepository(ApplicationCtx context) => Context = context;

        public Task<int> Add(Post e) =>
            Context.Posts.AddAsync(e).ContinueWith(x => Context.SaveChanges());

        public Task<List<Post>> Filter(Func<Post, bool> pred)
        {
            throw new NotImplementedException();
        }

        public Task<Post> Get(int id) => Context.Posts.FirstAsync(x => x.PostId==id);

        public Task<IEnumerable<Post>> GetAll() => 
            Task.FromResult(Context.Posts.Include(x => x.User).AsEnumerable());
        

        public Task<int> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Replace(int id, Post e)
        {
            throw new NotImplementedException();
        }

        public Task<List<Post>> Take(int count)
        {
            throw new NotImplementedException();
        }
    }
}