using ContactListo.DataAccess.DTO;


namespace ContactListo.Services
{
    public interface IContactService
    {
        Task<IEnumerable<ContactDto>> GetAllContactsAsync();
        Task<int> GetAllContactCountAsunc();
        Task<IEnumerable<ContactDto>> GetContactsPagedAsync(int? pageNumber, int pageSize);
    }
}
