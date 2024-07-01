using Microsoft.AspNetCore.Mvc;

namespace LagoonHotel.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult ExclusiveServiceDetails()
        {
            return View();
        }

        public IActionResult RentDetails()
        {
            return View();
        }

        public IActionResult RestDetails()
        {
            return View();
        }

        public IActionResult ParkingDetails()
        {
            return View();
        }
    }
}
