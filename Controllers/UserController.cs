using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieOnlineBooking.Data;
using MovieOnlineBooking.Model;
using System.Data;

namespace MovieOnlineBooking.Controllers
{
   // [Authorize(Roles = "User")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly MovieApiDbContext context;

        public UserController(MovieApiDbContext apiDbcontext)
        {
            context = apiDbcontext;

        }

        //toget the moviesDescription
        [HttpGet("Movie/[action]")]
        public async Task<IActionResult> GetMovies()
        {
            var movies = await context.movies.ToListAsync();
            if (movies == null)
            {
                return NotFound("Movie not found in database");
            }
            return Ok(movies);
        }


        //to ge the movie  by name
        [HttpGet("Movie/[action]/{name}")]
        public async Task<IActionResult> GetMovieByName(string name)
        {
            var movie = await context.movies.FirstOrDefaultAsync(m => m.Name == name);
            if (movie == null)
            {
                return NotFound("name is not valid, Enter valid name");
            }
            return Ok(movie);
        }




        /* //to Add the movieDescription
        [HttpPost("Movie/[action]")]
        public async Task<IActionResult> AddMovie(Movie movie)
        {
            context.movies.Add(movie);
            await context.SaveChangesAsync();
            return Ok("Movie added successfully");
        }
        */

        //=================================================================

        //to Add the RegistrationDetails
        [HttpPost("UserRegister/[action]")]
        public async Task<IActionResult> AddUserRegistration(UserRegister signup)
        {

            context.signups.Add(signup);
            await context.SaveChangesAsync();
            return Ok(signup);
        }


/*        //to get user/register details by id for user detials
        [HttpGet("UserRegister/[action]")]
        public async Task<IActionResult> GetUserRegistrationByName(string name)
        {
            var register = await context.signups.FirstOrDefaultAsync(s => s.Name == name);
            //var signup = context.signups.Find(Name);
            if (register == null)
            {
                return NotFound("Users register name is not valid, Enter valid name of user");
            }

            return Ok(register);
        }
*/

 //===============================================================================

        //to Add the ReviewDetails
        [HttpPost("Review/[action]")]
        public async Task<IActionResult> AddReview(Review review)
        {
            context.reviewes.Add(review);
            await context.SaveChangesAsync();
            return Ok(review);
        }


        //toupdate the movie
        [HttpPut("Review/[action]")]
        public async Task<IActionResult> UpdateReview(Review review)
        {
            if (review == null || review.ReviewId == 0)
            {
                return BadRequest("Review update is not possible for invalid data");
            }

           
            var existingReview = await context.reviewes.FindAsync(review.ReviewId);
            if (existingReview == null)
            {
                return NotFound("Review with the specified ID not found");
            }

            // Update the review properties
            existingReview.Rating = review.Rating;
            existingReview.ReviewerName = review.ReviewerName;
            existingReview.Comment = review.Comment;
            existingReview.ReviewDate = review.ReviewDate;

            await context.SaveChangesAsync();
            return Ok("Review updated successfully");
        }



        //CardDetials

        [HttpPost("CardDetail/[action]")]
        public async Task<IActionResult> AddCardDetail(CardDetail cardDetail)
        {
            context.cardDetails.Add(cardDetail);
            await context.SaveChangesAsync();
            return Ok("Card details added successfully");
        }

        // Update card details
        [HttpPut("CardDetail/[action]")]
        public async Task<IActionResult> UpdateCardDetail(CardDetail cardDetail)
        {
            if (cardDetail == null || cardDetail.CardId == 0)
            {
                return BadRequest("Card detail update is not possible for invalid data");
            }

            var existingCardDetail = await context.cardDetails.FindAsync(cardDetail.CardId);
            if (existingCardDetail == null)
            {
                return NotFound("Card detail with the specified ID not found");
            }

            // Update the card detail properties
            existingCardDetail.Name = cardDetail.Name;
            existingCardDetail.PhoneNumber = cardDetail.PhoneNumber;
            existingCardDetail.CardNumber = cardDetail.CardNumber;
            existingCardDetail.Cvv = cardDetail.Cvv;
            existingCardDetail.Month = cardDetail.Month;
            existingCardDetail.Year = cardDetail.Year;

            await context.SaveChangesAsync();
            //return Ok("Card details updated successfully");
            return Ok(new { Message = "Card details updated successfully", CardDetail = cardDetail });
        }
    }
}