using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iCafe.Models;

namespace iCafe.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        bool isValidUser(string username, string password);
    }
}
