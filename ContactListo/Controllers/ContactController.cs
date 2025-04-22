using AutoMapper;
using ContactListo.DataAccess.DTO;
using ContactListo.DataAccess.Lookups;
using ContactListo.Services;
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
        public async Task<IActionResult> Index()
        {
            var contactDtos = await _contactService.GetAllContactsAsync(); 
            var model = new ContactListViewModel
            {
                Contacts = contactDtos 
            };
            return View(model);
        }
    }
}
