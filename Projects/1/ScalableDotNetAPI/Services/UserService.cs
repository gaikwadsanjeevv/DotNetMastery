using ScalableDotNetAPI.Models;

namespace ScalableDotNetAPI.Services
{
    public class UserService : IUserService
    {
        public User GetUser()
        {
            return new User { Id = 1, Username = "testuser" };
        }
    }
}
