using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyRent.Data.Entities
{
    public class RentHistory
    {
        [Key]
        public int RentHistoryId { get; set; }

        [ForeignKey("UserId")]
        public int RentingUserId { get; set; }

        [ForeignKey("UserId")]
        public int AdOwnerId { get; set; }

        public int AdId { get; set; }

        public DateTime CreatedDate { get; set; }

        public string Description { get; set; }

        public virtual User RentingUser { get; set; }
        public virtual User AdOwner { get; set; }
        public virtual Ad Ad { get; set; }
    }
}