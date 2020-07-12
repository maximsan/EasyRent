using System.ComponentModel.DataAnnotations;

namespace EasyRent.Data.Entities
{
    public class BookmarkAd
    {
        [Key]
        public int BookmarkAdId { get; set; }
        public int AdId { get; set; }
        public int BookmarkListId { get; set; }
        public virtual Ad Ad { get; set; }
        public virtual BookmarkList BookmarkList { get; set; }
    }
}