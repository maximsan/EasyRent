using System.ComponentModel.DataAnnotations;

namespace EasyRent.Data.Entities
{
    public class CategorySubcategory
    {
        [Key]
        public int CategorySubcategoryId { get; set; }

        public int CategoryId { get; set; }
        public int SubcategoryId { get; set; }
        public Category Category { get; set; }
        public Subcategory Subcategory { get; set; }
    }
}
