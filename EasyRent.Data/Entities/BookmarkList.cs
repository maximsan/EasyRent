using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyRent.Data.Entities
{
    public class BookmarkList
    {
        public int BookmarkListId { get; set; }

        [ForeignKey("Id")]
        public string UserId { get; set; }
        public User User { get; set; }
        public ICollection<BookmarkAdBookmarkList> BookmarkAdBookmarkLists { get; set; }
    }
}
