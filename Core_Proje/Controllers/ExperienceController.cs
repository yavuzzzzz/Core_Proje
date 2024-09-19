using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
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

		[HttpGet]
		public IActionResult AddExperience()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddExperience(Experience experience)
		{
			experienceManager.TAdd(experience);
			return RedirectToAction("Index");

		}
		public IActionResult DeleteExperience(int id)
		{
			var value = experienceManager.TGetById(id);
			experienceManager.TDelete(value);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateExperience(int id)
		{
			ViewBag.v1 = "Deneyim Listesi";
			ViewBag.v2 = "Deneyimler";
			ViewBag.v3 = "Deneyim Listesi";
			var values = experienceManager.TGetById(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult UpdateExperience(Experience experience)
		{
			experienceManager.TUpdate(experience);
			return RedirectToAction("Index");
		}
	}
}
