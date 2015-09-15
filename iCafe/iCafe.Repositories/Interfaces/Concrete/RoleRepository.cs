using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iCafe.Models;
using iCafe.DAL;

namespace iCafe.Repositories.Interfaces.Concrete
{
    public class RoleRepository : iCafeRepository<Role>, IRoleRepository
    {
        public RoleRepository(iCafeEntities iCafeEntitiesContext) : base(iCafeEntitiesContext)
        {

        }
        public Role GetRoleByGuid(Guid roleGuid)
        {
            return base.DbSet.First(r => r.RoleId == roleGuid);
        }

        public Role GetRoleByName(string roleName)
        {
            return base.DbSet.First(r => r.Name.Equals(roleName, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
