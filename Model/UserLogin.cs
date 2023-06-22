using System.ComponentModel.DataAnnotations;

namespace MovieOnlineBooking.Model
{
    public class UserLogin
    {
        [Required(ErrorMessage = "Username is required")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }

       
    }
}
