using Microsoft.AspNetCore.Mvc;
using Movie_System.Data;

namespace Movie_System.Controllers
{
	public class CinemaController : Controller
	{
		private readonly AppDb _context;

		public CinemaController(AppDb context)
		{
			_context=context;
		}

		public IActionResult Index()
		{
			var data = _context.Cinemas.ToList();
			return View(data);
		}
	}
}
