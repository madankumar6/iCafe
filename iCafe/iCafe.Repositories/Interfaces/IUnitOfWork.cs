using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iCafe.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        IRoleRepository RoleRepository { get; }
        void SaveChanges();
    }
}
