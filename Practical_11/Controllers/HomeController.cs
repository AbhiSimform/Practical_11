using Practical_11.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Practical_11.Controllers
{
	public class HomeController : Controller
	{
		private static List<User> _users = new List<User>();

		public HomeController()
		{
			for (int i = 0; i < 10; i++)
			{
				_users.Add(new User()
				{
					Id = i,
					Name = $"Test{i * 10}",
					DOB = DateTime.Now.Date,
					Address = $"hello this is address! {i * 11232}"
				});
			}
		}

		public ActionResult Index()
		{
			return View(_users);
		}

		public ActionResult Create()
		{
			return View(new User());
		}

		[HttpPost]
		public ActionResult Create(User user)
		{
			_users.Add(user);
			return View(new User());
		}


		public ActionResult Update(int id)
		{
			return View();
		}

		public ActionResult Update(User user)
		{

			return RedirectToAction("Index");
		}

		public ActionResult Delete(int id)
		{
			_users.Remove(_users.Find(x => x.Id == id));
			return View();
		}

	}
}