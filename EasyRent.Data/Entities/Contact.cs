using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyRent.Data.Entities
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<UserContact> UserContacts { get; set; }
    }
}
