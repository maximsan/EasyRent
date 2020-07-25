using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyRent.Data.Entities
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public virtual User User { get; set; }
    }
}