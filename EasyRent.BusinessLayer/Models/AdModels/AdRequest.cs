using EasyRent.BusinessLayer.Models;

namespace EasyRent.BusinessLayer.Models.AdModels
{
    public class AdRequest : SearchRequest
    {
        public int? AdId { get; set; }
    }
}