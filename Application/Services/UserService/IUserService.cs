using Application.Models.UserModel;

namespace Application.Services.UserService
{
    public interface IUserService
    {
        Task<IList<UserResponseDTO>> GetUsers();
        Task<bool> AddUser(UserRequestDTO userRequest);
    }
}