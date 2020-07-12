using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyRent.Data.Entities
{
    public class Subcategory
    {
        [Key]
        public int SubcategoryId { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
