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
    public class SeasonController : ControllerBase
    {
        private readonly SeasonContext _context;

        public SeasonController(SeasonContext context)
        {
            _context = context;
        }

        // GET: api/Season
        [HttpGet]
        public async Task<IActionResult> GetAllSeasons()
        {
            var seasons = await _context.Seasons.ToListAsync();
            return Ok(seasons);
        }

        // GET: api/Season/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSeasonById(int id)
        {
            var seasons = await _context.Seasons.FirstOrDefaultAsync(m => m.ID == id);
            if (seasons == null)
            {
                return NotFound();
            }

            return Ok(seasons);
        }
    }

}
