using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MovieOnlineBooking.Model
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [Required]
        public float Rating { get; set; }

        [Required]
        public string ReviewerName { get; set; }

        [Required]
        public string Comment { get; set; }

        [Required]
        public string ReviewDate { get; set; }




        //for movied fk
        public int MovieId { get; set; }
        [JsonIgnore]
        [ForeignKey("MovieId")]
        public Movie? Movie { get; set; }



        public int UserId { get; set; }

        [JsonIgnore]
        [ForeignKey("UserId")]
        public UserRegister? UserRegister { get; set; }

    }
}
