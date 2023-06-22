using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MovieOnlineBooking.Model
{
    public class UserRegister
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Password is required.")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters.")]
        //[RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$",
        //  ErrorMessage = "Password must contain at least 8 characters, one letter, one number, and one special character.")]

        public string Password { get; set; }



        //for review table for making the relationship of two table  that will show that this user table has relationship with reviw table

        [JsonIgnore]
        public ICollection<Review>? Reviewes { get; set; }




        //For sending primarykey to payment

        [JsonIgnore]
        public ICollection<CardDetail>? CardDetails { get; set; }


    }
}