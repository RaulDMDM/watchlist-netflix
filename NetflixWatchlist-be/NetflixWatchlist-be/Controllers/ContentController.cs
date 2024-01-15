using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetflixWatchlist_be.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetflixWatchlist_be.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentController : ControllerBase
    {
        private readonly netflix_watchlistContext _context;
        public ContentController(netflix_watchlistContext context)
        {
            _context = context;
        }

        // GET: api/<ContentController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var content = await _context.Contents.ToListAsync();
                return Ok(content);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
