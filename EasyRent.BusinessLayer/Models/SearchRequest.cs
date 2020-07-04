using System.Linq;
using EasyRent.Common.Extensions;

namespace EasyRent.BusinessLayer.Models
{
    public abstract class SearchRequest
    {
        private readonly string[] orderDirections = new string[]
        {
            "ASC",
            "DESC"
        };

        private string sortExpression;

        public int PageSize { get; set; } = 0;
        public int Page { get; set; } = 20;
        public string SortExpression
        {
            get => sortExpression;
            set => sortExpression = CheckSortExpression(value);
        }

        private string CheckSortExpression(string sortExpression)
        {
            if (sortExpression.IsNullOrWhiteSpace())
            {
                return null;
            }

            var sortExpressionParts = sortExpression.Split(' ');
            var thisType = GetType();

            if (!orderDirections.Contains(sortExpressionParts[1].ToUpper()) // check order direction
                || !thisType.GetProperties().Select(q => q.Name.ToUpper()).Contains(sortExpressionParts[0].ToUpper())) // check all props by reflection 
            {
                return null;
            }

            return sortExpression;
        }
    }
}