using System.ComponentModel.DataAnnotations;

namespace EasyRent.Data.Entities
{
    public class AdImage
    {
        [Key]
        public virtual Ad Ad { get; set; }
        public int AdId { get; set; }
        public int AdImageId { get; set; }
        public int ImageId { get; set; }
        public virtual Image Image { get; set; }
    }
}