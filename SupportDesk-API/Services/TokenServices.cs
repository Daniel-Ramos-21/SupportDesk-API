using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.IdentityModel.Tokens;
using SupportDesk_API.Data;
using SupportDesk_API.Models;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SupportDesk_API.Services
{
    public class TokenServices
    {
     
        private readonly IConfiguration _config;

        //Constructo de la clase 
        public TokenServices(IConfiguration config)
        {
            _config = config;
        }

        public string GenerarToken(User user)
        {
            //Obtiene la configuracion del appseting.json
            var jwtSetion = _config.GetSection("Jwt");
            //crea la clave simetrica a partir del string "Key" combertido a bytes
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSetion["Key"]!));
            //Credenciales de firma combina la clave con la firma del algoritmo 
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            //la lista de afirmaciones que iran dentro del Token 
            var claims = new List<Claim>
            {
                new(JwtRegisteredClaimNames.Sub, user.Id.ToString()), //identificador del usuario
                new(JwtRegisteredClaimNames.Email, user.Email), // email del usuario
                new(ClaimTypes.Name, user.Name), //nombre del usuario
                new(ClaimTypes.Role, user.Role.ToString())  // rol del usuario
            };

            //Construye el Token Jwt con toda la informacion de los claims
            var Token = new JwtSecurityToken(
                issuer: jwtSetion["issuer"], //  issuer que seria el que emite el token
                audience: jwtSetion["Audencie"], // quien puede consumir el token 
                claims: claims,     //los datos del usuerio
                expires: DateTime.UtcNow.AddHours(8), // el tiempo de expiracion del token 
                signingCredentials: creds //la firma que garantiza que no fue alterado
                );

            //Convierte el objeto JwtSecurityToken a un string serializado (el token final)
            return new JwtSecurityTokenHandler().WriteToken(Token);
        }
    }
}
