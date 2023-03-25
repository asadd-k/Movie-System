using Microsoft.EntityFrameworkCore;
using Movie_System.Models;

namespace Movie_System.Data
{
	public class AppDb : DbContext
	{
		public AppDb(DbContextOptions<AppDb> options) : base(options)
		{
			
		}

		protected override void OnModelCreating(ModelBuilder modelbuilder)
		{
			modelbuilder.Entity<Actor_Movie>().HasKey(am => new
			{
				am.actorID , am.movieID
			});

			modelbuilder.Entity<Actor_Movie>().HasOne(m => m.movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.movieID);

			modelbuilder.Entity<Actor_Movie>().HasOne(m => m.actor).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.actorID);


			base.OnModelCreating(modelbuilder);
		}

		public DbSet<Actor> Actors { get; set; }
		public DbSet<Movie> Movies { get; set; }
		public DbSet<Cinema> Cinemas { get; set; }
		public DbSet<Producer> Producers { get; set; }
		public DbSet<Actor_Movie> Actors_Movies { get; set; }

	}
}
