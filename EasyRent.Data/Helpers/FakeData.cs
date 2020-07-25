using Bogus;
using EasyRent.Data.Entities;
using System;
using System.Collections.Generic;

namespace EasyRent.Data.Helpers
{
    public static class FakeData
    {
        public const int MaxAds = 100;
        public const int MaxUsers = 2;

        public static IEnumerable<Ad> GetFakeAds()
        {
            var adFaker = new Faker<Ad>();

            var adId = 1;
            adFaker.RuleFor(q => q.AdId, q => adId++)
                .RuleFor(q => q.Description, q => q.Lorem.Paragraph())
                .RuleFor(q => q.Location, q => q.Address.City())
                .RuleFor(q => q.Price, q => decimal.Parse(q.Commerce.Price()))
                .RuleFor(q => q.Title, q => q.Commerce.ProductName())
                .RuleFor(q => q.CreatedDate, q => q.Date.Between(new DateTime(2015, 1, 1), DateTime.Now))
                .RuleFor(q => q.Available, q => q.Random.Int(0, 10))
                .RuleFor(q => q.OwnerId, q => q.Random.Int(1, 2));

            return adFaker.GenerateLazy(MaxAds);
        }

        public static IEnumerable<User> GetFakeUsers()
        {
            var userFaker = new Faker<User>();

            var userId = 1;
            userFaker.RuleFor(q => q.Email, q => q.Person.Email)
                .RuleFor(q => q.EmailConfirmed, q => true)
                .RuleFor(q => q.FirstName, q => q.Person.FirstName)
                .RuleFor(q => q.FirstName, q => q.Person.LastName)
                .RuleFor(q => q.Id, q => userId++)
                .RuleFor(q => q.PhoneNumber, q => q.Person.Phone)
                .RuleFor(q => q.PhoneNumberConfirmed, q => true)
                .RuleFor(q => q.UserName, q => q.Person.UserName);

            return userFaker.GenerateLazy(MaxUsers);
        }
    }
}