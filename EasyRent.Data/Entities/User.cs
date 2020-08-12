using EasyRent.Data.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EasyRent.Data.Entities
{
    public class User : IdentityUser<int>
    {
        [DefaultValue(null)]
        public int? AddressId { get; set; }

        [MaxLength(40)]
        public string FirstName { get; set; }

        [MaxLength(40)]
        public string LastName { get; set; }

        [MaxLength(500)]
        public string AboutMe { get; set; }

        public SexTypes? Sex { get; set; }

        public DateTime? Birthday { get; set; }

        public ICollection<Ad> Ads { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual BookmarkList BookmarkList { get; set; }
        public virtual ICollection<UserComment> PublishedComments { get; set; }
        public virtual ICollection<UserComment> OwnedComments { get; set; }
        public virtual Address Address { get; set; }
    }
}