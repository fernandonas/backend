using Application.Models.UserModel;
using Domain.Entity;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;

namespace Application.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IList<UserResponseDTO>> GetUsers()
        {
            var users = _userRepository.GetAll();

            return await Task.FromResult(users.Select(u => new UserResponseDTO
            {
                Active = u.Active,
                CreatedAt = u.CreatedAt,
                UpdatedAt = u.UpdatedAt,
                Email = u.Email,
                Name = u.Name,
                Id = u.Id
            }).ToList());
        }

        public async Task<bool> AddUser(UserRequestDTO userRequest)
        {
            await _userRepository.Create(new User()
            {
                Active = userRequest.Active,
                CreatedAt = userRequest.CreatedAt,
                UpdatedAt = userRequest.UpdatedAt,
                Email = userRequest.Email,
                Name = userRequest.Name,
                Id = userRequest.Id
            });
            return true;
        }
    }
}
