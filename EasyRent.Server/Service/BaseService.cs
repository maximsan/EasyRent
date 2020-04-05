using AutoMapper;
using EasyRent.Data;

namespace EasyRent.Server.Services
{
    public abstract class BaseService
    {
        protected readonly UnitOfWork unitOfWork;
        protected readonly IMapper mapper;

        protected BaseService(UnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
    }
}