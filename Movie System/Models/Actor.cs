using System.ComponentModel.DataAnnotations;

namespace Movie_System.Models
{
	public class Actor
	{
		[Key]
		public int actorID { get; set; }

		[Display(Name ="Profile Picture URL")]
		[Required(ErrorMessage ="Profile Picture is Requried")]
		public string profilepicURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Profile Picture is Requried")]
        public string Name { get; set; }


        [Display(Name = "Actors Biography")]
        [Required(ErrorMessage = "Profile Picture is Requried")]
        public string Description { get; set; }
		public List<Actor_Movie> Actors_Movies { get; set; }
	}
}
