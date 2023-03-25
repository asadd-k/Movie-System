using System.ComponentModel.DataAnnotations;

namespace Movie_System.Models
{
	public class Cinema
	{
		[Key]
		public int cinemaId { get; set; }

		[Display(Name="Logo")]
		public string logoURL { get; set; }

		[Required]
		[Display(Name= "Cinema Name")]
		public string Name { get; set; }

		[Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

		//since one cinema can have multiple movies

		public List<Movie> Movies { get; set; }
	}
}
