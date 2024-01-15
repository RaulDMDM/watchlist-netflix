using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetflixWatchlist_be;
using NetflixWatchlist_be.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetflixWatchlist_be.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly netflix_watchlistContext _context;
        public UserController(netflix_watchlistContext context)
        {
            _context = context;
        }

        [HttpGet("GetUserByName/{user_name}")]
        public async Task<IActionResult> GetUserByName(string user_name)
        {
            try
            {
                var user = await _context.Users.FindAsync(user_name);
                if (user == null)
                {
                    return NotFound();
                }
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }

}
