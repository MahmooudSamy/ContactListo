using ContactListo.DataAccess.DTO;

namespace ContactListo.ViewModel
{
    public class ContactListViewModel
    {
        public IEnumerable<ContactDto> Contacts { get; set; }
    }
}
