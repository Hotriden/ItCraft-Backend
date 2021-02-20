using ItCraftTest.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItCraftTest.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController: Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly UserDbContext _context;

        public UserController(ILogger<UserController> logger, UserDbContext context)
        {
            _logger = logger;
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await _context.Users.OrderBy(a => a.Id).ToListAsync();
            var message = $"About page visited at {DateTime.UtcNow.ToLongTimeString()}";
            _logger.LogInformation(message);
            return users;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool TodoItemExists(long id) => _context.Users.Any(e => e.Id == id);
    }
}
