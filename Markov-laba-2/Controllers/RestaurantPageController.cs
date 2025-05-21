using Microsoft.AspNetCore.Mvc;

namespace Markov_laba_2.Controllers
{
    public class RestaurantPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
