using System.Linq;
using Eterna.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers
{
	public class TeamController : Controller
	{
		private readonly DataContext _context;
		public TeamController (DataContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			var data = _context.TeamMembers.ToList();
			return View(data);
		}
	}
}
