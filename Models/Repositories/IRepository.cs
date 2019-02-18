using System.Collections.Generic;
using System;
using System.Threading.Tasks;

namespace Blog.Models.Repositories
{
    public interface IRepository<Entity>
    {
        Task<int> Add(Entity e);

        Task<Entity> Get(int id);

        Task<IEnumerable<Entity>> GetAll();

        Task<int> Remove(int id);

        Task<int> Replace(int id, Entity e);

        Task<List<Entity>> Filter(Func<Entity, bool> pred);

        Task<List<Entity>> Take(int count);

    }
}