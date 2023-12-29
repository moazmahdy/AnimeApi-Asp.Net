using AnimeApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnimeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimesController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public AnimesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAnimes()
        {
            var animes = await _context.Animes.ToListAsync();

            return Ok(animes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAnimeDataById(int id)
        {
            var anime = await _context.Animes.FindAsync(id);

            if (anime == null)
            {
                return NotFound();
            }

            return Ok(anime);
        }

        [HttpGet("GetByGenerID")]
        public async Task<IActionResult> GetAnimesByGenerId(int generId)
        {
            var anime = await _context.Animes.Where(a => a.GenersId == generId).ToListAsync();

            if (anime == null)
            {
                return NotFound();
            }

            return Ok(anime);
        }
    }
}
