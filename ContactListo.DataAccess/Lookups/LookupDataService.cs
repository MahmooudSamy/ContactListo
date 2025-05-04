using ContactListo.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListo.DataAccess.Lookups
{
    public class LookupDataService : IContactLookupData
    {
        private Func<AppDbContext> _context;

        public LookupDataService(Func<AppDbContext> appDbContext)
        {
            _context = appDbContext;
        }
        public async Task<IEnumerable<Contact>> GetAllCatact()
        {
            using (var context = _context())
            {
                return await context.Contacts.AsNoTracking().ToListAsync();
            }
        }

     
    }
}
