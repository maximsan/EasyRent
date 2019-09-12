using System;

namespace EasyRent.Server.Models
{
    public class ProductModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public int MaxDays { get; set; }
        public bool IsGift { get; set; }
    }
}
