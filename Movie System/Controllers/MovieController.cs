using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movie_System.Data;

namespace Movie_System.Controllers
{
	public class MovieController : Controller
	{
		private readonly AppDb _context;

		public MovieController(AppDb context)
		{
			_context=context;	
		}

		public IActionResult Index()
		{
			var data = _context.Movies.Include(n => n.Cinema).ToList(); 
			return View(data);
		}
	}
}
