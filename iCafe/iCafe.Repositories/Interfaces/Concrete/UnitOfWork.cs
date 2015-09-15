using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iCafe.Models;
using iCafe.DAL;
using iCafe.Repositories;

namespace iCafe.Repositories.Interfaces.Concrete
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private IUserRepository userRepository;
        private IRoleRepository roleRepository;

        private iCafeEntities iCafeEntitiesContext = new iCafeEntities();

        public IUserRepository UserRepository
        {
            get
            {
                if (this.userRepository == null)
                {
                    this.userRepository = new UserRepository(iCafeEntitiesContext);
                }
                return this.userRepository;
            }
        }

        public IRoleRepository RoleRepository
        {
            get
            {
                if (this.roleRepository == null)
                {
                    this.roleRepository = new RoleRepository(iCafeEntitiesContext);
                }
                return this.roleRepository;
            }
        }

        public void SaveChanges()
        {
            iCafeEntitiesContext.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    iCafeEntitiesContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        
    }
}
