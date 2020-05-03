using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyRent.Data.Entities
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }

        [MaxLength(30)]
        public string Country { get; set; }

        [MaxLength(40)]
        public string City { get; set; }

        [MaxLength(200)]
        public string AdditionalInformation { get; set; }

        [ForeignKey("Id")]
        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
