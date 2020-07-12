using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyRent.Data.Entities
{
    public class Ad
    {
        [Key]
        public int AdId { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public bool IsGift { get; set; }

        [MaxLength(100)]
        public string Location { get; set; }

        public int MaxDays { get; set; }
        public decimal Price { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<UserAd> UserAds { get; set; }
    }
}