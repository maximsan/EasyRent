using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyRent.Data.Entities
{
    public class Ad
    {
        [Key]
        public int AdId { get; set; }

        [ForeignKey("UserId")]
        public int OwnerId { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [MaxLength(100)]
        public string Location { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public int Available { get; set; }

        public DateTime CreatedDate { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        public virtual ICollection<Image> Images { get; set; }
        public virtual User Owner { get; set; }
        public virtual ICollection<AdComment> AdComments { get; set; }
        public virtual ICollection<RentedAd> RentedAds { get; set; }
        public virtual ICollection<RentHistory> RentHistories { get; set; }
    }
}