using Domain.Entity;

namespace Application.Models.UserModel
{
    public class UserRequestDTO: BaseEntity
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
}
