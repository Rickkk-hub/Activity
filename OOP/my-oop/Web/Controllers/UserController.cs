using Application.Services;
using Domain.DTO;

namespace Web.Controllers
{
    public class UserController
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("\n---Menu---");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");

               int choice = int.Parse(Console.ReadLine() ?? "");
            
               switch (choice)
                {
                    case 1:
                    Register();
                    break;

                    case 2:
                    Login();
                    break;
                    
                    case 3:
                    Console.WriteLine("Exit Successfully!");
                    return;

                }
            }
        }

        public void Register()
        {
            Console.WriteLine("FullName: ");
            string FullName = Console.ReadLine() ?? "";

            Console.WriteLine("Email: ");
            string Email = Console.ReadLine() ?? "";

            Console.WriteLine("Password: ");
            string Password = Console.ReadLine() ?? "";

            Console.WriteLine("ConfirmPassword: ");
            string ConfirmPassword = Console.ReadLine() ?? "";

            var register = new RegisterDTo
            {  
                FullName = FullName,
                Email = Email,
                Password = Password,   
                ConfirmPassword = ConfirmPassword 
            };

            _userService.Register(register);
        }

        public void Login()
        {
             Console.WriteLine("Email: ");
            string Email = Console.ReadLine() ?? "";

            Console.WriteLine("Password: ");
            string Password = Console.ReadLine() ?? "";

            var login = new LoginDTo
            {
                Email= Email,
                Password = Password
            };

            _userService.Login(login);
        }
    }
}