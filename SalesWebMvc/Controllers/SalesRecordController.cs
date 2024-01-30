using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvc.Controllers
{
	public class SalesRecordController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
