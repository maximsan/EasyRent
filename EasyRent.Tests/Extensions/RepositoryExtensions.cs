using EasyRent.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Threading;

namespace EasyRent.Tests.Extensions
{
    public static class RepositoryExtensions
    {
        public static void SetupCreate<TEntity>(this Mock<IRepository<TEntity>> mockedRepo, DbSet<TEntity> dbSet, TEntity entity) where TEntity : class
        {
            mockedRepo.Setup(q => q.CreateAsync(It.IsAny<TEntity>())).Callback((TEntity q, CancellationToken c) => dbSet.AddAsync(entity, default));
        }

        public static void SetupUpdate<TEntity>(this Mock<IRepository<TEntity>> mockedRepo, DbSet<TEntity> dbSet, TEntity entity) where TEntity : class
        {
            mockedRepo.Setup(q => q.Update(It.IsAny<TEntity>())).Callback((TEntity q) => { dbSet.Update(q); });
        }
    }
}