using System.Collections.Generic;

namespace EasyRent.BusinessLayer.Models.CategoryModels
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public IEnumerable<SubcategoryModel> Subcategories { get; set; }
    }
}