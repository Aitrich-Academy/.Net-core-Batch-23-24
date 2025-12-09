using AutoMapper;
using WebApi_Login.DTOs;
using WebApi_Login.Models;
using WebApi_Login.Repositories;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;


namespace WebApi_Login.Services
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public UserService(IUserRepository repository, IMapper mapper, IConfiguration configuration)
        {
            _repository = repository;
            _mapper = mapper;
            _configuration = configuration;
        }

        public string Register(UserRegisterDto userDto)
        {
            if (_repository.UserExists(userDto.Username))
                return "Username already exists";

            var user = _mapper.Map<User>(userDto);
            _repository.Register(user);
            _repository.Save();

            return "Registration successful";
        }

        public object Login(UserLoginDto loginDto)
        {
            var user = _repository.Login(loginDto.Username, loginDto.Password);
            if (user == null)
                return "Invalid username or password";

            // Generate token
            var claims = new[]
            {
        new Claim(ClaimTypes.Name, user.Username)
    };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
