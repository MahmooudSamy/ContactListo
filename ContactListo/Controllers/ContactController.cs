using AutoMapper;
using ContactListo.DataAccess.DTO;
using ContactListo.DataAccess.Lookups;
using ContactListo.Services;
using ContactListo.Utilities;
using ContactListo.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace ContactListo.Controllers
{
    public class ContactController : Controller
    {
       
        private IContactService _contactService;
        private IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index(int? pageNumber)
        {
            //var contactDtos = await _contactService.GetAllContactsAsync(); 
            //var model = new ContactListViewModel
            //{
            //    Contacts = contactDtos 
            //};
            int pageSize = 5;
            int page = pageNumber ?? 1;
            
            var contactDtos = await _contactService.GetContactsPagedAsync(page, pageSize);
            int totalContacts = await _contactService.GetAllContactCountAsunc();
            PagedList < ContactDto > pagenation = 
                new PagedList<ContactDto>(contactDtos.ToList(), totalContacts, page, pageSize);
            var model = new ContactListViewModel
            {
                Contacts = contactDtos,
                ContactPagenation=pagenation,
                PageIndex = page,
                TotalPages = (int)Math.Ceiling(totalContacts / (double)pageSize),
                HasPreviousPage = page > 1,
                HasNextPage = page < (int)Math.Ceiling(totalContacts / (double)pageSize)
     
            };

            return View(model);
        }
    }
}
