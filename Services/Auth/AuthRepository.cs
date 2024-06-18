using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coupons2.Data;
using coupons2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using coupons2.Services.Auth;

namespace coupons2.Services.Auth
{
    public class AuthRepository : IAuthRepository
    {
        private readonly Coupons2Context  _context;
        private readonly JwtSettings _jwtSettings;

        public AuthRepository(Coupons2Context context, IOptions<JwtSettings> options)
        {
            _context = context;
            _jwtSettings = options.Value;

        }
        public string GenerateToken(MarketingUsers user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecurityKey));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()), 
                new Claim(JwtRegisteredClaimNames.Sub, user.Username),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                // new Claim(ClaimTypes.Role, user.Rol)
            };

            var token = new JwtSecurityToken(
                issuer: _jwtSettings.SecurityKey,
                audience: _jwtSettings.SecurityKey,
                claims: claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public IEnumerable<MarketingUsers> GetAll()
        {
            throw new NotImplementedException();
        }

        public MarketingUsers Login(string Username, string Password)
        {
             // Buscar el usuario en la base de datos por su usuario
            var user = _context.MarketingUser.FirstOrDefault(u => u.Username == Username);
            
            // Verificar si el usuario existe y la contraseña es correcta
            if (user != null &&  user.Password == Password)
            {
                //Si las credenciales son válidas, devolver el usuario autenticado
                return user;
            }
            else
            {
                // Si las credenciales son inválidas, devolver null
                return null;
            }
        }

        public void LogOutAsync()
        {
            throw new NotImplementedException();
        }
    }
}