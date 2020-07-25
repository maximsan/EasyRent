using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyRent.Data.Migrations
{
    public partial class ChangeAdAndSeedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsGift",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "MaxDays",
                table: "Ads");

            migrationBuilder.AddColumn<int>(
                name: "Available",
                table: "Ads",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Ads",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Ads",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, null, "4800fa54-5f03-43c0-9a45-4fdbc6bd2cb9", "Patrick.Raynor63@yahoo.com", true, "Raynor", null, false, null, null, null, null, "1-708-575-3690", true, null, false, "Patrick_Raynor" },
                    { 2, 0, null, "49cf63c6-3b73-4693-ad6f-f0c10ec0aa89", "Mathew.Boyer@yahoo.com", true, "Boyer", null, false, null, null, null, null, "957.971.3376 x4163", true, null, false, "Mathew94" }
                });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 1,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2017, 5, 26, 8, 44, 21, 894, DateTimeKind.Unspecified).AddTicks(1017), "Excepturi illum et provident aliquid ut deleniti sequi. Odio debitis possimus. Fugiat voluptatum ea et ex ut et. Reprehenderit ipsam nostrum maiores nobis aliquid. Temporibus id aut aut maiores architecto nihil commodi.", "North Sylvan", 1, 56.06m, "Handcrafted Frozen Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 2,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2019, 1, 10, 4, 0, 23, 472, DateTimeKind.Unspecified).AddTicks(6910), "Nisi sed in reiciendis quia vel. Quia quas suscipit perspiciatis libero. Et consequatur corporis et voluptas assumenda occaecati voluptate aut hic.", "Irwinside", 2, 129.24m, "Fantastic Granite Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 3,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2019, 6, 3, 17, 24, 11, 261, DateTimeKind.Unspecified).AddTicks(1753), "Qui laboriosam doloremque ut quia. Corporis eos quia dolores labore inventore accusamus est et. Aut autem harum ipsa ut aliquam consequatur provident nostrum nobis. Nam dolorum laborum cumque eos explicabo rem repellendus delectus in. Mollitia possimus aut dolore dolorem sunt quia vero quaerat. Eum aut et totam saepe vero aspernatur voluptas non.", "New Jenifer", 2, 864.19m, "Generic Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 4,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2016, 7, 29, 22, 51, 34, 209, DateTimeKind.Unspecified).AddTicks(4065), "Nam animi earum omnis debitis earum maiores molestiae quisquam. Iusto nihil aspernatur fugiat id. Ut dolore labore quis blanditiis odio ut magnam. Saepe praesentium consequatur.", "West Berenice", 2, 895.24m, "Refined Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 5,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2018, 2, 11, 17, 52, 16, 631, DateTimeKind.Unspecified).AddTicks(165), "Fugit eveniet consequatur quia dolor et voluptas consequatur molestias illum. At est voluptatem consequatur modi optio est. Maiores deleniti reiciendis aut nihil eius ut natus.", "New Jacechester", 2, 542.85m, "Intelligent Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2015, 8, 1, 4, 16, 10, 616, DateTimeKind.Unspecified).AddTicks(557), "Consequuntur et et. Id aliquam ipsum voluptas laborum earum qui. Sit aperiam iusto dolores repellendus.", "Port Loy", 2, 507.03m, "Generic Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 7,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2018, 8, 22, 14, 54, 16, 739, DateTimeKind.Unspecified).AddTicks(3179), "Aut deserunt ut laborum harum vero eum deleniti est. Delectus consequatur quisquam excepturi est accusamus quam cupiditate. Rerum consequuntur est dolore. Iusto provident atque molestias ducimus qui porro et assumenda.", "Lake Felicitystad", 2, 678.17m, "Fantastic Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 8,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2016, 8, 9, 15, 58, 46, 77, DateTimeKind.Unspecified).AddTicks(9621), "Repellendus dolores esse sit nobis. Iusto sint rerum aperiam nisi velit. Aspernatur quis voluptatem aperiam. Ut laboriosam animi facilis. Autem aliquam maxime dolores perferendis minima rem mollitia. Repellendus dolorem placeat aliquid explicabo voluptatem quo.", "East Deondreview", 1, 770.00m, "Small Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2016, 3, 7, 9, 29, 25, 136, DateTimeKind.Unspecified).AddTicks(5607), "Qui et tempore eos molestiae ipsa non earum ea quam. Dolorem odio autem velit. Aliquid voluptatem tempora. Dolores placeat ratione nisi non itaque consequatur quo et. Non asperiores pariatur et qui magni quos est molestiae.", "West Omahaven", 1, 773.38m, "Small Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 10,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2019, 1, 10, 4, 41, 55, 243, DateTimeKind.Unspecified).AddTicks(2569), "Veritatis pariatur totam reiciendis quas voluptas non corrupti cum. Optio excepturi quia. Ipsam consequatur aut minima. Maxime aspernatur quia odio est necessitatibus quis. Earum id sequi fugiat facere. Et recusandae alias nesciunt nulla et dolorem cum iusto autem.", "North Faymouth", 1, 777.20m, "Tasty Granite Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 11,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2018, 7, 18, 13, 11, 31, 126, DateTimeKind.Unspecified).AddTicks(9915), "Velit maxime sunt dolores alias doloribus aut occaecati quaerat earum. Est nemo ipsam est consequuntur et ex. Nam et adipisci. Ut aut unde doloribus dicta repudiandae aut repellendus. Placeat quae officia esse possimus dolores neque nobis.", "Rupertshire", 1, 133.09m, "Handmade Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 12,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2017, 11, 15, 10, 33, 12, 44, DateTimeKind.Unspecified).AddTicks(6219), "Consequuntur sit dicta numquam explicabo omnis voluptas. Alias quibusdam id ratione nesciunt rerum. Quaerat est ut.", "East Clarabelle", 1, 381.96m, "Ergonomic Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2015, 10, 17, 13, 6, 30, 372, DateTimeKind.Unspecified).AddTicks(7640), "Numquam et ipsa ipsum deserunt. Sapiente autem voluptatem sed dolorem quo nobis facere. Quo aut eos assumenda.", "Port Lowellmouth", 2, 910.35m, "Practical Soft Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 14,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2015, 4, 8, 0, 2, 2, 401, DateTimeKind.Unspecified).AddTicks(4548), "Quis est qui aut odit. Nostrum nostrum ullam aliquid repudiandae dolorem doloribus voluptatum optio ea. Autem perspiciatis molestiae dolore officiis odio in inventore. Maxime pariatur eum illum. Quod dignissimos vero laboriosam aperiam. Dignissimos minus maiores sunt.", "Port Keira", 1, 724.51m, "Awesome Frozen Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 15,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2019, 5, 30, 23, 28, 23, 419, DateTimeKind.Unspecified).AddTicks(7532), "Fugiat veritatis et. Aut maxime aut dolore. Praesentium deleniti reiciendis quia est dolores. Distinctio consectetur dolore rerum. Ex est sapiente aut pariatur corrupti non.", "Schmidtburgh", 2, 371.59m, "Handmade Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 16,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2015, 3, 10, 17, 44, 54, 293, DateTimeKind.Unspecified).AddTicks(7924), "Possimus quod consequuntur perferendis et culpa omnis pariatur. Consequatur iure aliquid velit maiores deleniti voluptatum nostrum ut. Nesciunt quaerat omnis ducimus facilis.", "North Darrenview", 2, 114.53m, "Incredible Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 17,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2020, 6, 15, 2, 58, 0, 221, DateTimeKind.Unspecified).AddTicks(7893), "Possimus provident ullam ullam. Molestiae maiores velit recusandae ipsum omnis modi dolores. Corporis et alias dignissimos repellat nostrum. Quo quia ut beatae id odio. Omnis voluptatem et aut distinctio dolore sed. Doloremque vero dolorum.", "South Daren", 2, 242.16m, "Unbranded Granite Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 18,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2016, 3, 19, 21, 22, 0, 479, DateTimeKind.Unspecified).AddTicks(9630), "Aut necessitatibus non. Sint quia hic eius ut maiores rem eos. Occaecati distinctio natus rerum delectus exercitationem totam. Qui distinctio eum magnam.", "Germanhaven", 2, 833.14m, "Handmade Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 19,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2015, 6, 7, 9, 56, 19, 618, DateTimeKind.Unspecified).AddTicks(6770), "Et et et beatae. Quisquam ut doloribus quis fuga esse vel nobis. Debitis cumque et.", "Goyetteberg", 1, 699.45m, "Sleek Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 20,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2018, 12, 11, 3, 31, 48, 31, DateTimeKind.Unspecified).AddTicks(8422), "Rerum sit ut ducimus nihil eum ut quos reprehenderit quas. Ipsam quo aut. Ut inventore ratione distinctio quisquam illum aliquid reprehenderit ut maiores. Consequatur ullam reiciendis alias magnam sunt.", "Bashirianchester", 1, 292.79m, "Practical Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2015, 1, 17, 11, 57, 18, 696, DateTimeKind.Unspecified).AddTicks(3661), "Dolor voluptates eos laborum ut at. Labore atque libero. Nostrum itaque nihil praesentium. Vel quae excepturi iure aliquam non ea et voluptatem soluta.", "Maryhaven", 1, 953.75m, "Intelligent Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 22,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2017, 6, 20, 13, 28, 24, 953, DateTimeKind.Unspecified).AddTicks(1376), "Hic consequuntur voluptatibus aut sunt nostrum. Odio aliquid maxime voluptates enim sit corrupti optio dicta magni. Omnis veritatis praesentium nam sit voluptas ex non. Provident esse non laborum eum esse. Explicabo iure voluptate dolore odio et ut quo voluptas omnis.", "Morarstad", 2, 700.68m, "Unbranded Soft Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 23,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2016, 12, 14, 19, 45, 2, 974, DateTimeKind.Unspecified).AddTicks(9904), "Autem et et natus consequatur. Accusantium nihil magni cupiditate vero. Reprehenderit enim soluta rerum quia. Nesciunt placeat laboriosam omnis unde quod. Dolor fuga et illo ipsum eos et quae consequatur deserunt. Deserunt debitis quaerat ut nobis et est quaerat possimus.", "West Lavina", 2, 107.63m, "Tasty Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 24,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2019, 10, 7, 19, 18, 28, 557, DateTimeKind.Unspecified).AddTicks(8956), "Repudiandae expedita accusantium. In consequatur sapiente distinctio tenetur corporis culpa porro. Nostrum sit modi dolorum veritatis et et quis maiores harum.", "North Josianne", 1, 60.04m, "Unbranded Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 25,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2019, 8, 15, 12, 10, 15, 907, DateTimeKind.Unspecified).AddTicks(1010), "Modi ut et quis sed nobis mollitia aut. Qui aut dolor cumque et vel qui consequuntur sint suscipit. Non voluptatem omnis quo debitis enim accusantium quo in. Quisquam consequatur minima et aut doloribus. Est saepe eius est dolor distinctio maxime ratione laboriosam.", "North Adelle", 1, 823.05m, "Handmade Plastic Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 26,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2016, 7, 8, 5, 16, 23, 618, DateTimeKind.Unspecified).AddTicks(7666), "Voluptate tempora expedita. Ea cupiditate consequatur excepturi ut dicta quibusdam qui voluptates. Dolorum sed consequuntur placeat ea. Error ut hic repellat dolorem in porro autem ex. Et voluptates enim minus consequatur libero.", "Tobymouth", 1, 140.44m, "Handmade Metal Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2020, 7, 4, 15, 24, 31, 318, DateTimeKind.Unspecified).AddTicks(1989), "Est saepe nihil repellat voluptas accusamus. Accusamus ad distinctio recusandae eum aut harum. Qui eius rerum excepturi. Maiores tenetur iste velit. Eius quasi non aspernatur soluta voluptas quidem nam nisi est. Maxime accusamus et odio non et.", "Port Zander", 1, 946.07m, "Incredible Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 28,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2018, 5, 9, 6, 51, 26, 403, DateTimeKind.Unspecified).AddTicks(18), "Reprehenderit est laboriosam molestias voluptatem dolorum quibusdam deserunt. Mollitia eveniet ullam dolorem laudantium maiores est nihil aliquid. Architecto sapiente atque natus expedita sed doloremque rerum ut. Aut fuga esse sapiente molestiae hic. Quia labore nulla ducimus rerum dolorum qui quibusdam consequatur optio.", "Swaniawskiland", 2, 793.05m, "Gorgeous Metal Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2015, 10, 30, 19, 15, 6, 959, DateTimeKind.Unspecified).AddTicks(4797), "Corporis asperiores id eum ratione distinctio ut deleniti. Et excepturi aut error laudantium. Quis et nisi possimus voluptas est molestias.", "North Roxanefurt", 2, 824.37m, "Unbranded Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 30,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2017, 8, 13, 14, 43, 5, 773, DateTimeKind.Unspecified).AddTicks(7283), "At quo consequatur rem quasi dolorem cupiditate ea ut ea. Tempora qui velit. Ipsum et voluptatem dignissimos. Quibusdam maxime quisquam.", "Kunzefort", 1, 51.27m, "Generic Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 31,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2019, 8, 19, 7, 40, 35, 436, DateTimeKind.Unspecified).AddTicks(398), "Distinctio dolorum officiis nobis earum consequuntur ratione impedit. Voluptas molestiae consequatur quisquam minus consectetur porro saepe. Voluptate eos odit doloribus. Reiciendis incidunt est non vel ducimus necessitatibus error aut. Unde dolores unde iste laudantium.", "Syblefurt", 2, 35.19m, "Ergonomic Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 32,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2016, 11, 6, 23, 53, 58, 227, DateTimeKind.Unspecified).AddTicks(1107), "Culpa modi porro reprehenderit perspiciatis. Temporibus eveniet qui ipsum adipisci voluptas voluptatem voluptas. Quia quo quia labore rerum. Molestiae quisquam et corrupti. Et optio et. Dignissimos quasi deserunt quasi enim nisi.", "Port Abbey", 2, 823.31m, "Handmade Metal Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 33,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2018, 12, 16, 12, 29, 30, 717, DateTimeKind.Unspecified).AddTicks(7339), "Vero maxime sed voluptatem fuga. Numquam voluptatem et eius. Rem facere sunt doloribus illo est consequuntur ipsum consectetur blanditiis. Earum vel quia esse rerum et esse iure temporibus id. Et voluptas neque veniam exercitationem. Ducimus vero nesciunt nulla dolorem alias.", "Antoniettafurt", 2, 669.94m, "Tasty Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2019, 10, 30, 14, 5, 19, 32, DateTimeKind.Unspecified).AddTicks(8470), "Nemo reiciendis non voluptatem quo id fugit molestiae exercitationem. Dolores magnam eum assumenda. Nobis est suscipit exercitationem dicta est. Facilis nisi numquam eum blanditiis omnis quia saepe est. Repudiandae ex reiciendis ipsam ut amet qui quam qui. Nihil ea itaque esse voluptas consectetur dolor eveniet.", "Framimouth", 2, 840.03m, "Small Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 35,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2020, 2, 5, 14, 38, 4, 61, DateTimeKind.Unspecified).AddTicks(4277), "Eius in dignissimos quis laboriosam. Autem fugit ducimus sed consectetur officiis. Aperiam odit quis voluptate quibusdam. Ut animi nemo voluptates deleniti non architecto voluptas atque maiores.", "North Devon", 1, 140.47m, "Fantastic Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 36,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2019, 11, 5, 9, 7, 38, 907, DateTimeKind.Unspecified).AddTicks(5736), "Veritatis ducimus ducimus illo soluta atque. Iure quae praesentium dolore saepe perferendis minus voluptates quos delectus. Ut ratione enim magni. Qui non minus.", "Langworthfort", 2, 370.29m, "Refined Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 37,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2018, 2, 11, 5, 29, 43, 447, DateTimeKind.Unspecified).AddTicks(7949), "Non officia voluptas explicabo earum et. Consequatur quia distinctio laborum vel hic voluptate consequatur modi dicta. Consequatur illo consequuntur rerum occaecati atque officia cum dolorum non. Ratione velit ab aperiam ut.", "Marianefort", 1, 216.34m, "Intelligent Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 38,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2018, 7, 8, 12, 39, 10, 763, DateTimeKind.Unspecified).AddTicks(4912), "Quam et voluptates in repellendus animi dolores voluptate exercitationem culpa. Voluptas molestias voluptatem. Consequatur aspernatur reiciendis laudantium natus. Voluptate est dolores ea accusamus maxime amet unde similique. Eius qui id aliquam consectetur. Accusamus ea mollitia iste fuga dolore ab.", "Westonchester", 1, 924.87m, "Unbranded Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 39,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2017, 3, 26, 3, 21, 27, 600, DateTimeKind.Unspecified).AddTicks(6821), "Expedita omnis repellat. At nemo vero qui et at quaerat et consequatur explicabo. Tempora dolorum et consequatur sequi neque est non molestiae.", "Lake Eldabury", 2, 107.32m, "Handcrafted Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 40,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2016, 7, 18, 8, 35, 53, 303, DateTimeKind.Unspecified).AddTicks(4083), "Dignissimos quod magnam assumenda sint consequatur facere porro aut. Et iure ut perferendis aut suscipit quae nulla recusandae dolore. Possimus aperiam perferendis dignissimos dolorum sed voluptatum. Quas omnis natus. Aliquid quia consequuntur facere iure facilis sint est impedit ex. Quos accusantium accusamus eligendi ea et ex ea mollitia deserunt.", "New Melany", 1, 237.46m, "Incredible Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 41,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2019, 3, 5, 4, 45, 22, 98, DateTimeKind.Unspecified).AddTicks(1776), "Voluptatum aut quo nulla. Distinctio velit sit rem eos in magni. Quam placeat nulla quasi odit ratione ex.", "Haleytown", 1, 487.19m, "Practical Granite Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 42,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2020, 6, 6, 6, 13, 33, 876, DateTimeKind.Unspecified).AddTicks(494), "Maxime magnam unde. At natus quia optio sed culpa quia odio nostrum in. Et ratione nihil quia mollitia sequi et ad.", "Lake Felipeview", 1, 66.37m, "Generic Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 43,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2015, 3, 10, 21, 32, 52, 654, DateTimeKind.Unspecified).AddTicks(6789), "Accusamus omnis doloribus excepturi repellendus. Sequi eum adipisci est adipisci voluptas. Nesciunt id modi nostrum voluptate ut rerum reiciendis iure. Quas dolores quaerat aspernatur.", "Durganland", 1, 583.04m, "Tasty Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 44,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2019, 3, 12, 5, 40, 33, 628, DateTimeKind.Unspecified).AddTicks(9270), "Cumque est necessitatibus ut modi sequi qui voluptatem iusto. Voluptatem nobis qui odio odio exercitationem atque id corrupti. Cupiditate aliquid in quia quae accusantium. Est ea consequuntur eius. Deserunt deserunt sed ullam dicta quam non ut omnis.", "O'Reillyside", 2, 60.84m, "Practical Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 45,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2015, 8, 9, 7, 59, 37, 296, DateTimeKind.Unspecified).AddTicks(744), "Voluptatem quis ut dolore porro et velit et recusandae ut. Et ea explicabo vero ut. Quia et tempore qui. Provident est quos fugit officia saepe quod eveniet non. Iusto nulla enim nemo vero ab quis. Minus odio et sunt ex minima.", "Fredrickburgh", 1, 271.69m, "Generic Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 46,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2017, 11, 20, 11, 13, 6, 855, DateTimeKind.Unspecified).AddTicks(5574), "Facere animi suscipit corporis neque eaque eligendi minus. Excepturi qui omnis vel. Quo similique earum. Non odio sit numquam esse eius fuga rem. Ut sunt voluptas quae omnis. Velit ullam assumenda neque molestiae minima in.", "New Arvilla", 2, 186.71m, "Awesome Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 47,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2018, 3, 24, 13, 23, 18, 119, DateTimeKind.Unspecified).AddTicks(8116), "Veniam voluptatem quia. Amet fugit soluta eligendi facere molestiae facilis. Totam ipsa alias dolor autem quasi ea excepturi nihil.", "Alizachester", 1, 129.48m, "Intelligent Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 48,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2015, 8, 17, 4, 30, 59, 897, DateTimeKind.Unspecified).AddTicks(4658), "Rerum quos incidunt officiis. Qui ab maxime officia dolorem ut reiciendis eius porro. Quisquam impedit est aperiam excepturi et cum.", "Duanestad", 1, 410.84m, "Tasty Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 49,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2019, 9, 4, 16, 20, 17, 879, DateTimeKind.Unspecified).AddTicks(7858), "Occaecati unde assumenda nemo aperiam atque ex assumenda. Consequatur quasi minus voluptates excepturi dolorem dolor accusamus ipsa. Distinctio molestias enim voluptas. Quaerat ut et est delectus voluptatum quo impedit molestias sint.", "Port Vellabury", 1, 690.35m, "Awesome Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2017, 4, 13, 20, 47, 41, 211, DateTimeKind.Unspecified).AddTicks(9388), "Dignissimos ad animi et rerum dolores consequatur. Magnam impedit vel quae. At maxime et commodi aut ea tempora qui. Non tempora laudantium aliquid culpa. Dolorum et repellat maxime vel nulla amet. Consequatur incidunt necessitatibus in optio.", "Port Demarcus", 1, 142.01m, "Fantastic Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 51,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2019, 3, 28, 16, 59, 35, 205, DateTimeKind.Unspecified).AddTicks(5668), "Et odit magni veritatis quis omnis deserunt iste nemo. Qui impedit et nam quo libero velit. Magni vitae repellendus provident beatae consequatur. Dicta odit ut rerum explicabo ut tenetur consequuntur eveniet qui. Illo enim asperiores qui exercitationem voluptatem iure quod. Ut architecto eligendi dolorem.", "Port Luluborough", 1, 786.73m, "Ergonomic Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 52,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2019, 10, 18, 14, 35, 33, 558, DateTimeKind.Unspecified).AddTicks(3194), "Tempore non eaque accusamus. Dolorem itaque aspernatur et eos dignissimos soluta. Voluptas qui laboriosam et esse aut esse sit vero. Saepe id nisi. Est impedit exercitationem dolorem impedit dolor ab ut dolor.", "Destineyshire", 2, 906.06m, "Handmade Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 53,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2019, 12, 15, 19, 30, 57, 849, DateTimeKind.Unspecified).AddTicks(1458), "Reiciendis eligendi occaecati est ad. Veritatis vel sed qui voluptatem. Sit voluptas reprehenderit quia. Minus eveniet id esse delectus quidem voluptatibus blanditiis odit distinctio. Qui incidunt est. Nisi ut harum perferendis est deleniti et cupiditate maiores sed.", "South Zitachester", 2, 574.34m, "Practical Metal Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 54,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2015, 12, 25, 5, 55, 27, 929, DateTimeKind.Unspecified).AddTicks(706), "Perferendis inventore sed incidunt ipsum mollitia rerum commodi rerum qui. Eveniet autem optio vel unde. Corporis autem facere debitis et beatae. Id provident incidunt ducimus commodi nisi modi ipsum vitae distinctio.", "Vernaberg", 1, 248.55m, "Gorgeous Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 55,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2019, 7, 31, 1, 46, 28, 204, DateTimeKind.Unspecified).AddTicks(9129), "Dolor qui exercitationem ut in dolorem qui molestias alias. Voluptatibus omnis dolores. Commodi et repellat perspiciatis incidunt voluptatem vel magni. Quam enim et. Ducimus porro cumque.", "Walterburgh", 1, 911.31m, "Handmade Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 56,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2020, 3, 4, 23, 21, 28, 121, DateTimeKind.Unspecified).AddTicks(7182), "Distinctio excepturi reiciendis nobis facere fuga error. Dolor harum officiis cupiditate aut et et. Incidunt sequi consequuntur rerum temporibus ullam autem aut labore. Necessitatibus eos ut quia animi quia autem. Rem similique dignissimos fuga. Esse rerum quia cupiditate aspernatur aspernatur.", "Turcotteton", 2, 850.44m, "Gorgeous Rubber Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 57,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2017, 8, 28, 23, 51, 29, 982, DateTimeKind.Unspecified).AddTicks(4320), "Delectus ducimus dolorem id. Consectetur alias aperiam cumque ratione est sit dicta. Est distinctio impedit veritatis et est. Repudiandae qui nobis autem aut.", "New Rafaelberg", 1, 549.27m, "Practical Wooden Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 58,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2019, 11, 17, 7, 33, 56, 187, DateTimeKind.Unspecified).AddTicks(7674), "Maiores cupiditate et in. Consequuntur sint voluptas pariatur maiores magni eius voluptas. Officia vero illo asperiores. Earum est quia esse modi qui. Voluptatem architecto et hic et suscipit doloremque.", "Murrayberg", 1, 210.10m, "Sleek Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 59,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2017, 10, 6, 5, 24, 27, 240, DateTimeKind.Unspecified).AddTicks(4666), "Accusantium repellendus minima occaecati sunt nihil sit voluptas. Dolores eos odit voluptas rerum quae consequatur voluptas. Eveniet omnis autem. Rerum ut laboriosam est. Sit non et dignissimos et illum unde.", "Lake Aliya", 1, 553.58m, "Ergonomic Granite Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 60,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2020, 6, 14, 7, 38, 39, 126, DateTimeKind.Unspecified).AddTicks(5231), "Consequatur similique voluptas placeat. Dolores voluptatem quae. Quo eveniet quod sit et aut repellat voluptates tempore illo. Nostrum exercitationem occaecati incidunt assumenda nostrum doloremque quis corporis exercitationem. Quas est adipisci veniam ut quam sit aperiam nemo officia. Nam officia sint ullam quis nesciunt facilis magnam qui.", "Ernestofort", 1, 853.59m, "Ergonomic Steel Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 61,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2020, 7, 5, 21, 33, 41, 216, DateTimeKind.Unspecified).AddTicks(4447), "Officia earum reprehenderit delectus maiores rerum voluptates in. Quidem placeat consequatur occaecati harum non ipsam totam. Accusamus est illo quo ad quia a nisi non et. Sed quis velit rerum accusantium architecto est cupiditate sit iure. Minus tempore vero maiores culpa dignissimos sit. Quia numquam excepturi dolorem ut modi.", "Sedrickfurt", 2, 220.03m, "Small Metal Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 62,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2019, 11, 29, 23, 39, 56, 261, DateTimeKind.Unspecified).AddTicks(9314), "Qui dolores iste veniam autem dolores provident. Doloribus eum at nostrum deserunt. Aut est quibusdam tempore eligendi laudantium sapiente. Suscipit velit voluptatibus corporis quia quod.", "Lake Wilmaborough", 1, 636.32m, "Small Metal Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 63,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2015, 12, 29, 9, 43, 33, 533, DateTimeKind.Unspecified).AddTicks(8825), "Rerum incidunt nemo voluptatem vel. Quos harum expedita consectetur perferendis quo rerum qui. Nesciunt ex corporis corrupti vel. Voluptatem dolore in cupiditate et natus et ipsum necessitatibus.", "Fritschburgh", 2, 168.29m, "Ergonomic Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 64,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2016, 10, 15, 2, 14, 56, 233, DateTimeKind.Unspecified).AddTicks(7781), "Et omnis ut. Placeat ducimus ea cum cupiditate ut. Error molestias dolorum voluptatibus voluptates et est quasi est praesentium. Incidunt voluptas occaecati porro molestias quia dolores dolor cumque. Reiciendis soluta fugiat eligendi et doloremque et aut in. Commodi quam ipsam facere distinctio praesentium.", "North Mariliehaven", 2, 608.90m, "Rustic Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 65,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2015, 4, 19, 23, 28, 36, 497, DateTimeKind.Unspecified).AddTicks(7830), "Minima perspiciatis ut voluptas consequuntur qui dolorem temporibus quis deleniti. Qui a quis delectus ea vel. Assumenda inventore quae repudiandae sit et.", "Douglasfort", 1, 35.14m, "Rustic Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2015, 12, 6, 11, 46, 6, 694, DateTimeKind.Unspecified).AddTicks(7045), "Perferendis culpa consectetur dolorem quo tempore et quidem non inventore. Vero soluta quaerat molestias facere quia aut saepe. Non pariatur sit et placeat.", "Mosciskiside", 1, 253.60m, "Practical Frozen Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 67,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2019, 10, 28, 17, 57, 36, 673, DateTimeKind.Unspecified).AddTicks(6276), "Id modi autem asperiores vel. Omnis unde reiciendis ex voluptates. Rem pariatur eveniet minima facere molestiae dolorem natus ut.", "North America", 2, 6.21m, "Fantastic Soft Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 68,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2018, 5, 17, 16, 47, 48, 64, DateTimeKind.Unspecified).AddTicks(2139), "Dolores animi facere sint quis. Natus aliquam quis est. Impedit ab dolor similique ab molestias. Qui modi libero asperiores amet dolor. Doloribus asperiores dolores et nobis. Nobis eaque qui reiciendis dolore.", "Lake Georgianaburgh", 2, 606.55m, "Incredible Fresh Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 69,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2018, 1, 4, 15, 48, 17, 67, DateTimeKind.Unspecified).AddTicks(6038), "Inventore ea minima vitae. Laborum quas esse in adipisci eum sequi et. Est corrupti facere tempore totam aut quia. Maxime doloremque nemo et commodi aspernatur perspiciatis sunt voluptatibus aperiam. Enim deserunt quia aut animi reprehenderit.", "Krajcikfort", 1, 570.60m, "Awesome Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2015, 12, 29, 9, 9, 53, 95, DateTimeKind.Unspecified).AddTicks(6185), "Tempore atque quibusdam ut sequi et dolore omnis aperiam. Ea accusamus consequatur non. Omnis autem aut consequatur voluptatum.", "East Jermaineborough", 2, 489.61m, "Incredible Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2018, 12, 14, 16, 7, 37, 785, DateTimeKind.Unspecified).AddTicks(3250), "Porro enim unde deserunt consequatur odio. Voluptas dolorem ex est quasi delectus error ea. Commodi maxime optio quo soluta nihil reprehenderit doloribus. Esse qui dignissimos numquam animi a. Molestias voluptatum quis ut quibusdam ipsum molestiae. Distinctio quo voluptas et assumenda quaerat cupiditate.", "Schummbury", 2, 814.03m, "Incredible Frozen Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 72,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2017, 12, 5, 18, 9, 39, 98, DateTimeKind.Unspecified).AddTicks(4539), "Tenetur dolorum voluptatem. Tempora in dolores error corrupti minima blanditiis. Adipisci voluptatem consequuntur dolor delectus vel totam modi quia. Ab fuga fugiat repellendus et et ducimus assumenda ad voluptatibus. Quae voluptatum hic qui.", "North Judefurt", 1, 696.59m, "Small Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 73,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2017, 1, 28, 10, 22, 54, 739, DateTimeKind.Unspecified).AddTicks(9354), "Quod quidem qui suscipit repudiandae veritatis similique rerum porro odio. Molestias fugit quisquam consequatur voluptatum et ratione voluptas dolor. Aut minima earum officia excepturi at natus ut nemo. Dolorum temporibus error accusantium. Non ut dolores velit eum possimus ducimus distinctio. Consequuntur culpa voluptatem atque aut repudiandae voluptatum dolorem expedita.", "Port Flossieport", 1, 750.91m, "Fantastic Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 74,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2019, 1, 23, 19, 3, 39, 590, DateTimeKind.Unspecified).AddTicks(3223), "Unde eligendi consequatur hic quo perferendis molestiae quibusdam. Ea et amet. Non sed architecto eum qui est.", "North Jamar", 1, 88.86m, "Gorgeous Steel Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 75,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2018, 2, 14, 20, 59, 50, 751, DateTimeKind.Unspecified).AddTicks(8782), "Iure id voluptate. Fuga sed recusandae. Laudantium quod eos beatae. Quod quia nostrum rem cum non doloribus.", "New Maystad", 1, 85.43m, "Generic Steel Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 76,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2017, 6, 16, 13, 4, 12, 799, DateTimeKind.Unspecified).AddTicks(815), "Ipsam incidunt qui illo eveniet voluptates a ducimus. Tempora quo enim iure. Sed optio eos quaerat non dignissimos qui. Et ut qui.", "Auertown", 1, 4.39m, "Generic Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 77,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2017, 10, 26, 23, 44, 4, 305, DateTimeKind.Unspecified).AddTicks(3757), "Labore sunt voluptas aut ut vel ea doloribus. Optio aspernatur omnis ut cumque. Cumque reiciendis dolore. Et soluta incidunt tenetur saepe. Dignissimos natus quae velit eum hic dolore accusantium a fuga.", "Noemyview", 2, 852.58m, "Intelligent Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 78,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2017, 1, 10, 18, 34, 18, 52, DateTimeKind.Unspecified).AddTicks(1858), "Itaque nesciunt vel laudantium consectetur reiciendis beatae illo consequatur. Officiis quae explicabo aliquam ipsam temporibus corrupti. At non minima architecto laboriosam itaque molestias qui. Doloribus assumenda est.", "Watsonview", 1, 677.82m, "Generic Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 79,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2020, 7, 2, 0, 39, 23, 760, DateTimeKind.Unspecified).AddTicks(538), "Et et necessitatibus quam possimus sapiente consequuntur quia sit quas. Hic quos eos. Officiis tenetur autem et sunt quis veniam sint ut. Quam harum molestiae ea quia voluptatibus qui. Autem praesentium ad ab sunt quidem odit. Facilis nihil velit et et amet omnis quasi excepturi.", "Port Francisca", 1, 856.55m, "Generic Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 80,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2019, 7, 1, 5, 42, 29, 774, DateTimeKind.Unspecified).AddTicks(9270), "Porro eveniet occaecati atque consequatur fugit ea perspiciatis. Et nesciunt et modi rerum culpa quisquam asperiores aspernatur. Officiis ea saepe quo. Modi est omnis.", "North Angelinaburgh", 1, 300.24m, "Licensed Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 81,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2015, 4, 23, 23, 16, 22, 843, DateTimeKind.Unspecified).AddTicks(4488), "Ex cupiditate nobis. Consequatur error harum ut facere molestiae asperiores. Odit blanditiis laboriosam dolorem sit quas voluptatem facilis.", "East Heaven", 2, 763.88m, "Generic Fresh Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 82,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2017, 5, 6, 13, 11, 42, 980, DateTimeKind.Unspecified).AddTicks(6526), "Delectus nesciunt sint fugiat quia ipsum quia. Sunt autem quis optio et perspiciatis consectetur voluptatem. Aut fuga ipsum nesciunt corrupti quisquam beatae odit et.", "Wildermanmouth", 2, 577.98m, "Gorgeous Frozen Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2019, 5, 18, 3, 7, 21, 537, DateTimeKind.Unspecified).AddTicks(3197), "Et perferendis ullam id omnis natus voluptates. Optio inventore nam nihil tempora est ratione officiis. Deleniti iusto odio est veniam tempora. Sed sint sed iure ipsam. Repellendus et vel voluptatem corrupti laborum accusamus iste. Neque dolorem eum tempora rerum quis fugiat ut est quo.", "Adelaburgh", 1, 515.70m, "Sleek Soft Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 84,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2019, 12, 9, 7, 41, 13, 386, DateTimeKind.Unspecified).AddTicks(7881), "Occaecati voluptate ab. Nihil voluptas voluptates quia sed. Vero perspiciatis enim.", "West Anastasia", 2, 341.63m, "Tasty Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 85,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2019, 5, 10, 12, 51, 21, 621, DateTimeKind.Unspecified).AddTicks(6101), "Est debitis sed sequi dolorem qui quasi. Eos est reiciendis dolor et et quas odio cupiditate corporis. Voluptatem minus et tempora odio ad dignissimos. Velit accusamus eos. Animi velit omnis optio qui quis ut impedit sit repellendus.", "Brianastad", 1, 367.55m, "Refined Metal Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 86,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2019, 1, 2, 3, 50, 44, 173, DateTimeKind.Unspecified).AddTicks(9487), "Atque omnis atque est aspernatur. Vel id officiis doloremque repellat cum autem voluptas at dolorem. Quasi iste deserunt.", "West Augusta", 1, 108.97m, "Generic Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2020, 4, 15, 5, 52, 52, 414, DateTimeKind.Unspecified).AddTicks(7514), "Est ullam molestiae maiores numquam et enim sunt voluptas. Voluptates laborum dolores hic asperiores fugit. Non qui expedita consequatur et voluptatibus sed nobis autem.", "North Jazminfurt", 2, 753.22m, "Practical Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 88,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2017, 10, 20, 5, 23, 38, 782, DateTimeKind.Unspecified).AddTicks(9084), "Aliquam quibusdam laudantium ut officiis blanditiis atque aut et beatae. Pariatur illo est corrupti delectus. Voluptatem consequatur corporis. Facere et id libero eligendi qui est repudiandae alias. Minima alias reiciendis rem eos ut iure aut nam sed. Qui hic quia vel cumque est.", "East Shakira", 2, 756.64m, "Small Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 89,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2019, 2, 20, 1, 59, 21, 347, DateTimeKind.Unspecified).AddTicks(8661), "Alias possimus inventore et. Repellat nulla architecto numquam. Dolorum nobis quia ratione aspernatur iusto ex exercitationem. At asperiores soluta voluptas et quia. Magnam et vero ut.", "South Patsy", 1, 931.35m, "Handcrafted Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 90,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2017, 4, 8, 13, 2, 5, 327, DateTimeKind.Unspecified).AddTicks(772), "Iste assumenda quidem adipisci unde rerum totam. Ratione quaerat praesentium maxime amet quia molestiae ea. Asperiores placeat velit numquam et quia dolores. Ad atque expedita sunt laborum quas consectetur rerum consequatur quia. Sit molestiae laborum consequatur delectus quia qui. Doloremque quae maxime.", "North Trevion", 1, 213.47m, "Licensed Granite Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 91,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2015, 11, 1, 17, 48, 19, 144, DateTimeKind.Unspecified).AddTicks(7945), "Ad in vel deserunt sed. Ut vero illum velit et iure id eum eum. Ipsa nihil ad aut nulla non. Quidem voluptatem in impedit. Sit sapiente consequatur fugit excepturi fuga laboriosam delectus.", "New Edwardburgh", 2, 763.31m, "Intelligent Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 92,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2015, 1, 9, 0, 14, 4, 287, DateTimeKind.Unspecified).AddTicks(3182), "Odit consequatur necessitatibus. In blanditiis maxime aliquam. Dignissimos dolores ab provident. At iure facere debitis voluptatibus ipsa quam.", "South Brian", 2, 984.50m, "Incredible Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 93,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2019, 2, 20, 11, 29, 28, 291, DateTimeKind.Unspecified).AddTicks(1779), "Distinctio tempora mollitia et earum. Dolorem mollitia impedit. Eos sequi labore incidunt nam architecto facere qui tempore fuga. Expedita consequatur et possimus amet. Quibusdam qui magnam. Voluptas nisi facere accusamus ullam quaerat totam vel.", "Schultzview", 2, 707.54m, "Incredible Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 94,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2017, 6, 24, 23, 55, 17, 590, DateTimeKind.Unspecified).AddTicks(524), "Sunt non dolorem et consequatur. Est dolorem facere ab consequatur blanditiis. Nostrum exercitationem vel corrupti commodi consequatur. Quis qui et vel molestiae hic quos qui est. Hic aut et alias deserunt repudiandae.", "Lake Salvatorehaven", 1, 571.36m, "Incredible Steel Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 95,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2017, 10, 9, 1, 29, 50, 802, DateTimeKind.Unspecified).AddTicks(1108), "Ipsum quaerat maxime. Quo delectus molestias voluptatem ex repellat inventore molestiae. Reprehenderit enim aspernatur.", "Rodgerview", 1, 699.76m, "Fantastic Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 96,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2015, 5, 25, 12, 16, 42, 942, DateTimeKind.Unspecified).AddTicks(830), "Amet consequatur itaque cumque totam natus id. Quia quia et eaque. Necessitatibus qui fugiat. A totam repudiandae placeat dolorum aut sequi temporibus quia. Provident id dolore qui totam voluptatibus voluptatibus fugiat. Veritatis ex blanditiis perspiciatis repellendus quia saepe iure non nihil.", "Jeremyfort", 2, 820.06m, "Handcrafted Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 97,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2017, 10, 20, 22, 9, 33, 80, DateTimeKind.Unspecified).AddTicks(1964), "Repudiandae qui sint quasi qui a aperiam odio illo. Illo fugiat est. Et molestiae consequuntur fuga est quos. Consequatur quo ratione quisquam.", "Lynchstad", 1, 690.45m, "Unbranded Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2017, 4, 25, 11, 0, 5, 178, DateTimeKind.Unspecified).AddTicks(6540), "Quo ut itaque ex quos consequatur molestias. Voluptatibus quae labore accusantium at earum. Voluptas asperiores natus unde. Est aliquid et in esse placeat.", "Port Parisborough", 2, 497.44m, "Small Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2015, 5, 11, 7, 38, 21, 816, DateTimeKind.Unspecified).AddTicks(629), "Repellat sed impedit id id voluptatem officia quo. Quae nihil molestias porro eveniet aut at ea id sed. Maxime modi id et et unde ut quo omnis non.", "North Rylanfort", 2, 549.21m, "Intelligent Steel Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 100,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2018, 9, 12, 10, 0, 44, 377, DateTimeKind.Unspecified).AddTicks(8626), "Eos commodi illum dolor. Nemo ducimus illo. Magnam adipisci maiores omnis animi. Vitae amet vitae. Veniam odio aut quis est rerum ut et temporibus. Tempore blanditiis fugit fugiat ipsa maxime quis fugiat.", "Caspermouth", 2, 106.15m, "Sleek Metal Bacon" });

            migrationBuilder.CreateIndex(
                name: "IX_Ads_OwnerId",
                table: "Ads",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ads_AspNetUsers_OwnerId",
                table: "Ads",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ads_AspNetUsers_OwnerId",
                table: "Ads");

            migrationBuilder.DropIndex(
                name: "IX_Ads_OwnerId",
                table: "Ads");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Available",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Ads");

            migrationBuilder.AddColumn<bool>(
                name: "IsGift",
                table: "Ads",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "MaxDays",
                table: "Ads",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 1,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Sit dolores eaque saepe id ducimus saepe. Dolores quia velit voluptate dolores est at debitis dolor dolorum. Dolorem quasi repudiandae quis dolores similique eum. Et tenetur voluptate. Suscipit error dolores eum et fugit recusandae. Quasi est sunt.", "Gradyton", 4, 58.92m, "Unbranded Steel Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 2,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Sequi rerum blanditiis ut. Perspiciatis voluptas est voluptate ut et est sed eos. Commodi eos non voluptas dolore similique provident ab reiciendis. Sunt in praesentium est odit vero est animi ducimus sit. Cum natus sequi similique est minima nam. Dolorem modi placeat incidunt voluptatem optio beatae dolores esse.", "Kianastad", 27, 476.05m, "Incredible Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 3,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Ullam fugit voluptatem. Sunt soluta tempora. Ullam est adipisci rerum quis et dolore vel. Laboriosam dolorem adipisci beatae accusantium quisquam ea ipsa. Iste quisquam sed quaerat deleniti nihil quod minima commodi. Sit aspernatur distinctio omnis eaque aut omnis ea.", "Port Edmouth", 20, 664.10m, "Awesome Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 4,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Ad qui autem vitae numquam consequuntur quas atque ipsa exercitationem. Eveniet aut quas iste autem facilis soluta et nesciunt. Dolore ea eos. Deserunt quibusdam architecto. Cumque ratione dignissimos quasi ea dicta exercitationem.", "North Inesview", 16, 528.56m, "Handmade Steel Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 5,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Aliquam sunt accusamus repudiandae et. Excepturi at accusantium eaque et. Fuga voluptas et earum nisi voluptatem sit eum et esse.", "South Lois", 8, 190.88m, "Generic Granite Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 6,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Aspernatur ipsam perspiciatis voluptatibus libero repellendus quos vitae. Quas inventore quaerat sunt ab qui aspernatur. Qui reprehenderit sint. Adipisci fuga quo.", "Gutkowskiburgh", 13, 173.63m, "Unbranded Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 7,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Et nemo dolor ducimus ad natus expedita magnam ut ratione. Alias asperiores in quam sunt. Tenetur quia autem in et eligendi nihil. Consequatur et beatae voluptates. Consectetur perspiciatis excepturi laborum amet excepturi voluptatem expedita.", "Lake Desmond", 26, 926.45m, "Sleek Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 8,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Repellat vitae commodi ea reprehenderit consequatur eum a. Architecto nostrum et inventore culpa nisi deserunt. Vel corrupti vel reprehenderit et assumenda accusamus facilis nostrum sed. Voluptatibus numquam tempora voluptas inventore quibusdam beatae dolorem.", "Lake Candace", 5, 233.21m, "Intelligent Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 9,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Omnis cum cupiditate suscipit occaecati libero. Non ipsam sunt enim quos. Aut magnam libero reiciendis in pariatur delectus nulla. Et sint minima consequuntur distinctio.", "East Carmine", 1, 526.21m, "Sleek Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 10,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Facilis optio iste maiores. Deleniti doloribus excepturi qui. Ab saepe natus. Dolores qui qui natus excepturi.", "North Anastasiabury", 1, 995.41m, "Licensed Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 11,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Deleniti qui consequatur atque sit nihil exercitationem reiciendis quo dolor. Alias praesentium perferendis est ducimus qui et. Magni aut cum alias ut dolor officia. Perspiciatis asperiores aliquid quia voluptates. Fugiat quidem totam dicta beatae et autem aut. Nulla minus nam consequatur animi vel.", "South Cleora", 8, 566.99m, "Handcrafted Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 12,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Corporis maxime in placeat maiores commodi praesentium. Minima fuga autem qui ea molestias voluptatibus. Doloremque eligendi eum enim id quia doloribus molestiae. Dignissimos nesciunt quasi nisi. Tenetur quo aut.", "Onaville", 12, 353.28m, "Practical Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 13,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Aut consequatur quaerat amet est enim nulla et. Ut enim recusandae magni. Rem id ut sed reprehenderit voluptatem quia tempore ut.", "Lake Mose", 25, 330.50m, "Handcrafted Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 14,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Ducimus perferendis et aut quaerat totam et. Dignissimos assumenda et sunt laborum facilis. Et maxime necessitatibus minima aut quibusdam. Ullam laudantium alias quis a totam excepturi. Et fuga enim iure nobis quod omnis est veniam id. Voluptas voluptas et cum est velit dicta.", "West Toby", 12, 65.88m, "Rustic Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 15,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Debitis rerum excepturi sit maiores quos. Labore quaerat modi sapiente nobis consequatur voluptatem est perspiciatis. Aperiam facere qui temporibus ipsam. Accusamus sunt aut voluptatem. Natus adipisci rerum possimus accusantium explicabo nulla.", "East Desmond", 24, 275.82m, "Small Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 16,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Eligendi ipsa et voluptas. Dolorem porro quia ipsam libero error quo. Et aut totam exercitationem soluta veritatis qui quia. Ad dolor numquam voluptatem aperiam magnam deleniti laboriosam. Rerum velit quod qui veritatis. Repellendus eaque quis.", "McClurechester", 13, 283.37m, "Handcrafted Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 17,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Voluptas facere consequatur reprehenderit et eaque assumenda qui omnis. Temporibus laudantium optio reiciendis. Cum sint ut nulla illum. Molestias rerum eligendi expedita fuga. Pariatur saepe provident minus sit aliquid tempore in animi occaecati. Illum ea nostrum eum ut fugiat culpa laudantium aut.", "Berniecestad", 6, 683.80m, "Rustic Steel Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 18,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Tempore id ullam. Et quo sit. Est aut accusantium ea porro nesciunt. Vitae corrupti cupiditate ut enim consequatur fugit consectetur.", "Coymouth", 9, 364.92m, "Small Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 19,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Atque nulla et occaecati ut. Unde eius commodi aut ex. Sit qui ducimus blanditiis animi nobis iste deleniti voluptatibus.", "South Karlee", 17, 880.44m, "Intelligent Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 20,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Quo aut vitae incidunt enim facilis error eius sequi nihil. Dignissimos nemo quo. Aut nisi quo voluptates ducimus neque porro quod suscipit dolor. Cupiditate delectus iure amet repellat.", "Troyhaven", 16, 53.66m, "Gorgeous Wooden Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 21,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Laudantium ea inventore. Eos aliquam impedit tempore repellat voluptas impedit maxime aut omnis. Et maxime ab. Quia mollitia fugiat. Nihil quos quas nihil quia fugiat quidem dolor cumque explicabo. Optio enim soluta voluptate voluptatem doloremque.", "Greenholtbury", 11, 289.08m, "Licensed Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 22,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Et fugit aut eligendi odio harum iusto harum iusto ea. Iure quo commodi nam aut et error veritatis consequatur. Laboriosam minus asperiores nemo corporis ducimus. Dolores cum sed corporis non nulla dolores.", "New Guillermoshire", 3, 876.05m, "Small Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 23,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Blanditiis accusantium nobis minima neque ea. Qui id neque. Fugit eum dolores amet illum dolores.", "Shanahanport", 14, 995.16m, "Intelligent Rubber Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 24,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Repellat recusandae sit consequatur est autem debitis. Nihil recusandae vero excepturi magni dolore nisi labore aut. Voluptatum sit fugiat aut inventore omnis numquam dolores.", "Wardview", 24, 85.63m, "Refined Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 25,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Enim quibusdam est quia molestias quis voluptas aut. Dolore optio minima fugit possimus quaerat sint rerum. Possimus fugit debitis dolor.", "New Bettyeside", 12, 626.96m, "Refined Steel Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 26,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Optio delectus quia architecto. Excepturi unde sed quia. Delectus odio qui eos nihil sed ipsum voluptates est illo. Est quos facilis ut quia id saepe dolores aperiam quidem.", "Generalton", 13, 788.93m, "Ergonomic Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 27,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Asperiores cumque et amet. Quisquam quae est sunt. Sunt voluptates voluptatem ut et voluptatum provident odit. Et expedita voluptatibus qui ad voluptatem inventore ullam dignissimos repudiandae. Voluptas fugit ut nulla tenetur quasi.", "Jadamouth", 15, 559.37m, "Intelligent Steel Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 28,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Fugit eos dolores enim unde minus pariatur consequatur. Perferendis natus officia et qui quam id. Harum aliquid aut itaque quam veniam pariatur pariatur architecto. Praesentium ut qui recusandae temporibus. In earum iusto rerum animi voluptates mollitia ut.", "West Tristonport", 2, 591.12m, "Generic Steel Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 29,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Repellat sunt aut optio culpa facilis. Voluptatum reprehenderit iure laudantium aut beatae. Eos nostrum velit voluptatibus expedita quia est possimus impedit. Magni laboriosam laboriosam illum atque quo reprehenderit reprehenderit voluptatem.", "Paulland", 24, 247.10m, "Refined Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 30,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Debitis optio amet eos. Quia ullam molestiae vitae ullam aliquam eligendi et. Doloremque similique et corporis est doloribus soluta asperiores quasi. Natus voluptatibus nihil.", "Vallieland", 11, 36.17m, "Gorgeous Rubber Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 31,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Voluptatum animi rerum sit veniam enim sunt voluptas dolorem unde. Quod soluta et repellat quos. Cupiditate aut fuga aut corporis possimus.", "Lake Jason", 29, 944.50m, "Intelligent Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 32,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Fuga voluptas cumque consequatur aut qui nobis reiciendis voluptatem minus. Voluptate omnis enim excepturi ea perspiciatis. Doloremque hic qui voluptas quia voluptas quia ea aut.", "East Karina", 13, 862.08m, "Gorgeous Soft Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 33,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Corrupti quidem consequuntur velit est. Similique voluptas inventore alias quia dignissimos officia cum iste. Beatae dolores dolor officia eos fugiat in officia. Eum est enim similique qui. Numquam distinctio veritatis inventore quia et facere aut inventore id. Fugit ea animi voluptates natus et et.", "East Elianeburgh", 8, 434.98m, "Handcrafted Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 34,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Aut quaerat omnis sint sit doloribus dolor cupiditate dolorum. Facere voluptas est quisquam maiores. Quisquam repellat maiores quam enim. Dignissimos commodi a nobis earum in et ea ut commodi. Doloribus ab nisi possimus adipisci iure laborum magni eaque dolore. Blanditiis vero est omnis ad sunt recusandae.", "South Irmamouth", 4, 814.26m, "Fantastic Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 35,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Saepe numquam vel iure odio optio. Rerum deserunt cupiditate est autem nostrum incidunt distinctio. Et aspernatur beatae iure consequuntur ut totam qui vel dignissimos.", "Port Justine", 11, 238.17m, "Small Rubber Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 36,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Dolores quasi esse. Debitis quidem et velit harum dolor voluptatem ipsam dignissimos rerum. Vero aliquam expedita aliquam ex maxime.", "Kiarashire", 8, 728.97m, "Ergonomic Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 37,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Perspiciatis dicta et autem quo nobis neque excepturi quos. Inventore aspernatur quidem. Magni quas facilis accusamus vel. Et quos temporibus veniam atque dolores quam distinctio voluptatem. Ut quia architecto consequatur id tempora vel.", "New Chanelton", 5, 766.06m, "Incredible Metal Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 38,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Quia tempora laudantium commodi et facere et illo. Nisi enim laboriosam voluptatem quas. Delectus omnis recusandae voluptatem ut. Et est iste numquam sed quo possimus est. Mollitia non natus quo sed molestiae. Ut eius quia.", "South Timmothy", 15, 780.83m, "Incredible Frozen Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 39,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Sed facere provident libero voluptatem eius sed voluptates ratione. Ipsa ratione voluptas qui placeat vel dolor omnis. Odio et officiis porro optio aut magni reiciendis eius est. Nostrum consequuntur aut molestiae earum voluptas qui saepe est voluptatem. Voluptatem possimus sint veniam ipsam modi. Quisquam in provident.", "New Ezra", 27, 663.72m, "Small Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 40,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Ipsam dolores et velit. Ipsum ea aut et maiores necessitatibus eos est ab facere. Sed esse corrupti. Accusamus et autem quis recusandae molestias et accusantium minima aut. Doloremque et beatae architecto sit excepturi aut. Ratione qui tempora vel esse.", "Jettshire", 9, 146.81m, "Awesome Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 41,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Quis vel omnis officiis deleniti ea perspiciatis autem id aut. Vero inventore sunt aut minus est. Ab nisi dicta. Nobis sapiente qui et perspiciatis sit aut minus.", "Corkeryfurt", 25, 707.14m, "Gorgeous Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 42,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Id dignissimos dolorum quo asperiores repellendus odio qui voluptatem velit. Id consequatur doloremque saepe est magni et qui quae eos. Quos accusamus dolores ad. Et et porro voluptatum. Rem sunt quod rerum voluptatem aut delectus earum doloribus ratione.", "South Pearlieberg", 24, 627.42m, "Unbranded Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 43,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Culpa aspernatur reprehenderit hic placeat in. Qui velit non id itaque aut ut ad. Aliquam cumque sequi fugiat velit. Quo velit accusantium.", "Port Jerelmouth", 10, 883.59m, "Awesome Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 44,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Ut est ad qui dolore ea autem dolorum voluptate provident. Delectus quas suscipit libero veniam reiciendis fuga exercitationem cupiditate. Adipisci molestiae tempore tempore tempora aut. Facilis voluptatem et et quis veniam rerum error molestiae possimus. Voluptas voluptatem explicabo temporibus dolores quaerat itaque. Labore est animi est reprehenderit quia quis est voluptatem voluptas.", "Mitcheltown", 11, 913.02m, "Tasty Cotton Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 45,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Modi reprehenderit odit at eius eaque blanditiis. Nostrum ea et esse id. Est incidunt ipsa esse. Voluptas alias cum autem quibusdam dolorem aperiam.", "Jenningsborough", 4, 405.07m, "Unbranded Frozen Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 46,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Perspiciatis placeat iure aliquid quisquam aut ipsam maxime sit. Maiores dolor in nobis. Ut architecto asperiores officia perspiciatis mollitia nemo doloremque amet rem. Voluptates ipsum alias perspiciatis voluptatum reprehenderit rem molestiae est exercitationem. Sit est saepe. Ab totam quidem quae repellendus.", "Ornville", 13, 813.38m, "Tasty Soft Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 47,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Quisquam velit debitis facere. Qui maxime temporibus quo. Enim et asperiores quidem earum necessitatibus iure.", "Cheyannemouth", 26, 390.40m, "Rustic Metal Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 48,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Similique minus provident quidem magnam cum qui in eum nemo. Eligendi eius corporis soluta molestiae ducimus rem quaerat tempore. Quos et iste inventore ipsa cumque reprehenderit.", "North Christy", 22, 960.28m, "Rustic Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 49,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Veritatis reiciendis perspiciatis veritatis aut qui sed consequatur sapiente et. Laudantium eligendi eius temporibus. Et beatae consequatur aut in quia aut.", "East Oraland", 5, 731.20m, "Small Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 50,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Velit veniam magni quos vel suscipit. Illo beatae praesentium. Accusamus commodi ut repudiandae. Qui aspernatur dolore sed eum at. Atque illum suscipit.", "West Dortha", 28, 118.47m, "Awesome Metal Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 51,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Odio earum cumque rem tenetur cupiditate magni. Eum vel esse voluptatem ut laboriosam voluptas. Autem perspiciatis aut. Minima facilis cum ipsa officiis quidem omnis. Laboriosam eligendi sequi sequi. Ea hic temporibus in.", "Fritschhaven", 22, 490.73m, "Handcrafted Cotton Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 52,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Recusandae in sunt neque. Aut dolore incidunt autem. Expedita animi voluptatem placeat a. Dolores modi quaerat maiores.", "Howellmouth", 19, 603.52m, "Incredible Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 53,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Labore sed natus atque voluptas mollitia magnam provident maiores ab. Quia nesciunt cupiditate maxime quia recusandae fugit voluptas ipsam occaecati. Nam voluptas voluptatem unde. Totam natus officiis. Voluptate odio et accusantium sed ipsa fugiat et commodi. Id labore quia quasi expedita incidunt perferendis aut molestiae ea.", "North Janisview", 1, 456.24m, "Intelligent Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 54,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Ut aut consectetur molestias minus ex dolores quia magni. Quia ea reprehenderit. Reiciendis praesentium aliquam distinctio ipsam voluptatem qui magni excepturi qui. Ut sit consequatur vitae consequatur. Est aut qui harum consequuntur perferendis natus molestiae.", "Leannonfurt", 9, 263.35m, "Unbranded Metal Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 55,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Repellat reiciendis quas. Sed velit voluptas animi praesentium ipsum omnis accusantium quos consequuntur. Molestiae mollitia animi magnam minima. Dignissimos eligendi id odio quas voluptates fugiat magnam consequatur. Saepe assumenda sapiente vitae fugiat dolorem harum enim.", "Schillermouth", 17, 392.92m, "Rustic Fresh Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 56,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Fugiat voluptas et dolorem veniam adipisci iste veniam voluptas ut. Quis aut ut. Dolores accusamus aliquam provident ipsa quos voluptatem delectus. Nemo corrupti quia necessitatibus corporis. Officia rem commodi vero esse atque id.", "South Nyasiamouth", 17, 404.63m, "Ergonomic Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 57,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Ut saepe nostrum mollitia. Quas atque sunt ea id sint. Accusamus nam voluptatibus amet hic iste et sequi recusandae. Necessitatibus aut assumenda voluptas. Earum vero officiis sunt et nihil ratione. Voluptate quis doloribus aut vero autem nulla quia et unde.", "Stanleyhaven", 17, 218.59m, "Rustic Metal Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 58,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Minus alias atque eum. Asperiores ut porro atque est et sunt quisquam. In eveniet a qui veritatis dolor dicta quae. Aliquam architecto et. Vel rerum minus voluptate sint beatae ut aliquam.", "Lake Carrie", 8, 866.00m, "Refined Wooden Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 59,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Id dolor amet doloribus voluptatem dolor aspernatur tempore. Nesciunt nobis reiciendis incidunt facere accusamus nisi neque architecto. Labore hic aut qui nihil quia explicabo quibusdam.", "East Tyrese", 29, 408.75m, "Licensed Rubber Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 60,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Iure voluptatem omnis enim dolore incidunt. Sunt nihil sunt voluptate quis cupiditate tempore illo. Reiciendis id deserunt ea omnis vel modi eum possimus rem. Velit ad ipsum distinctio veniam sit debitis est facere adipisci. Cumque dolor architecto pariatur facere cupiditate iure ut cum ad.", "Leannonfort", 25, 880.40m, "Incredible Metal Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 61,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Iste est voluptas perspiciatis. Magnam repudiandae consequuntur amet facilis. Ullam eligendi ab aperiam vel veniam voluptates veritatis optio asperiores.", "Schmelerstad", 9, 757.39m, "Incredible Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 62,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Velit expedita accusantium quis. Qui provident iste et laborum voluptatem repellendus doloremque autem id. Omnis quibusdam et quae temporibus excepturi in dolor est. Cumque dolore ut et vitae est suscipit totam optio rerum. Cum aut commodi placeat ex natus dicta minus. Assumenda aliquam est.", "Manntown", 11, 806.90m, "Fantastic Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 63,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "A placeat veniam sit mollitia non sed. Error cum sapiente sequi aut eligendi. Ullam iusto hic enim dignissimos est quia ducimus. Est laboriosam illo reprehenderit non vitae aut. Qui beatae ratione laborum laudantium laboriosam. Iste adipisci omnis sed in qui omnis laudantium suscipit et.", "Vancemouth", 29, 402.75m, "Refined Soft Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 64,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Aliquam voluptatum ratione et deleniti nam. Suscipit voluptatem unde explicabo fugiat explicabo voluptatibus. Magnam modi alias accusamus eum eum debitis porro omnis. Magni enim iusto. Magnam qui nemo id non quo.", "North Londonchester", 28, 148.29m, "Practical Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 65,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Vero possimus consectetur voluptatem id placeat et eveniet. Vel possimus eum ut aliquid qui qui. Assumenda voluptatem repellendus explicabo neque enim tempore sed deserunt minima. Soluta iure et non tempora nisi enim sint dolore ut. Est debitis quo aliquid suscipit voluptas nam qui.", "South Abigale", 16, 671.77m, "Generic Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 66,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Occaecati rerum perferendis totam rem numquam. Rerum dolorem sequi natus. Aut eveniet est. Quas et quaerat. Recusandae ut sed eos voluptates ducimus cum eos omnis.", "South Nona", 18, 28.90m, "Handmade Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 67,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Fuga neque reprehenderit et molestias ipsum. Harum aut debitis unde dolores. Quia rerum omnis ipsum velit sequi natus accusantium ut.", "East Kaden", 21, 797.26m, "Sleek Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 68,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Voluptas quas quidem est perspiciatis nulla. Eligendi dolorum vel. Voluptatibus numquam nesciunt et odio est voluptatum. Voluptates voluptatum et vel vitae fugiat quia.", "Shieldsbury", 24, 780.94m, "Tasty Rubber Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 69,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Est ut consequatur voluptas eum. Earum non ut nisi delectus autem. Ea illum autem. Esse perferendis impedit quia omnis illum laboriosam. Velit voluptatem quo aperiam fuga et neque aliquid quis facere. Rem incidunt non perferendis cum dolorem.", "South Dayanastad", 24, 16.11m, "Tasty Cotton Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 70,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Aspernatur eius eos. Nam ducimus sit qui odit dolor. Repudiandae aut accusantium voluptas id.", "Port Geoffrey", 27, 1.52m, "Small Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 71,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Nostrum molestiae corporis. Et exercitationem exercitationem quia magnam et laborum eaque aut. Ut officiis similique doloribus assumenda sunt iusto error aut. Id et hic dolore eaque et.", "New Arvilla", 18, 157.06m, "Handmade Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 72,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Dolorum soluta est. Asperiores quia aspernatur mollitia perspiciatis magni laudantium delectus. Possimus nam est esse saepe voluptatem consequuntur nisi. Dicta amet et. Tenetur ut et officia doloremque sit iusto porro tenetur facere.", "Hagenesbury", 9, 401.77m, "Fantastic Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 73,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Aperiam voluptas et et laboriosam. Aut nihil impedit sunt mollitia officia eveniet vitae quis eos. Tenetur aspernatur magni non hic aut voluptates recusandae odit deleniti. Est doloribus nisi dolor qui et debitis fuga sit adipisci. Dicta ea perferendis aut eum.", "East Hallieborough", 28, 539.13m, "Fantastic Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 74,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Vitae cupiditate repellat et incidunt totam asperiores optio porro. Esse alias in sed. Provident est nihil aut assumenda sint earum quam. Qui optio qui et amet id deserunt consequatur.", "Lake Peterton", 11, 697.33m, "Small Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 75,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Sequi quod sed perferendis dolores. Consequatur est quae et. Quaerat qui aut dolore est provident quia molestiae. Fugit harum ab necessitatibus tempore ea facilis.", "North Marisolbury", 13, 201.01m, "Handcrafted Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 76,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Aut eveniet dolor repellat unde error velit totam. Repellat sunt molestiae corrupti ullam dignissimos aut dolor. Eligendi ipsam nisi qui non consequatur provident. Esse ullam inventore quos fugiat. Dolore nulla enim doloremque.", "North Ashley", 15, 477.55m, "Intelligent Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 77,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Adipisci sunt sapiente qui. Placeat ipsam non nisi veniam quis. Totam sit voluptatem fugit velit.", "East Rosinafurt", 20, 985.69m, "Practical Granite Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 78,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Quo eos reiciendis aut. Vel ipsum quia laboriosam distinctio sit dicta et. Quas doloremque expedita. Est et laboriosam commodi temporibus officia deleniti quaerat rem omnis.", "South Theresebury", 10, 112.32m, "Fantastic Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 79,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Dicta aut dolorem est placeat ratione beatae molestiae. Eos tenetur possimus excepturi esse non et rem. Iure ea dignissimos et et. Autem id est est.", "Ondrickaburgh", 22, 171.32m, "Incredible Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 80,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Ipsa dignissimos ea sit fugiat esse voluptatem. Velit asperiores temporibus dolore ut at sint vitae modi. Reprehenderit id voluptatibus aut. Corporis fugit reiciendis quo tempora qui numquam. Harum aliquid aut nemo rerum alias aut architecto sed.", "North Erickstad", 30, 566.84m, "Handmade Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 81,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Vel et voluptates. Doloremque voluptates aspernatur eius at in et. Adipisci qui nesciunt saepe.", "South Waltonton", 4, 109.60m, "Intelligent Granite Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 82,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Voluptatem unde numquam reprehenderit quam dolores qui voluptatum magni dignissimos. Minima eaque et necessitatibus eius. Voluptatem quibusdam magni rem eum tempore maxime. Quo consequatur delectus enim enim autem harum nisi maiores omnis. Rerum amet quas nihil illo nam accusantium qui.", "Dimitriside", 6, 219.99m, "Unbranded Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 83,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Ducimus quos officiis totam quos culpa corrupti. Quia illum et rerum. Ab consequuntur eius culpa odio facilis explicabo architecto consequatur et.", "Port Lorenzside", 25, 745.23m, "Fantastic Soft Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 84,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Sed quis quibusdam ipsum eligendi molestiae numquam aut praesentium. Iure odit voluptas aut. Alias enim consequuntur. Dicta deleniti rerum eligendi et rem vero cum.", "Hobartfort", 3, 75.10m, "Intelligent Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 85,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Voluptate placeat quisquam debitis adipisci ut. Fugiat saepe nemo voluptatem dolor maxime et. Magnam consequatur nemo eveniet mollitia qui cumque. Magnam natus ducimus quidem dolores enim et dolor consequatur. Culpa ut vel voluptatem. Quis exercitationem aspernatur qui.", "Kattiefurt", 27, 687.68m, "Handmade Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 86,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Et dolore ad impedit repudiandae totam ipsam maxime quo. Occaecati ut consequuntur et sunt neque. Labore incidunt nesciunt sit. Dolores quia sed minima mollitia nobis omnis. Soluta corrupti odit suscipit placeat sapiente corporis adipisci laudantium omnis. Ut culpa rerum ullam est nihil alias ullam cupiditate deserunt.", "New Madelynnfort", 1, 750.08m, "Tasty Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 87,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Maiores fugiat omnis doloremque eos autem ut laborum. Ut est soluta ut voluptatum voluptatem vero voluptatem excepturi. Deserunt eum ut quis totam eveniet qui molestias id. Aliquid id eum cum. Iste placeat eos ut placeat. Aspernatur est nam dolorum odio repudiandae iure aliquid.", "Trantowside", 3, 778.46m, "Gorgeous Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 88,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Dolores voluptate quis dolorem in. Commodi earum alias consequatur et enim asperiores. Omnis tempora dolores eligendi sunt nam accusantium maiores et. Quod voluptatem quam non. Qui aut consequatur.", "South Brentborough", 11, 933.51m, "Gorgeous Wooden Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 89,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Vel molestiae quisquam ut quia ipsam omnis repellendus iste dolor. Quis voluptatem nisi consequuntur nihil beatae dicta quo necessitatibus id. Fugit et dignissimos fuga nihil aut natus ea esse velit. Architecto nobis qui sit quam dolore non.", "Leopoldoview", 19, 325.32m, "Gorgeous Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 90,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Non quasi esse id corporis eum ipsam. Blanditiis omnis saepe libero modi voluptatem omnis totam. Architecto distinctio in voluptate distinctio voluptas et reprehenderit asperiores.", "Jaylenmouth", 6, 639.16m, "Practical Metal Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 91,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Asperiores molestiae est ullam velit. Delectus optio voluptatem eum iure. Accusamus at molestias voluptates suscipit.", "Brakusmouth", 7, 789.28m, "Intelligent Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 92,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Ad repudiandae laudantium alias ipsum sapiente esse voluptatum fugiat ullam. Maiores ipsa optio ratione enim. Id ut laborum necessitatibus tempore qui explicabo. Hic quidem fugit sed impedit laudantium blanditiis culpa qui. Dolor vero eum numquam nisi qui vel cum. Aut fugiat inventore vero dicta deleniti expedita.", "Leonberg", 1, 602.70m, "Intelligent Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 93,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Ullam enim quia quo ut. Officia consequatur commodi blanditiis minus iure. Neque molestias repellat sed sed sit saepe dolor doloremque est.", "Lake Rosemarieborough", 13, 87.39m, "Generic Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 94,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Sequi odit iste. Architecto molestiae totam at quisquam accusantium et ipsam quisquam. Sint id et. Magni voluptas perspiciatis ut unde. Beatae illo quae. Et voluptas delectus illo.", "Port Addie", 13, 442.44m, "Incredible Steel Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 95,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Nemo optio magni dignissimos consequuntur corporis repudiandae deleniti provident ut. Libero deleniti rerum natus corrupti optio sit. Nemo non a inventore accusamus et. Ab fugit neque est quia ut et laborum sapiente.", "Weberfurt", 28, 742.99m, "Gorgeous Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 96,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Est iure quia nulla tenetur facilis accusantium. Fugit repellat ut rerum. Occaecati ad magnam et ipsam. Doloremque consequatur omnis et molestiae impedit omnis et sunt. Inventore quos est voluptas ea velit totam molestiae.", "East Arlo", 6, 327.82m, "Licensed Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 97,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Aut et quos ducimus quia molestiae cumque et. Occaecati velit dolores in in itaque sunt illo quas fuga. Ut quia consequatur quia non.", "Lake Rossfurt", 30, 249.67m, "Incredible Granite Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 98,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Ratione est quis ullam fuga vero. Rerum est dolores consequatur. Et possimus id fugit maiores eveniet est. Nulla dolorem sint perferendis cumque at qui asperiores enim. Quidem occaecati dolorum et nihil ducimus dolores quia est ipsa. Eos animi qui.", "East Lemuel", 28, 235.89m, "Rustic Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 99,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Deserunt voluptatibus eligendi ex. Est eaque et cum quo et nostrum. Maxime sit quis reiciendis nam quia qui optio maiores similique.", "Millieport", 8, 896.88m, "Handmade Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 100,
                columns: new[] { "Description", "Location", "MaxDays", "Price", "Title" },
                values: new object[] { "Qui et dignissimos facere dolor est. Consequatur nulla sit omnis eveniet alias nisi eos deserunt rerum. Distinctio qui vel rem.", "Hardyville", 20, 120.68m, "Sleek Wooden Shoes" });
        }
    }
}
