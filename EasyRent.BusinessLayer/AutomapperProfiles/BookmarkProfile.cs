using AutoMapper;
using EasyRent.BusinessLayer.Models.UserModels;
using EasyRent.Data.Entities;

namespace EasyRent.BusinessLayer.AutomapperProfiles
{
    public class BookmarkProfile : Profile
    {
        public BookmarkProfile()
        {
            CreateMap<BookmarkList, BookmarkListModel>();
            CreateMap<Ad, BookmarkModel>();
            CreateMap<BookmarkAd, BookmarkModel>()
                .ForMember(q => q, q => q.MapFrom(w => w.Ad));
        }
    }
}