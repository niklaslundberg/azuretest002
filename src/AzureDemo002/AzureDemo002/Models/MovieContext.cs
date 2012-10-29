using System.Data.Entity;

namespace AzureDemo002.Models
{
	public class MovieContext : DbContext
	{
		public MovieContext() : base("MovieDb")
		{
			
		}

		public IDbSet<Movie> Movies { get; set; } 
	}

	public class Movie
	{
		public int Id { get; set; }
		public string Title { get; set; }
	}
}