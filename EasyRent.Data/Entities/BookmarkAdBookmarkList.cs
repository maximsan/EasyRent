namespace EasyRent.Data.Entities
{
    public class BookmarkAdBookmarkList
    {
        public int BookmarkAdBookmarkListId { get; set; }

        public int BookmarkListId { get; set; }
        public int BookmarkAdId { get; set; }
        public BookmarkList BookmarkList { get; set; }
        public BookmarkAd BookmarkAd { get; set; }
    }
}
