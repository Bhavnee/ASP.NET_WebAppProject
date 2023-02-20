using Microsoft.AspNetCore.Mvc;

namespace CharakAyurvedicHospital.Controllers
{
    public class DoctorsList : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SarbjitInfo()
        {
            return View();
        }

        public IActionResult AmarjitInfo()
        { 
            return View();
        }
        public IActionResult AbhimanyuInfo()
        {
            return View();
        }
        public IActionResult MridhuInfo()
        {
            return View();
        }
    }
}
