using System.Web.Mvc;
using Foo.Web.Controllers;
using Xunit;

namespace Foo.Tests.Web.Controllers
{
	public class HomeControllerTest
	{
		private readonly HomeController _controller;

		public HomeControllerTest()
		{
			_controller = new HomeController();
		}

		[Fact]
		public void IndexShouldReturnViewResult()
		{
			var result = _controller.Index();
			Assert.IsType<ViewResult>(result);
		}
	}
}
