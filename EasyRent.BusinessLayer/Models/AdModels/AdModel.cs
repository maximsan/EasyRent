﻿using System.Collections.Generic;

namespace EasyRent.BusinessLayer.Models.AdModels
{
    public class AdModel
    {
        public int AdId { get; set; }
        public ICollection<ImageModel> Images { get; set; }
        public string Description { get; set; }
        public bool IsGift { get; set; }
        public string Location { get; set; }
        public int MaxDays { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }
    }
}