namespace EasyRent.Data.Entities
{
    public class BookmarkAdBookmarkList
    {
        public int BookmarkAdBookmarkListId { get; set; }

        public int BookmarkListId { get; set; }
        public int BookmarkAdId { get; set; }
        public virtual BookmarkList BookmarkList { get; set; }
        public virtual BookmarkAd BookmarkAd { get; set; }
    }
}
