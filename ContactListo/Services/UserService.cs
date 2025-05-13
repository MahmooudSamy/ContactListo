using ContactListo.DataAccess.DTO;
using ContactListo.DataAccess.Repositories;

namespace ContactListo.Services
{
    public class UserService : IUserService
    {
        private IUserRepositories _userRepositories;

        public UserService(IUserRepositories userRepositories)
        {
            _userRepositories = userRepositories;
        }
        public Task<UserDto> GetUserByUsernameAndPassword(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
