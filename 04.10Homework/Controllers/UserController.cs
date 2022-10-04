using Microsoft.AspNetCore.Mvc;

namespace _04._10Homework.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Faiq";
            ViewBag.Surname = "Resulzade";
            ViewBag.Age = 20;
            ViewBag.Country = "Azerbaijan";
            ViewBag.Phone_Number = "+994 ** *** ** **";
            return View();
        }
    }
}
