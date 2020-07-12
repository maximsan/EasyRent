using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyRent.Data.Entities
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        public virtual ICollection<Subcategory> Subcategories { get; set; }
    }
}
