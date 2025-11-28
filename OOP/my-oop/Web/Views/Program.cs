using Application.Services;
using Infrastructure.Repository;
using Web.Controllers;

namespace Web.Views
{
    public class Program
    {
        public static void Main()
        {
            var userRepository = new UserRepository();
            var userService = new UserService(userRepository);
            var UserController = new UserController(userService);

            UserController.Menu();

        }
    }
}