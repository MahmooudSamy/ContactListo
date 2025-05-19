using AutoMapper;
using ContactListo.DataAccess.DTO;
using ContactListo.DataAccess.Repositories;
using ContactListo.Domain;

namespace ContactListo.Services
{
    public class UserService : IUserService
    {
        private IUserRepositories _userRepositories;
        private IMapper _mapper;

        public UserService(IUserRepositories userRepositories,IMapper mapper)
        {
            _userRepositories = userRepositories;
            _mapper = mapper;
        }
        public async Task<UserDto> GetUserByUsernameAndPassword(string username, string password)
        {
           
         var user=  await _userRepositories.GetByUsernameAndPassword(username,password);
            return _mapper.Map<UserDto>(user);
        }
    }
}
