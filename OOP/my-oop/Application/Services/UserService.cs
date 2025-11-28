using Application.Interfaces;
using Domain.DTO;
using Domain.Entities;
using Infrastructure.Interfaces;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;

        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }

        public void Register(RegisterDTo registerDTo)
        {
            try
            {
                var exEmail = _repo.GetByEmail(registerDTo.Email);
                if (exEmail != null)
                    throw new Exception("Email is Already Taken!");

                if (!registerDTo.Email.Contains("@") || !registerDTo.Email.Contains("."))
                    throw new Exception("Invalid Email Format!");

                if (registerDTo.Password != registerDTo.ConfirmPassword)
                    throw new Exception("Password do not match!");

                var user = new User
                {
                    FullName = registerDTo.FullName,
                    Email = registerDTo.Email,
                    Password = registerDTo.Password,
                };
                
                _repo.Add(user);
                Console.WriteLine("Registration Successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Login(LoginDTo loginDTo)
        {
            try
            {
                var user = _repo.GetByEmail(loginDTo.Email);
                if (user == null)
                    throw new Exception("Invalid Email!");

                if(user.Password != loginDTo.Password)
                throw new Exception("Invalid Password!");


                Console.WriteLine("Login Successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}