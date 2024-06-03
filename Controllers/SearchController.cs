using Microsoft.AspNetCore.Mvc;

namespace ASPLabb4.Controllers;
public class SearchController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
}
