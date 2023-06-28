using Practical_11.Data;
using Practical_11.Models;
using System.Web.Mvc;

namespace Practical_11.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet]
		public ActionResult Index()
		{
			return View(DataClass.Users());
		}

		[HttpGet]
		public ActionResult Create()
		{
			return View(new User());
		}

		[HttpGet]
		public ActionResult Detail(int? id)
		{
			if (id == null)
			{
				return RedirectToAction("Error");
			}
			var user = DataClass.GiveMeUser(id ?? 0);
			if (user == null)
			{
				return RedirectToAction("Error");
			}
			return View(user);
		}

		public ActionResult Error()
		{
			return View();
		}

		[HttpGet]
		public ActionResult Update(int? id)
		{
			if (id == null)
			{
				return RedirectToAction("Error");
			}

			var user = DataClass.GiveMeUser(id ?? 0);

			if (user == null)
			{
				return RedirectToAction("Error");
			}

			return View(user);
		}

		[HttpGet]
		public ActionResult Delete(int? id)
		{
			if (id == null)
			{
				return RedirectToAction("Error");
			}

			var user = DataClass.GiveMeUser(id ?? 0);

			if (user == null)
			{
				return RedirectToAction("Error");
			}
			return View(user);
		}

		[HttpPost]
		public ActionResult Delete(User user)
		{
			DataClass.DeleteUser(user.Id);
			return RedirectToAction("Index");
		}


		[HttpPost]
		public ActionResult Update(User user)
		{
			if (user == null)
			{
				return RedirectToAction("Error");
			}

			DataClass.UpdateUser(user);
			return RedirectToAction("Index");
		}

		[HttpPost]
		public ActionResult Create(User user)
		{
			DataClass.AddUser(user);
			return RedirectToAction("Index");
		}

	}
}