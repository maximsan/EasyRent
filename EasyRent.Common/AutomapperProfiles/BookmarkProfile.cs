using AutoMapper;
using EasyRent.Common.Models.UserModels;
using EasyRent.Data.Entities;

namespace EasyRent.Common.AutomapperProfiles
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