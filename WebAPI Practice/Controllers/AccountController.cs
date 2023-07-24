using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;
using WebAPIDApp.Data;
using WebAPIDApp.DTO_s;
using WebAPIDApp.Entities;
using WebAPIDApp.Interfaces;

namespace WebAPIDApp.Controllers
{
    public class AccountController : BaseAPIController
    {
        private readonly DataContext _context;
        private readonly ITokenService _tokenService;

        public AccountController(DataContext context, ITokenService tokenService) 
        {
            _context = context;
            _tokenService = tokenService;
        }

        [HttpPost("register")]

        public async Task<ActionResult<UserDTO>> Register(RegisterDTO registerDTO)
        {
            if (await UserExists(registerDTO.Username))
            {
                return BadRequest("Username is taken");
            }
            using var hmac = new HMACSHA512();

            var user = new AppUser
            {
                UserName = registerDTO.Username,
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDTO.Password)),
                passwordSalt = hmac.Key
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return new UserDTO
            {
                Username = user.UserName,
                Token = _tokenService.CreateToken(user)
            };
        }

        [HttpPost("login")]

        public async Task<ActionResult<UserDTO>> Login(LoginDTO loginDTO)
        {
            var user = await _context.Users.SingleOrDefaultAsync(x => x.UserName == loginDTO.Username);
            if (user == null)
            {
                return Unauthorized("Invalid username");
            }
            using var hmac = new HMACSHA512(user.passwordSalt);
            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDTO.Password));

            for(int i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != user.passwordHash[i]) return Unauthorized("Invalid password");
            }

            return new UserDTO
            {
                Username = user.UserName,
                Token = _tokenService.CreateToken(user)
            };
        }

        private async Task<bool> UserExists(string username)
        {
            return await _context.Users.AnyAsync(x => x.UserName == username.ToLower());
        }
    }
}
