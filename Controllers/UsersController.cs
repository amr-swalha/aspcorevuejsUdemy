using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Vue2Spa.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : BaseController
    {
        public UsersController(IConfiguration config) : base(config)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login([FromBody]LoginDTO loginInfo)
        {
            if (loginInfo.email == "user@site.com" && loginInfo.password == "123456")
            {
                var claims = new List<Claim>
                {
                    new Claim(JwtRegisteredClaimNames.Sub, loginInfo.email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(ClaimTypes.NameIdentifier, loginInfo.email)
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Key"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var expires = DateTime.Now.AddDays(Convert.ToDouble(1));

                var token = new JwtSecurityToken(
                    configuration["Issuer"],
                    configuration["Audience"],
                    claims,
                    expires: expires,
                    signingCredentials: creds
                );
                return Ok( await Task.FromResult(new JwtSecurityTokenHandler().WriteToken(token)));
            }

            return Unauthorized();
        }

        [HttpGet("[action]")]
        [Authorize]
        public IActionResult Test()
        {
            return Content("You successes");
        }
    }

    public class LoginDTO
    {
        public string email { get; set; }
        public string password { get; set; }
    }
}
