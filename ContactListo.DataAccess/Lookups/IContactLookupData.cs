using ContactListo.DataAccess.DTO;
using ContactListo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListo.DataAccess.Lookups
{
    public interface IContactLookupData
    {
        Task<IEnumerable<Contact>> GetAllCatact();
       
    }
}
