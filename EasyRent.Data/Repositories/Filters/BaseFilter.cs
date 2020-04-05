namespace EasyRent.Data.Repositories.Filters
{
    public class BaseFilter
    {
        public int PageSize { get; set; }
        public int Page { get; set; }
        public string SortExpression { get; set; }
    }
}