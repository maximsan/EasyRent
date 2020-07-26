using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyRent.BusinessLayer.Models.AdModels
{
    public class AdModel
    {
        public int AdId { get; set; }

        public ICollection<ImageModel> Images { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [MaxLength(100)]
        public string Location { get; set; }

        public decimal Price { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        public int Available { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}