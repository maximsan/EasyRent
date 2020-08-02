using EasyRent.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EasyRent.Data.Repositories
{
    public abstract class BaseRepository<TEntity> : IDisposable, IRepository<TEntity> where TEntity : class
    {
        protected readonly ApplicationDbContext Context;
        protected DbSet<TEntity> CurrentSet;

        protected BaseRepository(ApplicationDbContext context)
        {
            Context = context;
            CurrentSet = context.Set<TEntity>();
        }

        public virtual async Task CreateAsync(TEntity entity) => await CurrentSet.AddAsync(entity).ConfigureAwait(false);

        public virtual void Delete(TEntity entity) => CurrentSet.Remove(entity);

        public virtual IQueryable<TEntity> GetAll() => CurrentSet.AsNoTracking();

        public virtual async Task<TEntity> GetByIdAsync(int id) => await CurrentSet.FindAsync(id).ConfigureAwait(false);

        public virtual async Task SaveAsync() => await Context.SaveChangesAsync().ConfigureAwait(false);

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