using EasyRent.Data.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyRent.Data.Entities
{
    public class RentedAd
    {
        [Key]
        public int RentedAdId { get; set; }

        [ForeignKey("UserId")]
        public int RentedAdUserId { get; set; }

        [ForeignKey("AdId")]
        public int AdId { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public RentStatuses Status { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public virtual User RentedAdUser { get; set; }

        public virtual Ad Ad { get; set; }
    }
}