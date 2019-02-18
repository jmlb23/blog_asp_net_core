using Microsoft.AspNetCore.Mvc;
using Blog.Models.Repositories;
using Blog.Models.Entities;

namespace Blog.Controllers
{
    public class PostController : Controller
    {
        private IRepository<Post> Repository{ get; set;}
        public PostController(IRepository<Post> repository)
        {
            Repository = repository;
        }
        public IActionResult List() => View(Repository.GetAll());
        public IActionResult Entry(int id = 0) => View(Repository.Get(id));
    }
}