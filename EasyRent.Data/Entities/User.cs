using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace EasyRent.Data.Entities
{
    public class User : IdentityUser<int>
    {
        public virtual Address Address { get; set; }

        [DefaultValue(null)]
        public int? AddressId { get; set; }

        [MaxLength(40)]
        public string FirstName { get; set; }

        [MaxLength(40)]
        public string LastName { get; set; }

        public virtual ICollection<UserAd> UserAds { get; set; }
        public virtual ICollection<UserContact> UserContacts { get; set; }
        public virtual BookmarkList BookmarkList { get; set; }
    }
}