using System.ComponentModel.DataAnnotations;

namespace Movie_System.Models
{
	public class Producer
	{
		[Key]
		public int producerID { get; set; }

		[Display(Name="Profile Picture")]
		public string profilepicURL { get; set; }

		[Required]
		[Display(Name="Full Name")]
		public string Name { get; set; }


		[Required]
        [Display(Name = "Biography")]
        public string Description { get; set; }

		//producers can also have multiple movies 

		public List<Movie> Movies { get; set; }
	}
}
