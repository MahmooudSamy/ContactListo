using AutoMapper;
using ContactListo.DataAccess.DTO;
using ContactListo.DataAccess.Lookups;

namespace ContactListo.Services
{
    public class ContactService:IContactService
    {
        private IContactLookupData _contactLookupData;
        private IMapper _mapper;

        public ContactService(IContactLookupData contactLookupData, IMapper mapper)
        {
            _contactLookupData = contactLookupData;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ContactDto>> GetAllContactsAsync()
        {
            var contact = await _contactLookupData.GetAllCatact();
            return _mapper.Map<IEnumerable<ContactDto>>(contact);
        }
    }
}
