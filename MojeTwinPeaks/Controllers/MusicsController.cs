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
    public class MusicsController : ControllerBase  
    {
        private readonly MusicContext _context;

        public MusicsController(MusicContext context)
        {
            _context = context;
        }

        // GET: api/musics
        [HttpGet]
        public async Task<IActionResult> GetAllMusics()
        {
            var musics = await _context.MusicTable.ToListAsync();
            return Ok(musics);  
        }

        // GET: api/musics/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMusicById(int id)
        {
            var music = await _context.MusicTable.FirstOrDefaultAsync(m => m.ID == id);
            if (music == null)
            {
                return NotFound();
            }

            return Ok(music);  
        }
    }

}
