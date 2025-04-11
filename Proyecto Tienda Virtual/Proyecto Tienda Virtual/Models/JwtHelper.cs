using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Proyecto_Tienda_Virtual.Models
{
    public class JwtHelper
    {
       public string GetUserIdFromToken(HttpRequest request)
        {
            if (!request.Cookies.ContainsKey("UserToken"))
                return null;

            var token = request.Cookies["UserToken"];
            var handler = new JwtSecurityTokenHandler();
            var jwt = handler.ReadJwtToken(token);
            return jwt.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
        }
        public static string GenerateAnonymousToken()
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            byte[] key = new byte[32]; // 256 bits = 32 bytes
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(key);
            }

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                new Claim("UserId", Guid.NewGuid().ToString()),
                new Claim("IsAnonymous", "true")
            }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature
                )
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
