using MessagePack;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Movie_System.Data;
using Movie_System.Data.Services;
using Movie_System.Models;

namespace Movie_System.Controllers
{
	public class ActorController : Controller
	{
		private readonly IActorsService _service;
		private readonly AppDb _db; 

		public ActorController(IActorsService service, AppDb db)
		{
			_service = service; 
			_db = db;	
		}

		public IActionResult Index()
		{
			var data = _service.GetAll();  
			return View(data);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create([Bind("Name, profilepicURL, Description")]Actor actor)
		{
			 _db.Actors.Add(actor);
			_db.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult Details(int id)
		{
			if (id == null || id == 0) 
			{
				return NotFound(); 
			}
			var result = _db.Actors.Find(id); 
			return View(result);
		}

        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit([Bind("Name, profilepicURL, Description")] Actor actor)
        {
            _db.Actors.Update(actor);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
