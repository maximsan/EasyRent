using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EasyRent.Data.Migrations
{
    public partial class ChangeUserAdRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAds");

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 1,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2015, 4, 4, 20, 5, 10, 603, DateTimeKind.Unspecified).AddTicks(2855), "Earum aut ut. Voluptatibus reiciendis minus sed debitis ea et. Rerum dicta quo non molestias. Quae dignissimos eos magni qui nulla optio qui. Est et enim et expedita. Fuga sunt assumenda et vero laborum iure unde delectus cupiditate.", "New Josephine", 404.31m, "Handcrafted Rubber Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 2,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2017, 3, 10, 10, 5, 45, 144, DateTimeKind.Unspecified).AddTicks(6701), "Vel cupiditate nihil nulla neque fuga ipsa in error molestiae. Iure sit repellat earum consequatur est magni expedita saepe quia. Dolores ut dolor esse nihil aut aut. Repellendus ea occaecati expedita minima.", "South Adrienview", 764.26m, "Sleek Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 3,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2016, 6, 28, 7, 54, 50, 728, DateTimeKind.Unspecified).AddTicks(6407), "Facilis repellendus in occaecati mollitia sint quibusdam quia. Consectetur nam maxime et itaque iure. Qui omnis accusamus commodi quisquam. Molestias harum cum saepe iure est rerum maxime.", "Ambrosetown", 52.57m, "Practical Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 4,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2020, 6, 20, 18, 10, 39, 245, DateTimeKind.Unspecified).AddTicks(1675), "Vero nemo aliquid. Voluptas similique quia nam dolore aspernatur quaerat accusantium. Rerum ad voluptas voluptas cumque magni amet similique facilis est. Porro accusamus deleniti dolorem molestiae debitis quod. Quas et quo sed veniam aut ab illum et. Dolores deleniti temporibus consequatur quia excepturi rerum aut nihil aut.", "Pacochaport", 214.83m, "Handcrafted Soft Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 5,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2020, 8, 5, 7, 24, 14, 574, DateTimeKind.Unspecified).AddTicks(8825), "Ex reprehenderit occaecati minima odit. Atque accusamus est. Facere officia ratione consequuntur qui.", "Neldashire", 220.35m, "Incredible Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 6,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2016, 4, 10, 14, 9, 31, 851, DateTimeKind.Unspecified).AddTicks(1224), "Perspiciatis voluptatibus beatae qui nihil quod quia. In atque voluptas. Officiis dolorum iste praesentium natus sint. Et sunt repudiandae minima tempora consequuntur temporibus repudiandae et est. Eligendi magni atque sunt itaque rerum.", "Kurtisborough", 2, 849.49m, "Small Steel Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 7,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2019, 5, 19, 22, 2, 57, 932, DateTimeKind.Unspecified).AddTicks(3240), "Eveniet quia odio voluptates ut iste recusandae harum. Pariatur animi harum eum sed in alias autem. Et corporis soluta libero rerum aut officia veritatis. Similique corrupti illo.", "South Imelda", 207.36m, "Small Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 8,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2019, 6, 19, 9, 8, 4, 960, DateTimeKind.Unspecified).AddTicks(8340), "Sit quisquam voluptatibus optio voluptatem. Animi nihil iusto velit quidem quae accusantium tempora quis. Quia ipsum excepturi commodi qui est. Aperiam consectetur dolorum dolor at ipsa aut. Repellat nam quis atque dolorem doloribus saepe ipsa tempora.", "Bergnaumstad", 1, 119.82m, "Unbranded Cotton Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2018, 4, 20, 11, 3, 48, 821, DateTimeKind.Unspecified).AddTicks(2617), "Velit ad dolorem sed consectetur hic molestias in. Placeat vel nihil iure quidem eum et maxime. Voluptatum et consequuntur. Qui beatae doloremque esse aut.", "Kiehnbury", 588.34m, "Awesome Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2017, 8, 11, 5, 29, 9, 69, DateTimeKind.Unspecified).AddTicks(4688), "Ipsa eum facilis qui numquam nobis adipisci qui exercitationem perferendis. Ab qui sit doloremque animi quia debitis. Quas omnis nulla. A aliquam neque eum accusamus corporis ab asperiores. Quibusdam ratione et quae atque cumque. Qui quo nobis consequatur.", "Vandervortborough", 1, 445.77m, "Awesome Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 11,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2018, 4, 12, 6, 58, 33, 96, DateTimeKind.Unspecified).AddTicks(2918), "Velit libero nobis sit. At quia molestiae. Voluptatem dicta aliquam repellat. Voluptatibus sed quam optio eligendi libero explicabo.", "Port Amandaside", 717.05m, "Incredible Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 12,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2018, 3, 16, 20, 52, 40, 132, DateTimeKind.Unspecified).AddTicks(9424), "Ut autem quibusdam quis consequuntur ut excepturi aliquam error facere. Vitae ducimus earum ut consequatur ipsa vel molestiae est. Neque minus quidem. Laboriosam omnis reiciendis id distinctio ut.", "Trompton", 351.63m, "Generic Plastic Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 13,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2015, 7, 8, 19, 9, 20, 722, DateTimeKind.Unspecified).AddTicks(4701), "Sit modi quo enim ea aut. Ut nam eveniet culpa quo architecto. Neque a temporibus doloribus sed et ut numquam. Sit reprehenderit deserunt. Ab asperiores et ad dolorum enim eligendi unde velit sunt. Consectetur quia voluptatem.", "Port Saigeborough", 1, 219.28m, "Gorgeous Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 14,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2016, 5, 9, 15, 28, 18, 684, DateTimeKind.Unspecified).AddTicks(9320), "Similique ut sequi expedita. Voluptas officiis voluptate unde nihil dolorum a error eum aspernatur. Iure quisquam quibusdam commodi et dolor laboriosam sed eos. Ipsam delectus saepe ut. Fugit alias sunt quia in quaerat.", "Dickiview", 302.19m, "Handmade Rubber Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 15,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2018, 7, 22, 6, 49, 39, 238, DateTimeKind.Unspecified).AddTicks(895), "Ea nihil et commodi quaerat nobis temporibus harum tenetur. Cumque qui et excepturi facilis sapiente molestias a voluptatum. Occaecati quos rem non quis. Possimus quia rerum. Et occaecati quam aspernatur corrupti adipisci qui facere maxime ea. Rerum corporis sed quos aut.", "East Titus", 2, 490.62m, "Handmade Cotton Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 16,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2016, 11, 23, 18, 4, 4, 455, DateTimeKind.Unspecified).AddTicks(1702), "Doloribus velit non qui maxime doloribus ullam. Doloremque aut voluptatem qui. Facere numquam quasi molestiae in amet aliquid.", "West Malachiport", 2, 277.46m, "Fantastic Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 17,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2017, 8, 27, 20, 30, 58, 879, DateTimeKind.Unspecified).AddTicks(1465), "Vero omnis perspiciatis voluptatum facere velit ipsam qui nemo earum. Non deleniti molestiae voluptatibus consectetur aut nihil. Est rerum et deserunt provident voluptate nemo ut omnis. Nulla et illo dignissimos. Impedit asperiores libero deserunt quia vel.", "Lehnerchester", 456.84m, "Ergonomic Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 18,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2019, 5, 6, 5, 43, 58, 254, DateTimeKind.Unspecified).AddTicks(5939), "Voluptatibus at architecto. Dolorem aut quasi dignissimos at. Et laudantium optio sed assumenda maiores numquam.", "Lebsackport", 531.01m, "Fantastic Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 19,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2015, 1, 6, 14, 58, 26, 137, DateTimeKind.Unspecified).AddTicks(2131), "Officiis excepturi ullam et neque architecto officia. Aliquid eum expedita cupiditate qui cupiditate. Voluptates ut possimus sed ut.", "Gerholdburgh", 384.10m, "Handmade Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 20,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2019, 6, 30, 7, 34, 41, 339, DateTimeKind.Unspecified).AddTicks(4519), "Ut itaque reiciendis ipsa voluptatem nulla sed. Dolor error et sequi et doloribus. Et sed dignissimos molestias vel et iste eligendi et.", "Port Sylvanstad", 2, 485.69m, "Awesome Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 21,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2015, 9, 2, 1, 22, 21, 547, DateTimeKind.Unspecified).AddTicks(6891), "Ad deserunt quam modi architecto commodi dolore. Odit occaecati porro placeat quisquam totam. Architecto est et esse dolore. Autem ea itaque molestiae reiciendis. Eos explicabo ex possimus iusto aut voluptatem. At dicta nesciunt pariatur adipisci.", "East Bryana", 396.70m, "Intelligent Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 22,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2017, 8, 28, 21, 30, 57, 86, DateTimeKind.Unspecified).AddTicks(5282), "Eos perspiciatis amet atque consectetur atque. Aspernatur assumenda iure exercitationem facere. Minima quod in quia esse maiores quos dolor modi.", "Collierfurt", 1, 7.59m, "Handmade Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 23,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2020, 1, 6, 6, 29, 0, 190, DateTimeKind.Unspecified).AddTicks(9431), "Ullam laudantium dolores omnis nam. Vero placeat nihil illo recusandae iure harum. Sed commodi repudiandae sit impedit expedita optio sint maxime ab.", "Deckowmouth", 235.58m, "Unbranded Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 24,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2016, 2, 15, 5, 31, 26, 354, DateTimeKind.Unspecified).AddTicks(9647), "Ut molestiae facere vel harum. Et maxime sed. Quis fugiat earum pariatur natus. Eligendi unde qui eum porro vitae. Deleniti et fuga eos consequuntur sunt eaque quo voluptatem non. Explicabo atque voluptatem voluptas voluptatem nam sed repellat pariatur.", "Ramonside", 292.49m, "Small Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 25,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2016, 1, 28, 0, 56, 54, 895, DateTimeKind.Unspecified).AddTicks(6993), "Amet deleniti ad sint aut ipsum tempore. Neque nihil eius et aut facere beatae qui. Cupiditate sint ut quisquam incidunt. Libero sapiente sit dolorem reprehenderit sed. Quo magnam sit veniam voluptates alias doloribus vel perferendis.", "South Evie", 686.27m, "Rustic Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2016, 6, 14, 20, 8, 8, 561, DateTimeKind.Unspecified).AddTicks(4647), "Deleniti voluptatibus suscipit quo tenetur odit id omnis cum. Veniam sed quia qui delectus. Illum nulla architecto voluptatem omnis excepturi nihil. Autem unde tempora beatae delectus qui perspiciatis minus quia.", "West Donnashire", 445.60m, "Tasty Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 27,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2017, 2, 1, 14, 55, 45, 969, DateTimeKind.Unspecified).AddTicks(4245), "Ea natus fuga quam. Iusto qui quaerat minima delectus. Excepturi laudantium voluptate debitis cupiditate officia sed.", "Lueilwitzshire", 321.44m, "Intelligent Metal Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 28,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2017, 3, 9, 20, 55, 40, 525, DateTimeKind.Unspecified).AddTicks(3440), "Quia enim nam voluptatem amet. Blanditiis perspiciatis voluptas aut ratione eos est reprehenderit. Atque voluptatibus omnis sit eos tempore quibusdam ex. Incidunt eaque suscipit molestiae voluptas alias omnis. Dolores maiores autem quis nulla enim. Non quasi ipsa assumenda.", "Guyland", 1, 597.16m, "Refined Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 29,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2016, 12, 19, 12, 48, 24, 211, DateTimeKind.Unspecified).AddTicks(5128), "Vel sint inventore et ratione sit non. Voluptas natus id consequatur id animi nihil rerum. Sit consequatur autem et accusantium nam velit explicabo. Et rerum maxime laborum numquam magnam. Commodi velit quis temporibus reprehenderit architecto aut. Laboriosam consequatur magni libero assumenda vero ut.", "Jackelinechester", 3.01m, "Incredible Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 30,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2015, 1, 23, 19, 45, 29, 992, DateTimeKind.Unspecified).AddTicks(2112), "Fugiat qui a voluptatem nisi corrupti est autem. Illo pariatur minima aliquam. Magnam nostrum voluptatem sed provident voluptas qui voluptatem iure nostrum. Numquam ut atque consequatur veritatis sed non error quis ab. Vel at temporibus sit repellat deleniti ab quas id odio. Quam vero nihil voluptas porro voluptas et sed.", "Clovisfurt", 2, 259.59m, "Rustic Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 31,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2016, 12, 18, 19, 14, 38, 692, DateTimeKind.Unspecified).AddTicks(2062), "Rerum debitis exercitationem voluptates dolorem maxime ut voluptas. Numquam aut nobis. Totam deleniti fuga distinctio minus ea. Et aliquam deleniti possimus quo mollitia distinctio. Nihil totam molestiae sunt nobis qui eos. Error autem nesciunt ut reiciendis ipsum aut.", "West Willie", 807.84m, "Handcrafted Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 32,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2015, 5, 16, 0, 58, 6, 112, DateTimeKind.Unspecified).AddTicks(6948), "Et in sed velit sunt dicta facere fuga. Quis nemo repellat quisquam est itaque inventore et. Iusto fuga saepe et consequuntur odio qui. Consequatur corrupti eaque sed sed ipsa quis vitae incidunt.", "North Laurynstad", 884.14m, "Intelligent Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 33,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2017, 3, 31, 21, 6, 31, 573, DateTimeKind.Unspecified).AddTicks(2216), "Ipsum est atque. Explicabo est facere eum ad explicabo totam repellendus vitae. Qui sint facere voluptatem et.", "Garrisonfort", 31.47m, "Gorgeous Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 34,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2016, 3, 13, 17, 40, 51, 140, DateTimeKind.Unspecified).AddTicks(5174), "Placeat cumque a ipsam molestiae quidem. Hic nobis sit pariatur accusamus recusandae magni et. A sapiente eos ipsam maxime ex ducimus tempore autem.", "Cristinafort", 2, 541.71m, "Gorgeous Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 35,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2017, 5, 13, 17, 50, 50, 853, DateTimeKind.Unspecified).AddTicks(8450), "Hic nesciunt aut. Ipsam rerum enim. Molestiae aspernatur qui consectetur placeat dignissimos eum.", "Lake Marquisbury", 1, 255.35m, "Gorgeous Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 36,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2017, 8, 10, 10, 43, 59, 359, DateTimeKind.Unspecified).AddTicks(3903), "Sit expedita ut voluptate quo soluta consequatur aut voluptatibus veniam. Velit eos ratione qui deleniti architecto. Autem nulla voluptatem excepturi totam reiciendis voluptas eum. Perferendis nemo praesentium dolores et omnis iure adipisci ut.", "Reynoldsport", 2, 69.39m, "Practical Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 37,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2015, 1, 5, 18, 14, 34, 753, DateTimeKind.Unspecified).AddTicks(2042), "Corrupti consequatur ut quaerat. Unde ut qui consectetur nostrum vitae rerum. Asperiores et occaecati ratione non eos placeat hic sit.", "Evangelineville", 725.15m, "Fantastic Cotton Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2016, 5, 7, 14, 18, 19, 141, DateTimeKind.Unspecified).AddTicks(7068), "Cupiditate itaque aut debitis quis alias atque autem. Ut et officia. Odio vitae quas voluptatem. Quia consequatur consectetur corporis porro consequatur explicabo saepe. Blanditiis suscipit amet similique.", "Celestineland", 1, 468.97m, "Awesome Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 39,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2017, 3, 22, 16, 4, 17, 407, DateTimeKind.Unspecified).AddTicks(256), "Aut est sunt. Ut commodi voluptatibus nobis asperiores modi. Excepturi modi eius odit dolor. Et doloremque eaque saepe ut repudiandae. Sunt aut occaecati explicabo quae corrupti.", "North Lessie", 200.02m, "Generic Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 40,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2018, 8, 12, 15, 52, 41, 660, DateTimeKind.Unspecified).AddTicks(1503), "In sint dolorem et dolore laboriosam corporis. Nulla doloribus ut ut non qui. Sequi ea repellat voluptas rerum quidem quas tenetur dolore. Voluptatem laborum temporibus quaerat repellat cumque itaque soluta reprehenderit reprehenderit.", "New Jaleel", 2, 727.37m, "Intelligent Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 41,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2017, 2, 16, 17, 4, 44, 300, DateTimeKind.Unspecified).AddTicks(5414), "Laudantium ut consequatur doloribus dolorem magnam rem et architecto natus. Minus modi est sint incidunt nulla nostrum. Eos qui facere vel natus.", "Gloverfurt", 98.96m, "Ergonomic Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 42,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2019, 6, 3, 8, 6, 33, 967, DateTimeKind.Unspecified).AddTicks(7092), "Necessitatibus aut provident est non. Voluptatem quo perferendis minus quas blanditiis ad. Quibusdam maiores similique numquam dolorem.", "Carolinefort", 48.88m, "Unbranded Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 43,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2019, 12, 11, 18, 47, 34, 99, DateTimeKind.Unspecified).AddTicks(2503), "Amet sunt voluptatem nisi quo possimus est et exercitationem et. Unde non voluptas quia dolorem facere veritatis. Consequatur est et odio sunt vitae sapiente harum.", "Lake Myrlland", 958.36m, "Licensed Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 44,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2016, 8, 16, 8, 6, 9, 616, DateTimeKind.Unspecified).AddTicks(1007), "A error officiis ad. Quaerat quo dolores vel unde aperiam voluptatem. Iure corporis voluptatem magni. Voluptatem officiis consequuntur molestias. Iste voluptas culpa minus iure dignissimos voluptas vel assumenda. Laudantium at ipsa.", "Cummerataview", 2, 821.21m, "Rustic Granite Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 45,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2018, 10, 13, 2, 11, 13, 558, DateTimeKind.Unspecified).AddTicks(6991), "Occaecati alias placeat quo quisquam dicta. Qui placeat ipsam. Ipsa non ducimus est ab minus ut ab quisquam sed. Voluptas delectus impedit odio placeat. Repellendus cupiditate at quis consequatur nemo accusamus. Culpa reiciendis ab aut commodi in.", "New Cristopher", 424.84m, "Gorgeous Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 46,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2016, 1, 28, 0, 12, 8, 469, DateTimeKind.Unspecified).AddTicks(5776), "Necessitatibus voluptatem tempore. Consequuntur minima laboriosam voluptatum libero tempora laudantium culpa ut. Culpa et rem facere. Eaque ea dolores delectus. Facere veniam ratione architecto vel aut ut esse. Omnis quam est est quibusdam pariatur.", "Pacochahaven", 733.50m, "Ergonomic Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 47,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2019, 3, 11, 6, 38, 25, 241, DateTimeKind.Unspecified).AddTicks(512), "Et modi accusamus est. Exercitationem accusantium doloremque nulla magni voluptatem nam natus quaerat. Sed rem quibusdam. Rem tempore ut dignissimos consequatur voluptatum ea eveniet iusto sed. Quasi reiciendis labore.", "Cruickshankville", 1, 594.42m, "Ergonomic Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 48,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2019, 6, 18, 16, 10, 37, 507, DateTimeKind.Unspecified).AddTicks(6086), "Eius quia vel ipsum sint quisquam. Quia aut non ut omnis. Numquam aliquid in deserunt voluptates facere inventore. Molestiae et sunt pariatur cupiditate. Magni nam est ut eveniet aut.", "Gerholdberg", 1, 85.49m, "Gorgeous Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 49,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2016, 7, 14, 1, 58, 19, 281, DateTimeKind.Unspecified).AddTicks(4414), "Esse sunt eos ipsam voluptates. Eos magnam culpa quia. Cupiditate quisquam voluptatem asperiores quia ratione praesentium vel et. Aut perspiciatis a.", "West Erickburgh", 382.55m, "Gorgeous Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 50,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2019, 5, 29, 2, 16, 1, 840, DateTimeKind.Unspecified).AddTicks(3392), "Vel possimus similique ipsa facilis modi fugiat. Nihil commodi rerum est ab est. Omnis placeat quaerat dignissimos unde ut. Deserunt eum omnis accusamus.", "New Joanne", 2, 251.72m, "Unbranded Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 51,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2020, 6, 9, 5, 19, 9, 46, DateTimeKind.Unspecified).AddTicks(4756), "Ea placeat quo quos quam hic vel. Sit et aperiam non cupiditate similique asperiores rerum. Fuga neque quod quos omnis voluptates qui a. Voluptatum et ab ut voluptatem eligendi. Neque ut eligendi fugiat velit est rerum ducimus pariatur sed. Distinctio reiciendis qui quia necessitatibus tempore voluptatem impedit.", "Ansleyton", 584.23m, "Refined Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 52,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2017, 4, 4, 16, 55, 28, 918, DateTimeKind.Unspecified).AddTicks(4620), "Ullam laboriosam in. Libero ullam ab modi pariatur. Nostrum rerum labore non atque voluptatibus est. Quia autem fugit est. Aut quasi ipsam at.", "Port Prudence", 1, 165.14m, "Rustic Concrete Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 53,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2015, 7, 27, 18, 6, 33, 687, DateTimeKind.Unspecified).AddTicks(9264), "Officia fuga molestiae vero sit dolor blanditiis ut. Dicta unde et quia eos minima tenetur est. Optio nostrum aliquid ducimus. Ut quae ea sequi dignissimos voluptas aut neque qui.", "South Kurtis", 751.88m, "Intelligent Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 54,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2017, 2, 17, 9, 49, 54, 623, DateTimeKind.Unspecified).AddTicks(850), "Voluptas natus voluptas repellat. Sint porro dolores cumque beatae corporis qui quo culpa consequatur. Fuga aut culpa dolorem et delectus necessitatibus eum.", "Julianamouth", 2, 934.38m, "Small Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 55,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2016, 4, 13, 0, 42, 30, 504, DateTimeKind.Unspecified).AddTicks(8098), "Occaecati nesciunt cupiditate magnam sunt doloremque. Minima consectetur dignissimos repudiandae est earum deleniti voluptatum id reprehenderit. Aliquam ea tempore perferendis dignissimos reprehenderit.", "Sauerton", 1, 108.05m, "Fantastic Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 56,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2016, 11, 29, 22, 30, 36, 696, DateTimeKind.Unspecified).AddTicks(2867), "Corrupti sit minus saepe vitae est. Aut laborum nesciunt doloribus similique sed architecto doloribus. Aliquid distinctio illum molestias porro magni dolores enim rerum.", "Thielburgh", 1, 527.72m, "Handcrafted Steel Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 57,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2020, 3, 15, 16, 59, 26, 108, DateTimeKind.Unspecified).AddTicks(5923), "Commodi minima veritatis autem sit dolor deserunt temporibus. Doloribus voluptas itaque dicta debitis ut quas. Placeat ex fugiat quam rerum nemo minus consequatur.", "Thoraland", 369.79m, "Intelligent Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 58,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2017, 12, 3, 20, 34, 32, 965, DateTimeKind.Unspecified).AddTicks(5502), "Magni eum aliquid ut occaecati nihil repellendus omnis sit. Vel ratione sed impedit quaerat omnis. Et esse ut sit. Placeat vero atque.", "West Shanel", 2, 369.53m, "Small Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 59,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2016, 12, 3, 23, 53, 42, 867, DateTimeKind.Unspecified).AddTicks(5952), "Non eveniet cupiditate. Dolor eaque qui fugit delectus magnam occaecati. Velit cumque molestiae sunt velit molestiae sed quidem quos. Aut magni et sit voluptatem cupiditate.", "Mullerbury", 204.83m, "Unbranded Soft Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2018, 10, 26, 17, 22, 29, 71, DateTimeKind.Unspecified).AddTicks(6098), "Id maxime sint ipsum est doloremque ipsum enim asperiores enim. Voluptatem eum qui. Excepturi quibusdam reprehenderit et repellat porro et.", "West Shadburgh", 953.52m, "Practical Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 61,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2017, 8, 2, 4, 0, 45, 697, DateTimeKind.Unspecified).AddTicks(2195), "Placeat et non. Officiis aut aut provident laborum. Ab illum dolorem et repellendus perspiciatis quas.", "Cristberg", 2, 988.38m, "Awesome Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 62,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2020, 3, 14, 6, 58, 44, 208, DateTimeKind.Unspecified).AddTicks(2952), "Harum ratione quae labore eligendi omnis. Et aperiam quod maiores nihil dicta in. Dolorem dolores repellendus velit et eaque dolor magni sed. Ipsa adipisci qui rerum eveniet quibusdam veniam aut sed reiciendis. Consequatur culpa rem deleniti dolor. Rem explicabo ipsum omnis ut voluptatibus ut laudantium.", "Greenholtmouth", 2, 292.56m, "Fantastic Granite Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 63,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2019, 3, 16, 13, 45, 22, 517, DateTimeKind.Unspecified).AddTicks(5788), "Tempora dolores earum nihil id delectus mollitia blanditiis qui sint. Quisquam iusto ea nihil eaque. Suscipit qui numquam eum quia recusandae quas facere consequatur maxime. Ex beatae tempora qui voluptates corporis qui. Voluptatem totam hic itaque eum.", "Nolantown", 2, 980.32m, "Licensed Fresh Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 64,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2020, 4, 15, 10, 19, 48, 363, DateTimeKind.Unspecified).AddTicks(9641), "Ex dolores illo sed iusto hic autem. Architecto aut quod eligendi. Consequatur dolores et quis necessitatibus atque.", "East Rick", 2, 491.57m, "Awesome Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 65,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2016, 4, 26, 10, 44, 48, 414, DateTimeKind.Unspecified).AddTicks(3253), "Aut quia ipsam iste aut in. Quo sint nesciunt porro. Temporibus ut ea quos alias. Odit autem dicta quos quidem corporis cupiditate consequatur. Voluptatem repudiandae aut quo corrupti ullam quisquam. Atque quia aliquam voluptas molestias labore quia ut.", "South Jovanchester", 1, 627.77m, "Sleek Steel Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 66,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2017, 12, 14, 0, 59, 33, 212, DateTimeKind.Unspecified).AddTicks(9366), "Similique aut doloremque et officiis consequatur et. Voluptatem tempora aut et voluptatem officiis ipsam. Reprehenderit animi dolores voluptates cupiditate velit illum consequatur. Eveniet autem debitis quasi animi.", "Turcotteview", 1, 28.00m, "Unbranded Wooden Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 67,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2018, 9, 24, 6, 53, 8, 267, DateTimeKind.Unspecified).AddTicks(1171), "Et voluptatem excepturi quidem commodi et. Consectetur voluptas voluptatem voluptatem eum sunt nesciunt adipisci. Et reiciendis sit. Iusto porro ea aut quidem ut a voluptatem cupiditate et.", "Quigleymouth", 61.71m, "Sleek Rubber Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 68,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2017, 7, 2, 6, 53, 18, 262, DateTimeKind.Unspecified).AddTicks(4992), "Omnis nulla rerum quae itaque facere aut velit accusantium expedita. Blanditiis accusantium amet ut in alias. Eligendi similique nam aut.", "South Rosinatown", 654.18m, "Generic Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2017, 3, 17, 1, 55, 8, 211, DateTimeKind.Unspecified).AddTicks(7050), "Sint totam officia ullam sed dolor voluptas voluptas nemo exercitationem. Eaque voluptatem et. Nam ea ducimus. Non repellendus repellendus dicta velit voluptates aut. Libero consectetur non sed eligendi.", "East Gideon", 931.78m, "Practical Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 70,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2017, 5, 24, 4, 44, 37, 956, DateTimeKind.Unspecified).AddTicks(7744), "Assumenda doloribus suscipit doloribus odio. Ipsa molestiae ipsum ut. Qui eum reprehenderit iure. Nulla expedita et. Possimus eum sunt. Voluptatem neque magnam.", "Veronaville", 2, 871.48m, "Handcrafted Steel Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 71,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2018, 2, 23, 16, 21, 48, 540, DateTimeKind.Unspecified).AddTicks(3550), "Sit ipsum aut cupiditate. Illo expedita unde. Odio iure unde. Deleniti distinctio quas iure quam et est ad.", "Konopelskiview", 974.06m, "Sleek Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 72,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2016, 2, 21, 15, 5, 43, 22, DateTimeKind.Unspecified).AddTicks(2669), "Molestiae quidem et facilis eos blanditiis eaque. Laborum incidunt dolores sunt est amet ipsum. Voluptatem eaque dolores cupiditate et. Explicabo nihil facilis unde rerum provident a maiores illo ut.", "North Dessiehaven", 2, 737.91m, "Refined Granite Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 73,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2015, 9, 21, 1, 36, 24, 81, DateTimeKind.Unspecified).AddTicks(7139), "Eveniet quia quis aliquid voluptas. Molestiae aut consequatur rerum. Perspiciatis eius alias enim vel molestias. Et quia neque cupiditate id non voluptas harum. Excepturi provident quia dolores nostrum ea.", "Lake Dana", 353.55m, "Intelligent Rubber Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 74,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2015, 12, 9, 20, 13, 17, 343, DateTimeKind.Unspecified).AddTicks(1413), "Corporis occaecati vero numquam sequi optio voluptatum aperiam sint. Quis quisquam ea accusantium. Dolor velit dignissimos corrupti reprehenderit dolor eos nulla.", "North Jaeden", 325.79m, "Small Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2017, 2, 1, 21, 5, 11, 234, DateTimeKind.Unspecified).AddTicks(3679), "Fugit animi ullam. Fuga voluptatem aliquam rerum sed autem. Asperiores sequi itaque sapiente porro omnis placeat.", "Moenville", 673.61m, "Generic Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 76,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2017, 6, 21, 15, 58, 1, 222, DateTimeKind.Unspecified).AddTicks(2810), "Sunt ad numquam. Culpa sit fugit. Et consequatur molestiae. Facilis aut qui laudantium ipsum.", "Port Estastad", 534.14m, "Handcrafted Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 77,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2015, 2, 6, 0, 22, 13, 458, DateTimeKind.Unspecified).AddTicks(8742), "Error odit quam velit veniam. Dolor voluptatem ex dolor. Corrupti rerum in soluta voluptates doloremque quisquam. Tempora sed vel incidunt dolores iure iste. Cum qui qui sit earum vel laborum.", "Schuppefort", 1, 445.24m, "Generic Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 78,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2018, 7, 24, 3, 19, 42, 493, DateTimeKind.Unspecified).AddTicks(91), "Est ad vero. Velit ad harum blanditiis ab sit officiis veniam consequatur qui. Aut aut numquam mollitia distinctio aut ad. Eos quasi qui consequuntur sit ut sit. Sunt voluptate ut voluptates voluptas illum amet qui.", "Hagenesside", 560.10m, "Generic Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 79,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2016, 11, 26, 11, 53, 36, 239, DateTimeKind.Unspecified).AddTicks(1973), "Excepturi perspiciatis et. Quis cum asperiores. Dolorem voluptatem ducimus repudiandae et provident dolor debitis perspiciatis illum. Veniam dolorem atque est aliquid. Porro reiciendis sint occaecati.", "Gaylordview", 2, 959.46m, "Intelligent Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 80,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2019, 3, 22, 5, 23, 40, 146, DateTimeKind.Unspecified).AddTicks(1966), "Nemo ut possimus eos aut eligendi sunt neque cum. Ab iusto ullam. Accusantium vero quo eum. Cumque beatae commodi debitis eveniet repellat tenetur est. Ut sed exercitationem veniam est praesentium.", "Krisside", 2, 492.81m, "Rustic Steel Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 81,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2016, 11, 2, 18, 0, 1, 117, DateTimeKind.Unspecified).AddTicks(9967), "Distinctio asperiores fugit. Fuga quam aut hic maxime earum accusantium eos. Illo consequatur cumque non eos autem assumenda repellendus quo.", "Isacside", 222.09m, "Handcrafted Rubber Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 82,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2017, 1, 23, 15, 41, 38, 658, DateTimeKind.Unspecified).AddTicks(2986), "Nostrum eligendi ad perspiciatis repudiandae officiis in cumque porro in. Quasi et quia sit amet qui nihil. Iusto tempora dolorem. Libero voluptas ea voluptas dolore. Esse nihil aut ipsum.", "Rueckerburgh", 1, 428.16m, "Fantastic Concrete Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 83,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2016, 5, 2, 23, 14, 36, 453, DateTimeKind.Unspecified).AddTicks(917), "Vero deserunt provident et et molestias illum hic aliquam possimus. Commodi id omnis molestias odit sequi. Ullam voluptatem perspiciatis eveniet facere ea impedit.", "Kerlukeport", 147.47m, "Ergonomic Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 84,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2020, 1, 3, 17, 8, 17, 196, DateTimeKind.Unspecified).AddTicks(1664), "Harum molestias voluptates id. Repudiandae sed exercitationem. Qui laborum quisquam vel numquam occaecati illum itaque ut a. Quia et accusamus architecto laboriosam et amet et possimus. Eum et optio officiis. Inventore reprehenderit unde atque voluptatibus harum veritatis.", "Wehnerfort", 756.78m, "Incredible Fresh Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 85,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2018, 12, 22, 16, 3, 35, 81, DateTimeKind.Unspecified).AddTicks(1636), "Inventore est rerum quo voluptatem quaerat qui et sed qui. Maxime accusantium earum eligendi laudantium molestiae reprehenderit eos aut quia. Ratione non magnam. Totam suscipit repellat et eum in sint. Vel autem quam omnis veniam modi aliquam magni. Earum rerum beatae minus reprehenderit nesciunt nesciunt.", "Port Kenneth", 974.39m, "Licensed Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 86,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2016, 3, 24, 11, 52, 46, 0, DateTimeKind.Unspecified).AddTicks(1837), "Quas tempore doloribus deserunt eum corporis. Ut ipsa officiis aut. Quisquam beatae qui quia maiores quia at beatae. Voluptas in et fugiat. A et numquam quo delectus animi et eos et at. Ex dolore molestiae voluptatem quaerat fugit deserunt autem molestiae aliquam.", "Franciscabury", 1, 722.54m, "Practical Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 87,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2017, 1, 10, 4, 21, 30, 378, DateTimeKind.Unspecified).AddTicks(3726), "Rerum ut voluptatem nobis sit voluptates molestias quia vero. Minus aliquam harum molestiae nihil illum. Est consequatur consequuntur et est ut quas voluptas doloribus omnis.", "Reichelfurt", 1, 963.90m, "Awesome Fresh Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 88,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2015, 5, 12, 22, 50, 40, 490, DateTimeKind.Unspecified).AddTicks(8815), "Nobis veniam quisquam qui labore harum sed sunt corrupti. Eveniet corporis itaque laudantium earum pariatur. Beatae omnis nulla nisi. Id atque numquam atque voluptatem. Aperiam error laboriosam illum nisi earum.", "Lake Cieloburgh", 28.94m, "Refined Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 89,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2017, 1, 22, 4, 54, 10, 872, DateTimeKind.Unspecified).AddTicks(6874), "Sed itaque placeat. Consequatur labore est dignissimos. Unde ut sit facere deleniti. Inventore et et vitae a repellat laboriosam aspernatur.", "Sylviatown", 2, 888.37m, "Rustic Cotton Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 90,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2019, 2, 3, 19, 1, 3, 612, DateTimeKind.Unspecified).AddTicks(1338), "Iusto veniam ea. In dolorum et quibusdam exercitationem. Odit ad reprehenderit reiciendis voluptas qui corporis maxime eum accusantium. Voluptas dicta magnam tenetur aliquid mollitia repellat aperiam sit.", "Elyssaburgh", 448.62m, "Incredible Soft Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 91,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2018, 3, 26, 20, 0, 40, 652, DateTimeKind.Unspecified).AddTicks(338), "Et impedit aut omnis dolores voluptatem id. Veritatis sint corrupti et. Mollitia velit voluptatem vel modi. Et voluptas fugit.", "Lake Wilhelm", 943.35m, "Handcrafted Steel Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2019, 1, 29, 12, 10, 27, 500, DateTimeKind.Unspecified).AddTicks(6772), "Eaque vel ducimus dolor. Ducimus qui rerum sed et dolorem eos adipisci impedit. Consequatur ut veniam ipsam repellat omnis est. Aut quibusdam omnis deleniti ut. Corrupti soluta odio et sit iste illum.", "Conniebury", 576.19m, "Ergonomic Fresh Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 93,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2017, 1, 11, 7, 39, 18, 567, DateTimeKind.Unspecified).AddTicks(7868), "Corrupti quaerat tempora tenetur minus non praesentium aliquid ab iusto. Corporis ut at ea harum aut. Tenetur dolor sequi possimus nam qui. Id saepe ut eligendi animi quae cum aut sint ab. Quaerat qui nihil vel natus.", "Lake Dollyfort", 2, 68.14m, "Generic Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 94,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2015, 9, 27, 5, 5, 50, 784, DateTimeKind.Unspecified).AddTicks(6850), "Consequatur qui deserunt dicta ipsa repellat quidem. Distinctio ducimus reprehenderit nihil dolores qui aut. Autem dolore soluta.", "Liashire", 989.20m, "Fantastic Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 95,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2018, 2, 20, 18, 18, 8, 650, DateTimeKind.Unspecified).AddTicks(5102), "Laudantium excepturi incidunt impedit voluptatem cum quia nobis impedit. Alias perspiciatis quia debitis sed sunt sequi ducimus. Maiores molestias ut officia tenetur eos. Velit voluptas adipisci et asperiores dolor voluptas animi.", "Dickiburgh", 746.48m, "Sleek Cotton Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2020, 4, 2, 19, 0, 35, 509, DateTimeKind.Unspecified).AddTicks(2568), "Libero occaecati velit ad reiciendis adipisci. Nisi laboriosam error molestiae minima nulla culpa deleniti voluptate quos. Placeat qui numquam quisquam hic non nemo voluptate sapiente. Repellendus hic non. Laboriosam praesentium architecto cum error sint rerum et incidunt.", "Gerlachborough", 1, 265.65m, "Tasty Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 97,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2017, 11, 5, 0, 45, 20, 978, DateTimeKind.Unspecified).AddTicks(2374), "Autem amet rerum. Enim ut sunt incidunt non natus reprehenderit. Quia itaque iure quas et nulla sunt a.", "McLaughlinberg", 1, 463.47m, "Generic Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 98,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2016, 12, 1, 1, 3, 40, 934, DateTimeKind.Unspecified).AddTicks(7750), "Aut nam perspiciatis enim magni odit nostrum rerum ipsam similique. Nihil accusamus est sunt quae. In dolores rerum quos dolorem qui sed. Deleniti voluptatibus est et veritatis dolor pariatur similique molestias fugiat. Qui sed autem eligendi omnis fuga rerum. Nostrum consequatur deserunt et sunt enim.", "O'Keefeside", 45.74m, "Fantastic Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 99,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2019, 6, 27, 22, 5, 46, 827, DateTimeKind.Unspecified).AddTicks(3316), "Exercitationem magnam reprehenderit qui at commodi saepe qui. Qui accusantium dignissimos reprehenderit et cupiditate voluptas repudiandae. Necessitatibus fugit aperiam vel.", "South Stephaniaport", 119.55m, "Intelligent Frozen Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 100,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2018, 2, 8, 22, 17, 0, 44, DateTimeKind.Unspecified).AddTicks(7905), "Reprehenderit maiores quo a incidunt. Doloribus dolorum animi et quas et occaecati aut omnis molestiae. Omnis aut et sint. Accusamus omnis voluptas et. Mollitia mollitia mollitia ullam debitis cupiditate sed dolores. Beatae amet distinctio ratione ipsa possimus rem saepe qui.", "Metzton", 1, 227.31m, "Generic Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "PhoneNumber", "UserName" },
                values: new object[] { "538b13b5-5545-4b65-bf2e-e05080c46e79", "Michelle58@hotmail.com", "McClure", "(545) 836-1015", "Michelle.McClure" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "PhoneNumber", "UserName" },
                values: new object[] { "b7684e09-7a3d-42e9-af55-93ffb3762e04", "Bethany.White72@hotmail.com", "White", "1-480-277-7151", "Bethany_White" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "Name",
                value: "Одежда и аксессуары");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "Name",
                value: "Детские товары");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "Name",
                value: "Техника и электроника");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "Name",
                value: "Хобби и отдых");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "Name",
                value: "Свадьба и праздники");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "Name",
                value: "Автотовары");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "Name",
                value: "Сад и огород");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "Name",
                value: "Здоровье");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "Name",
                value: "Спорт, туризм и активный отдых");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                column: "Name",
                value: "Ремонт и стройка");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 11, "Другое" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 17,
                column: "CategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 18,
                column: "CategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 19,
                column: "CategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 20,
                column: "CategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 21,
                column: "CategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 22,
                column: "CategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 23,
                column: "CategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 24,
                column: "CategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 25,
                column: "CategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 26,
                column: "CategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 27,
                column: "CategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 28,
                column: "CategoryId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 29,
                column: "CategoryId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 30,
                column: "CategoryId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 31,
                column: "CategoryId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 32,
                column: "CategoryId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 33,
                column: "CategoryId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 34,
                column: "CategoryId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 35,
                column: "CategoryId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 36,
                column: "CategoryId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 37,
                column: "CategoryId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 38,
                column: "CategoryId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 39,
                column: "CategoryId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 40,
                column: "CategoryId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 41,
                column: "CategoryId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 42,
                column: "CategoryId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 43,
                column: "CategoryId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 44,
                column: "CategoryId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 45,
                column: "CategoryId",
                value: 10);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11);

            migrationBuilder.CreateTable(
                name: "UserAds",
                columns: table => new
                {
                    UserAdId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AdId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAds", x => x.UserAdId);
                    table.ForeignKey(
                        name: "FK_UserAds_Ads_AdId",
                        column: x => x.AdId,
                        principalTable: "Ads",
                        principalColumn: "AdId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAds_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 1,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2017, 6, 4, 1, 55, 7, 177, DateTimeKind.Unspecified).AddTicks(8407), "Soluta sit mollitia eaque eum quas numquam est aut. Corporis aliquam et unde quas temporibus. Officiis enim rerum quasi ratione mollitia atque.", "North Napoleon", 236.17m, "Small Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 2,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2017, 12, 10, 11, 51, 48, 694, DateTimeKind.Unspecified).AddTicks(1376), "Corrupti officia ea quam nemo molestias. Omnis aut reprehenderit quas nam saepe consequatur. Possimus ipsam nesciunt est provident. Fugit voluptas aliquid omnis reiciendis facere. Ut accusamus consequatur nihil animi. Corporis itaque rem.", "Mayertmouth", 581.61m, "Refined Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 3,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2020, 4, 30, 12, 55, 26, 593, DateTimeKind.Unspecified).AddTicks(9444), "Et sed quis totam esse. Autem dolorem ab. Voluptas possimus labore cupiditate itaque qui vitae veritatis.", "Lakinview", 285.34m, "Practical Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 4,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2016, 12, 23, 5, 41, 12, 663, DateTimeKind.Unspecified).AddTicks(5477), "Soluta rerum sed perferendis minus placeat cupiditate a amet. Molestiae fugit nihil. Magnam consequatur laboriosam enim. Corporis dignissimos sit non impedit officiis numquam optio. Nemo laudantium esse itaque rerum modi aut est. Tempora autem amet veritatis.", "Port Morrisstad", 323.90m, "Refined Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 5,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2017, 8, 24, 7, 31, 34, 544, DateTimeKind.Unspecified).AddTicks(5356), "Eum nam aut dolorem eos sint ab. Et quisquam nam maiores dolorem sed quaerat error officia. Occaecati omnis labore. Qui quibusdam magni omnis ex. Autem tenetur at qui et consequatur quo.", "New Gladyce", 87.91m, "Gorgeous Wooden Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 6,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2019, 7, 2, 3, 22, 19, 226, DateTimeKind.Unspecified).AddTicks(8337), "Expedita molestiae voluptas voluptas. Possimus ratione laboriosam veritatis cupiditate enim. Officia nesciunt sed odio cumque accusamus cupiditate maxime. Consequatur hic maiores adipisci accusantium et esse repellat pariatur. Minus sed qui cumque officia laborum amet ex iure explicabo.", "Lake Ozellaburgh", 1, 695.30m, "Sleek Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 7,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2016, 9, 16, 0, 31, 58, 939, DateTimeKind.Unspecified).AddTicks(5458), "Aliquid nostrum aut omnis similique rem excepturi qui laboriosam. Sed culpa neque adipisci. Hic dolorem excepturi sint dolores est. Officia dolorem quisquam et non quia illum adipisci architecto. Consectetur est ipsa voluptate et quo dolorum aut.", "Hilllchester", 561.17m, "Gorgeous Metal Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 8,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2020, 2, 10, 2, 19, 42, 222, DateTimeKind.Unspecified).AddTicks(7392), "Voluptas voluptate adipisci culpa cumque. Inventore et earum iure voluptates ratione eos fugiat iure. Voluptatem ab sit doloribus necessitatibus quidem. Veniam vitae doloremque sint aperiam. Modi totam ipsum numquam vel itaque repellendus quos laudantium impedit. Omnis iste itaque atque blanditiis ut quam velit ullam.", "East Lelahborough", 2, 986.92m, "Fantastic Wooden Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2017, 6, 10, 1, 42, 22, 584, DateTimeKind.Unspecified).AddTicks(9274), "Aspernatur quisquam et. Non voluptas eveniet id reiciendis nobis nisi cupiditate. Suscipit optio omnis eum. Est quas minus et et eos at. Odio aut rerum culpa. Aperiam et facere blanditiis eius error quo laborum sunt sint.", "Arvidview", 261.23m, "Licensed Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2018, 3, 7, 20, 47, 20, 807, DateTimeKind.Unspecified).AddTicks(9362), "Eum nostrum adipisci. Inventore necessitatibus cumque necessitatibus sunt delectus qui quisquam. Id blanditiis debitis voluptatum numquam. Recusandae sint maiores. Illum animi animi. Qui in quis.", "South Adolfo", 2, 973.45m, "Awesome Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 11,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2015, 3, 26, 15, 7, 41, 822, DateTimeKind.Unspecified).AddTicks(7086), "Molestiae qui est placeat. Consectetur voluptatem nesciunt sapiente voluptatem delectus voluptatem perspiciatis qui magnam. Illo blanditiis eum dolore quos. Est ut impedit suscipit et asperiores et et. Exercitationem voluptatem ipsam natus enim magni pariatur est. Dolores labore velit quia provident doloribus molestiae eos non.", "Larkintown", 994.42m, "Handcrafted Metal Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 12,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2019, 10, 25, 14, 11, 27, 264, DateTimeKind.Unspecified).AddTicks(7232), "Voluptas perspiciatis illo. Tempore repellat incidunt quo earum et. Consequatur a fugit magnam. Error consequatur porro et molestiae. Qui reprehenderit nam ullam ea id at ut nisi.", "Bartolettimouth", 809.61m, "Handcrafted Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 13,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2017, 5, 25, 19, 7, 11, 107, DateTimeKind.Unspecified).AddTicks(2594), "Facilis enim labore eaque unde. In voluptatum quam quia impedit velit. Illum distinctio est quis rerum fuga maiores. Ut reprehenderit est quia corporis iste hic debitis.", "Montanachester", 2, 622.14m, "Sleek Steel Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 14,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2019, 12, 11, 4, 4, 58, 484, DateTimeKind.Unspecified).AddTicks(6363), "Temporibus et corrupti quia omnis ut. Optio repudiandae corrupti aliquid sunt voluptatem mollitia maxime sint laudantium. Et et ducimus mollitia repudiandae deserunt repellat in doloremque.", "Krisborough", 110.21m, "Refined Granite Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 15,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2019, 10, 27, 0, 27, 3, 265, DateTimeKind.Unspecified).AddTicks(9749), "Eaque cum aliquam delectus sit vel eos corporis. Laboriosam neque delectus et similique labore alias adipisci aut saepe. Reiciendis ut ratione fugit similique. Cupiditate sunt repellendus quo voluptas perferendis.", "East Coralieberg", 1, 194.89m, "Generic Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 16,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2019, 12, 29, 19, 52, 54, 744, DateTimeKind.Unspecified).AddTicks(6800), "Vel cum quaerat et non est. Aut quia cum aut provident eos in rerum at ab. Sed in ratione hic quaerat ea aut. Natus sed soluta laudantium nihil sed facere optio amet.", "Dinohaven", 1, 256.58m, "Small Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 17,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2017, 1, 22, 3, 5, 54, 225, DateTimeKind.Unspecified).AddTicks(1274), "Ut magnam ea. Possimus repudiandae illum enim et quam eveniet incidunt quisquam. At sit expedita aut. Dolor dignissimos non itaque officia sed quaerat dolor. Ratione inventore omnis a ipsam facere voluptas et voluptatem.", "Urielville", 934.06m, "Practical Soft Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 18,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2017, 10, 14, 21, 11, 47, 22, DateTimeKind.Unspecified).AddTicks(6484), "Tempore ut cupiditate porro sint laborum accusantium ipsam est est. Id eaque consequuntur quis distinctio earum. Delectus aut maiores aut consequatur accusantium atque nulla sit qui. Eius officia est veniam quo rem dolorem labore. In eos ullam omnis. Ipsa blanditiis totam eveniet ullam iure dolorum.", "New Kenya", 91.39m, "Tasty Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 19,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2019, 12, 3, 14, 0, 51, 208, DateTimeKind.Unspecified).AddTicks(3630), "Expedita omnis voluptatem assumenda qui velit et. Quam cumque occaecati dolorem quas iusto praesentium. Sunt sit hic porro et aperiam autem saepe nesciunt adipisci. Consequatur deserunt quod aut voluptas perspiciatis est saepe repellat voluptatem. Perferendis cumque est quo sed qui quia quod.", "Joshville", 271.17m, "Unbranded Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 20,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2018, 8, 24, 13, 18, 49, 243, DateTimeKind.Unspecified).AddTicks(8055), "Est quaerat ipsam voluptas. Soluta est consectetur veniam omnis perspiciatis laudantium itaque rerum alias. Quasi tempora fugiat et. Quam est consequatur est quia vel autem quia. Eius enim labore eveniet architecto possimus iure aut. Occaecati eaque maiores blanditiis consequatur aut id suscipit ipsa non.", "Schroederburgh", 1, 789.10m, "Handcrafted Cotton Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 21,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2018, 2, 14, 6, 10, 3, 390, DateTimeKind.Unspecified).AddTicks(8211), "Eveniet voluptatibus et natus enim tempora eaque consequatur dolore. Voluptatem ut ipsam accusantium id sapiente quibusdam reprehenderit officiis. Est culpa suscipit at itaque atque perspiciatis quos aut odit. In dolore et eos alias quo. Nihil molestias exercitationem incidunt delectus.", "South Tommieport", 666.37m, "Handcrafted Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 22,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2019, 12, 8, 16, 49, 13, 156, DateTimeKind.Unspecified).AddTicks(9295), "Facilis voluptas dolorum repellendus nobis. Non eos nihil est aut distinctio necessitatibus. Quia perspiciatis nobis commodi eligendi perspiciatis laborum voluptas.", "North Adan", 2, 878.10m, "Licensed Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 23,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2015, 12, 28, 0, 48, 42, 913, DateTimeKind.Unspecified).AddTicks(6513), "Ex architecto et sint dolorem placeat corporis eum officia. Eum vel omnis itaque odit enim officiis asperiores tenetur. Cumque voluptatem blanditiis et dolor aut est. Necessitatibus ut totam et aut. Autem quae repudiandae.", "Lindgrenside", 242.32m, "Licensed Soft Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 24,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2017, 9, 25, 8, 29, 3, 871, DateTimeKind.Unspecified).AddTicks(6142), "Earum aut modi est consequatur quia aperiam. Perferendis eos sit voluptatem accusantium itaque quae. Sit quo porro natus inventore qui. Qui aut enim. Qui aut odio qui nihil nulla qui hic provident et. Aspernatur earum nisi molestiae ut et occaecati sint numquam.", "Pollichton", 847.03m, "Sleek Cotton Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 25,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2018, 2, 21, 17, 43, 59, 746, DateTimeKind.Unspecified).AddTicks(9148), "Optio quia qui laborum in omnis ipsam dolor. Doloribus sint ratione voluptatum laborum. Eius et dolores deleniti recusandae sunt explicabo et saepe. Deserunt aut quia cupiditate labore ea harum rem numquam in. Necessitatibus illum quia architecto quia quod repudiandae vero. Voluptates quis accusamus laborum.", "Port Alysonbury", 837.41m, "Awesome Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2016, 7, 12, 21, 37, 52, 86, DateTimeKind.Unspecified).AddTicks(8919), "Et veritatis qui aut tempore voluptatem numquam ipsa sit vel. Voluptate qui aliquid sit. Porro ipsa modi ut. Nihil vel ex non quidem tempore et deserunt.", "East Eulah", 625.44m, "Intelligent Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 27,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2015, 10, 15, 16, 24, 43, 284, DateTimeKind.Unspecified).AddTicks(9285), "Similique assumenda quae officiis perferendis aut adipisci quam. Nulla laborum omnis numquam veniam tempora soluta tempora tempore aperiam. Velit ducimus consequatur et fugiat dolor sint.", "West Travis", 423.54m, "Licensed Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 28,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2018, 7, 16, 7, 17, 45, 931, DateTimeKind.Unspecified).AddTicks(9203), "Non deleniti vel distinctio. Unde in velit non eos quia. Dolorum sed sint. Quia voluptas qui ipsa.", "New Tommieton", 2, 997.79m, "Practical Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 29,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2016, 8, 19, 19, 24, 58, 171, DateTimeKind.Unspecified).AddTicks(7101), "Voluptatum molestias aut aperiam temporibus cupiditate aut quaerat. Qui ea sequi necessitatibus et. Mollitia laboriosam sit saepe itaque dignissimos delectus. Unde quis distinctio inventore quod molestiae dolor temporibus quis eum.", "East Mathilde", 406.57m, "Intelligent Plastic Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 30,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2018, 8, 15, 17, 15, 30, 932, DateTimeKind.Unspecified).AddTicks(1547), "Itaque odit dolorum sed illo nostrum quia. Voluptate corporis molestias in error maxime consequuntur laudantium. Sit officia autem fugit quia.", "Maddisonside", 1, 190.91m, "Rustic Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 31,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2019, 1, 9, 0, 56, 33, 514, DateTimeKind.Unspecified).AddTicks(5637), "Aliquid iste odio. Officiis corrupti libero est nihil asperiores rerum. Voluptas laudantium non. Non qui ad numquam esse laborum sint delectus quis. Neque odio accusantium omnis facilis ea et unde reprehenderit. Accusantium dolorem blanditiis aut consequuntur quas ut.", "Adrielfort", 350.27m, "Handcrafted Granite Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 32,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2016, 3, 13, 14, 21, 23, 375, DateTimeKind.Unspecified).AddTicks(8487), "Id eaque rem magnam perferendis voluptas tempora. Nam aliquid ut totam nostrum architecto rerum. Odit asperiores ipsum sunt voluptates quo et tenetur quos. Dolores delectus voluptatem ipsa iusto in rerum. Et sed omnis sunt dignissimos omnis eveniet et labore et.", "Harberton", 591.93m, "Refined Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 33,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2015, 3, 11, 2, 16, 15, 285, DateTimeKind.Unspecified).AddTicks(5591), "Fugit occaecati omnis. Eum quaerat molestiae dolorum sint distinctio. Nisi quam odit velit provident omnis qui. Maiores rem soluta ipsum. Blanditiis et dolores accusantium.", "East Ted", 329.84m, "Gorgeous Rubber Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 34,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2018, 6, 16, 6, 39, 15, 826, DateTimeKind.Unspecified).AddTicks(6190), "Dolores et voluptas quia consequatur quo quia qui. Vitae distinctio voluptatem nihil cumque iste iusto ut mollitia quae. Quia in adipisci optio maxime consectetur dicta temporibus nobis neque. Est ducimus omnis quos at aliquid ab aliquid. Minus voluptate aut ut natus et et iste. Maiores nobis numquam.", "Balistreriport", 1, 94.45m, "Practical Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 35,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2017, 5, 25, 22, 26, 4, 384, DateTimeKind.Unspecified).AddTicks(1054), "Ea illo illum officiis quia nihil vitae ullam et. Consectetur porro ullam pariatur dolores. Quis non quisquam.", "Jaunitaport", 2, 709.38m, "Practical Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 36,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2017, 2, 26, 8, 15, 22, 223, DateTimeKind.Unspecified).AddTicks(5981), "Aliquid commodi suscipit. Quas fugiat doloremque ut consequatur et iure ut mollitia quo. Autem in dolores quis sit aspernatur distinctio ut quis. Ut in quo consequatur ad commodi et molestias consectetur. Ex sapiente eos harum quaerat aliquam sit aliquid autem.", "South Bessiestad", 1, 237.58m, "Generic Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 37,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2020, 2, 8, 3, 39, 16, 493, DateTimeKind.Unspecified).AddTicks(1939), "Ab dolores nesciunt. Consectetur ut explicabo ut omnis praesentium. Alias dignissimos eum porro et doloremque. Sint enim omnis. Ipsam incidunt illum animi.", "West Brooklynberg", 103.98m, "Rustic Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2019, 5, 18, 7, 37, 34, 327, DateTimeKind.Unspecified).AddTicks(5750), "Rerum aliquam magnam. Beatae nihil culpa autem omnis. Ea ex sit aspernatur. Laudantium vero illum molestiae et deserunt. Tempore in occaecati ex ut. Odit sint maiores reprehenderit quia aut ad illo ullam.", "Ferryport", 2, 238.09m, "Licensed Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 39,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2015, 6, 3, 19, 36, 35, 697, DateTimeKind.Unspecified).AddTicks(4773), "Officiis illo voluptates unde quia rem nemo qui at. Quisquam rem qui nobis vero voluptatem ut voluptatem quia. Quia neque repellat culpa in vel dolor voluptates eum.", "Lonzostad", 162.45m, "Ergonomic Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 40,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2016, 3, 13, 15, 50, 59, 471, DateTimeKind.Unspecified).AddTicks(3300), "Rem ducimus quae sint illo molestias quia similique dolores vel. Ducimus dolore ducimus impedit inventore sit ratione dolorem. Qui velit ut sit dolores enim facilis qui. Architecto consequuntur ratione repellendus vero at porro hic et ut. Distinctio nisi dolore aut saepe dolores repudiandae harum occaecati.", "Rodriguezchester", 1, 175.54m, "Refined Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 41,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2016, 1, 20, 15, 33, 12, 678, DateTimeKind.Unspecified).AddTicks(998), "Libero sunt veritatis nobis officia nam reprehenderit mollitia asperiores. Voluptatem et a. Ab hic molestiae. Repellat qui perferendis non amet. Et aut itaque minima culpa.", "Arnechester", 604.95m, "Small Frozen Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 42,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2017, 9, 21, 3, 46, 7, 674, DateTimeKind.Unspecified).AddTicks(8114), "Eaque non cumque deleniti eveniet eius illum. Voluptatem repellendus culpa vel ut pariatur id. Qui aliquam et qui aut perferendis. Accusantium culpa adipisci hic eaque ad.", "Hagenesshire", 528.75m, "Refined Frozen Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 43,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2020, 1, 14, 16, 41, 3, 449, DateTimeKind.Unspecified).AddTicks(6598), "Facere voluptatem porro. Corporis quaerat sequi aliquam iure blanditiis eos. Quod velit voluptatem aperiam tempore ut cumque enim. Magnam iste voluptatum animi at rem officiis sit eveniet. Quisquam eos laborum ex placeat omnis cupiditate ad itaque autem. Necessitatibus nemo dignissimos quis temporibus laudantium tenetur quis vel.", "Skilesport", 341.09m, "Sleek Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 44,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2016, 10, 18, 7, 28, 31, 809, DateTimeKind.Unspecified).AddTicks(5196), "Corrupti in qui fugiat magni illo enim aliquam voluptatem fuga. Voluptatum doloribus ea dolore doloremque ipsam et aut et. Dicta recusandae necessitatibus autem enim pariatur eaque ut fuga dolorem. Excepturi et in minus.", "South Madyson", 1, 407.22m, "Handcrafted Wooden Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 45,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2020, 1, 28, 18, 59, 14, 661, DateTimeKind.Unspecified).AddTicks(4120), "Laudantium quia qui eum. Ea a in rerum aliquam praesentium vero quia incidunt. Cupiditate et laborum sapiente consequuntur a sint qui. Voluptate id labore voluptas molestiae laborum qui commodi et.", "Kobeborough", 41.35m, "Practical Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 46,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2015, 7, 12, 2, 13, 49, 565, DateTimeKind.Unspecified).AddTicks(3743), "Quibusdam sed qui ea dolores occaecati blanditiis quae modi amet. Deleniti quisquam reiciendis quia quia sed aut accusantium et explicabo. Et et vel atque ea labore consequatur eius a nihil.", "Sammystad", 402.17m, "Licensed Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 47,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2020, 7, 22, 0, 12, 58, 276, DateTimeKind.Unspecified).AddTicks(1598), "Harum at voluptatem laudantium velit aperiam temporibus. Et et ut. Cumque quibusdam voluptatem et nesciunt numquam labore consequatur tempora. Et vero consequatur est sit cum nobis. Et omnis labore reiciendis voluptatem non dolorem saepe ipsa omnis.", "Port Ford", 2, 60.45m, "Tasty Soft Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 48,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2015, 6, 1, 23, 3, 29, 179, DateTimeKind.Unspecified).AddTicks(4514), "Beatae eligendi exercitationem aut. Laudantium aspernatur molestiae. Fugit nisi dolores omnis quia fuga est est. Atque voluptatem quia laudantium in exercitationem. Quod necessitatibus dolorum architecto. Quaerat quae repellat repudiandae cumque.", "Marleeside", 2, 476.79m, "Handcrafted Soft Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 49,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2018, 12, 24, 12, 54, 34, 500, DateTimeKind.Unspecified).AddTicks(7987), "Voluptas consequuntur aut eius molestiae sequi libero. Laborum fugit repellat tenetur nemo sunt deleniti ex ea at. Dolores quidem nihil beatae eaque.", "Auermouth", 467.87m, "Awesome Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 50,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2016, 12, 20, 5, 0, 54, 36, DateTimeKind.Unspecified).AddTicks(9334), "Aspernatur quia suscipit necessitatibus sit recusandae. Molestiae est a. Dolores voluptatem aliquam quo.", "West Aubrey", 1, 870.47m, "Practical Steel Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 51,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2019, 11, 11, 14, 11, 41, 680, DateTimeKind.Unspecified).AddTicks(7280), "Modi at quis sit architecto cupiditate. Quaerat labore occaecati velit aut nihil sit est aliquid voluptates. Facilis ratione corporis cum et nihil voluptas commodi et.", "East Olaf", 427.33m, "Sleek Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 52,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2017, 12, 1, 21, 18, 53, 305, DateTimeKind.Unspecified).AddTicks(5150), "Laborum suscipit repellat. Itaque debitis veniam dolorem dicta in. Dignissimos inventore minus illo fugit perspiciatis illo. Quia impedit saepe ut explicabo totam explicabo eveniet cum. Laudantium quasi hic ut. Aperiam vel corporis sed eos unde natus velit ut.", "New Erinbury", 2, 780.40m, "Ergonomic Cotton Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 53,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2016, 3, 30, 16, 50, 16, 485, DateTimeKind.Unspecified).AddTicks(3916), "Quibusdam et consequatur nulla reiciendis est aut fuga. Harum rem ullam cumque labore. Nisi consectetur ipsam et excepturi aliquid dolores sint eos. Sed id temporibus eos omnis voluptate quia autem.", "North Gregg", 194.63m, "Small Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 54,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2020, 4, 19, 12, 35, 56, 716, DateTimeKind.Unspecified).AddTicks(2064), "Quasi vitae quo deserunt voluptatibus sit tempora ratione accusamus. Ullam reprehenderit accusamus sed eos. Amet atque omnis. Ut molestiae eum eius. Voluptatem ipsum placeat nam nostrum iusto. Similique veniam et eaque voluptas velit nesciunt eius sit.", "South Valentinchester", 1, 10.21m, "Incredible Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 55,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2016, 6, 21, 14, 18, 11, 201, DateTimeKind.Unspecified).AddTicks(9944), "Officia ratione optio et sit fugiat nesciunt voluptatum. Culpa non cupiditate dolorem qui laudantium. Labore maiores quia iste eaque non quam iusto et. Dolorem enim ipsa porro aliquam alias. Nulla optio molestias laboriosam ratione sit voluptas inventore impedit. Molestiae voluptatem adipisci amet quod iusto debitis.", "Amaraland", 2, 380.73m, "Handcrafted Cotton Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 56,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2016, 7, 17, 6, 58, 12, 575, DateTimeKind.Unspecified).AddTicks(5925), "Et voluptas voluptas molestiae soluta reiciendis rerum a corrupti sunt. Repellat dolores sit harum quos velit nemo numquam vitae fugiat. Aut sed saepe praesentium.", "West Orionton", 2, 31.79m, "Intelligent Plastic Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 57,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2015, 4, 26, 8, 19, 18, 343, DateTimeKind.Unspecified).AddTicks(3862), "Quia vero voluptatum reprehenderit et beatae aut. Aliquid maxime labore pariatur vel similique molestiae illo ut facere. Aperiam modi illum.", "Chesleybury", 61.60m, "Handmade Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 58,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2018, 12, 5, 8, 59, 10, 888, DateTimeKind.Unspecified).AddTicks(2790), "Aut tempora ex est qui consequuntur repellendus in consequatur. Ut tempora eius libero reprehenderit fugit aut. Deleniti veritatis nostrum. Quis ullam voluptatibus iste nisi et.", "Eleanoreside", 1, 345.98m, "Sleek Steel Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 59,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2018, 8, 19, 16, 58, 49, 468, DateTimeKind.Unspecified).AddTicks(5749), "Magnam facilis aut asperiores rerum sit voluptas et quis numquam. Omnis velit quaerat. Dolorum itaque inventore autem voluptas dolor. Voluptatem sint est adipisci optio.", "North Maryambury", 516.21m, "Handcrafted Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2019, 12, 19, 14, 51, 24, 725, DateTimeKind.Unspecified).AddTicks(7092), "Quo ad qui laboriosam dolore dolorem recusandae enim occaecati. Voluptas rerum cumque sint numquam eveniet dolorum quos ut dignissimos. Rerum a mollitia et provident illo. Ducimus pariatur labore facilis ea asperiores consequuntur quas quia nobis. Deleniti voluptatem molestiae cum ipsum.", "Ryanfort", 188.96m, "Gorgeous Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 61,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2016, 1, 23, 6, 32, 57, 339, DateTimeKind.Unspecified).AddTicks(7627), "Voluptatem unde ut. Aut repellat qui libero optio quia labore impedit. Quo est recusandae tempora et sit. Sapiente temporibus tempore.", "Lake Samsonfurt", 1, 534.86m, "Licensed Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 62,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2016, 12, 7, 2, 43, 26, 846, DateTimeKind.Unspecified).AddTicks(3352), "Qui omnis quis voluptatem est aut rem aut. Odit quibusdam omnis tempora explicabo distinctio vitae. Quaerat odit non.", "Langworthshire", 1, 245.02m, "Incredible Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 63,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2017, 8, 7, 14, 38, 3, 17, DateTimeKind.Unspecified).AddTicks(5945), "Non accusantium temporibus tempore dolores. Ducimus tenetur voluptatem accusamus quos est et fugit enim est. Laborum nesciunt nihil rerum distinctio temporibus harum iste.", "Port Emmetville", 1, 125.56m, "Fantastic Granite Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 64,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2019, 5, 15, 23, 53, 11, 356, DateTimeKind.Unspecified).AddTicks(2617), "Qui fugit consequatur sequi quia consequatur voluptatem iure quia eius. Quia et vel necessitatibus id iure et labore nesciunt sed. Maiores magni autem adipisci quos. Provident id dicta.", "West Maybelltown", 1, 46.12m, "Generic Soft Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 65,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2019, 3, 7, 15, 43, 23, 751, DateTimeKind.Unspecified).AddTicks(8070), "Nisi eaque rem error mollitia rem beatae nesciunt. Qui officiis numquam consequuntur cum ea aut sint sit vero. Magni et optio tenetur repellendus nulla doloribus. Velit praesentium omnis hic quam minima repellendus. Est molestiae voluptate inventore non non sequi minima eum. Et itaque iusto dignissimos voluptatem officia enim autem culpa.", "West Joshua", 2, 780.74m, "Handmade Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 66,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2019, 3, 16, 16, 33, 11, 977, DateTimeKind.Unspecified).AddTicks(8543), "Pariatur necessitatibus animi veniam deserunt laborum quibusdam quae sed. Quam quia ut molestiae illo sequi ut adipisci. Rerum ipsa optio enim esse quia qui expedita culpa ipsa. Expedita est et sit. Quae fugiat nesciunt. Reiciendis excepturi sit autem voluptas et qui consequatur.", "Kassulkeborough", 2, 778.66m, "Incredible Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 67,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2017, 10, 12, 16, 17, 9, 146, DateTimeKind.Unspecified).AddTicks(7865), "Ducimus tenetur eius. Voluptatem inventore minus. Tenetur at aut quia.", "Lednershire", 125.89m, "Handmade Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 68,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2019, 1, 22, 7, 33, 15, 644, DateTimeKind.Unspecified).AddTicks(1796), "Quo ea aliquid veritatis. Ut et laudantium est vitae tempora voluptatem. Voluptas ex impedit amet dolor. Ut velit consequatur ut dolor rerum nesciunt eaque eum. Est ut aut. Veritatis nostrum et.", "Marcusstad", 685.99m, "Unbranded Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2018, 5, 6, 8, 24, 28, 421, DateTimeKind.Unspecified).AddTicks(9500), "Sapiente quo nemo quidem deleniti eos. Impedit et sunt quam laudantium tempora sunt molestiae. Illum fugit eveniet incidunt eaque quod alias sint culpa ipsum. Et sit dolore. Tempore sit expedita et velit vel. Harum voluptatem quia qui sit dolores magnam dolores.", "Lake Bonita", 711.87m, "Unbranded Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 70,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2018, 5, 6, 18, 3, 3, 670, DateTimeKind.Unspecified).AddTicks(1196), "Illo enim qui officiis autem amet sunt maxime dolores. Tempora tempora culpa amet atque quidem voluptates. Iste accusamus ut ducimus quo velit. Dolorum laboriosam exercitationem id minus nemo rerum commodi. In quia odio ducimus non repellat ipsa. Alias rerum et saepe magni quisquam cumque.", "New Skye", 1, 667.47m, "Tasty Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 71,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2016, 8, 3, 12, 1, 55, 504, DateTimeKind.Unspecified).AddTicks(9863), "Autem eos in voluptatem qui eos doloribus laborum neque. Praesentium et natus eum. Dignissimos eum qui pariatur quos et mollitia quia ipsa. Aut in et delectus est qui. Blanditiis ratione dolore commodi animi. Doloremque doloremque eos odit ut ut tempora.", "Bennyland", 761.98m, "Rustic Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 72,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2016, 2, 7, 12, 17, 57, 526, DateTimeKind.Unspecified).AddTicks(1926), "Ex pariatur est laudantium molestiae facilis iusto autem ratione repellendus. Culpa in nulla quia omnis illum. Excepturi illo earum illum voluptas.", "Gislasonburgh", 1, 802.41m, "Tasty Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 73,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2018, 5, 9, 11, 23, 15, 455, DateTimeKind.Unspecified).AddTicks(5158), "Est nihil similique non. Odit eos vitae et eligendi iste. Voluptatem error atque totam voluptates. Ratione accusantium ut vitae quod sed fuga nulla.", "New Bethany", 589.47m, "Sleek Granite Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 74,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2017, 1, 10, 19, 15, 57, 97, DateTimeKind.Unspecified).AddTicks(5268), "Quae hic vitae id. Quia nihil earum atque reprehenderit ullam error quis adipisci ut. Nihil est nobis consequatur officia.", "Lillieburgh", 967.60m, "Gorgeous Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2020, 1, 17, 12, 3, 59, 909, DateTimeKind.Unspecified).AddTicks(157), "Assumenda tempore velit earum. Sit error dolores soluta commodi explicabo exercitationem unde ullam. Et fuga saepe maxime dignissimos. Omnis molestiae voluptas vel assumenda fuga reiciendis nobis culpa omnis.", "Port Ewald", 521.26m, "Sleek Metal Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 76,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2016, 2, 3, 5, 25, 53, 272, DateTimeKind.Unspecified).AddTicks(629), "Aliquam non aut esse aut saepe qui id eum eum. Laboriosam numquam et accusamus magni eaque iste qui vel aut. Fugiat aliquid quia dolor dolor molestiae adipisci. Labore quia aut facilis quia quibusdam voluptas aliquid et vitae. Voluptas recusandae officiis doloremque consequatur. Minima quo ullam et hic.", "Angelfort", 655.90m, "Handcrafted Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 77,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2018, 1, 3, 11, 45, 40, 261, DateTimeKind.Unspecified).AddTicks(1946), "Ratione officia sit similique quasi architecto quis est et. Cupiditate voluptatem libero a quia velit voluptatum. Sunt saepe consequuntur quis temporibus hic nulla. Aut modi eos blanditiis ut illum ullam. Qui odio cum.", "Cordiemouth", 2, 12.77m, "Intelligent Steel Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 78,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2015, 1, 21, 6, 36, 10, 331, DateTimeKind.Unspecified).AddTicks(335), "Perferendis quisquam et vel facilis. Vero et vel est omnis ut et unde. Provident nihil sapiente sunt tempora aut. Quod nostrum voluptas aut hic et possimus. Nemo provident commodi molestiae consequuntur id.", "South Madeline", 389.65m, "Refined Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 79,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2016, 10, 11, 21, 23, 19, 724, DateTimeKind.Unspecified).AddTicks(2540), "Mollitia et fugiat in esse excepturi velit quos. Quia illo voluptas possimus laborum quae ut quam voluptatem est. Nihil quo sit ut. Sit ea et tempora qui. Sed itaque quia facilis aliquam culpa qui fugit. Sint harum possimus doloremque vel necessitatibus harum quaerat deserunt.", "New Loren", 1, 182.49m, "Licensed Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 80,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2020, 4, 4, 11, 41, 27, 499, DateTimeKind.Unspecified).AddTicks(4438), "Dolorem ut magnam est. Dolorem et delectus temporibus reprehenderit eligendi et. Fuga autem tenetur voluptatem rerum esse unde aut est.", "Connellytown", 1, 353.36m, "Rustic Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 81,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2018, 8, 15, 2, 59, 29, 419, DateTimeKind.Unspecified).AddTicks(358), "Ut consequatur quas laboriosam eos et sed nostrum. Recusandae eveniet est nihil sit velit recusandae dolorem cum. Soluta illo sint commodi aut nobis dolorem eligendi enim. Pariatur autem ut voluptatem. Minima nihil ducimus. Accusantium aliquid ut consequatur nulla delectus et ad non.", "Rathfort", 773.07m, "Incredible Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 82,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2019, 12, 22, 5, 23, 12, 371, DateTimeKind.Unspecified).AddTicks(2086), "Eligendi quis saepe vitae a iste distinctio cumque. Ut maiores atque ex et. Suscipit et tempore in accusamus velit labore. Mollitia vel architecto ipsa harum dolorem velit ducimus.", "North Carissa", 2, 336.13m, "Tasty Granite Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 83,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2017, 12, 12, 21, 11, 8, 455, DateTimeKind.Unspecified).AddTicks(9510), "Quae est nisi esse nobis aspernatur et. Sequi animi non et qui fuga. Nihil aut sint accusantium debitis. Blanditiis error et sed ipsam cupiditate debitis excepturi repellendus doloribus. Quo tempore optio officiis aperiam.", "Flomouth", 956.58m, "Small Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 84,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2015, 10, 20, 8, 13, 15, 250, DateTimeKind.Unspecified).AddTicks(9033), "Accusantium consequatur saepe omnis. Laborum deserunt neque repudiandae numquam consequatur in doloribus. Quis laborum labore voluptate omnis non quam libero eius nesciunt. Et earum nesciunt maxime ut nostrum.", "East Meta", 488.13m, "Licensed Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 85,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2020, 7, 16, 10, 55, 5, 856, DateTimeKind.Unspecified).AddTicks(4556), "Dignissimos doloribus sapiente. Fugit et non quis quas odit molestiae maxime ex temporibus. Veritatis est libero et esse aut molestiae itaque. Ad ea deserunt excepturi molestias voluptatem. Dolorem impedit unde omnis ipsum non tenetur eum.", "South Lewmouth", 326.81m, "Handmade Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 86,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2016, 6, 26, 16, 41, 47, 908, DateTimeKind.Unspecified).AddTicks(3083), "Tempore exercitationem odit occaecati illo iste. Impedit voluptas optio dolor labore iure id eaque. Aut error sed illum voluptas adipisci aut qui dolores. Nam nemo ad id ratione quo saepe.", "East Hank", 2, 442.54m, "Gorgeous Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 87,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2018, 11, 8, 2, 38, 20, 62, DateTimeKind.Unspecified).AddTicks(2140), "Omnis itaque eos recusandae voluptas reiciendis et dolores iste. Voluptatum esse quo eum dignissimos necessitatibus eum. Est unde rerum nisi veritatis qui. Commodi facere ducimus error omnis est quis ipsa. Qui tempore cupiditate autem hic fuga ut. Laboriosam dolor cum repellat qui officiis cum vitae.", "Parisianville", 2, 289.78m, "Unbranded Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 88,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2015, 7, 29, 8, 25, 4, 517, DateTimeKind.Unspecified).AddTicks(1307), "Similique consequatur qui consectetur quis. Et assumenda commodi aut. Aspernatur sed labore consequatur veniam omnis.", "Lorihaven", 771.65m, "Sleek Metal Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 89,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2015, 8, 5, 3, 6, 3, 499, DateTimeKind.Unspecified).AddTicks(7167), "Quo et maiores in asperiores dolores sit a atque. In architecto et porro officiis consectetur dicta. Et sed mollitia. Cum voluptas nisi qui dicta suscipit omnis dicta et atque.", "Port Julianne", 1, 942.94m, "Sleek Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 90,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2018, 1, 10, 17, 43, 9, 809, DateTimeKind.Unspecified).AddTicks(4030), "Inventore consequatur et. Quibusdam vero sit libero sit quia sed molestiae iure. Inventore velit quae repellat sit qui consequatur explicabo. Recusandae consectetur non nobis iure debitis perspiciatis non.", "New Margret", 268.61m, "Awesome Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 91,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2018, 5, 6, 6, 4, 17, 835, DateTimeKind.Unspecified).AddTicks(1014), "Dolore assumenda animi iste voluptas rerum. Inventore cum qui eveniet repellat delectus nesciunt recusandae in. Ipsum harum temporibus rem est non corporis quo reprehenderit. Eligendi est blanditiis quaerat quia illo et. Neque officia autem nulla maxime vitae. Pariatur magni est cum corporis autem.", "Rogahnfurt", 751.47m, "Practical Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2017, 1, 6, 11, 54, 32, 979, DateTimeKind.Unspecified).AddTicks(8365), "Sed aut suscipit modi aut sunt. Suscipit facere est maiores quos voluptas rerum impedit maiores quibusdam. Culpa eaque sunt ratione voluptates reiciendis dolor molestias rerum. Quidem aut quia nostrum provident qui et reiciendis voluptatem et. Sequi minus delectus fuga. Omnis sit molestiae.", "Jacklyntown", 798.56m, "Small Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 93,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2016, 1, 18, 13, 36, 4, 153, DateTimeKind.Unspecified).AddTicks(6695), "Quis nobis ab cumque rerum ducimus. A non aliquam qui quo ipsum omnis molestiae. Quia occaecati eveniet numquam mollitia. Sit iusto harum.", "East Kirkchester", 1, 35.03m, "Handcrafted Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 94,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2016, 4, 3, 19, 50, 9, 753, DateTimeKind.Unspecified).AddTicks(3973), "Cum error et modi dolores. Est dolorem et corrupti quis. Labore qui nostrum qui voluptas quis ex. Et itaque dolorem sed incidunt eveniet animi. Ipsa voluptatibus tempore a et at voluptas suscipit voluptatem autem.", "Alexandreachester", 464.88m, "Fantastic Soft Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 95,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2016, 2, 22, 21, 50, 26, 920, DateTimeKind.Unspecified).AddTicks(2216), "Nisi deserunt aut architecto sed quod in rerum. Mollitia optio repellendus consequuntur facilis vel voluptas rerum eum est. Doloribus totam optio quia ut animi iste consequatur eum consequatur. In ducimus reprehenderit.", "Arnoldhaven", 544.49m, "Handcrafted Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2020, 2, 3, 21, 52, 10, 744, DateTimeKind.Unspecified).AddTicks(9381), "Laboriosam id maiores a laboriosam velit deserunt ut distinctio officiis. Temporibus ipsum animi sit doloremque fugit maiores dolores ullam suscipit. Consequatur qui deleniti nisi qui molestias sit repellendus. Nihil doloribus reiciendis.", "Lake Geraldine", 2, 871.99m, "Handcrafted Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 97,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2020, 8, 6, 14, 32, 42, 588, DateTimeKind.Unspecified).AddTicks(1422), "Autem illo sint. Sunt reprehenderit dolores eaque deserunt id minus aliquam voluptatum asperiores. Dicta occaecati officiis repellendus amet quibusdam adipisci suscipit.", "New Dee", 2, 318.78m, "Licensed Granite Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 98,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2015, 12, 24, 3, 27, 43, 390, DateTimeKind.Unspecified).AddTicks(8225), "Cum officia aut optio optio non tenetur eum expedita dicta. Qui tempore alias porro. Eos voluptatibus alias voluptatem dolor porro. Quaerat nulla architecto nobis perspiciatis dolorem est.", "New Amy", 26.82m, "Small Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 99,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2017, 6, 28, 7, 44, 23, 200, DateTimeKind.Unspecified).AddTicks(1187), "Soluta minima sint pariatur facilis aut est eaque eos. Sed neque temporibus sapiente aperiam. At dolorum non velit eius ab deserunt esse laboriosam. Repellat eius reiciendis nobis saepe doloremque esse quis. Ad maxime asperiores. Debitis assumenda consequuntur totam ut quia.", "Ferrytown", 463.04m, "Awesome Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 100,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2016, 7, 17, 1, 39, 19, 497, DateTimeKind.Unspecified).AddTicks(7350), "Aspernatur molestias asperiores consequatur omnis veritatis blanditiis commodi. Maxime esse molestiae omnis odit vero consectetur. Rerum sunt qui ex et dignissimos velit hic. Esse commodi molestiae qui voluptatibus dolor ea officia facilis. Iusto et numquam et perferendis accusamus.", "Camdenfort", 2, 122.96m, "Handcrafted Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "PhoneNumber", "UserName" },
                values: new object[] { "61992ee8-d314-4ab3-b102-eaf6e46ab617", "Margie.Streich@gmail.com", "Streich", "724-821-2322 x4884", "Margie.Streich20" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "PhoneNumber", "UserName" },
                values: new object[] { "343a77a1-ede0-4ed6-b54a-c95ae323a9b9", "Vanessa.Hegmann14@gmail.com", "Hegmann", "1-535-833-7619 x816", "Vanessa.Hegmann" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "Name",
                value: "Детские товары");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "Name",
                value: "Техника и электроника");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "Name",
                value: "Хобби и отдых");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "Name",
                value: "Свадьба и праздники");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "Name",
                value: "Автотовары");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "Name",
                value: "Сад и огород");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "Name",
                value: "Здоровье");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "Name",
                value: "Спорт, туризм и активный отдых");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "Name",
                value: "Ремонт и стройка");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                column: "Name",
                value: "Другое");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 17,
                column: "CategoryId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 18,
                column: "CategoryId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 19,
                column: "CategoryId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 20,
                column: "CategoryId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 21,
                column: "CategoryId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 22,
                column: "CategoryId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 23,
                column: "CategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 24,
                column: "CategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 25,
                column: "CategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 26,
                column: "CategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 27,
                column: "CategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 28,
                column: "CategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 29,
                column: "CategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 30,
                column: "CategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 31,
                column: "CategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 32,
                column: "CategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 33,
                column: "CategoryId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 34,
                column: "CategoryId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 35,
                column: "CategoryId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 36,
                column: "CategoryId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 37,
                column: "CategoryId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 38,
                column: "CategoryId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 39,
                column: "CategoryId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 40,
                column: "CategoryId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 41,
                column: "CategoryId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 42,
                column: "CategoryId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 43,
                column: "CategoryId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 44,
                column: "CategoryId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 45,
                column: "CategoryId",
                value: 9);

            migrationBuilder.CreateIndex(
                name: "IX_UserAds_AdId",
                table: "UserAds",
                column: "AdId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAds_UserId",
                table: "UserAds",
                column: "UserId");
        }
    }
}
