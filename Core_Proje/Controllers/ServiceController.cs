using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
	public class ServiceController : Controller
	{
		ServiceManager serviceManager = new ServiceManager(new EfServiceDal());

		public IActionResult Index()
		{
			ViewBag.v1 = "Hizmet Listesi";
			ViewBag.v2 = "Hizmetler";
			ViewBag.v3 = "Hizmet Listesi";

			var values = serviceManager.TGetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddService()
		{
			ViewBag.v1 = "Hizmet Listesi";
			ViewBag.v2 = "Hizmetler";
			ViewBag.v3 = "Hizmet Ekleme";
			return View();
		}
		[HttpPost]
		public IActionResult AddService(Service service)
		{
			serviceManager.TAdd(service);
			return RedirectToAction("Index");

		}
		public IActionResult DeleteService(int id)
		{
			var value = serviceManager.TGetById(id);
			serviceManager.TDelete(value);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateService(int id)
		{
			ViewBag.v1 = "Hizmet Listesi";
			ViewBag.v2 = "Hizmetler";
			ViewBag.v3 = "Hizmet Güncelleme";
			var values = serviceManager.TGetById(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult UpdateService(Service service)
		{
			serviceManager.TUpdate(service);
			return RedirectToAction("Index");
		}
	}
}
