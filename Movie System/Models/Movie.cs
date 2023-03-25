using Movie_System.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie_System.Models
{
    public class Movie
	{
		[Key]
		public int movieID { get; set; }

		[Required]
		public string Title { get; set; }

		[Required]
		public string Description { get; set; }

		[Required]
		public double Price { get; set; }

		[Required]
		public int Quantity { get; set; } = 0 ;

		public string imageURL { get; set; }

		[Required]
		public DateTime startDate { get; set; }

		[Required]
		public DateTime endDate { get; set; }

		[Required]
		public MovieCategory Category { get; set; }

		public List<Actor_Movie> Actors_Movies { get; set; }

		public int cinemaID { get; set; }
		[ForeignKey("cinemaID")]
		public Cinema Cinema { get; set; }

		public int producerID { get; set; }
		[ForeignKey("producerID")]
		public Producer Producer { get; set; }

	}
}
