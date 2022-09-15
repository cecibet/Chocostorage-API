using ChocoStorageAPI.Entities;
using ChocoStorageAPI.Models;
using ChocoStorageAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ChocoStorageAPI.Controllers
{
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IAuthenticationServices _customAuthenticationService;

        public AuthenticationController(IConfiguration config, IAuthenticationServices autenticacionService)
        {
            _config = config; //Hacemos la inyección para poder usar el appsettings.json
            this._customAuthenticationService = autenticacionService;
        }

        [HttpPost("authenticate")] 
        public ActionResult<string> Autenticar(AuthenticationRequestBody authenticationRequestBody)
        {
            var user = ValidateCredentials(authenticationRequestBody);

            if (user is null)
                return Unauthorized();

            var securityPassword = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_config["Authentication:SecretForKey"])); //Traemos la SecretKey del Json. agregar antes: using Microsoft.IdentityModel.Tokens;

            var credentials = new SigningCredentials(securityPassword, SecurityAlgorithms.HmacSha256);

            var claimsForToken = new List<Claim>();
            claimsForToken.Add(new Claim("sub", user.Id.ToString()));
            claimsForToken.Add(new Claim("given_name", user.Name));
            claimsForToken.Add(new Claim("family_name", user.SurName));
            claimsForToken.Add(new Claim("role", user.Role.ToString()));

            var jwtSecurityToken = new JwtSecurityToken(
              _config["Authentication:Issuer"],
              _config["Authentication:Audience"],
              claimsForToken,
              DateTime.UtcNow,
              DateTime.UtcNow.AddHours(1),
              credentials);

            var tokenToReturn = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);

            return Ok(tokenToReturn);
        }

        private User? ValidateCredentials(AuthenticationRequestBody authParams)
        {
            return _customAuthenticationService.ValidateUser(authParams);
        }
    }
}