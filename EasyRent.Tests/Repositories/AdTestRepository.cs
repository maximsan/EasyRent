using EasyRent.Data.Entities;
using EasyRent.Data.Interfaces;
using EasyRent.Data.Repositories.Filters;
using EasyRent.Tests.Helpers.DataHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyRent.Tests.Repositories
{
    public class AdTestRepository : IAdRepository
    {
        public void Create(Ad entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Ad entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Ad> GetAll()
        {
            throw new NotImplementedException();
        }

        public Ad GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Ad> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Ad> Search(AdFilter filter)
        {
            return AdHelper.Search(filter);
        }

        public void Update(Ad entity)
        {
            throw new NotImplementedException();
        }
    }
}
