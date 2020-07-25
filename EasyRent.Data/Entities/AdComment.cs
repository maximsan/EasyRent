using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyRent.Data.Entities
{
    public class AdComment
    {
        [Key]
        public int AdCommentId { get; set; }

        [ForeignKey("AdId")]
        public int AdId { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        public string Comment { get; set; }

        [Range(0, 5)]
        public int Rating { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual Ad Ad { get; set; }
        public virtual User User { get; set; }
    }
}