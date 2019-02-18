using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class ErrorsController : Controller
    {
        public IActionResult Error() => View(HttpContext.Response.StatusCode);
    }
}