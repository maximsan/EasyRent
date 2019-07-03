using System.Collections.Generic;

namespace EasyRent.Data.Entities
{
    public class BookmarkAd
    {
        public int BookmarkAdId { get; set; }

        public int AdId { get; set; }
        public Ad Ad { get; set; }
        public ICollection<BookmarkAdBookmarkList> BookmarkAdBookmarkLists { get; set; }
    }
}
