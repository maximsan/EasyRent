using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyRent.Data.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        public ICollection<CategorySubcategory> CategorySubcategories { get; set; }
    }
}
