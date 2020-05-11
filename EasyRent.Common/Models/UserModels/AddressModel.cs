using System.ComponentModel.DataAnnotations;

namespace EasyRent.Common.Models.UserModels
{
    public class AddressModel
    {
        public int AddressId { get; set; }

        [MaxLength(30)]
        public string Country { get; set; }

        [MaxLength(40)]
        public string City { get; set; }

        [MaxLength(200)]
        public string AdditionalInformation { get; set; }
    }
}