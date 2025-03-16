using Microsoft.AspNetCore.Mvc;

namespace ShopMVC.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Post(int year, int month, int day)
        {
            return Ok($"Post of {year} / {month} / {day}");
        }
    }
}
