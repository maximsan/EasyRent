using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyRent.Data.Entities
{
    public class UserContact
    {
        [Key]
        public int UserContactId { get; set; }

        [MaxLength(50)]
        public string ContactValue { get; set; }

        [ForeignKey("Id")]
        public string UserId { get; set; }
        public int ContactId { get; set; }
        public virtual User User { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
