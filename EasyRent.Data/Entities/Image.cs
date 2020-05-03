using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyRent.Data.Entities
{
    public class Image
    {
        [Key]
        public int ImageId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Url { get; set; }

        public virtual ICollection<AdImage> AdImages { get; set; }
    }
}
