using ContactListo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListo.DataAccess.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private AppDbContext _context;

        public ContactRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public void Add(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Task<Contact> GetContactByAddress(int address)
        {
            throw new NotImplementedException();
        }

        public Task<Contact> GetContactByName(string contactName)
        {
            throw new NotImplementedException();
        }

        public Task<Contact> GetContactByPhone(int phone)
        {
            throw new NotImplementedException();
        }

        public void Remove(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
