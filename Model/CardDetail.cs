using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MovieOnlineBooking.Model
{
    public class CardDetail
    {
        [Key]
        public int CardId { get; set; }
        [Required]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        // [StringLength(10, MinimumLength = 10, ErrorMessage = "Phone number must be 10 digits.")]
        public long PhoneNumber { get; set; }


        [Required(ErrorMessage = "Card number is required.")]
        [RegularExpression(@"^\d{16}$", ErrorMessage = "Card number must be 16 digits.")]
        public string CardNumber { get; set; }


        [Required(ErrorMessage = "CVV is required.")]
        [RegularExpression(@"^\d{3}$", ErrorMessage = "CVV must be 3 digits.")]
        public int Cvv { get; set; }


        [Required]
        public int Month { get; set; }


        [Required]
        public int Year { get; set; }



        //for userID  fk
        public int UserId { get; set; }
        [JsonIgnore]
        [ForeignKey("UserId")]
        public UserRegister? UserRegister { get; set; }

       

    }
}
