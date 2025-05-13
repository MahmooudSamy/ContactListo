using ContactListo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListo.DataAccess.Repositories
{
    public  interface IUserRepositories
    {
        Task<UserModel> GetByUsernameAndPassword(string username, string password);
    }
}
