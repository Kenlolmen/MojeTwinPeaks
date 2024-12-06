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
    public class PlaceController : ControllerBase
    {
        private readonly PlaceContext _context;

        public PlaceController(PlaceContext context)
        {
            _context = context;
        }

        // GET: api/Place
        [HttpGet]
        public async Task<IActionResult> GetAllPlaces()
        {
            var place = await _context.Places.ToListAsync();
            return Ok(place);
        }

        // GET: api/Place/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPlaceById(int id)
        {
            var place = await _context.Places.FirstOrDefaultAsync(m => m.ID == id);
            if (place == null)
            {
                return NotFound();
            }

            return Ok(place);
        }
    }

}
