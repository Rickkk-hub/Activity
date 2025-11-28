using Domain.Entities;
using Infrastructure.Interfaces;

namespace Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users = new();

        public User? GetByEmail(string email)
        => _users.FirstOrDefault(u => u.Email == email);
        public User? Add(User user)
        {
            _users.Add(user);
                return user;
        }
    }
}