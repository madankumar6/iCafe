using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using iCafe.DAL;
using System.Linq.Expressions;

namespace iCafe.Repositories.Interfaces.Concrete
{
    public class iCafeRepository<T> : IRepository<T> where T : class
    {
        public iCafeEntities iCafeEntitiesContext { get; set; }
        public DbSet<T> DbSet { get; set; }


        public iCafeRepository(iCafeEntities iCafeEntitiesContext)
        {
            this.iCafeEntitiesContext = iCafeEntitiesContext;
            this.DbSet = this.iCafeEntitiesContext.Set<T>();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return DbSet;
        }

        public virtual IEnumerable<T> Get(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> query = DbSet;

            if (filter != null)
            {
                query.Where(filter);
            }
            return query.ToList();
        }

        public virtual T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public virtual void Add(T entity)
        {
            //DbEntityEntry entityEntry = iCafeEntitiesContext.Entry<T>(entity);

            //if (entityEntry.State == EntityState.Detached)
            //{
            //    entityEntry.State = EntityState.Added;
            //}
            //else
            //{
                DbSet.Add(entity);
            //}
        }

        public virtual void Update(T entity)
        {
            DbEntityEntry dbEntityEntry = iCafeEntitiesContext.Entry(entity);
            if (dbEntityEntry.State == EntityState.Detached)
            {
                DbSet.Attach(entity);
            }
            dbEntityEntry.State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            if (iCafeEntitiesContext.Entry(entity).State == EntityState.Detached)
            {
                DbSet.Attach(entity);
            }
            DbSet.Remove(entity);
        }

        public void Delete(int id)
        {
            T entityToDelete = DbSet.Find(id);
            Delete(entityToDelete);
        }
    }
}
