using ContactListo.DataAccess.DTO;
using ContactListo.Utilities;

namespace ContactListo.ViewModel
{
    public class ContactListViewModel
    {
        public IEnumerable<ContactDto> Contacts { get; set; }

      public  PagedList<ContactDto> ContactPagenation { get; set; }
        public int PageIndex { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
    }
}
