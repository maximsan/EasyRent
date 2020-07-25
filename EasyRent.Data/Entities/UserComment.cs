using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyRent.Data.Entities
{
    public class UserComment
    {
        public int UserCommentId { get; set; }

        [ForeignKey("UserId")]
        public int PublisherId { get; set; }

        [ForeignKey("UserId")]
        public int OwnerId { get; set; }

        public string Comment { get; set; }

        [Range(0, 5)]
        public int Rating { get; set; }

        public virtual User Publisher { get; set; }
        public virtual User Owner { get; set; }
    }
}