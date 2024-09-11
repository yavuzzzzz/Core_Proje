using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
	public class SkillController : Controller
	{
		SkillManager skillManager = new SkillManager(new EfSkillDal());
		public IActionResult Index()
		{

			ViewBag.v1 = "Yetenek Listesi";
			ViewBag.v2 = "Yetenekler";
			ViewBag.v3 = "Yetenek Listesi";
			ViewBag.v4 = "Skill";
			var values = skillManager.TGetList();
			return View(values);
		}

		[HttpGet]
		public IActionResult AddSkill()
		{
			ViewBag.v1 = "Yetenek Ekleme";
			ViewBag.v2 = "Yetenekler";
			ViewBag.v3 = "Yetenek Ekleme";
			return View();
		}
		[HttpPost]
		public IActionResult AddSkill(Skill skill)
		{
			skillManager.TAdd(skill);
			return RedirectToAction("Index");

		}
		public IActionResult DeleteSkill(int id)
		{
			var value = skillManager.TGetById(id);
			skillManager.TDelete(value);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateSkill(int id)
		{
			ViewBag.v1 = "Güncelleme";
			ViewBag.v2 = "Yetenekler";
			ViewBag.v3 = "Yetenek Güncelleme";
			var values = skillManager.TGetById(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult UpdateSkill(Skill skill)
		{
			skillManager.TUpdate(skill);
			return RedirectToAction("Index");
		}
	}
}
