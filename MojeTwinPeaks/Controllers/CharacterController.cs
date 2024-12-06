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
    public class CharacterController : ControllerBase
    {
        private readonly CharacterContext _context;

        public CharacterController(CharacterContext context)
        {
            _context = context;
        }

        // GET: api/character
        [HttpGet]
        public async Task<IActionResult> GetAllCharacters()
        {
            var characters = await _context.Characters.ToListAsync();
            return Ok(characters);
        }

        // GET: api/character/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCharactersId(int id)
        {
            var character = await _context.Characters.FirstOrDefaultAsync(m => m.ID == id);
            if (character == null)
            {
                return NotFound();
            }

            return Ok(character);
        }
    }
}
