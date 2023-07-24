using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIDApp.Data;
using WebAPIDApp.Entities;

namespace WebAPIDApp.Controllers
{
    public class UserController : BaseAPIController
    {
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]

        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        [Authorize]
        [HttpGet("{id}")]

        public async Task<ActionResult<AppUser>> GetOneUser(int id)
        {
            return await _context.Users.FindAsync(id);                      
        }
    }
}
