using System;
using System.Web.Mvc;

namespace Foo.Web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
	}
}
