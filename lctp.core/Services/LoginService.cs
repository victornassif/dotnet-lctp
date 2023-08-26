using lctp.libs.Interfaces;
using lctp.libs.Models;

namespace lctp.core.Services
{
    public class LoginService
    {
        private IBaseRepository<UserModel> _userRepository;
        public LoginService(IBaseRepository<UserModel> repository)
        {
            _userRepository = repository;
        }

        public async Task<UserModel> GetUser()
        {
            return new UserModel() { Id = 1, Name = "Victor Nassif", Password = "im-hungry-123", Role = "study" };
        }
    }
}
