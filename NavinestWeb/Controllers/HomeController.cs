using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NavinestWeb.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult MyListingAdd()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult MyProfile()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult AgentList()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult Agent()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult ChangePassword()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult PropertyListingMap(string txtPropertySearchIndex, string selPropertyType, string searchin)
		{
			//Get listing here first
			return View();
		}

		public ActionResult Notifications()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult Membership()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult Payments()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult Account()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}