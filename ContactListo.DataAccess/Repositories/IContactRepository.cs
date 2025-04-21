using ContactListo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListo.DataAccess.Repositories
{
    public interface IContactRepository
    {
        Task<Contact> GetContactByName(string contactName);
        Task<Contact> GetContactByPhone(int phone);
        Task<Contact> GetContactByAddress(int address);
        void Add(Contact contact);
        void Remove(Contact contact);
        Task SaveAsync();
    }
}
