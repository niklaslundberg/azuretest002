using System;
using System.Linq;
using System.Web.Mvc;
using AzureDemo002.Models;

namespace AzureDemo002.Controllers
{
	public class MovieController : Controller
	{
		public ActionResult Index()
		{
			MoviesViewModel viewModel;
			using (var ctx = new MovieContext())
			{
				var movies = ctx.Movies.ToArray();

				viewModel = new MoviesViewModel(movies);
			}

			return View(viewModel);
		}

		public ActionResult Add()
		{
			using (var ctx = new MovieContext())
			{
				ctx.Movies.Add(new Movie {Title = "My Movie " + DateTime.UtcNow.ToString("o") + " (manual)"});
				ctx.SaveChanges();
			}

			return new RedirectResult("~/");
		}

		public ActionResult Fail()
		{
			throw new InvalidOperationException("This is a demo exception");
		}

		public ActionResult Reset()
		{
			using (var ctx = new MovieContext())
			{
				ctx.Database.ExecuteSqlCommand("TRUNCATE TABLE [Movies]");
			}
			return new RedirectResult("~/");
		}
	}
}