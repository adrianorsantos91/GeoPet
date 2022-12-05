using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using GeoPet.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using GeoPet.Constants;

namespace GeoPet.Services
{
    public class TokenGenerator
    {
        public string Generate(Client client)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var tokenDescription = new SecurityTokenDescription()
            {
                SigningCredentials = new SecurityCredentials(
                    new SysmmetricSecurityKey(Encoding.ASCII.GetBytes(TokenConstants.Secret)),
                    SecurityAlgorithms.HmacSha256Signature
                ),
                Expires = DateTime.Now.AddDays(3)
            };

            var token = tokenHandler.CreateToken(tokenDescription);

            return tokenHandler.WriteToken(token);
        }
    }
    
}