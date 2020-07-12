using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [ForeignKey("AdId")]
        public int AdId { get; set; }

        public virtual Ad Ad { get; set; }
    }
}
