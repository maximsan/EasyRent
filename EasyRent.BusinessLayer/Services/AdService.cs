using AutoMapper;
using EasyRent.BusinessLayer.Interfaces;
using EasyRent.BusinessLayer.Models.AdModels;
using EasyRent.Data.Entities;
using EasyRent.Data.Interfaces;
using EasyRent.Data.Repositories.Filters;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyRent.BusinessLayer.Services
{
    public class AdService : BaseService, IAdService
    {
        public AdService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<AdModel> GetByIdAsync(int id)
        {
            if (id <= 0)
            {
                return default;
            }

            var entity = await _unitOfWork.AdRepository.GetByIdAsync(id);
            var model = _mapper.Map<AdModel>(entity);

            return model;
        }

        public async Task<List<AdModel>> SearchAsync(AdRequest request)
        {
            if (request is null)
            {
                return new List<AdModel>(0);
            }

            var filter = _mapper.Map<AdFilter>(request);
            var foundAds = _unitOfWork.AdRepository.Search(filter);
            var result = await _mapper.ProjectTo<AdModel>(foundAds).ToListAsync().ConfigureAwait(false);

            return result;
        }

        public async Task<AdModel> CreateAsync(AdModel model)
        {
            if (model is null)
            {
                return default;
            }

            var adEntity = _mapper.Map<Ad>(model);

            await _unitOfWork.AdRepository.CreateAsync(adEntity);
            await _unitOfWork.AddressRepository.SaveAsync().ConfigureAwait(false);

            var result = _mapper.Map<AdModel>(adEntity);

            return result;
        }

        public async Task UpdateAsync(AdModel model)
        {
            if (model is null || model.AdId <= 0)
            {
                return;
            }

            var adEntity = await _unitOfWork.AdRepository.GetByIdAsync(model.AdId).ConfigureAwait(false);

            _mapper.Map(model, adEntity, model.GetType(), adEntity.GetType());

            _unitOfWork.AdRepository.Update(adEntity);
            await _unitOfWork.AdRepository.SaveAsync().ConfigureAwait(false);
        }

        public async Task DeleteAsync(int id)
        {
            if (id == 0)
            {
                return;
            }

            var entity = await _unitOfWork.AdRepository.GetByIdAsync(id).ConfigureAwait(false);

            _unitOfWork.AdRepository.Delete(entity);
            await _unitOfWork.AdRepository.SaveAsync().ConfigureAwait(false);
        }
    }
}