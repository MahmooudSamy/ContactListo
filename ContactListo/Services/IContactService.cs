using ContactListo.DataAccess.DTO;

namespace ContactListo.Services
{
    public interface IContactService
    {
        Task<IEnumerable<ContactDto>> GetAllContactsAsync();
    }
}
