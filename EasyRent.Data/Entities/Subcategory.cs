using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyRent.Data.Entities
{
    public class Subcategory
    {
        [Key]
        public int SubcategoryId { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}