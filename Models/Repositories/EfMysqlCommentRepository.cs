using Blog.Models.Entities;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Blog.Models.Repositories
{
    public class EfMysqlCommentRepository : IRepository<Comment>
    {
        private ApplicationCtx Context {get; set;}
        public EfMysqlCommentRepository(ApplicationCtx ctx)
        {
            Context = ctx;
        }
        public Task<int> Add(Comment e) => 
            Context
            .Comments
            .AddAsync(e)
            .ContinueWith((x) => Context.SaveChangesAsync())
            .Unwrap();
        public Task<Comment> Get(int id) => Context.Comments.FindAsync(id);
        public Task<IEnumerable<Comment>> GetAll() => Task.FromResult(Context.Comments.AsEnumerable());
        public Task<int> Remove(int id) =>
            Get(id)
            .ToAsyncEnumerable()
            .Select(x => Context.Comments.Remove(x).Entity.CommentId).First().ContinueWith(x => Context.SaveChanges());
        public Task<int> Replace(int id, Comment e)=>
            Get(id)
            .ToAsyncEnumerable()
            .Select(x => Context.Comments.Update(x).Entity.CommentId).First().ContinueWith(x => Context.SaveChanges());
        public Task<List<Comment>> Filter(Func<Comment, bool> pred) => 
            Context
            .Comments
            .ToAsyncEnumerable()
            .Where(pred)
            .ToList();
        public Task<List<Comment>> Take(int count) =>
            Context
            .Comments
            .ToAsyncEnumerable()
            .Take(count)
            .ToList();
    
    }
}