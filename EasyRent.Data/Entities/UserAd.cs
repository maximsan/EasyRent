using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyRent.Data.Entities
{
    public class UserAd
    {
        [Key]
        public int UserAdId { get; set; }

        [ForeignKey("Id")]
        public string UserId { get; set; }
        public int AdId { get; set; }
        public User User { get; set; }
        public Ad Ad { get; set; }
    }
}
