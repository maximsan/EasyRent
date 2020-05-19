using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EasyRent.Data.Repositories
{
    public abstract class BaseRepository<TEntity> : IDisposable where TEntity : class
    {
        protected readonly ApplicationDbContext Context;
        protected DbSet<TEntity> CurrentSet;

        protected BaseRepository(ApplicationDbContext context)
        {
            Context = context;
            CurrentSet = context.Set<TEntity>();
        }

        public virtual void Create(TEntity entity) => CurrentSet.Add(entity);

        public virtual void Delete(TEntity entity) => CurrentSet.Remove(entity);

        public virtual IQueryable<TEntity> GetAll() => CurrentSet.AsNoTracking();

        public virtual TEntity GetById(int id) => CurrentSet.Find(id);

        public virtual async Task<TEntity> GetByIdAsync(int id) => await CurrentSet.FindAsync(id).ConfigureAwait(false);

        public virtual void Save() => Context.SaveChanges();

        public virtual async Task SaveAsync() => await Context.SaveChangesAsync();

        public virtual void Update(TEntity entity) => Context.Entry(entity).State = EntityState.Modified;

        #region Disposable

        private bool disposed;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
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

        #endregion Disposable
    }
}