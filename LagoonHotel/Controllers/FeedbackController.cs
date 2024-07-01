using LagoonHotel_DataAccess.Repository.IRepository;
using LagoonHotel_Models;
using Microsoft.AspNetCore.Mvc;

namespace LagoonHotel.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly IFeedBackRepository _feedRepo;

        public FeedbackController(IFeedBackRepository feedRepo)
        {
            _feedRepo = feedRepo;
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Feedback obj)
        {
            if (ModelState.IsValid)
            {
                _feedRepo.Add(obj);
                _feedRepo.Save();
                return RedirectToAction("Successfull");
            }
            return View(obj);
        }

        public IActionResult Successfull()
        {
            return View();
        }


    }
}
