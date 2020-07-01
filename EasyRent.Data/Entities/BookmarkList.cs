using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyRent.Data.Entities
{
    public class BookmarkList
    {
        public int BookmarkListId { get; set; }

        [ForeignKey("Id")]
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<BookmarkAd> BookmarkAds { get; set; }
    }
}
