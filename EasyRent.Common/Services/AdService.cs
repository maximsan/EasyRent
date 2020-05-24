﻿using AutoMapper;
using EasyRent.Common.Models.AdModels;
using EasyRent.Data;
using EasyRent.Data.Entities;
using EasyRent.Data.Repositories.Filters;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyRent.Common.Services
{
    public class AdService : BaseService, IAdService
    {
        public AdService(UnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<List<AdViewModel>> Search(AdRequest request)
        {
            if(request is null)
            {
                return new List<AdViewModel>(0);
            }

            var filter = mapper.Map<AdFilter>(request);
            var foundAds = unitOfWork.AdRepository.Search(filter);
            var result = mapper.Map<List<AdViewModel>>(await foundAds.ToListAsync().ConfigureAwait(false));

            return result;
        }

        public async Task Create(AdModel model)
        {
            if(model is null)
            {
                return;
            }

            var adEntity = mapper.Map<Ad>(model);
            unitOfWork.AdRepository.Create(adEntity);
            await unitOfWork.AddressRepository.SaveAsync().ConfigureAwait(false);
        }

        public async Task Update(AdModel model)
        {
            if (model is null || model.AdId <= 0)
            {
                return;
            }

            var adEntity = await unitOfWork.AdRepository.GetByIdAsync(model.AdId).ConfigureAwait(false);

            mapper.Map(model, adEntity, model.GetType(), adEntity.GetType());

            unitOfWork.AdRepository.Update(adEntity);

            await unitOfWork.AdRepository.SaveAsync().ConfigureAwait(false);
        }

        public async Task Delete(int id)
        {
            if(id == 0)
            {
                return;
            }

            var entity = await unitOfWork.AdRepository.GetByIdAsync(id).ConfigureAwait(false);

            unitOfWork.AdRepository.Delete(entity);

            await unitOfWork.AdRepository.SaveAsync().ConfigureAwait(false);
        }
    }
}