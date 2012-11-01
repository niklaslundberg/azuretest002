using System;
using System.Data.Entity.Migrations;
using AzureDemo002.Models;

namespace AzureDemo002.Migrations
{
	internal sealed class Configuration : DbMigrationsConfiguration<MovieContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
		}

		protected override void Seed(MovieContext context)
		{
			var movie = new Movie {Title = string.Format("MyMovie ({0})", DateTime.UtcNow.ToString("o") + " (seed)")};

			context.Movies.Add(movie);
		}
	}
}