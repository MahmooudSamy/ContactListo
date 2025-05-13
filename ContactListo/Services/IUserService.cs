using ContactListo.DataAccess.DTO;


namespace ContactListo.Services
{
    public interface IUserService
    {
        Task<UserDto> GetUserByUsernameAndPassword(string username, string password);


        
    }
}
