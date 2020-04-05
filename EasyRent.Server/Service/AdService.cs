using AutoMapper;
using EasyRent.Common.Models.AdModels;
using EasyRent.Data;
using EasyRent.Data.Repositories.Filters;
using System.Collections.Generic;

namespace EasyRent.Server.Services
{
    public class AdService : BaseService
    {
        public AdService(UnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public List<AdViewModel> Search(AdRequest request)
        {
            var filter = mapper.Map<AdFilter>(request);
            var foundAds = unitOfWork.AdRepository.Search(filter);
            var result = mapper.Map<List<AdViewModel>>(foundAds);

            return result;
        }
    }
}