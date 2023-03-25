namespace Movie_System.Models
{
	public class Actor_Movie
	{
		public int movieID { get; set; }

		public Movie movie { get; set; }

		public int actorID { get; set; }

		public Actor actor { get; set; }
	}
}


// Multiple actors can have multiple movies 
// Mutiple movies can have multiple actors

/* This is a many to many relation
 * A separate class ( Join Table ) is created for it . 
 
 */
