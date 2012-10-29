using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AzureDemo002.Models
{
	public class MoviesViewModel
	{
		public IEnumerable<Movie> Movies { get; private set; }

		public MoviesViewModel(IEnumerable<Movie> movies)
		{
			Movies = movies;
		}
	}
}