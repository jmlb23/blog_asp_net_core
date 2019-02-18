using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blog.Models.Entities;


namespace Blog.Models.Repositories
{
    public class EfMysqlUserRepository : IRepository<User>
    {
        public Task<int> Add(User e)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> Filter(Func<User, bool> pred)
        {
            throw new NotImplementedException();
        }

        public Task<User> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Replace(int id, User e)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> Take(int count)
        {
            throw new NotImplementedException();
        }
    }
}