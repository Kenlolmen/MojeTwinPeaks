using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MojeTwinPeaks.Models;

namespace MojeTwinPeaks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EpisodeController : ControllerBase
    {
        private readonly EpisodeContext _context;

        public EpisodeController(EpisodeContext context)
        {
            _context = context;
        }

        // GET: api/Episodes
        [HttpGet]
        public async Task<IActionResult> GetAllEpisodes()
        {
            var episodes = await _context.Episodes.ToListAsync();
            return Ok(episodes);
        }

        // GET: api/Episodes/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEpisodesById(int id)
        {
            var episode = await _context.Episodes.FirstOrDefaultAsync(m => m.ID == id);
            if (episode == null)
            {
                return NotFound();
            }

            return Ok(episode);
        }
    }

}
