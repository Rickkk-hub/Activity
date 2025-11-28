using Domain.Entities;

namespace Infrastructure.Interfaces
{
    public interface IUserRepository
    {
        User? GetByEmail(string Email);
        User? Add(User user);
    }
}