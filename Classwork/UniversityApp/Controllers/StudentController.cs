using System.Linq;
using System.Threading;
using Microsoft.AspNetCore.Mvc;
using UniversityApp.Models;

namespace UniversityApp.Controllers
{
	public class StudentController : Controller
	{
		private readonly DataContext _context;
		public StudentController(DataContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var data = _context.Students.ToList();
			return View(data);
		}
	}
}
