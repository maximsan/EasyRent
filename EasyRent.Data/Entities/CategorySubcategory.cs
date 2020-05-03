using System.ComponentModel.DataAnnotations;

namespace EasyRent.Data.Entities
{
    public class CategorySubcategory
    {
        [Key]
        public int CategorySubcategoryId { get; set; }

        public int CategoryId { get; set; }
        public int SubcategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Subcategory Subcategory { get; set; }
    }
}
