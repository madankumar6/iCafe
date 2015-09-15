using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iCafe.Models;

namespace iCafe.Repositories.Interfaces
{
    public interface IRoleRepository : IRepository<Role>
    {
        Role GetRoleByGuid(Guid roleGuid);
        Role GetRoleByName(string roleName);
    }
}
