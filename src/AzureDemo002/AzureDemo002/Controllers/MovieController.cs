using System.Linq;
using System.Web.Mvc;
using AzureDemo002.Models;

namespace AzureDemo002.Controllers
{
	public class MovieController : Controller
	{
		//
		// GET: /Movie/

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
	}
}