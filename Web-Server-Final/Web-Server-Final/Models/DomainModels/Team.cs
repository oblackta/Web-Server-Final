using System.ComponentModel.DataAnnotations;

namespace Web_Server_Final.Models
{
    public class Team
    {
        public int TeamId { get; set; }

        [StringLength(200, ErrorMessage = "Name may not exceed 200 characters.")]
        [Required(ErrorMessage = "Please enter a team name.")]
        public string TeamName { get; set; }

        public string City { get; set; }

        public int SportId { get; set; } // Foreign key property
    }
}
