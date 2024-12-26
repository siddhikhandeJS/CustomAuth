using CustomAuth.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using CustomAuth.Entities;
using Microsoft.AspNetCore.Authentication;

namespace CustomAuth.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly string _jwtKey;

        public AccountController(AppDbContext context, IConfiguration configuration)
        {
            _context = context;
            _jwtKey = configuration["JwtSettings:SecretKey"];
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = _context.Users.SingleOrDefault(u => u.Email == email && u.Password == password);
            if (user == null)
            {
                return Unauthorized("Invalid credentials");
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtKey);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                new Claim(ClaimTypes.Name, user.Email)
            }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return Ok(new { Token = tokenHandler.WriteToken(token) });
        }

        [HttpPost]
        public IActionResult Signup(string email, string password)
        {
            if (_context.Users.Any(u => u.Email == email))
            {
                return BadRequest("User already exists");
            }

            var user = new User { Email = email, Password = password };
            _context.Users.Add(user);
            _context.SaveChanges();

            return Ok("Signup successful");
        }

        [HttpPost]
        public IActionResult ForgotPassword(string email)
        {
            var user = _context.Users.SingleOrDefault(u => u.Email == email);
            if (user == null)
            {
                return BadRequest("User not found");
            }

            // Simulate sending a password reset email
            return Ok("Password reset instructions sent to email");
        }

        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Auth");
        }


    }
}
