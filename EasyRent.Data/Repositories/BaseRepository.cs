using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EasyRent.Data.Repositories
{
    public abstract class BaseRepository<TEntity> : IDisposable where TEntity : class
    {
        protected readonly ApplicationDbContext Context;
        protected DbSet<TEntity> CurrentSet;

        private bool disposed;

        protected BaseRepository(ApplicationDbContext context)
        {
            Context = context;
            CurrentSet = context.Set<TEntity>();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Create(TEntity entity)
        {
            CurrentSet.Add(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            CurrentSet.Remove(entity);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return CurrentSet.AsNoTracking();
        }

        public virtual TEntity GetById(int id)
        {
            return CurrentSet.Find(id);
        }

        public virtual void Save()
        {
            Context.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }

                disposed = true;
            }
        }
    }
}