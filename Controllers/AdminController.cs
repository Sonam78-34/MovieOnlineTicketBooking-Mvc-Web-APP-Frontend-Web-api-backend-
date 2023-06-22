using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieOnlineBooking.Data;
using MovieOnlineBooking.Model;

namespace MovieOnlineBooking.Controllers
{
    //[Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {

        private readonly MovieApiDbContext context;
        //private object?[]? reviewename;

        public AdminController(MovieApiDbContext apiDbcontext)
        {
            context = apiDbcontext;

        }

        //toget the moviesDescription
        [HttpGet("Movies/[action]")]

        public async Task<IActionResult> GetMovies()
        {
            var movies = await context.movies.ToListAsync();
            if (movies == null)
            {
                return NotFound("Movies not found in database");
            }
            return Ok(movies);
        }


        //to ge the movie  by name
        [HttpGet("Movies/[action]/{name}")]
       
        public async Task<IActionResult> GetMovieByName(string name)
        {
            var movie = await context.movies.FirstOrDefaultAsync(m => m.Name == name);
            if (movie == null)
            {
                return NotFound("name is not valid, Enter valid name");
            }
            return Ok(movie);
        }




        //to Add the movieDetails
        [HttpPost("Movies/[action]")]
        
        public async Task<IActionResult> AddMovie(Movie movie)
        {
            context.movies.Add(movie);
            await context.SaveChangesAsync();
            return Ok("Movie added successfully");
        }


        //toupdate the movie


        [HttpPut("Movies/[action]/{Id}")]
        public async Task<IActionResult> UpdateMovieById(int Id, Movie movie)
        {
            try
            {
                if (movie == null || movie.MovieId != Id)
                {
                    return BadRequest("Invalid movie data or mismatched movie ID");
                }

                var existingMovie = await context.movies.FindAsync(Id);
                if (existingMovie == null)
                {
                    return NotFound("Movie not found");
                }

                // Update the movie properties
                existingMovie.Name = movie.Name;
                existingMovie.Image = movie.Image;
                existingMovie.Rating = movie.Rating;
                existingMovie.Language = movie.Language;
                existingMovie.Duration = movie.Duration;
                existingMovie.Genre = movie.Genre;
                existingMovie.Availability = movie.Availability;
                existingMovie.Cast = movie.Cast;
                existingMovie.Description = movie.Description;

                await context.SaveChangesAsync();

                return Ok("Movie updated successfully");
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                return StatusCode(500, $"An error occurred while updating the movie: {ex.Message}");
            }
        }



        //to delete
        [HttpDelete("Movies/[action]/{id}")]

        public async Task<IActionResult> DeleteMovieById(int id)
        {
            var movie = await context.movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound("Movie Id does not exist");
            }

            context.movies.Remove(movie);
            await context.SaveChangesAsync();
            return Ok("Movie deleted successfully");
        }

        // ======================= ReviewAdmin  ===========================

        //Toget Review of user
        [HttpGet("Review/[action]")]

        public async Task<IActionResult> GetReviews()
        {
            var reviews = await context.reviewes.ToListAsync();
            if (reviews == null)
            {
                return NotFound(" User Review data do not exits in database");
            }
            return Ok(reviews);
        }


        //to delete the review by id

        [HttpDelete("Review/[action]/{id}")]
        public async Task<IActionResult> DeleteReviewById(int id)
        {
            var review = await context.reviewes.FindAsync(id);
            if (review == null)
            {
                return NotFound("Review Id does not exist");
            }

            context.reviewes.Remove(review);
            await context.SaveChangesAsync();
            return Ok("Review has been deleted successfully");
        }

        //  UserRegistration 


        //toget the user registration
        [HttpGet("UserRegister/[action]")]

        public async Task<IActionResult> GetUserRegistrationDetails()
        {
            var registrations = await context.signups.ToListAsync();
            if (registrations == null)
            {
                return NotFound("User registration data does not exist in the database");
            }
            return Ok(registrations);
        }




        //to get userregister details by name
        [HttpGet("UserRegister/[action]/{name}")]

        public async Task<IActionResult> GetUserRegistrationByName(string name)
        {
            var registration = await context.signups.FirstOrDefaultAsync(s => s.Name == name);
            if (registration == null)
            {
                return NotFound("User registration name is not valid. Enter a valid user name");
            }

            return Ok(registration);
        }



        //to delete registration by id
        [HttpDelete("UserRegister/[action]/{id}")]
        public async Task<IActionResult> DeleteUserRegistrationById(int id)
        {
            var registration = await context.signups.FindAsync(id);
            if (registration == null)
            {
                return NotFound("Registration ID does not exist");
            }

            context.signups.Remove(registration);
            await context.SaveChangesAsync();
            return Ok("Registration data deleted successfully");
        }
        
    }
}


