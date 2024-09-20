using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Core_Proje.Controllers
{
	public class PortfolioController : Controller
	{
		PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
		public IActionResult Index()
		{
			ViewBag.v1 = "Proje Listesi";
			ViewBag.v2 = "Projelerim";
			ViewBag.v3 = "Proje Listesi";
			var values = portfolioManager.TGetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddPortfolio()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddPortfolio(Portfolio portfolio)
		{
			ViewBag.v1 = "Proje Listesi";
			ViewBag.v2 = "Projelerim";
			ViewBag.v3 = "Proje Ekleme";

			PortfolioValidator validations = new PortfolioValidator();
			ValidationResult results = validations.Validate(portfolio);
			if (results.IsValid)
			{
				portfolioManager.TAdd(portfolio);
				return RedirectToAction("Index");
			}
			else
			{
				foreach (var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}

			}
			return View();

		}

		public IActionResult DeletePortfolio(int id)
		{
			var values = portfolioManager.TGetById(id);
			portfolioManager.TDelete(values);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult UpdatePortfolio(int id)
		{
			ViewBag.v1 = "Proje Listesi";
			ViewBag.v2 = "Projelerim";
			ViewBag.v3 = "Proje Düzenleme";
			var values = portfolioManager.TGetById(id);
			return View(values);
		}

		[HttpPost]
		public IActionResult UpdatePortfolio(Portfolio portfolio)
		{
			PortfolioValidator validations = new PortfolioValidator();
			ValidationResult results = validations.Validate(portfolio);
			if (results.IsValid)
			{
				portfolioManager.TUpdate(portfolio);
				return RedirectToAction("Index");
			}
			else
			{
				foreach (var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
		}
	}
}
