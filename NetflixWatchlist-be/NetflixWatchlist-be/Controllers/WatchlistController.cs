using Microsoft.AspNetCore.Mvc;
using NetflixWatchlist_be.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetflixWatchlist_be.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WatchlistController : ControllerBase
    {
        private readonly netflix_watchlistContext _context;
        public WatchlistController(netflix_watchlistContext context)
        {
            _context = context;
        }

        // GET: api/<WatchlistController>
        [HttpGet("GetListByUser/{user_name}")]
        public async Task<IActionResult> GetListByUser(string user_name)
        {
            try
            {
                var watchlist = await _context.Watchlists.FindAsync(user_name);
                if (watchlist == null)
                {
                    return NotFound();
                }
                return Ok(watchlist);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Watchlist watchlist)
        {
            try
            {
                _context.Watchlists.Add(watchlist);
                await _context.SaveChangesAsync();
                return Ok(new {message = "Lista registrada con exito"});

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
              
        }
    }
}
