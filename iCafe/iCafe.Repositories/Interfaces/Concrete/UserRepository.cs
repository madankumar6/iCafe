using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iCafe.Core;
using iCafe.Models;
using iCafe.DAL;
using iCafe.Core.Interfaces;
using iCafe.Core.Interfaces.Concrete;

namespace iCafe.Repositories.Interfaces.Concrete
{
    class UserRepository : iCafeRepository<User>, IUserRepository
    {
        IPassword passwordService = new Password();

        public UserRepository(iCafeEntities iCafeEntitiesContext) : base(iCafeEntitiesContext)
        {

        }
    
        public bool  isValidUser(string username, string password)
        {
            var user = base.Get(u => u.Username == username && u.Password == passwordService.CreateHashingPasssword(password)).First();

            if (user != null)
            {
                return true;
            }
            
            return false;
        }
    }
}
