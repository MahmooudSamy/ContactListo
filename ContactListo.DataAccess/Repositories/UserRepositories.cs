using ContactListo.DataAccess.Extentions;
using ContactListo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListo.DataAccess.Repositories
{
    public class UserRepositories : IUserRepositories
    {

        private List<UserModel> usersList = new()
        {
           new  UserModel {UserId=1,UserName="user1",Password="user1".Sha256()}
        };
        public async Task<UserModel> GetByUsernameAndPassword(string username, string password)
        {
            var user = await Task.FromResult(usersList.SingleOrDefault
                (u => u.UserName == username && u.Password == password.Sha256()));
            return user;
        }
    }
}
