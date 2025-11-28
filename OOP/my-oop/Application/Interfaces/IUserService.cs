using Domain.DTO;

namespace Application.Interfaces
{
    public interface IUserService
    {
        void Register(RegisterDTo registerDTo);
        void Login(LoginDTo loginDTo);
    }
}