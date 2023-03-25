using Microsoft.AspNetCore.Mvc;
using Movie_System.Data;

namespace Movie_System.Controllers
{
	public class ProducerController : Controller
	{
		private readonly AppDb _context;

		public ProducerController(AppDb context)
		{
				_context= context;
		}

		public IActionResult Index()
		{
			var data = _context.Producers.ToList();
			return View(data);
		}
	}
}
