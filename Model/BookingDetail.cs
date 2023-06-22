using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MovieOnlineBooking.Model
{
    public class BookingDetail
    {
        [Key]
        public int BookingId { get; set; }

        [Required]
        public string BookingDate { get; set; }

        [Required]
        public string NoOfSeats { get; set; }

        [Required]
        public string TotalPrice { get; set; }

        //for movied fk
        [JsonIgnore]
        [ForeignKey("MovieId")]
        public Movie? Movie { get; set; }

/*
        //for userID  fk
        public int UserId { get; set; }
        [JsonIgnore]
        [ForeignKey("UserId")]
        public UserRegister? UserRegister { get; set; }

        /*
                //for paymentId fk
                [JsonIgnore]
                [ForeignKey("PaymentId")]
                public Payment Payment { get; set; }  
         


        [JsonIgnore]
        public Payment? Payment { get; set; }

        */
        


    }
}
