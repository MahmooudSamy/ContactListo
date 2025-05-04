using AutoMapper;
using ContactListo.DataAccess.DTO;
using ContactListo.DataAccess.Lookups;
using ContactListo.DataAccess.Repositories;

namespace ContactListo.Services
{
    public class ContactService:IContactService
    {
        private IContactLookupData _contactLookupData;
        private IContactRepository _contactRepository;
        private IMapper _mapper;

        public ContactService(IContactLookupData contactLookupData,IContactRepository contactRepository, IMapper mapper)
        {
            _contactLookupData = contactLookupData;
            _contactRepository = contactRepository;
            _mapper = mapper;
        }

        public async Task<int> GetAllContactCountAsunc()
        {
            return await _contactRepository.GetAllContactCountAsunc();
        }

        public async Task<IEnumerable<ContactDto>> GetAllContactsAsync()
        {
            var contact = await _contactLookupData.GetAllCatact();
            return _mapper.Map<IEnumerable<ContactDto>>(contact);
        }

        public async Task<IEnumerable<ContactDto>> GetContactsPagedAsync(int? pageNumber, int pageSize)
        {
            var contact = await _contactRepository.GetContactsPagedAsync(pageNumber, pageSize);
            return _mapper.Map<IEnumerable<ContactDto>>(contact);
        }
    }
}
