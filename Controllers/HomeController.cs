using Microsoft.AspNetCore.Mvc;
using Blog.Models.Entities;
using Blog.Models.Repositories;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Blog.Controllers
{
    public class HomeController : Controller 
    {
        private IRepository<Comment> Repository { get; set;}
        public HomeController(IRepository<Comment> repository)
        {
            Repository = repository;
        }
        public IActionResult Index() => View();

        public IActionResult Posts() => RedirectToAction("List","Post");
        public IActionResult About() => View();
    }
}