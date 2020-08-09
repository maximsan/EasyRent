using Bogus;
using EasyRent.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EasyRent.Data.Helpers
{
    public static class FakeData
    {
        public const int MaxAds = 100;
        public const int MaxUsers = 2;

        private static readonly Category[] SeedDataCategories = new Category[]
        {
            new Category { Name = "Одежда и аксессуары", CategoryId = 1 },
            new Category { Name = "Детские товары", CategoryId = 2 },
            new Category { Name = "Техника и электроника", CategoryId = 3 },
            new Category { Name = "Хобби и отдых", CategoryId = 4 },
            new Category { Name = "Свадьба и праздники", CategoryId = 5 },
            new Category { Name = "Автотовары", CategoryId = 6 },
            new Category { Name = "Сад и огород", CategoryId = 7 },
            new Category { Name = "Здоровье", CategoryId = 8 },
            new Category { Name = "Спорт, туризм и активный отдых", CategoryId = 9 },
            new Category { Name = "Ремонт и стройка", CategoryId = 10 },
            new Category { Name = "Другое", CategoryId = 11 }
        };

        private static readonly Subcategory[] SeedDataSubcategories = new Subcategory[]
        {
            new Subcategory { Name = "Мужская одежда", CategoryId = 1 },
            new Subcategory { Name = "Женская одежда", CategoryId = 1 },
            new Subcategory { Name = "Обувь", CategoryId = 1 },
            new Subcategory { Name = "Для мероприятий", CategoryId = 1 }, //??
            new Subcategory { Name = "Аксессуары", CategoryId = 1 },
            new Subcategory { Name = "Другое", CategoryId = 1 },

            new Subcategory { Name = "Одежда", CategoryId = 2 },
            new Subcategory { Name = "Обувь", CategoryId = 2 },
            new Subcategory { Name = "Игрушки", CategoryId = 2 },
            new Subcategory { Name = "Транспорт и коляски", CategoryId = 2 },
            new Subcategory { Name = "Другое", CategoryId = 2 },

            new Subcategory { Name = "Бытовая техника", CategoryId = 3 },
            new Subcategory { Name = "Телефоны, планшеты, гаджеты", CategoryId = 3 },
            new Subcategory { Name = "Компьютерная техника", CategoryId = 3 },
            new Subcategory { Name = "Консоли", CategoryId = 3 },
            new Subcategory { Name = "Другое", CategoryId = 3 },

            new Subcategory { Name = "Компьютерные игры", CategoryId = 4 },
            new Subcategory { Name = "Настольные игры", CategoryId = 4 },
            new Subcategory { Name = "Музыкальные инструменты", CategoryId = 4 },
            new Subcategory { Name = "Книги и журналы", CategoryId = 4 },
            new Subcategory { Name = "Охота и рыбалка", CategoryId = 4 },
            new Subcategory { Name = "Другое", CategoryId = 4 },

            new Subcategory { Name = "Одежда", CategoryId = 5 },
            new Subcategory { Name = "Обувь", CategoryId = 5 },
            new Subcategory { Name = "Аксессуары", CategoryId = 5 },
            new Subcategory { Name = "Мебель", CategoryId = 5 },
            new Subcategory { Name = "Другое", CategoryId = 5 },

            new Subcategory { Name = "Автомобили", CategoryId = 6 },
            new Subcategory { Name = "Мотоциклы, квадроциклы", CategoryId = 6 },
            new Subcategory { Name = "Аксессуары", CategoryId = 6 },
            new Subcategory { Name = "Инструмент", CategoryId = 6 },
            new Subcategory { Name = "Другое", CategoryId = 6 },

            new Subcategory { Name = "Инструмент", CategoryId = 7 },
            new Subcategory { Name = "Другое", CategoryId = 7 },

            new Subcategory { Name = "Тренажеры", CategoryId = 8 },
            new Subcategory { Name = "Другое", CategoryId = 8 },

            new Subcategory { Name = "Зимние спорттовары", CategoryId = 9 },
            new Subcategory { Name = "Летние спорттовары", CategoryId = 9 },
            new Subcategory { Name = "Всесезонные спорттовары", CategoryId = 9 },
            new Subcategory { Name = "Туристические товары", CategoryId = 9 },
            new Subcategory { Name = "Велотовары", CategoryId = 9 },
            new Subcategory { Name = "Туристические услуги", CategoryId = 9 },
            new Subcategory { Name = "Другое", CategoryId = 9 },

            new Subcategory { Name = "Инструмент", CategoryId = 10 },
            new Subcategory { Name = "Другое", CategoryId = 10 }
        };

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

        public static IEnumerable<Category> GetCategories()
        {
            return SeedDataCategories;
        }

        public static IEnumerable<Subcategory> GetSubcategories()
        {
            int subcategoryId = 0;

            foreach (var category in SeedDataCategories)
            {
                var subcategories = SeedDataSubcategories
                    .Where(q => q.CategoryId == category.CategoryId)
                    .ToArray();

                foreach (var subcategory in subcategories)
                {
                    subcategory.SubcategoryId = ++subcategoryId;
                }
            }

            return SeedDataSubcategories;
        }
    }
}