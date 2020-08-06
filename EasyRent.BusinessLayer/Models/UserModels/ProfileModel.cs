using EasyRent.Data.Enums;
using System;

namespace EasyRent.BusinessLayer.Models.UserModels
{
    public class ProfileModel
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AboutMe { get; set; }
        public SexTypes? Sex { get; set; }
        public DateTime? Birthday { get; set; }

        public AddressModel Address { get; set; }
    }
}