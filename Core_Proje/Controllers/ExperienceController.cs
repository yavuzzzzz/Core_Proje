using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
			ViewBag.v1 = "Deneyim Listesi";
			ViewBag.v2 = "Deneyimler";
			ViewBag.v3 = "Deneyim Listesi";
            ViewBag.v4 = "Experience";
			var values = experienceManager.TGetList();
            return View(values);
        }
    }
}
