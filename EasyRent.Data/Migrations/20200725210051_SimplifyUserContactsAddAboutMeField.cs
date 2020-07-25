using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EasyRent.Data.Migrations
{
    public partial class SimplifyUserContactsAddAboutMeField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserContacts");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Contacts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AboutMe",
                table: "AspNetUsers",
                maxLength: 500,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2015, 5, 12, 21, 6, 59, 465, DateTimeKind.Unspecified).AddTicks(8085), "Nihil libero qui officia repudiandae ut quisquam quia. Ut aut aliquam est consequatur dignissimos provident. Et laborum nobis quia eum quos quia sed eius. Necessitatibus ipsam quidem doloremque nisi dolorem. Saepe expedita blanditiis quod voluptates et non sapiente quae.", "Barrowsville", 1, 825.31m, "Intelligent Plastic Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 2,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2020, 1, 16, 19, 45, 16, 551, DateTimeKind.Unspecified).AddTicks(2276), "Deserunt dolor et ab eligendi rerum fugiat aut. Ut assumenda sunt necessitatibus voluptatum repellendus architecto dicta asperiores perspiciatis. Neque repellendus provident exercitationem ut qui voluptatem in reprehenderit. Qui eos labore dolores ullam deleniti a. Eius dolor explicabo sequi quasi est quaerat aspernatur. Est non at reiciendis qui recusandae ipsum laudantium consequatur facilis.", "New Elistad", 2, 260.64m, "Practical Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 3,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2019, 3, 17, 19, 10, 27, 64, DateTimeKind.Unspecified).AddTicks(1732), "Fugit qui est consequatur distinctio. Quo consequatur aperiam. Praesentium sed ab sed.", "Brennaside", 2, 66.78m, "Handcrafted Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 4,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2018, 2, 4, 16, 58, 41, 984, DateTimeKind.Unspecified).AddTicks(9982), "Quod libero architecto ex dolore dolor omnis modi id. Cum similique molestias praesentium aspernatur fugiat dolorem. Quo sunt non debitis consequatur sint. Repellendus dicta nobis totam ea velit at consequatur eum voluptatem. Id soluta alias.", "Port Rhea", 799.70m, "Small Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 5,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2019, 6, 16, 0, 1, 14, 904, DateTimeKind.Unspecified).AddTicks(5725), "Provident vitae laudantium fuga eos vero iste. Praesentium sunt et facere vel. Dolorem possimus soluta adipisci.", "North Jedview", 2, 556.79m, "Ergonomic Cotton Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 6,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2016, 3, 6, 1, 39, 48, 672, DateTimeKind.Unspecified).AddTicks(5063), "Nostrum laudantium est aut assumenda ut quia in sit dolor. Perspiciatis consectetur sed architecto quam. Et mollitia officiis perferendis laboriosam et aut beatae non.", "East Ottilie", 60.06m, "Sleek Soft Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 7,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2015, 4, 26, 11, 37, 40, 234, DateTimeKind.Unspecified).AddTicks(2754), "Illo velit voluptatum autem accusamus. Sit voluptates consequatur maiores enim expedita sapiente iusto accusantium ex. Hic natus libero et et maiores delectus et consequuntur. Omnis enim reiciendis perspiciatis repellendus vel omnis in. In eius rem maiores.", "D'Amoreville", 2, 375.95m, "Unbranded Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 8,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2015, 5, 10, 11, 23, 17, 875, DateTimeKind.Unspecified).AddTicks(2305), "Qui itaque corrupti consequatur molestiae excepturi quia maxime. Et mollitia iure dignissimos. Voluptas voluptate eos quo a est deleniti. Placeat et vitae est eaque quos accusantium.", "Reyview", 634.04m, "Unbranded Steel Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 9,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2015, 3, 15, 16, 36, 46, 668, DateTimeKind.Unspecified).AddTicks(1662), "Qui facere nostrum. Est recusandae ea veniam est adipisci necessitatibus. Optio ratione sequi amet vero qui illum voluptatum nobis porro. Et sequi facere cupiditate rem delectus nisi. Vitae quasi id. Dolorem praesentium ab enim cum harum quia suscipit iusto.", "Lebsackside", 1, 771.71m, "Unbranded Metal Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 10,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2018, 3, 5, 0, 21, 41, 667, DateTimeKind.Unspecified).AddTicks(3693), "Voluptatem quos quam. Voluptate recusandae voluptatem. Aspernatur consequatur nulla sunt qui. Qui aut quam qui voluptas.", "West Cathy", 1, 864.54m, "Generic Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 11,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2017, 1, 7, 0, 43, 57, 655, DateTimeKind.Unspecified).AddTicks(2277), "Expedita dolore maxime cum. Harum nostrum ut cumque necessitatibus doloribus suscipit magni tempore nulla. Sunt delectus in et quibusdam sunt.", "Murazikshire", 1, 626.15m, "Licensed Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 12,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2019, 5, 19, 10, 56, 54, 632, DateTimeKind.Unspecified).AddTicks(7715), "Consectetur voluptas et expedita omnis quia consequuntur officiis. Officia reprehenderit fugiat minus. Aut autem repellat nemo quod dignissimos nisi dicta consequatur sed.", "Evelynhaven", 1, 88.14m, "Generic Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2019, 6, 24, 18, 47, 51, 182, DateTimeKind.Unspecified).AddTicks(4144), "Est sint quia. Corrupti molestiae molestiae nostrum. Ratione necessitatibus dolorem incidunt. Commodi id praesentium mollitia quia.", "South Kadeshire", 2, 417.15m, "Incredible Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 14,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2016, 6, 13, 23, 40, 56, 715, DateTimeKind.Unspecified).AddTicks(94), "Voluptatum ut est vitae aut. Tenetur quam expedita beatae aut unde qui. Vero suscipit aut. Quia nihil qui. Non consectetur a temporibus necessitatibus ducimus.", "Lindseymouth", 631.72m, "Generic Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 15,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2016, 5, 20, 17, 57, 28, 39, DateTimeKind.Unspecified).AddTicks(1156), "Rerum et ducimus qui et velit delectus enim sit molestiae. Rerum minima eum magni aspernatur odio blanditiis consequuntur ipsam. Quas facere doloremque provident magnam itaque eum tempore. Nihil eligendi totam eum veritatis labore non. Ut perspiciatis dolorem culpa.", "Lake Peggie", 902.49m, "Incredible Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 16,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2016, 4, 28, 19, 47, 48, 849, DateTimeKind.Unspecified).AddTicks(6597), "Enim eos sequi esse eos. Voluptatum dolores quidem officia eius eos. Saepe assumenda saepe ipsum.", "Port Kristian", 491.63m, "Small Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 17,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2017, 11, 4, 0, 13, 50, 758, DateTimeKind.Unspecified).AddTicks(7311), "Nihil omnis provident ut voluptatem. Molestiae vitae excepturi. Eos quasi est earum cum.", "Madonnachester", 2, 458.24m, "Small Rubber Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 18,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2015, 2, 25, 10, 10, 36, 599, DateTimeKind.Unspecified).AddTicks(7132), "Eveniet qui dolor incidunt quas. Autem numquam vel nobis mollitia. Qui nulla consequatur. Eaque dolor excepturi et odit error atque culpa. Odio qui quod nisi ut minima ut voluptatem illum doloremque. Suscipit eaque harum facere saepe qui et voluptas veritatis nihil.", "Cathrinefort", 425.07m, "Sleek Granite Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 19,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2015, 6, 10, 16, 45, 0, 175, DateTimeKind.Unspecified).AddTicks(9638), "Sit et quia illo accusamus perspiciatis voluptate. Nihil alias vel accusamus voluptatem alias voluptatem omnis. Vel cumque facilis occaecati adipisci et reiciendis hic sint autem. Voluptates nostrum nam optio minima id impedit error in. Eos voluptatem et iusto alias quidem ex et aut.", "West Elise", 1, 121.40m, "Licensed Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 20,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2018, 5, 20, 16, 8, 22, 972, DateTimeKind.Unspecified).AddTicks(2888), "Hic facere id. Velit suscipit fugit officia qui nostrum qui sit. Occaecati eum numquam.", "East Cassidystad", 2, 29.70m, "Licensed Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 21,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2017, 5, 19, 13, 21, 2, 50, DateTimeKind.Unspecified).AddTicks(6597), "Expedita sunt corporis autem id. Similique dolorem porro deserunt ullam labore sit occaecati dolor maxime. Illo magnam dolore.", "Ziemannside", 1, 98.47m, "Awesome Steel Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 22,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2015, 10, 12, 13, 52, 24, 989, DateTimeKind.Unspecified).AddTicks(2016), "Ab voluptas molestiae quisquam minima aut. Est vel iure consequatur mollitia. Eum optio exercitationem ratione qui quos sed rerum illum.", "New Litzy", 2, 205.77m, "Licensed Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 23,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2017, 2, 28, 8, 36, 43, 581, DateTimeKind.Unspecified).AddTicks(1439), "Consectetur alias deserunt praesentium laudantium enim qui facilis iusto. Et ut incidunt consectetur autem quo. In dolorum sed et incidunt. Voluptatem explicabo architecto consequatur distinctio fugiat tempore eligendi omnis.", "North Clevechester", 702.60m, "Handcrafted Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 24,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2019, 10, 28, 18, 9, 4, 98, DateTimeKind.Unspecified).AddTicks(3861), "Minima aut est. Itaque vero nostrum maiores labore. A dolores sit.", "West Ellis", 67.67m, "Licensed Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 25,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2015, 9, 13, 5, 38, 52, 333, DateTimeKind.Unspecified).AddTicks(6509), "Dolores mollitia dolores odio minus et nulla dolorem. Vel aspernatur in autem. Illum ea est alias a labore iste quis quia debitis. Quia consectetur fuga quia dolorem ipsum possimus laborum id et. Nesciunt unde quas magnam fugit. Aut omnis nostrum et eligendi.", "Welchborough", 1, 93.10m, "Ergonomic Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 26,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2020, 1, 18, 21, 24, 32, 649, DateTimeKind.Unspecified).AddTicks(242), "Velit laborum modi et inventore facilis laboriosam. Est sunt iste et tempora dolores nihil consequuntur dolore. Est officia ut et ad. Consequatur beatae et et at deleniti eaque maiores.", "Wunschton", 1, 641.51m, "Unbranded Soft Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 27,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2017, 9, 18, 7, 12, 29, 528, DateTimeKind.Unspecified).AddTicks(1953), "Iure architecto et est omnis quidem debitis quos quas. Mollitia dolor suscipit ut dolores voluptatibus culpa voluptas. Nostrum illo similique nisi dolore ea et ut iusto tempora. Quidem pariatur impedit qui exercitationem non non blanditiis hic. Animi perspiciatis atque tempora. Ipsam corporis ut ipsam inventore voluptas.", "East Lizethmouth", 1, 817.08m, "Handmade Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 28,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2016, 8, 9, 5, 15, 37, 609, DateTimeKind.Unspecified).AddTicks(6547), "Aperiam maxime quasi rerum dolore error assumenda quia. Porro eligendi molestias dicta fugit eos dicta omnis rerum sed. Sed non libero vitae. Voluptatum velit mollitia magnam praesentium illum sequi minima.", "Dietrichfurt", 244.01m, "Practical Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 29,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2016, 1, 10, 15, 19, 29, 454, DateTimeKind.Unspecified).AddTicks(3455), "Voluptatem qui et possimus sed qui sint quia aspernatur aut. Architecto doloribus sed est consequatur quia accusamus. Ut sed tempora et et modi. Laboriosam repellendus consequatur aut voluptas enim quia ratione quam.", "Kristafort", 134.56m, "Handmade Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 30,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2019, 11, 19, 3, 13, 11, 874, DateTimeKind.Unspecified).AddTicks(8132), "Eius voluptas eum fugit suscipit. Natus qui eaque corrupti optio sed ad iure qui. Numquam est consectetur accusamus voluptas repellendus accusantium repellendus suscipit id. Animi nihil ipsa et incidunt expedita deserunt quia. Voluptatibus assumenda asperiores non facilis facere.", "East Shawna", 2, 306.06m, "Refined Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 31,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2015, 5, 2, 10, 40, 54, 237, DateTimeKind.Unspecified).AddTicks(415), "Velit iusto corporis animi omnis animi dicta sapiente. Repellat maiores totam debitis soluta ut enim aut. Dolor nam tempora sunt ea voluptas. Doloremque debitis ex accusantium eum architecto sed minus a dolor.", "Carabury", 990.76m, "Fantastic Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 32,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2020, 1, 6, 5, 28, 9, 696, DateTimeKind.Unspecified).AddTicks(585), "Dolor beatae corporis et occaecati sit. Rem voluptatem doloremque sed optio maxime est minus itaque. Et qui minus sint et in fugit officia blanditiis. Eius perspiciatis doloremque voluptatem quos atque.", "Maxieburgh", 720.56m, "Unbranded Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 33,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2018, 2, 17, 23, 20, 36, 22, DateTimeKind.Unspecified).AddTicks(9982), "Nobis et libero quo quod adipisci praesentium. Nobis molestias cum et amet ipsam veritatis autem laborum. Quis aut quae numquam qui accusantium blanditiis eius earum quis. Fugiat et rerum. Et ut numquam est molestias et quo natus libero quibusdam.", "North Olgamouth", 606.75m, "Sleek Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 34,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2016, 1, 21, 14, 32, 53, 165, DateTimeKind.Unspecified).AddTicks(2140), "Aut rerum aliquam cupiditate aliquam sunt. At beatae aperiam qui est velit pariatur quasi. Consequuntur qui ducimus. Quam quae consequatur nobis nobis suscipit. Perspiciatis perspiciatis et quasi enim non et aut vitae aliquam.", "New Janick", 943.74m, "Tasty Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 35,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2017, 6, 7, 11, 10, 46, 155, DateTimeKind.Unspecified).AddTicks(2794), "Sit iusto sed velit consectetur ab. Quidem similique quo. Non sit enim non delectus enim possimus voluptatibus id maiores. Pariatur officiis reiciendis iusto voluptatum accusantium sit dolores voluptas. Ut inventore ea et.", "Berniermouth", 381.47m, "Small Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 36,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2015, 3, 8, 17, 39, 55, 81, DateTimeKind.Unspecified).AddTicks(9273), "Consequatur voluptatem debitis dicta non et et sit. Dolore modi possimus in doloremque et architecto. Dolor reiciendis consequuntur hic dolor sit et sit animi soluta. Dolorem velit numquam porro tempore voluptas numquam. Et facere non voluptas iste doloremque voluptas nihil pariatur voluptatibus. Accusantium fugiat laborum odio aut veniam quidem soluta doloremque.", "New Annestad", 226.18m, "Tasty Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 37,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2019, 7, 18, 14, 33, 51, 844, DateTimeKind.Unspecified).AddTicks(4318), "Et blanditiis dolore pariatur est similique et itaque ipsam. Eaque quibusdam expedita nihil iste aut. Iusto aperiam nesciunt amet asperiores. Nobis ipsam aut mollitia eos nam libero nisi saepe quasi. Eius sequi consectetur doloremque.", "Anselmouth", 1, 92.16m, "Handcrafted Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 38,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2018, 11, 26, 5, 30, 7, 298, DateTimeKind.Unspecified).AddTicks(2940), "Cumque et ab in. Dolorum voluptatum natus provident unde ut inventore ad. Ab qui qui dignissimos corrupti in dolor corporis. Delectus in explicabo nemo id expedita et provident laboriosam. Laudantium ut ad nulla dolores.", "Laurynfurt", 1, 630.69m, "Sleek Steel Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 39,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2019, 4, 15, 14, 58, 36, 649, DateTimeKind.Unspecified).AddTicks(4541), "Sunt consequuntur assumenda numquam quam qui voluptatem vitae quia non. Id et aperiam perferendis harum. Consequatur tempore est ullam incidunt at necessitatibus porro voluptatem.", "Reichelhaven", 1, 698.41m, "Gorgeous Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 40,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2020, 2, 2, 16, 24, 56, 341, DateTimeKind.Unspecified).AddTicks(2386), "Ipsa in perferendis. Voluptatem inventore veniam rerum est laudantium quasi totam saepe. Autem quam officia. Enim debitis dolores ut officia ut numquam voluptatum magnam. Consectetur dolores dolorum.", "Andreannemouth", 769.52m, "Ergonomic Soft Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 41,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2020, 7, 7, 5, 22, 44, 715, DateTimeKind.Unspecified).AddTicks(6104), "Nisi est in aut enim rerum. Sit iste magni. Ut est maiores rem perspiciatis voluptas aut tempora. Officia nulla praesentium voluptate sed labore minima distinctio ab. Voluptatum ut qui voluptas dolore saepe illum tempore voluptatibus quia. Tenetur et deleniti.", "East Zelma", 1, 109.33m, "Gorgeous Frozen Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 42,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2020, 1, 11, 3, 23, 48, 791, DateTimeKind.Unspecified).AddTicks(7020), "Amet asperiores est aperiam id laudantium. Laborum expedita molestiae vel. Quod culpa qui ipsum dolorem illo est quidem omnis voluptatibus. Rerum et ipsum. Inventore accusamus atque rerum quo alias. Nihil dolorem voluptatibus rerum similique id qui qui.", "Wehnerview", 1, 65.70m, "Fantastic Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 43,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2016, 1, 2, 3, 3, 36, 805, DateTimeKind.Unspecified).AddTicks(8245), "Porro quia hic et. Iusto dicta quasi maxime ipsum perspiciatis aspernatur non doloribus. Et amet aut atque dicta vel voluptas nesciunt odit laudantium. Et tempore quibusdam delectus.", "South Gianni", 800.55m, "Small Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 44,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2017, 4, 14, 18, 55, 29, 114, DateTimeKind.Unspecified).AddTicks(1197), "Impedit et qui quia dolores autem dolorem ea porro. Pariatur labore reprehenderit reprehenderit quae. Laboriosam et harum velit ad omnis pariatur doloribus impedit. Sapiente vel doloremque consequatur. Ut similique veritatis et molestias impedit eos eaque.", "Lake Ida", 1, 250.28m, "Small Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 45,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2016, 10, 18, 1, 24, 29, 5, DateTimeKind.Unspecified).AddTicks(1103), "Sed quas odit voluptatum non et ea laborum aut. Ducimus voluptas impedit natus et tempore. Omnis sed dolores sed in.", "South Robertamouth", 814.76m, "Gorgeous Rubber Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 46,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2020, 6, 29, 22, 40, 51, 155, DateTimeKind.Unspecified).AddTicks(5151), "Nulla praesentium qui nobis. Nemo cupiditate doloremque aut in aut ut voluptatum. Voluptatum vitae eos repudiandae.", "Nicolasshire", 299.09m, "Awesome Metal Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 47,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2019, 5, 14, 22, 43, 29, 750, DateTimeKind.Unspecified).AddTicks(1889), "Occaecati voluptas ut. Et numquam maxime sunt eum. Soluta perspiciatis adipisci neque quisquam doloribus laboriosam vitae dicta. Laudantium aut aut provident tempora unde repudiandae earum.", "Lake Cicero", 1, 473.87m, "Handmade Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 48,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2017, 6, 24, 1, 57, 45, 512, DateTimeKind.Unspecified).AddTicks(7571), "Laboriosam assumenda vitae quasi a. Aut vel et esse est eaque. Expedita harum molestias tempora aut qui odit ullam et consequatur. Rerum quia aut. Quis itaque doloribus incidunt provident.", "Grimeschester", 1, 928.12m, "Small Rubber Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 49,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2019, 8, 2, 13, 47, 56, 497, DateTimeKind.Unspecified).AddTicks(8324), "Voluptatem molestias vitae. Consequatur iste doloribus delectus dignissimos. Sed a aut et facere laborum qui explicabo voluptatibus nihil. Molestias eos ea itaque culpa velit. Sit distinctio assumenda dolor earum ipsa. Optio quisquam repellat et vel alias.", "North Salvatore", 2, 757.71m, "Handmade Frozen Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 50,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2017, 3, 3, 20, 22, 41, 490, DateTimeKind.Unspecified).AddTicks(6420), "Dignissimos et facilis. Quisquam ut repellendus ea omnis. Dolor adipisci possimus perferendis non earum illo necessitatibus. Ipsum animi nihil sequi quam ad id velit fuga.", "Leonoraland", 1, 36.89m, "Incredible Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2020, 6, 21, 9, 20, 55, 334, DateTimeKind.Unspecified).AddTicks(7616), "Dolores voluptatem ducimus harum corporis libero repellat quisquam. Expedita assumenda nemo. Ut iusto voluptatem et modi aspernatur sed ratione nesciunt. Earum quas placeat et sit sint ut explicabo minus. Dolorem eaque culpa aut cupiditate sed id id voluptatum animi. Voluptas qui incidunt inventore corporis deleniti necessitatibus dolorum tempora debitis.", "Whitneyberg", 508.55m, "Rustic Rubber Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 52,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2017, 1, 9, 9, 2, 7, 409, DateTimeKind.Unspecified).AddTicks(7320), "Esse rerum incidunt. Quae reiciendis odit dolores sint libero iste illum aspernatur. Sint consequatur quo aperiam est voluptatum quas perferendis. Inventore voluptatem laudantium qui natus et dolorum ut. Vel aut ea.", "Rhiannonview", 431.74m, "Unbranded Granite Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 53,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2018, 7, 26, 1, 27, 0, 278, DateTimeKind.Unspecified).AddTicks(9858), "Odio eaque asperiores enim quia fugiat. Provident in voluptatibus. Sed qui culpa perspiciatis. Saepe in odio iusto nostrum minima molestiae reiciendis.", "New Murphy", 1, 958.88m, "Licensed Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 54,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2017, 2, 7, 19, 34, 36, 181, DateTimeKind.Unspecified).AddTicks(3468), "Aut aliquid explicabo veniam exercitationem ad alias. Expedita repudiandae pariatur suscipit ut eaque totam. Reiciendis consequatur sed neque fugit perferendis. Similique aspernatur consequuntur. Placeat neque provident expedita non fuga voluptatem rerum perspiciatis. Nesciunt qui sit ad ipsam.", "West Nicolette", 2, 400.33m, "Tasty Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 55,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2015, 3, 21, 21, 50, 35, 57, DateTimeKind.Unspecified).AddTicks(7165), "Voluptate autem laboriosam non sit dolorem occaecati aliquam ducimus. Quaerat voluptatem quo hic. Molestiae eos illum et. Rerum quibusdam eligendi. Vel cumque eos voluptatem similique repellendus accusamus temporibus. Dolorem laborum explicabo sed omnis reiciendis reiciendis.", "North Sarah", 1, 195.78m, "Ergonomic Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 56,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2015, 7, 25, 0, 39, 46, 575, DateTimeKind.Unspecified).AddTicks(6098), "Consequatur quo voluptates laborum aspernatur cum porro deleniti accusantium. Nobis distinctio quaerat rem qui rerum. Inventore quisquam ea voluptas rerum.", "Sageside", 499.27m, "Awesome Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 57,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2018, 11, 2, 9, 30, 31, 560, DateTimeKind.Unspecified).AddTicks(986), "Dolor possimus sint. Asperiores non inventore. Hic alias laboriosam non itaque dolorum. Et nihil occaecati sed aut alias sed ut. Nobis animi aut.", "South Thurman", 2, 58.15m, "Fantastic Wooden Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2018, 3, 22, 20, 54, 31, 885, DateTimeKind.Unspecified).AddTicks(1032), "Adipisci corporis ut. Animi cupiditate porro natus tenetur libero non qui sint dolor. Voluptatem distinctio cupiditate et ipsam qui molestiae quisquam. Accusantium rerum delectus.", "New Tobychester", 833.20m, "Fantastic Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 59,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2020, 7, 22, 6, 48, 34, 594, DateTimeKind.Unspecified).AddTicks(5226), "Delectus eaque ratione tempore quaerat non eos. Blanditiis quia doloremque qui aut sit libero. Culpa voluptatem voluptates expedita iste fuga vero accusantium recusandae. Accusantium praesentium odio dicta consequatur voluptatum. Nisi ut ea minima ab assumenda et aut autem quidem.", "Port Edd", 1, 730.63m, "Incredible Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 60,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2020, 7, 17, 23, 56, 57, 918, DateTimeKind.Unspecified).AddTicks(792), "Nisi dolor quia id aut et soluta sequi consequatur voluptas. Natus omnis libero nemo corrupti provident unde. Pariatur sit maiores commodi consequuntur est. Cum libero et dicta doloremque velit repudiandae autem. Dolor nesciunt enim. Repellat consequuntur modi ut expedita ut est ut nobis atque.", "South Pamelahaven", 1, 126.30m, "Licensed Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 61,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2016, 12, 23, 11, 10, 23, 9, DateTimeKind.Unspecified).AddTicks(740), "Quis veniam consequatur. Facilis iure distinctio consequuntur voluptas. Distinctio velit est a. Impedit omnis molestiae cum doloribus amet omnis dolorum. Sit temporibus officia et. Neque tempora et ipsum fugit.", "Yosthaven", 991.13m, "Ergonomic Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 62,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2017, 1, 23, 5, 19, 36, 335, DateTimeKind.Unspecified).AddTicks(8378), "In eum harum odit eius neque. Fugiat dolorem molestias nam error voluptatem vero. Consequatur omnis dolorem asperiores aut labore laborum accusantium minus.", "Schaeferhaven", 2, 95.94m, "Tasty Fresh Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 63,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2020, 3, 5, 7, 49, 28, 352, DateTimeKind.Unspecified).AddTicks(7748), "Sit aliquam rerum veritatis aspernatur laboriosam nostrum nihil quia. Delectus eius dolor perferendis deserunt. Aliquam fugit numquam temporibus et ut dolore. Ipsam praesentium et asperiores corrupti nostrum.", "East Jane", 2, 40.96m, "Tasty Granite Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 64,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2017, 8, 7, 20, 11, 32, 26, DateTimeKind.Unspecified).AddTicks(6151), "Velit culpa qui et enim tenetur labore. Fugit consequatur nam animi a sed. Sint placeat quidem. Exercitationem recusandae doloremque voluptas qui facere.", "Alessandroton", 370.02m, "Incredible Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 65,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2015, 10, 21, 4, 45, 49, 505, DateTimeKind.Unspecified).AddTicks(7823), "Est voluptatem repudiandae facere inventore dolor iusto. Accusamus vitae accusamus dolores impedit sit. Et accusantium nam vel quod. Officiis similique molestiae sequi veritatis temporibus aut aliquid dolores possimus. Nisi ut inventore atque iste perspiciatis debitis at.", "West Sharon", 660.19m, "Rustic Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 66,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2017, 7, 27, 22, 20, 48, 221, DateTimeKind.Unspecified).AddTicks(3984), "Aut molestiae laborum vel culpa doloribus animi. Reprehenderit harum magni id voluptas et voluptatem aut quia autem. Deleniti temporibus non suscipit expedita asperiores voluptates voluptas error. Facilis debitis rem est eius sint.", "West Delaney", 1, 905.88m, "Awesome Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 67,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2019, 11, 18, 1, 6, 10, 259, DateTimeKind.Unspecified).AddTicks(7819), "Sint iusto vero voluptatem dolores. Sapiente placeat culpa. A qui libero tempora eaque mollitia maxime.", "Olsontown", 108.55m, "Handmade Soft Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 68,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2015, 7, 8, 17, 39, 37, 242, DateTimeKind.Unspecified).AddTicks(1314), "Et similique ducimus nulla in nulla consequuntur ut fuga maxime. Qui rem itaque eum sit nihil. Nisi ut veniam porro. Unde aut modi. Cumque nisi ratione dolore.", "Hectorfort", 514.38m, "Small Granite Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 69,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2017, 5, 8, 1, 3, 21, 850, DateTimeKind.Unspecified).AddTicks(4850), "Aut adipisci ipsam. Temporibus voluptates sit qui est sapiente rerum fuga. Iste ut quod aliquid et.", "East Jasmin", 500.12m, "Handmade Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 70,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2015, 1, 15, 18, 51, 20, 497, DateTimeKind.Unspecified).AddTicks(9506), "Sapiente doloribus tempora deserunt. Aliquid repellendus officia. Autem nesciunt eligendi mollitia quod dolor. Neque totam est ut.", "Monaport", 1, 856.19m, "Generic Granite Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 71,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2020, 4, 11, 23, 31, 53, 650, DateTimeKind.Unspecified).AddTicks(7796), "Consequatur molestias repellat est in. Unde unde tenetur omnis dolore harum ipsa repellendus et. Non quam quaerat.", "East Cory", 402.99m, "Gorgeous Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 72,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2017, 10, 23, 21, 47, 46, 286, DateTimeKind.Unspecified).AddTicks(5128), "Eaque eligendi et est dicta quod dolores. Voluptate sint inventore minima reiciendis deleniti vero vel eos. Velit deleniti culpa odit omnis eos autem. Omnis ratione doloremque. Illo et quia quia quia itaque labore aspernatur illum. Qui est at quam nesciunt.", "Kassulkemouth", 1, 646.86m, "Awesome Steel Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 73,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2017, 1, 28, 21, 15, 53, 197, DateTimeKind.Unspecified).AddTicks(9735), "Nam saepe voluptatibus reiciendis doloribus dolor mollitia et molestiae odit. Enim sint in voluptas temporibus magni dicta aut aliquam. Reiciendis et soluta consequatur et. Quisquam neque consequuntur debitis ipsum ad. In sed fugiat. Voluptate dolorem aliquam iste minus.", "Muellerport", 729.19m, "Tasty Plastic Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 74,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2020, 6, 18, 9, 49, 51, 992, DateTimeKind.Unspecified).AddTicks(3074), "Nobis doloremque corporis ut corrupti nemo debitis. Corporis incidunt harum repellat voluptates repellat natus a. Soluta ratione repellat repellendus dolore eaque inventore cupiditate assumenda. In veritatis facere distinctio eos animi. Necessitatibus quia provident sit sint occaecati.", "Lake Herta", 1, 595.41m, "Tasty Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 75,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2015, 2, 27, 1, 14, 18, 213, DateTimeKind.Unspecified).AddTicks(4118), "Rerum cum aut odio doloribus et ducimus. Vel voluptatum quidem omnis similique quos qui corrupti. Iure molestiae dolores. Et dolorum molestiae qui dignissimos et eaque hic excepturi. Et quia magni aliquam et et ducimus sit.", "Port Clinton", 1, 708.75m, "Unbranded Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 76,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2020, 7, 22, 20, 38, 53, 922, DateTimeKind.Unspecified).AddTicks(2922), "Quis porro quae assumenda aliquam inventore debitis dolorum unde. Voluptate assumenda ullam voluptas. Ut odio labore voluptatum officiis distinctio quia qui. Error sint quisquam impedit rerum esse similique.", "Morissettefurt", 266.92m, "Intelligent Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 77,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2017, 5, 25, 20, 52, 18, 55, DateTimeKind.Unspecified).AddTicks(7963), "Odit voluptatum molestiae velit veritatis et non officia. Et praesentium non dolorem in. Quia suscipit laboriosam dolorem cum magni. Praesentium sequi expedita sunt sint amet beatae. Est dolores fugiat sunt. Dolores eos molestias.", "Corneliusbury", 2, 826.08m, "Incredible Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2018, 10, 16, 12, 44, 36, 255, DateTimeKind.Unspecified).AddTicks(2968), "Distinctio non similique voluptatem. Et perferendis ad facere corrupti maiores nisi. Voluptatem consequatur quia vel deserunt perspiciatis ullam. Eum soluta a. Corporis ullam consequuntur asperiores tempora.", "Port Jailyn", 2, 925.37m, "Awesome Steel Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2017, 12, 9, 4, 16, 19, 729, DateTimeKind.Unspecified).AddTicks(9142), "Facere dolorem modi architecto ipsam quis voluptas fugiat illo. Dicta nihil dicta fugiat nulla laborum saepe. Velit necessitatibus minima non.", "North Shannastad", 1, 442.45m, "Unbranded Soft Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 80,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2019, 11, 29, 11, 14, 2, 446, DateTimeKind.Unspecified).AddTicks(3672), "Excepturi minus sit. Aut et neque ipsum delectus et aperiam quo maxime ut. Temporibus et suscipit incidunt qui tempora voluptatem consequuntur adipisci qui.", "Jacobston", 1, 357.24m, "Tasty Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2019, 1, 4, 20, 34, 58, 459, DateTimeKind.Unspecified).AddTicks(1180), "Non amet sunt fugit ex illo exercitationem nulla. Optio eligendi aut voluptates nam tempore hic dolorum. Commodi est doloribus quaerat dolorem in sunt illum maiores. Temporibus a maiores ut architecto beatae et ratione. Totam accusamus aspernatur eum. Voluptatibus voluptatem impedit ut ducimus.", "West Eli", 262.68m, "Unbranded Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2017, 12, 23, 9, 18, 47, 275, DateTimeKind.Unspecified).AddTicks(1266), "Ut quasi similique. Temporibus impedit autem. Fugiat aut non aut voluptatem aut voluptatem omnis. Minima perferendis est dolorem consequatur libero quia quos. Architecto non et ex cumque consequuntur qui dignissimos.", "North Devonte", 1, 291.00m, "Intelligent Cotton Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 83,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2015, 7, 13, 19, 3, 16, 791, DateTimeKind.Unspecified).AddTicks(3242), "Aut itaque nihil dolores beatae tempore. Alias sed ipsum. Et error explicabo quidem eos non. Nemo ea aliquid impedit facilis ut. Aliquid dicta in assumenda nostrum facere ea. Alias qui eos modi nemo minima.", "North Izabellaberg", 1, 160.67m, "Generic Steel Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 84,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2018, 1, 29, 23, 10, 19, 777, DateTimeKind.Unspecified).AddTicks(2124), "Repellat rem eos in. Rem voluptatibus est qui et. Repudiandae esse eaque autem. Excepturi et rerum dolorum velit ad veniam. Totam atque est dolores et asperiores assumenda quo soluta et.", "Port Sadie", 2, 184.38m, "Refined Soft Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 85,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2018, 11, 29, 2, 49, 28, 34, DateTimeKind.Unspecified).AddTicks(4823), "Quod officia modi neque qui. Esse maiores itaque quisquam amet. Recusandae aut et atque.", "New Makennaport", 230.05m, "Licensed Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 86,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2020, 5, 23, 1, 46, 58, 468, DateTimeKind.Unspecified).AddTicks(3378), "Facilis eum animi cum eos. Sit enim laudantium voluptate laudantium exercitationem optio cum. Autem fuga magnam eaque necessitatibus voluptas blanditiis vero. Nihil aut earum. Velit praesentium aliquam et provident est exercitationem saepe officia natus. Et nulla non harum sit velit eius provident quia.", "North Arleneton", 2, 615.70m, "Tasty Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 87,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2015, 1, 17, 10, 8, 8, 479, DateTimeKind.Unspecified).AddTicks(24), "Odit eos consequatur voluptatem vel voluptas aut eum maxime. Veritatis qui aut ipsa. Qui cum dolorem corrupti similique illum debitis reprehenderit.", "East Alfreda", 532.58m, "Intelligent Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 88,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2017, 6, 10, 21, 23, 4, 327, DateTimeKind.Unspecified).AddTicks(4346), "Aliquid fuga doloremque eum blanditiis cupiditate quod nostrum. Sit fuga rerum a eum consequatur nostrum facere atque. Voluptatibus tempora totam et aut omnis. Omnis ad qui velit.", "New Melody", 1, 301.09m, "Gorgeous Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 89,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2017, 5, 8, 8, 58, 50, 284, DateTimeKind.Unspecified).AddTicks(8248), "Culpa ea omnis qui in in id. Aliquam odit nostrum veniam excepturi aut repellat illo. Modi maxime laudantium rem laborum unde recusandae.", "O'Konmouth", 2, 171.60m, "Generic Plastic Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 90,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2015, 9, 8, 8, 44, 13, 928, DateTimeKind.Unspecified).AddTicks(4158), "Quam eum expedita autem ut. Rerum consequatur in nihil. Reprehenderit velit deserunt eum consequatur ullam est fugit delectus. Dolorum praesentium sint nulla similique asperiores itaque et accusamus. Accusamus asperiores minus quidem tempora error. Molestiae quis libero dolor sed.", "Santinaville", 973.67m, "Small Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 91,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2015, 7, 3, 22, 27, 49, 211, DateTimeKind.Unspecified).AddTicks(5411), "Et et quod non ut consectetur. Porro non quae. In laudantium a id dolore non nobis eum exercitationem harum. Tenetur ab nobis. Rerum qui aut placeat vitae nisi et. Fugiat corporis qui voluptas a.", "New Jamartown", 460.18m, "Tasty Soft Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 92,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2020, 2, 15, 13, 20, 4, 693, DateTimeKind.Unspecified).AddTicks(4674), "Optio et illum porro delectus eligendi nulla. Et iste impedit dolor delectus sunt. Sit quia ullam nihil dicta.", "Mosefurt", 169.96m, "Ergonomic Granite Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 93,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2019, 11, 20, 18, 7, 48, 742, DateTimeKind.Unspecified).AddTicks(781), "Omnis rem est odio laudantium sed laboriosam. Repellat culpa at aut. Tempora dolores vel et voluptas delectus culpa aut aut. Delectus doloribus est rerum rem deserunt molestiae nostrum iure maiores. Tempora dolores molestiae.", "Reicheltown", 1, 962.78m, "Gorgeous Steel Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 94,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2017, 6, 21, 19, 0, 4, 303, DateTimeKind.Unspecified).AddTicks(7117), "Porro corrupti possimus. Doloribus rerum dignissimos qui soluta ducimus vel deleniti et ut. Quis totam sed. Repellat repellat blanditiis ut est sapiente et soluta. Quod dicta blanditiis. Temporibus rem debitis iusto.", "Jessycashire", 455.02m, "Licensed Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 95,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2017, 11, 22, 7, 56, 1, 6, DateTimeKind.Unspecified).AddTicks(7351), "Sit vero velit esse placeat at alias voluptatem hic. Molestiae autem sapiente nihil. Deserunt doloribus in eligendi reprehenderit distinctio quidem facere delectus.", "East Cristianton", 212.11m, "Ergonomic Metal Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 96,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2019, 8, 25, 22, 17, 50, 941, DateTimeKind.Unspecified).AddTicks(5932), "Ipsa corrupti recusandae rem et atque eum in. Dolores ea et est blanditiis voluptas fugiat. Sunt eum odit ducimus exercitationem ut rerum voluptates. At qui corrupti. Aperiam molestiae sapiente sint hic dicta possimus et quae. Quis reprehenderit quas quo.", "Bahringermouth", 641.54m, "Fantastic Rubber Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 97,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2016, 2, 19, 8, 21, 47, 84, DateTimeKind.Unspecified).AddTicks(9004), "Hic exercitationem natus error et recusandae dicta voluptas. Recusandae aut minus quas et beatae. Quae ut id illo autem dolorem repellendus necessitatibus corrupti.", "North Shauntown", 198.22m, "Licensed Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2019, 3, 7, 19, 22, 38, 763, DateTimeKind.Unspecified).AddTicks(7584), "Occaecati iusto corporis quod magnam molestiae. Eum eos magni non aperiam temporibus vel ipsa quia tenetur. Excepturi tempore beatae. At sed est voluptatem sed sint.", "West Beaulahstad", 2, 422.25m, "Awesome Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 99,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2019, 11, 17, 3, 41, 12, 393, DateTimeKind.Unspecified).AddTicks(1667), "Distinctio beatae hic ex consequatur voluptate et ratione excepturi magnam. Rerum est ea. Qui aspernatur perferendis. Aut alias repellendus quo accusantium voluptates laborum modi libero maxime. Ut omnis et nihil esse laboriosam. Nulla porro vero est est provident ab sunt libero minus.", "New Miafurt", 36.49m, "Awesome Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 100,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2017, 1, 23, 13, 5, 28, 940, DateTimeKind.Unspecified).AddTicks(6784), "Amet voluptas ea dicta ut laudantium. Maiores maiores voluptas soluta magnam. Magni fugit tempora magnam repellendus. Labore debitis inventore inventore doloremque est accusamus delectus mollitia minus.", "Aydenshire", 399.07m, "Incredible Metal Sausages" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "PhoneNumber", "UserName" },
                values: new object[] { "d523e362-7cf9-40cd-a071-f34504a8d238", "Melba.Waelchi98@yahoo.com", "Waelchi", "729-231-1940", "Melba.Waelchi" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "PhoneNumber", "UserName" },
                values: new object[] { "6d9ecfb4-e67a-4dd9-9dfa-aab2bdaf11e0", "Lee4@yahoo.com", "Kreiger", "1-556-433-8165 x01678", "Lee.Kreiger" });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_UserId",
                table: "Contacts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_AspNetUsers_UserId",
                table: "Contacts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_AspNetUsers_UserId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_UserId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "AboutMe",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "UserContacts",
                columns: table => new
                {
                    UserContactId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ContactId = table.Column<int>(type: "integer", nullable: false),
                    ContactValue = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserContacts", x => x.UserContactId);
                    table.ForeignKey(
                        name: "FK_UserContacts_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserContacts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2015, 7, 29, 19, 13, 25, 609, DateTimeKind.Unspecified).AddTicks(8374), "Vero esse qui ipsum qui molestiae voluptas rerum nostrum aspernatur. Consequatur reiciendis minima. Voluptate consequuntur veniam in.", "Jesusport", 2, 522.74m, "Unbranded Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 2,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2017, 9, 5, 20, 27, 37, 486, DateTimeKind.Unspecified).AddTicks(9388), "Et omnis eligendi officiis. Voluptatibus numquam cupiditate reiciendis omnis officia suscipit est rerum unde. Molestias sequi voluptatem dicta. Rem iste vel vel saepe. Fugit maxime quia ducimus voluptatibus non vero voluptatem ab. Ea et nihil repudiandae omnis.", "Lake Talon", 1, 144.07m, "Refined Steel Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 3,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2019, 6, 17, 15, 22, 51, 192, DateTimeKind.Unspecified).AddTicks(7144), "Saepe sit quia enim dolores aut qui aut. Et sit est consequatur autem similique et itaque odit. Voluptas quia qui quae illum rem labore voluptatem fugiat id. Qui quia laboriosam nulla delectus. Nulla reiciendis voluptates eos minima consequatur maiores est voluptate corporis.", "North Hudson", 1, 9.96m, "Awesome Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 4,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2015, 3, 7, 2, 54, 25, 213, DateTimeKind.Unspecified).AddTicks(7819), "Voluptas aliquam vitae enim dolores excepturi. Quia enim sapiente dolorem culpa et a adipisci est natus. Animi ad velit dolorem ut. Qui mollitia quisquam labore debitis sed nisi distinctio nihil blanditiis.", "New Andreanneshire", 316.07m, "Sleek Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 5,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2019, 9, 14, 15, 4, 24, 936, DateTimeKind.Unspecified).AddTicks(2908), "Qui nostrum iste labore qui. Consequatur reiciendis tempore ex eos sint eveniet autem. Dolore minus dolorum neque officiis velit qui perspiciatis. Deserunt quae consequuntur nihil consequuntur eos non nobis. Et dolores hic voluptatem ullam velit tenetur. Deleniti totam ullam sint ab esse soluta ipsum.", "West Nigelton", 1, 981.51m, "Rustic Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 6,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2019, 6, 30, 16, 3, 5, 450, DateTimeKind.Unspecified).AddTicks(5523), "Pariatur sed dolorem blanditiis autem expedita expedita. Molestiae iusto quam non quia porro ex et. Perspiciatis harum dignissimos magnam sunt quo assumenda deserunt natus. Quis velit voluptatum. Odit autem sed et non rem laudantium tempore.", "Baileyview", 109.98m, "Refined Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 7,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2019, 11, 5, 6, 18, 51, 247, DateTimeKind.Unspecified).AddTicks(5816), "Odit laudantium dolores. Possimus optio illo eos illum. Veniam provident qui repellendus enim quo inventore. Nihil est voluptas. Accusamus quam vel voluptatibus ut et quo placeat est.", "Predovicview", 1, 546.19m, "Generic Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 8,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2015, 1, 1, 23, 49, 3, 433, DateTimeKind.Unspecified).AddTicks(1747), "Consectetur quod et expedita vitae accusantium quae placeat aliquid. Minus quisquam ut deserunt porro occaecati omnis qui fuga ratione. Molestiae ipsam quo. Labore nam mollitia. Eius consectetur ex est aut.", "Marianneside", 325.72m, "Unbranded Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 9,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2017, 9, 13, 21, 0, 45, 622, DateTimeKind.Unspecified).AddTicks(835), "Enim illo cupiditate ut explicabo quas autem blanditiis. Ut molestiae quasi et nulla ea ducimus deleniti magni. Autem repellat modi voluptates eaque laborum qui voluptas eius. Et et voluptas accusamus voluptas non. Architecto alias consequuntur est natus enim modi. Magnam fugiat optio ipsa quae eius.", "Cassandraville", 2, 587.80m, "Handcrafted Steel Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 10,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2015, 6, 19, 4, 53, 55, 317, DateTimeKind.Unspecified).AddTicks(1546), "Aut quisquam quidem aspernatur sed ullam sint. Quis voluptatum consequatur aspernatur illum est alias quos. Dolor possimus et quia quaerat perspiciatis praesentium consequuntur veniam. Nulla totam officia aliquid atque accusantium voluptatibus. Et omnis voluptatem harum qui.", "West Roselyntown", 2, 160.38m, "Ergonomic Soft Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 11,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2017, 12, 8, 4, 21, 0, 858, DateTimeKind.Unspecified).AddTicks(6640), "Eos ea quo dolor quia ut sint cum architecto veniam. Consequuntur cupiditate architecto quo molestiae et porro quidem ratione. Tempore debitis velit et corporis. Sint facilis omnis. Necessitatibus voluptatum mollitia neque in qui quia animi sit. Porro illo perferendis veritatis et quidem accusantium recusandae.", "Kristianside", 2, 64.66m, "Handmade Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 12,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2015, 7, 22, 8, 31, 38, 143, DateTimeKind.Unspecified).AddTicks(3661), "Ea aperiam enim laudantium saepe est molestiae voluptates quaerat nulla. Fugit qui et facilis. Et aliquid culpa nam repellat culpa explicabo. Aut dolorem placeat quasi. Ab veniam facilis qui labore enim nobis quod unde dolorem. Quo sed tempore nihil ea.", "Monahanburgh", 2, 883.57m, "Awesome Metal Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2019, 4, 12, 10, 35, 20, 748, DateTimeKind.Unspecified).AddTicks(9209), "Dolores culpa et ut at recusandae non error sed iure. Sed sapiente aut ipsam. Nemo tenetur aut voluptates. Omnis veritatis numquam blanditiis amet voluptate. Sit perspiciatis occaecati exercitationem corrupti quod. Ut aspernatur quis vero sit praesentium qui.", "Kerlukebury", 1, 175.24m, "Unbranded Metal Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 14,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2016, 1, 24, 1, 59, 21, 958, DateTimeKind.Unspecified).AddTicks(2430), "Omnis ex occaecati at dignissimos libero non dolorem incidunt doloribus. Sint et eius enim nisi vitae recusandae explicabo cumque. Dolore voluptates fuga illum minima voluptatem.", "Alfredmouth", 752.77m, "Gorgeous Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 15,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2015, 4, 22, 1, 42, 34, 24, DateTimeKind.Unspecified).AddTicks(868), "Consectetur et quidem voluptates debitis similique voluptatum perspiciatis nihil esse. Nobis vero nesciunt. Totam corporis ducimus saepe aperiam.", "West Raheemfort", 670.74m, "Gorgeous Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 16,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2015, 2, 23, 22, 35, 48, 515, DateTimeKind.Unspecified).AddTicks(4212), "Aut et quae vel laboriosam doloremque inventore nisi id. Nemo doloremque debitis eveniet aut officiis odit. Et iste numquam omnis temporibus nulla nulla labore rerum delectus. Corrupti cum reprehenderit odit pariatur pariatur aliquam ipsam expedita. Quam quo eligendi molestiae nulla quas possimus autem laboriosam et. Rerum eos modi laboriosam dolorum dolore sed velit delectus.", "West Audramouth", 247.55m, "Refined Frozen Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 17,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2016, 11, 23, 1, 29, 17, 263, DateTimeKind.Unspecified).AddTicks(4344), "Molestiae vel quisquam cupiditate sit rerum. Dicta dignissimos ullam totam reiciendis. Ut ipsum voluptas tempora animi eos sed. Eos doloremque maxime eos sit delectus officia fugiat. Nostrum est quaerat quos numquam voluptas dolorum aspernatur repudiandae.", "Lake Shainafurt", 1, 88.54m, "Generic Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 18,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2019, 4, 5, 9, 22, 18, 859, DateTimeKind.Unspecified).AddTicks(906), "Impedit odio omnis veritatis aliquid aut. Voluptatem reiciendis facere aliquam cum consequatur. Quisquam ab quia sit ratione consequuntur nobis delectus quaerat. Sed rerum sed similique deleniti fuga nulla cum ut. Itaque illum minus voluptatem quos facilis porro voluptas consectetur. Fuga voluptatibus vitae.", "Stehrfurt", 16.46m, "Practical Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 19,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2020, 5, 28, 5, 8, 59, 79, DateTimeKind.Unspecified).AddTicks(5444), "Ea vero illum tempore ex et culpa impedit neque. Ut voluptatem quia voluptas et voluptate sint est nesciunt amet. Et enim quo dolorem. Et nam exercitationem beatae adipisci rerum dolor. Dicta temporibus ut explicabo quo. Quae ad sint non.", "Hauckfort", 2, 574.16m, "Sleek Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 20,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2019, 3, 17, 10, 57, 38, 396, DateTimeKind.Unspecified).AddTicks(9051), "Perspiciatis aut pariatur placeat voluptatum sint velit. Nobis voluptatem sed. Facere impedit molestias dolorem itaque sapiente qui rerum rerum eum. Corrupti assumenda vero voluptatem aperiam incidunt modi dolorum sit. Perspiciatis dolore et et sunt quisquam magni eos.", "Franeckichester", 1, 801.41m, "Tasty Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 21,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2018, 2, 20, 10, 23, 39, 624, DateTimeKind.Unspecified).AddTicks(4897), "Optio mollitia neque laboriosam commodi voluptatibus et. Autem pariatur praesentium rerum sint labore non laudantium nihil. Pariatur et perferendis vitae aut dolores quasi.", "Randytown", 2, 348.25m, "Gorgeous Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 22,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2017, 5, 30, 5, 49, 43, 226, DateTimeKind.Unspecified).AddTicks(6527), "Praesentium aut aut. Commodi corrupti voluptatibus. Ab veniam porro est laboriosam ab odio amet vel. Laborum atque accusantium enim cum dolorem sunt. Aspernatur quidem enim beatae sed quis. Vel dolore cumque quod dolores.", "Lavadaland", 1, 348.81m, "Small Cotton Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 23,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2018, 9, 20, 8, 26, 30, 351, DateTimeKind.Unspecified).AddTicks(4602), "Placeat autem laboriosam. Inventore amet quia earum provident rerum. Nisi sint ut dolorem molestiae nisi. Et quod ducimus soluta a perferendis ex cum dolore ad. Qui voluptate accusamus. Ut voluptas voluptas hic et quia inventore quos quibusdam.", "Mayeville", 783.97m, "Refined Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 24,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2015, 4, 14, 3, 40, 33, 554, DateTimeKind.Unspecified).AddTicks(8968), "Iste quasi fugiat. Odit vel earum recusandae accusamus. Ut occaecati deleniti magnam facilis voluptas. Ut harum maxime dolore est beatae.", "Lake Khalil", 847.86m, "Intelligent Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 25,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2018, 8, 5, 6, 5, 45, 121, DateTimeKind.Unspecified).AddTicks(2300), "Quaerat dolores fuga eligendi rerum sed natus non. Neque est corporis culpa. Qui consectetur unde nihil nobis temporibus. Asperiores in sint sed provident maxime saepe laudantium laboriosam sit. Et ut eum. At nulla est fuga nobis.", "Samanthaton", 2, 120.17m, "Gorgeous Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 26,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2016, 4, 14, 17, 42, 16, 737, DateTimeKind.Unspecified).AddTicks(2680), "Eaque et ut sint aut nesciunt velit autem libero. Accusamus reiciendis est est eaque voluptatem. Suscipit nihil minus. Aut consectetur consequuntur. In ut voluptatem tenetur dolore magnam. Magnam quia laborum id sed molestiae maxime est ad.", "North Delphine", 2, 994.14m, "Ergonomic Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 27,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2019, 12, 16, 19, 58, 32, 366, DateTimeKind.Unspecified).AddTicks(3783), "Velit optio itaque laborum eos iusto quo necessitatibus voluptatem. Nihil eius doloremque qui veniam aperiam. Ut dolorum deserunt perferendis praesentium. Dicta earum dolores consequatur rerum est doloremque amet est. Ipsa illo fuga cum consequuntur. Doloribus aperiam quibusdam consequuntur eum deserunt doloremque sapiente iure tempora.", "Tomasahaven", 2, 974.51m, "Gorgeous Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 28,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2016, 10, 13, 9, 12, 52, 129, DateTimeKind.Unspecified).AddTicks(8286), "Dolorem et sed. Est nulla doloribus tempore. Ex quia et harum natus eius sit reiciendis.", "Port Cecilia", 982.43m, "Handcrafted Steel Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 29,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2016, 12, 28, 11, 27, 58, 237, DateTimeKind.Unspecified).AddTicks(5670), "Id eum blanditiis reiciendis et. Omnis aut mollitia qui. Aut quo sunt tempora. Rerum nisi qui natus voluptate repudiandae ex omnis fugiat.", "East Chesleytown", 914.03m, "Ergonomic Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 30,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2015, 7, 27, 8, 11, 2, 981, DateTimeKind.Unspecified).AddTicks(3081), "Impedit aliquid nam quia vel tempore est adipisci ut dicta. Nisi autem sit ex cumque voluptates qui voluptatum optio. Quo eaque autem asperiores. Quisquam nihil magnam ex est cumque eaque alias. Vel eveniet vitae sed soluta aperiam quidem illum.", "West Margarettamouth", 1, 766.13m, "Fantastic Steel Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 31,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2019, 9, 28, 2, 17, 42, 181, DateTimeKind.Unspecified).AddTicks(3502), "Enim nostrum sit optio tenetur ullam rerum repudiandae iusto. Corporis autem cumque reiciendis. Dolorem veniam autem distinctio quas voluptatem a doloremque voluptatem. Tenetur voluptatem tempora et. Facilis sit sed omnis et est facere. Qui id eligendi ut facilis non consequatur neque et.", "East Linnie", 817.27m, "Gorgeous Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 32,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2017, 2, 22, 6, 48, 24, 231, DateTimeKind.Unspecified).AddTicks(5039), "Repellat minima quisquam consequatur necessitatibus quos quis. Itaque repudiandae adipisci architecto. Et molestiae vel sed enim qui.", "Wuckerthaven", 596.48m, "Small Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 33,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2019, 3, 25, 16, 11, 7, 378, DateTimeKind.Unspecified).AddTicks(6554), "Nisi quod quis minus blanditiis ut eveniet facere. Beatae doloribus magni excepturi accusantium omnis quis adipisci. Deleniti minus eaque dignissimos veritatis sunt. Nobis porro est. Odit harum ut accusantium. Pariatur suscipit nesciunt sit.", "Lake Dallas", 558.74m, "Ergonomic Fresh Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 34,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2020, 4, 12, 11, 50, 1, 0, DateTimeKind.Unspecified).AddTicks(5944), "Consectetur numquam nihil quia cum. Soluta porro fuga assumenda magnam ipsum deserunt laborum ducimus est. Ipsam quia eius. Eos ut rerum excepturi. Laboriosam consectetur culpa ut animi quod.", "Schmittside", 417.26m, "Refined Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 35,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2015, 12, 8, 23, 21, 32, 360, DateTimeKind.Unspecified).AddTicks(4531), "Officia ab delectus corrupti nihil ut distinctio assumenda. Excepturi ratione voluptas dolore repellendus distinctio adipisci natus quos. Ad ipsum excepturi quia. Optio doloremque aut dolore autem tempora error assumenda sequi. Ab laudantium sint at voluptas.", "New Richmond", 935.04m, "Sleek Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 36,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2018, 4, 3, 9, 11, 22, 421, DateTimeKind.Unspecified).AddTicks(1143), "Neque nemo et non architecto debitis. Temporibus qui iure velit. Culpa rerum autem ipsum reiciendis id velit cum impedit est. Officia laboriosam culpa est dolores odit eos qui inventore.", "Lake Grayce", 461.79m, "Handmade Soft Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 37,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2018, 11, 3, 18, 35, 19, 440, DateTimeKind.Unspecified).AddTicks(4130), "Minima at ex ut veniam quam consectetur voluptatem doloribus et. Iusto quos nulla amet dolores consectetur ipsa nobis. Error aliquid sint quod unde repudiandae ducimus. Voluptas et suscipit est.", "Port Elroy", 2, 488.29m, "Intelligent Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 38,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2018, 12, 3, 17, 39, 50, 806, DateTimeKind.Unspecified).AddTicks(7419), "Neque sapiente ut debitis omnis voluptatum reprehenderit ullam vel. Consequatur molestiae laboriosam et doloribus consequatur ut tenetur iste. Voluptatem doloremque beatae id sed cumque.", "North Claudie", 2, 993.12m, "Refined Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 39,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2019, 8, 12, 11, 21, 44, 877, DateTimeKind.Unspecified).AddTicks(4836), "Nobis quis modi aperiam enim cupiditate occaecati. Voluptatem id nesciunt deleniti quisquam quisquam. Est quos magni aut consequatur nisi at velit aliquid odit. Aut nemo quidem harum eaque ea. In ut ut sequi veniam omnis. Vitae sequi unde libero rerum impedit enim.", "North Lavernberg", 2, 448.64m, "Handcrafted Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 40,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2018, 12, 26, 22, 46, 15, 893, DateTimeKind.Unspecified).AddTicks(6306), "Unde numquam maxime sint similique possimus inventore quia qui cum. Non quis voluptas veniam consectetur corporis provident. Qui fugit fugiat consectetur ipsa quam. Optio pariatur ipsum odio dolor veniam aliquid. Consequatur accusamus voluptate aperiam aspernatur consequuntur et hic est odio. Alias beatae vel.", "North Judah", 556.34m, "Fantastic Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 41,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2019, 6, 9, 0, 56, 59, 534, DateTimeKind.Unspecified).AddTicks(5167), "Inventore non sequi aut dolores magnam vero dolores voluptatem velit. Enim et laboriosam maxime neque qui placeat reiciendis quam. Ipsam omnis magni sint fuga aut qui.", "West Rosechester", 2, 937.02m, "Rustic Steel Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 42,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2016, 6, 2, 8, 11, 57, 536, DateTimeKind.Unspecified).AddTicks(3186), "Qui veritatis aut quaerat. Quia veritatis temporibus est sunt. Qui cum totam maxime expedita. Explicabo officiis consequatur. Reprehenderit accusantium similique. Suscipit enim ad.", "West Jamie", 2, 807.29m, "Rustic Plastic Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 43,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2015, 12, 6, 6, 56, 35, 693, DateTimeKind.Unspecified).AddTicks(7964), "Illum aperiam dolores porro sunt aut quaerat. Quia temporibus est qui quasi dignissimos odit consectetur. Ipsam dolor sint. Temporibus corrupti et odit laudantium natus ea ut corrupti. Sequi et quis unde alias eveniet nemo asperiores odit architecto.", "Urielport", 593.77m, "Unbranded Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 44,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2018, 1, 21, 23, 43, 31, 146, DateTimeKind.Unspecified).AddTicks(2390), "Placeat eligendi doloremque perspiciatis magnam laborum odit velit. Aut quo aut et voluptatem cumque saepe odit exercitationem. Voluptatem architecto voluptas ratione voluptas aut est modi. Voluptas ut et ut fuga laudantium nobis soluta.", "Jadafurt", 2, 695.70m, "Unbranded Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 45,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2016, 4, 28, 22, 26, 1, 465, DateTimeKind.Unspecified).AddTicks(1057), "Aperiam dolorem veritatis dignissimos dolores eaque dolorum et. Consectetur similique animi reprehenderit autem sunt fuga. Similique dolor sequi totam voluptatem. Est et doloremque iusto vel. Animi qui ut cum quos optio perferendis quia. Est officia voluptas omnis eos.", "Port Allie", 304.28m, "Sleek Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 46,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2017, 10, 25, 17, 32, 25, 376, DateTimeKind.Unspecified).AddTicks(8366), "Perferendis qui esse temporibus laudantium. Labore minima rerum praesentium corporis molestiae ut. Iste qui tenetur quibusdam deserunt enim eligendi rerum. Possimus est est. Quaerat doloremque ea sit id vero tempora nobis error possimus. Nemo maiores id dolores adipisci accusamus qui.", "West Reyesmouth", 144.37m, "Gorgeous Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 47,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2018, 2, 26, 10, 6, 6, 104, DateTimeKind.Unspecified).AddTicks(1590), "Dolor quod tempore voluptatibus dolore qui minima similique. Tempore repellat asperiores. Eum quos id impedit adipisci eligendi quia quia. Quia aut eligendi necessitatibus architecto iusto.", "Hellerfurt", 2, 555.09m, "Rustic Wooden Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 48,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2020, 4, 5, 15, 15, 0, 992, DateTimeKind.Unspecified).AddTicks(1690), "Officia sit ipsa qui eum sunt qui. Aliquam sit quibusdam autem iusto incidunt deleniti nobis esse sunt. Ea molestias voluptas assumenda quisquam.", "South Rodgerstad", 2, 995.16m, "Unbranded Plastic Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 49,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2020, 1, 18, 11, 33, 3, 277, DateTimeKind.Unspecified).AddTicks(720), "Mollitia ad sed iusto quia dolor. Omnis veniam sed molestiae dolorum nihil. Quod sit necessitatibus aut.", "Deltaborough", 1, 712.67m, "Fantastic Soft Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 50,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2017, 6, 14, 22, 4, 23, 335, DateTimeKind.Unspecified).AddTicks(1413), "Ex est voluptas ut illum ullam. Et suscipit nam corporis. Minus voluptas repudiandae ut. Est iste possimus illo reiciendis. Et magni rerum necessitatibus eum in ut nulla molestiae.", "Stehrmouth", 2, 277.47m, "Incredible Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2018, 11, 23, 4, 15, 15, 917, DateTimeKind.Unspecified).AddTicks(4634), "Hic sequi reiciendis. Qui saepe et. Atque hic autem autem consequatur quam aut. Voluptate temporibus ut et illum officiis quia debitis error quidem. Qui odio fugit animi dicta non facere a. Et fugiat natus soluta et quis rerum eveniet deleniti iure.", "Port Fredy", 400.71m, "Small Cotton Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 52,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2017, 4, 19, 6, 11, 59, 203, DateTimeKind.Unspecified).AddTicks(6886), "Quos amet eius. Quia consequatur aliquid quis dolorem illo laudantium consequuntur doloremque. Tempora nam esse non molestiae molestiae in. Ipsum et blanditiis eaque. Tempora totam excepturi. Aut ratione aut laboriosam autem laudantium.", "Cruickshankmouth", 545.98m, "Intelligent Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 53,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2016, 4, 10, 15, 36, 52, 816, DateTimeKind.Unspecified).AddTicks(8925), "Tenetur veniam id voluptatem. Cumque ipsam sit esse laboriosam dicta. Quia illum et similique culpa. Tempora labore pariatur velit natus consequatur ut aut non a.", "Howellberg", 2, 667.53m, "Generic Steel Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 54,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2017, 9, 28, 11, 35, 59, 405, DateTimeKind.Unspecified).AddTicks(8962), "Voluptatem ea ab. Beatae exercitationem nihil quis similique nulla fugiat. Ratione numquam nostrum facere est. Aut cupiditate quos ea voluptatem. Consequuntur quam expedita.", "West Henryfort", 1, 850.43m, "Intelligent Wooden Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 55,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2015, 5, 12, 4, 52, 22, 731, DateTimeKind.Unspecified).AddTicks(7854), "Praesentium quo reprehenderit. Iste hic cupiditate esse autem omnis quas vel molestiae eius. Nam aspernatur sit reprehenderit distinctio quidem eum. Qui doloremque voluptatibus.", "North Zionfort", 2, 603.27m, "Handcrafted Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 56,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2015, 10, 7, 3, 13, 23, 115, DateTimeKind.Unspecified).AddTicks(5585), "Dolor saepe et dolore perspiciatis sint. Molestiae perferendis molestias omnis qui dolores. Fuga esse architecto assumenda dolore aut sunt sint. Esse doloribus sequi qui exercitationem quia sequi.", "Predovicmouth", 544.77m, "Intelligent Soft Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 57,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2019, 8, 30, 3, 56, 31, 302, DateTimeKind.Unspecified).AddTicks(9162), "Perferendis excepturi dignissimos. Totam aperiam blanditiis suscipit doloribus rerum. Rem ut quaerat qui dolorem aliquam reprehenderit aspernatur. Placeat vero omnis vero. Officia odio eos voluptatem itaque dolore voluptatem nostrum.", "Susanashire", 1, 972.62m, "Awesome Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2020, 1, 19, 2, 4, 1, 159, DateTimeKind.Unspecified).AddTicks(3003), "Ad facilis hic quis similique aut magni consequuntur ducimus enim. Sapiente officia possimus aut. Mollitia enim illo rerum optio sit eum.", "West Ruben", 670.14m, "Handcrafted Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 59,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2017, 2, 17, 10, 5, 20, 136, DateTimeKind.Unspecified).AddTicks(8627), "Rerum corrupti corrupti blanditiis illo. Saepe voluptas quia. Accusantium eum eum aut consectetur labore non aut. Minima explicabo quaerat mollitia sapiente quo. Molestiae illum qui ea. Deleniti impedit vel itaque aut odit.", "Zulaufmouth", 2, 803.52m, "Incredible Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 60,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2017, 2, 3, 7, 35, 24, 720, DateTimeKind.Unspecified).AddTicks(8387), "Et vel qui. Id minima est. Non quod nulla nobis beatae cumque aut quis perspiciatis cum. Accusamus vitae dolores tempore aut eveniet. Possimus beatae doloribus culpa dolore quis. Optio architecto accusantium aut molestiae odit aut.", "East Korbinland", 2, 157.10m, "Refined Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 61,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2018, 10, 24, 11, 23, 45, 397, DateTimeKind.Unspecified).AddTicks(9354), "Doloremque eaque recusandae nihil rem sequi. Cupiditate est eveniet hic. Rem voluptatem vel fuga omnis voluptate. Sunt ut dolorum. Omnis iste tenetur illo placeat sed nihil tempore quod. Voluptatibus quas distinctio qui voluptatem voluptate.", "Port Kirsten", 641.69m, "Incredible Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 62,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2017, 1, 4, 10, 2, 5, 100, DateTimeKind.Unspecified).AddTicks(5871), "Repudiandae porro modi ipsa voluptate quia vel. Sint aut vel ea. Tempora quia ipsa corrupti est quisquam atque praesentium repellat pariatur.", "Olenshire", 1, 540.43m, "Unbranded Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 63,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2019, 6, 12, 14, 17, 38, 344, DateTimeKind.Unspecified).AddTicks(6802), "Accusantium incidunt earum explicabo corrupti omnis dolorem necessitatibus ipsum. Ipsum id aspernatur nihil culpa adipisci ipsa. Non eos repudiandae accusamus et enim molestiae.", "Jadaberg", 1, 248.92m, "Handmade Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 64,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2017, 2, 16, 11, 4, 24, 874, DateTimeKind.Unspecified).AddTicks(2114), "Omnis ut quisquam nostrum odit soluta asperiores. Et dignissimos dolores ex architecto voluptatem dolor. Ut nulla nesciunt animi libero libero pariatur. Hic rerum et fuga officiis. Et et voluptas est quos reprehenderit aut nulla consequatur consectetur. Libero amet consectetur sapiente eos quia nihil consectetur.", "Richmondstad", 23.83m, "Intelligent Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 65,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2020, 3, 27, 19, 14, 13, 357, DateTimeKind.Unspecified).AddTicks(2089), "Quis est corporis vel. Officia molestiae dolorem reprehenderit omnis. Aperiam ut ut. Atque distinctio nisi sunt totam aut et nesciunt odit consequatur.", "South Ociestad", 8.99m, "Fantastic Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 66,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2016, 10, 26, 0, 52, 13, 629, DateTimeKind.Unspecified).AddTicks(459), "Impedit ad placeat mollitia et itaque. Officia illo labore aut ea quisquam architecto magnam. Labore itaque error adipisci aut doloremque doloremque distinctio modi eum. Et eligendi accusantium nihil illo animi. Harum vel quisquam esse harum. In quam dolorem ipsam.", "Douglasburgh", 2, 315.41m, "Gorgeous Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 67,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2019, 11, 17, 20, 21, 8, 558, DateTimeKind.Unspecified).AddTicks(8864), "Et dicta autem esse omnis sunt saepe accusantium. Dolorem et odio odio odio ad dolorem. Nisi quibusdam eum eos quo. Sit aspernatur quasi consequatur nisi voluptas vel tempore repudiandae. Tenetur sunt harum eaque numquam libero enim cupiditate.", "Lake Angelinebury", 845.08m, "Refined Soft Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 68,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2018, 6, 27, 1, 36, 45, 711, DateTimeKind.Unspecified).AddTicks(610), "Illum non ipsam ex. Deleniti quisquam unde cumque sequi. Rerum qui atque et. Repellendus sunt cum atque eos quisquam recusandae impedit. Magnam velit iste ad ducimus ex quidem. Cupiditate eos ipsa.", "New Solon", 186.81m, "Generic Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 69,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2017, 9, 27, 0, 15, 38, 652, DateTimeKind.Unspecified).AddTicks(9216), "Rerum molestiae sunt recusandae ea ea. Explicabo mollitia est minus et. Dolorem ad magnam quibusdam sint.", "DuBuqueborough", 824.52m, "Incredible Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 70,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2020, 3, 3, 21, 29, 34, 743, DateTimeKind.Unspecified).AddTicks(7764), "Et odit eos consequatur est. Ea nihil minima dolorum velit quae ducimus impedit hic. Ut quam cumque consectetur eum qui et voluptates quae. Aspernatur doloribus quod.", "Langview", 2, 815.60m, "Gorgeous Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 71,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2016, 6, 14, 13, 35, 47, 244, DateTimeKind.Unspecified).AddTicks(4087), "Autem ut labore aut ullam autem dolorum ratione consequatur officia. Sit dicta deleniti voluptate blanditiis incidunt. Corrupti placeat consequatur nobis esse fugit facere incidunt nesciunt. Quia eveniet molestiae eos ad ullam qui nesciunt velit eveniet.", "Natashaport", 843.48m, "Fantastic Plastic Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 72,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2015, 11, 13, 7, 50, 44, 934, DateTimeKind.Unspecified).AddTicks(6433), "Optio quo quasi cum. Eligendi qui consequuntur aliquam quasi eius porro. Totam neque laborum et repellendus accusantium dolore quae sit. Maxime enim cupiditate.", "North Arlene", 2, 493.25m, "Sleek Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 73,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2016, 5, 3, 6, 31, 6, 630, DateTimeKind.Unspecified).AddTicks(2161), "Omnis omnis laboriosam quis rerum cum non. Voluptatem et fugit quam ex earum dolor voluptatem consequuntur. Optio voluptas ea alias vel. Quae voluptas similique et numquam libero ut qui. Nemo aut ut voluptates possimus est laboriosam numquam molestias. Voluptate accusantium expedita eos natus similique aliquid.", "Lake Adriannaview", 193.99m, "Licensed Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 74,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2017, 3, 29, 12, 47, 31, 260, DateTimeKind.Unspecified).AddTicks(3346), "Aliquid quidem distinctio animi quae non excepturi. Consequatur cum ex aut. Dolores aut expedita iure fuga consequatur exercitationem eos quidem iusto. Ex fugit ut necessitatibus aliquam occaecati. Incidunt iste sapiente voluptatem assumenda commodi inventore explicabo et.", "North Mallieland", 2, 657.91m, "Fantastic Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 75,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2017, 9, 19, 0, 14, 45, 234, DateTimeKind.Unspecified).AddTicks(7082), "Commodi nobis porro. Modi et non eligendi. Maiores pariatur et consequuntur iste recusandae ut. Exercitationem sit non autem.", "Lake Waltonburgh", 2, 779.79m, "Small Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 76,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2018, 7, 22, 4, 53, 15, 840, DateTimeKind.Unspecified).AddTicks(2897), "Consectetur minima iusto similique. Vel dolorem itaque iusto. Illum exercitationem provident quibusdam. Non adipisci nihil occaecati est. Quia recusandae maxime molestiae dignissimos labore aut id.", "Lake Chetburgh", 993.15m, "Fantastic Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 77,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2016, 7, 27, 17, 36, 46, 153, DateTimeKind.Unspecified).AddTicks(6389), "Aut fuga sequi voluptatibus dolore quia. Accusantium nostrum iste ratione fugiat voluptate. Nisi est facilis. Sunt illo velit corporis in quidem doloribus ut.", "New Aimee", 1, 558.41m, "Awesome Steel Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2015, 7, 12, 15, 1, 33, 819, DateTimeKind.Unspecified).AddTicks(565), "Velit aperiam expedita impedit voluptas ipsum aperiam rem qui exercitationem. Modi asperiores blanditiis rerum enim. Quas tempora sint asperiores. Est maxime consequatur minus consequatur qui rem consequuntur. Aperiam aspernatur cumque et sed qui quos praesentium.", "New Joseshire", 1, 138.47m, "Fantastic Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2017, 5, 9, 0, 30, 4, 633, DateTimeKind.Unspecified).AddTicks(9969), "Vitae architecto hic quos voluptatem repudiandae cumque aut dolorem. Repellat praesentium unde ad quia exercitationem a voluptate repudiandae placeat. Repellat sint voluptatum.", "Nicolasborough", 2, 211.07m, "Rustic Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 80,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2016, 7, 2, 16, 21, 30, 310, DateTimeKind.Unspecified).AddTicks(8874), "Facere aut ad. Temporibus aliquid veritatis nihil sint dolores. Sed cum ut eos est eos nostrum. Dicta sequi rem id fuga error quos itaque aliquam. In autem laborum quia explicabo perspiciatis hic dolores molestiae. Eligendi recusandae non sapiente aliquam quae tempora sed et est.", "East Penelope", 2, 160.66m, "Refined Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2017, 5, 24, 2, 30, 4, 115, DateTimeKind.Unspecified).AddTicks(5292), "Consequatur eveniet earum quia reiciendis quibusdam. Est amet sint impedit sit beatae voluptatem. Excepturi deleniti culpa suscipit tenetur aperiam atque quis nostrum culpa. Qui modi quaerat soluta atque molestias.", "Dwightland", 313.29m, "Small Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2017, 1, 20, 16, 2, 7, 54, DateTimeKind.Unspecified).AddTicks(3662), "Sunt laudantium beatae porro non est temporibus et qui nisi. Quia non est ut cupiditate ut. Laudantium molestias doloremque sed libero. Accusantium harum quos nisi sint et repellat at eveniet. Porro fugit autem minus exercitationem corrupti.", "Johnsside", 2, 319.57m, "Unbranded Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 83,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2019, 9, 17, 18, 9, 29, 339, DateTimeKind.Unspecified).AddTicks(7524), "Porro architecto necessitatibus quis quibusdam minima est. Minima dignissimos omnis cum nisi. Nihil beatae non nihil voluptatem laborum inventore.", "Mosciskistad", 2, 277.81m, "Incredible Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 84,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2018, 3, 22, 11, 50, 38, 785, DateTimeKind.Unspecified).AddTicks(6422), "In eos dolorem natus ut voluptatem explicabo ipsa repellat. Ducimus eos dolore aut. Autem nihil odio ipsum qui. Ut quod blanditiis ad explicabo ducimus. Laudantium qui nesciunt eligendi qui at. Reprehenderit animi occaecati qui odit illo similique veritatis assumenda ipsum.", "Barrowsbury", 1, 526.37m, "Refined Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 85,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2018, 1, 7, 12, 6, 30, 571, DateTimeKind.Unspecified).AddTicks(4610), "Consequatur veniam aliquam officiis quo culpa. Ab facere minima qui doloremque voluptatibus omnis. Vero et laboriosam et. Ut veniam occaecati et architecto at. Enim rem fugit aut quas sunt asperiores. Ut voluptas incidunt nisi.", "Langworthchester", 418.32m, "Sleek Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 86,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2016, 9, 1, 10, 56, 35, 875, DateTimeKind.Unspecified).AddTicks(1227), "Incidunt dignissimos autem molestiae dicta voluptas amet. Vero delectus labore in rerum enim necessitatibus itaque doloribus. Rerum non fugiat repellat sint ut aliquam. Quae et est enim sed aliquid facilis id omnis. Porro similique ratione. Eos et atque voluptatem ad eos.", "DuBuquemouth", 1, 408.32m, "Awesome Granite Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 87,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2016, 2, 29, 17, 55, 37, 624, DateTimeKind.Unspecified).AddTicks(7891), "Ipsum eius quisquam possimus architecto perspiciatis. Rerum non eaque quos fugiat modi. In voluptatum iure ea sint eveniet. Fugit dicta quo est voluptatem omnis consequatur nisi. Molestiae perspiciatis provident nemo qui.", "Rolfsonbury", 358.42m, "Unbranded Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 88,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2015, 11, 12, 12, 10, 52, 165, DateTimeKind.Unspecified).AddTicks(4345), "Consequuntur dolores sed repudiandae. Porro et quo inventore magni. Et facere repellendus nihil perspiciatis qui aut hic ullam repudiandae. Totam est alias. In nemo nemo. Nisi consequuntur omnis dolores harum officiis consequatur et est dolorem.", "Mertzborough", 2, 799.01m, "Refined Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 89,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2018, 3, 18, 10, 22, 41, 129, DateTimeKind.Unspecified).AddTicks(607), "Voluptas est enim aspernatur nam vel voluptates incidunt. Quia voluptate voluptatem repellendus. Nostrum dolorum voluptatem omnis id voluptatem praesentium quia in. Eligendi libero at est dignissimos. Eos praesentium veniam quo ea dolorem.", "Leuschkeville", 1, 995.91m, "Sleek Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 90,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2019, 8, 2, 16, 59, 32, 814, DateTimeKind.Unspecified).AddTicks(3191), "Accusantium voluptatibus consequatur. Odit rem ipsum facilis non tenetur voluptate. A modi repellendus quisquam amet rerum accusamus quasi qui quia.", "Mooreborough", 741.06m, "Generic Steel Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 91,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2019, 3, 24, 19, 7, 23, 644, DateTimeKind.Unspecified).AddTicks(954), "Distinctio praesentium esse cupiditate ex consequatur perspiciatis porro. Voluptates magni numquam eaque corporis harum delectus reprehenderit et ipsam. Quisquam ut modi reprehenderit ad consequatur nulla consequuntur quia eum. Ut laboriosam modi natus voluptas corporis nam deserunt veritatis. Cum neque pariatur atque magni nihil quia.", "South Hollie", 889.13m, "Intelligent Metal Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 92,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2016, 7, 27, 0, 45, 7, 626, DateTimeKind.Unspecified).AddTicks(3469), "Sapiente esse molestias sunt vitae tempora officiis vel maxime nemo. Qui est magnam esse ipsa quod quis voluptates. Distinctio occaecati quisquam id.", "Weberchester", 625.31m, "Intelligent Soft Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 93,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2016, 5, 23, 20, 35, 35, 60, DateTimeKind.Unspecified).AddTicks(8222), "Ipsum deserunt voluptas. Aliquam necessitatibus culpa aut aut. Labore itaque exercitationem aut voluptatem eos aut aut.", "South Maud", 2, 770.55m, "Generic Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 94,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2016, 7, 23, 10, 56, 23, 76, DateTimeKind.Unspecified).AddTicks(1528), "Ipsam ipsa voluptatem nemo officiis ratione. Et necessitatibus est earum dolorum recusandae magnam. Omnis voluptas incidunt dolor tempora ipsum enim minima.", "Hassanbury", 970.77m, "Generic Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 95,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2019, 2, 2, 19, 1, 10, 8, DateTimeKind.Unspecified).AddTicks(2265), "Adipisci repellendus doloribus aut officiis aliquam. Non omnis et architecto quo consequatur. Id et vel neque maiores non. Voluptas quos necessitatibus.", "East Yasmin", 910.25m, "Unbranded Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 96,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2015, 3, 13, 18, 11, 47, 27, DateTimeKind.Unspecified).AddTicks(7350), "Laboriosam magni voluptates ut quo aspernatur qui neque nisi natus. Neque consequatur vitae ut voluptatum ut numquam. Et nostrum aspernatur et eligendi ut. Quia inventore adipisci laboriosam sit molestias a.", "Krystelberg", 255.92m, "Small Granite Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 97,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2016, 12, 3, 14, 51, 44, 148, DateTimeKind.Unspecified).AddTicks(8919), "Dolorem et aut deserunt eum fugiat nostrum. Et cumque labore et numquam nihil. Est libero delectus alias. Explicabo sed quaerat dolores. Eius rerum porro deleniti in sapiente unde porro. Odio facilis occaecati.", "West Joanne", 41.92m, "Small Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2018, 4, 22, 11, 10, 22, 35, DateTimeKind.Unspecified).AddTicks(8883), "Magni consequatur consequatur unde nobis. Dolorum facilis nemo itaque est hic. Asperiores libero quod est repellendus aspernatur voluptatem. Aliquam sed mollitia et amet veritatis enim.", "East Susieville", 1, 575.93m, "Fantastic Plastic Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 99,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2019, 11, 2, 19, 56, 4, 608, DateTimeKind.Unspecified).AddTicks(2884), "Alias non non omnis iste laudantium aperiam tempora nemo. Sapiente rerum quae illum officiis neque assumenda ab. Quam enim molestiae nesciunt doloremque et. Velit facilis quidem ratione nobis. Praesentium dignissimos sint quae tempore quo earum quisquam doloremque.", "Port Jermaineside", 234.97m, "Sleek Rubber Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 100,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2019, 3, 3, 17, 46, 1, 130, DateTimeKind.Unspecified).AddTicks(2697), "Molestias sunt illo et. Sit ut reprehenderit deserunt neque. Sed atque animi corporis dolorem quos recusandae odit est reprehenderit. Occaecati distinctio dicta adipisci. Rerum neque voluptas quia minus modi et itaque rerum.", "Danielport", 761.88m, "Practical Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "PhoneNumber", "UserName" },
                values: new object[] { "7b6ef959-bce4-471d-941e-9c21f162198c", "Genevieve_Windler44@hotmail.com", "Windler", "342.357.9639 x0048", "Genevieve_Windler" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "PhoneNumber", "UserName" },
                values: new object[] { "517c524c-589a-4dc7-ad93-ca824393d542", "Gwen78@hotmail.com", "Rau", "(965) 733-6429 x76506", "Gwen_Rau75" });

            migrationBuilder.CreateIndex(
                name: "IX_UserContacts_ContactId",
                table: "UserContacts",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_UserContacts_UserId",
                table: "UserContacts",
                column: "UserId");
        }
    }
}
