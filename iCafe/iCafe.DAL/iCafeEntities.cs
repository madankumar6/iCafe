using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iCafe.Models;
using System.Data.Entity;
using System.Data.Entity.Core;

namespace iCafe.DAL
{
    public class iCafeEntities : DbContext
    {
        public iCafeEntities() : base("name=iCafeConnection")
        {
            Database.SetInitializer<iCafeEntities>(new CreateDatabaseIfNotExists<iCafeEntities>());
        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Login> Logins { get; set; }
    }
}
