using System.ComponentModel.DataAnnotations;

namespace Web_Server_Final.Models
{
    public class Sport
    {
        public int SportId { get; set; }

        [StringLength(200, ErrorMessage = "Name may not exceed 200 characters.")]
        [Required(ErrorMessage = "Please enter a team name.")]
        public string SportName { get; set; }
    }
}
