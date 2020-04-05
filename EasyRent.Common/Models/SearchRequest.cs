using System.Linq;
using EasyRent.Common.Extentions;

namespace EasyRent.Common.Models
{
    public abstract class SearchRequest
    {
        private readonly string[] orderDirections = new string[]
        {
            "ASC",
            "DESC"
        };

        private string sortExpression;

        public int? PageSize { get; set; }
        public int? Page { get; set; }
        public string SortExpression
        {
            get => sortExpression;
            set => sortExpression = CheckSortExpression(value);
        }

        protected SearchRequest()
        {
            SetSearchRequestFieldOnEmpty();
        }

        /// <summary>
        /// Set default values for page and pagesize if they are null.
        /// </summary>
        private void SetSearchRequestFieldOnEmpty()
        {
            if(!PageSize.HasValue)
            {
                PageSize = 20;
            }

            if(!Page.HasValue)
            {
                Page = 0;
            }
        }

        private string CheckSortExpression(string sortExpression)
        {
            if(sortExpression.IsNullOrWhiteSpace())
            {
                return null;
            }

            var sortExpressionParts = sortExpression.Split(' ');
            var thisType = GetType();

            if(!orderDirections.Contains(sortExpressionParts[1].ToUpper()) // check order direction
                || !thisType.GetProperties().Select(q => q.Name.ToUpper()).Contains(sortExpressionParts[0].ToUpper())) // check all props by reflection 
            {
                return null;
            }

            return sortExpression;
        }
    }
}