using Microsoft.AspNetCore.Mvc;

namespace ShopMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/5
        public IActionResult Welcome(int Id, string name, int age)
        {
            ViewData["name"] = "Hello " + name;
            ViewBag.Age = age;
            ViewBag.Id = Id;
            return View();
        }
    }
}
