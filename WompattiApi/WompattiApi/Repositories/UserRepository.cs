using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WompattiApi.Models;

namespace WompattiApi.Repositories
{
    public class UserRepository : IUserRepository
    {
        public User CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public User DeleteUser(User user, long id)
        {
            throw new NotImplementedException();
        }

        public User ReadUser(long id)
        {
            throw new NotImplementedException();
        }

        public List<User> ReadUsers()
        {
            throw new NotImplementedException();
        }

        public List<User> ReadUsers(string searchUser)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(User user, long id)
        {
            throw new NotImplementedException();
        }
    }
}
