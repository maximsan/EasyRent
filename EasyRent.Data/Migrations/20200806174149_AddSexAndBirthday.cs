using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyRent.Data.Migrations
{
    public partial class AddSexAndBirthday : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sex",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2017, 6, 4, 1, 55, 7, 177, DateTimeKind.Unspecified).AddTicks(8407), "Soluta sit mollitia eaque eum quas numquam est aut. Corporis aliquam et unde quas temporibus. Officiis enim rerum quasi ratione mollitia atque.", "North Napoleon", 236.17m, "Small Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 2,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2017, 12, 10, 11, 51, 48, 694, DateTimeKind.Unspecified).AddTicks(1376), "Corrupti officia ea quam nemo molestias. Omnis aut reprehenderit quas nam saepe consequatur. Possimus ipsam nesciunt est provident. Fugit voluptas aliquid omnis reiciendis facere. Ut accusamus consequatur nihil animi. Corporis itaque rem.", "Mayertmouth", 1, 581.61m, "Refined Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 3,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2020, 4, 30, 12, 55, 26, 593, DateTimeKind.Unspecified).AddTicks(9444), "Et sed quis totam esse. Autem dolorem ab. Voluptas possimus labore cupiditate itaque qui vitae veritatis.", "Lakinview", 1, 285.34m, "Practical Rubber Keyboard" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2017, 8, 24, 7, 31, 34, 544, DateTimeKind.Unspecified).AddTicks(5356), "Eum nam aut dolorem eos sint ab. Et quisquam nam maiores dolorem sed quaerat error officia. Occaecati omnis labore. Qui quibusdam magni omnis ex. Autem tenetur at qui et consequatur quo.", "New Gladyce", 1, 87.91m, "Gorgeous Wooden Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 6,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2019, 7, 2, 3, 22, 19, 226, DateTimeKind.Unspecified).AddTicks(8337), "Expedita molestiae voluptas voluptas. Possimus ratione laboriosam veritatis cupiditate enim. Officia nesciunt sed odio cumque accusamus cupiditate maxime. Consequatur hic maiores adipisci accusantium et esse repellat pariatur. Minus sed qui cumque officia laborum amet ex iure explicabo.", "Lake Ozellaburgh", 695.30m, "Sleek Wooden Soap" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2020, 2, 10, 2, 19, 42, 222, DateTimeKind.Unspecified).AddTicks(7392), "Voluptas voluptate adipisci culpa cumque. Inventore et earum iure voluptates ratione eos fugiat iure. Voluptatem ab sit doloribus necessitatibus quidem. Veniam vitae doloremque sint aperiam. Modi totam ipsum numquam vel itaque repellendus quos laudantium impedit. Omnis iste itaque atque blanditiis ut quam velit ullam.", "East Lelahborough", 986.92m, "Fantastic Wooden Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 9,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2017, 6, 10, 1, 42, 22, 584, DateTimeKind.Unspecified).AddTicks(9274), "Aspernatur quisquam et. Non voluptas eveniet id reiciendis nobis nisi cupiditate. Suscipit optio omnis eum. Est quas minus et et eos at. Odio aut rerum culpa. Aperiam et facere blanditiis eius error quo laborum sunt sint.", "Arvidview", 261.23m, "Licensed Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 10,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2018, 3, 7, 20, 47, 20, 807, DateTimeKind.Unspecified).AddTicks(9362), "Eum nostrum adipisci. Inventore necessitatibus cumque necessitatibus sunt delectus qui quisquam. Id blanditiis debitis voluptatum numquam. Recusandae sint maiores. Illum animi animi. Qui in quis.", "South Adolfo", 2, 973.45m, "Awesome Granite Ball" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2017, 5, 25, 19, 7, 11, 107, DateTimeKind.Unspecified).AddTicks(2594), "Facilis enim labore eaque unde. In voluptatum quam quia impedit velit. Illum distinctio est quis rerum fuga maiores. Ut reprehenderit est quia corporis iste hic debitis.", "Montanachester", 622.14m, "Sleek Steel Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 14,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2019, 12, 11, 4, 4, 58, 484, DateTimeKind.Unspecified).AddTicks(6363), "Temporibus et corrupti quia omnis ut. Optio repudiandae corrupti aliquid sunt voluptatem mollitia maxime sint laudantium. Et et ducimus mollitia repudiandae deserunt repellat in doloremque.", "Krisborough", 2, 110.21m, "Refined Granite Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 15,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2019, 10, 27, 0, 27, 3, 265, DateTimeKind.Unspecified).AddTicks(9749), "Eaque cum aliquam delectus sit vel eos corporis. Laboriosam neque delectus et similique labore alias adipisci aut saepe. Reiciendis ut ratione fugit similique. Cupiditate sunt repellendus quo voluptas perferendis.", "East Coralieberg", 194.89m, "Generic Fresh Bike" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2019, 12, 3, 14, 0, 51, 208, DateTimeKind.Unspecified).AddTicks(3630), "Expedita omnis voluptatem assumenda qui velit et. Quam cumque occaecati dolorem quas iusto praesentium. Sunt sit hic porro et aperiam autem saepe nesciunt adipisci. Consequatur deserunt quod aut voluptas perspiciatis est saepe repellat voluptatem. Perferendis cumque est quo sed qui quia quod.", "Joshville", 2, 271.17m, "Unbranded Concrete Computer" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2018, 2, 14, 6, 10, 3, 390, DateTimeKind.Unspecified).AddTicks(8211), "Eveniet voluptatibus et natus enim tempora eaque consequatur dolore. Voluptatem ut ipsam accusantium id sapiente quibusdam reprehenderit officiis. Est culpa suscipit at itaque atque perspiciatis quos aut odit. In dolore et eos alias quo. Nihil molestias exercitationem incidunt delectus.", "South Tommieport", 2, 666.37m, "Handcrafted Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 22,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2019, 12, 8, 16, 49, 13, 156, DateTimeKind.Unspecified).AddTicks(9295), "Facilis voluptas dolorum repellendus nobis. Non eos nihil est aut distinctio necessitatibus. Quia perspiciatis nobis commodi eligendi perspiciatis laborum voluptas.", "North Adan", 878.10m, "Licensed Metal Ball" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2017, 9, 25, 8, 29, 3, 871, DateTimeKind.Unspecified).AddTicks(6142), "Earum aut modi est consequatur quia aperiam. Perferendis eos sit voluptatem accusantium itaque quae. Sit quo porro natus inventore qui. Qui aut enim. Qui aut odio qui nihil nulla qui hic provident et. Aspernatur earum nisi molestiae ut et occaecati sint numquam.", "Pollichton", 2, 847.03m, "Sleek Cotton Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 25,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2018, 2, 21, 17, 43, 59, 746, DateTimeKind.Unspecified).AddTicks(9148), "Optio quia qui laborum in omnis ipsam dolor. Doloribus sint ratione voluptatum laborum. Eius et dolores deleniti recusandae sunt explicabo et saepe. Deserunt aut quia cupiditate labore ea harum rem numquam in. Necessitatibus illum quia architecto quia quod repudiandae vero. Voluptates quis accusamus laborum.", "Port Alysonbury", 2, 837.41m, "Awesome Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 26,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2016, 7, 12, 21, 37, 52, 86, DateTimeKind.Unspecified).AddTicks(8919), "Et veritatis qui aut tempore voluptatem numquam ipsa sit vel. Voluptate qui aliquid sit. Porro ipsa modi ut. Nihil vel ex non quidem tempore et deserunt.", "East Eulah", 625.44m, "Intelligent Steel Pizza" });

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
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2016, 8, 19, 19, 24, 58, 171, DateTimeKind.Unspecified).AddTicks(7101), "Voluptatum molestias aut aperiam temporibus cupiditate aut quaerat. Qui ea sequi necessitatibus et. Mollitia laboriosam sit saepe itaque dignissimos delectus. Unde quis distinctio inventore quod molestiae dolor temporibus quis eum.", "East Mathilde", 406.57m, "Intelligent Plastic Bike" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2019, 1, 9, 0, 56, 33, 514, DateTimeKind.Unspecified).AddTicks(5637), "Aliquid iste odio. Officiis corrupti libero est nihil asperiores rerum. Voluptas laudantium non. Non qui ad numquam esse laborum sint delectus quis. Neque odio accusantium omnis facilis ea et unde reprehenderit. Accusantium dolorem blanditiis aut consequuntur quas ut.", "Adrielfort", 2, 350.27m, "Handcrafted Granite Salad" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2018, 6, 16, 6, 39, 15, 826, DateTimeKind.Unspecified).AddTicks(6190), "Dolores et voluptas quia consequatur quo quia qui. Vitae distinctio voluptatem nihil cumque iste iusto ut mollitia quae. Quia in adipisci optio maxime consectetur dicta temporibus nobis neque. Est ducimus omnis quos at aliquid ab aliquid. Minus voluptate aut ut natus et et iste. Maiores nobis numquam.", "Balistreriport", 94.45m, "Practical Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2017, 5, 25, 22, 26, 4, 384, DateTimeKind.Unspecified).AddTicks(1054), "Ea illo illum officiis quia nihil vitae ullam et. Consectetur porro ullam pariatur dolores. Quis non quisquam.", "Jaunitaport", 2, 709.38m, "Practical Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 36,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2017, 2, 26, 8, 15, 22, 223, DateTimeKind.Unspecified).AddTicks(5981), "Aliquid commodi suscipit. Quas fugiat doloremque ut consequatur et iure ut mollitia quo. Autem in dolores quis sit aspernatur distinctio ut quis. Ut in quo consequatur ad commodi et molestias consectetur. Ex sapiente eos harum quaerat aliquam sit aliquid autem.", "South Bessiestad", 237.58m, "Generic Fresh Bike" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2019, 5, 18, 7, 37, 34, 327, DateTimeKind.Unspecified).AddTicks(5750), "Rerum aliquam magnam. Beatae nihil culpa autem omnis. Ea ex sit aspernatur. Laudantium vero illum molestiae et deserunt. Tempore in occaecati ex ut. Odit sint maiores reprehenderit quia aut ad illo ullam.", "Ferryport", 2, 238.09m, "Licensed Cotton Ball" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2017, 9, 21, 3, 46, 7, 674, DateTimeKind.Unspecified).AddTicks(8114), "Eaque non cumque deleniti eveniet eius illum. Voluptatem repellendus culpa vel ut pariatur id. Qui aliquam et qui aut perferendis. Accusantium culpa adipisci hic eaque ad.", "Hagenesshire", 2, 528.75m, "Refined Frozen Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 43,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2020, 1, 14, 16, 41, 3, 449, DateTimeKind.Unspecified).AddTicks(6598), "Facere voluptatem porro. Corporis quaerat sequi aliquam iure blanditiis eos. Quod velit voluptatem aperiam tempore ut cumque enim. Magnam iste voluptatum animi at rem officiis sit eveniet. Quisquam eos laborum ex placeat omnis cupiditate ad itaque autem. Necessitatibus nemo dignissimos quis temporibus laudantium tenetur quis vel.", "Skilesport", 2, 341.09m, "Sleek Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 44,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2016, 10, 18, 7, 28, 31, 809, DateTimeKind.Unspecified).AddTicks(5196), "Corrupti in qui fugiat magni illo enim aliquam voluptatem fuga. Voluptatum doloribus ea dolore doloremque ipsam et aut et. Dicta recusandae necessitatibus autem enim pariatur eaque ut fuga dolorem. Excepturi et in minus.", "South Madyson", 407.22m, "Handcrafted Wooden Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 45,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2020, 1, 28, 18, 59, 14, 661, DateTimeKind.Unspecified).AddTicks(4120), "Laudantium quia qui eum. Ea a in rerum aliquam praesentium vero quia incidunt. Cupiditate et laborum sapiente consequuntur a sint qui. Voluptate id labore voluptas molestiae laborum qui commodi et.", "Kobeborough", 1, 41.35m, "Practical Cotton Keyboard" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2018, 12, 24, 12, 54, 34, 500, DateTimeKind.Unspecified).AddTicks(7987), "Voluptas consequuntur aut eius molestiae sequi libero. Laborum fugit repellat tenetur nemo sunt deleniti ex ea at. Dolores quidem nihil beatae eaque.", "Auermouth", 1, 467.87m, "Awesome Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2016, 12, 20, 5, 0, 54, 36, DateTimeKind.Unspecified).AddTicks(9334), "Aspernatur quia suscipit necessitatibus sit recusandae. Molestiae est a. Dolores voluptatem aliquam quo.", "West Aubrey", 870.47m, "Practical Steel Sausages" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2016, 3, 30, 16, 50, 16, 485, DateTimeKind.Unspecified).AddTicks(3916), "Quibusdam et consequatur nulla reiciendis est aut fuga. Harum rem ullam cumque labore. Nisi consectetur ipsam et excepturi aliquid dolores sint eos. Sed id temporibus eos omnis voluptate quia autem.", "North Gregg", 2, 194.63m, "Small Rubber Sausages" });

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
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2018, 12, 5, 8, 59, 10, 888, DateTimeKind.Unspecified).AddTicks(2790), "Aut tempora ex est qui consequuntur repellendus in consequatur. Ut tempora eius libero reprehenderit fugit aut. Deleniti veritatis nostrum. Quis ullam voluptatibus iste nisi et.", "Eleanoreside", 345.98m, "Sleek Steel Towels" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2019, 12, 19, 14, 51, 24, 725, DateTimeKind.Unspecified).AddTicks(7092), "Quo ad qui laboriosam dolore dolorem recusandae enim occaecati. Voluptas rerum cumque sint numquam eveniet dolorum quos ut dignissimos. Rerum a mollitia et provident illo. Ducimus pariatur labore facilis ea asperiores consequuntur quas quia nobis. Deleniti voluptatem molestiae cum ipsum.", "Ryanfort", 188.96m, "Gorgeous Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 61,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2016, 1, 23, 6, 32, 57, 339, DateTimeKind.Unspecified).AddTicks(7627), "Voluptatem unde ut. Aut repellat qui libero optio quia labore impedit. Quo est recusandae tempora et sit. Sapiente temporibus tempore.", "Lake Samsonfurt", 534.86m, "Licensed Plastic Chicken" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2019, 5, 15, 23, 53, 11, 356, DateTimeKind.Unspecified).AddTicks(2617), "Qui fugit consequatur sequi quia consequatur voluptatem iure quia eius. Quia et vel necessitatibus id iure et labore nesciunt sed. Maiores magni autem adipisci quos. Provident id dicta.", "West Maybelltown", 46.12m, "Generic Soft Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 65,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2019, 3, 7, 15, 43, 23, 751, DateTimeKind.Unspecified).AddTicks(8070), "Nisi eaque rem error mollitia rem beatae nesciunt. Qui officiis numquam consequuntur cum ea aut sint sit vero. Magni et optio tenetur repellendus nulla doloribus. Velit praesentium omnis hic quam minima repellendus. Est molestiae voluptate inventore non non sequi minima eum. Et itaque iusto dignissimos voluptatem officia enim autem culpa.", "West Joshua", 780.74m, "Handmade Granite Shoes" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2018, 5, 6, 8, 24, 28, 421, DateTimeKind.Unspecified).AddTicks(9500), "Sapiente quo nemo quidem deleniti eos. Impedit et sunt quam laudantium tempora sunt molestiae. Illum fugit eveniet incidunt eaque quod alias sint culpa ipsum. Et sit dolore. Tempore sit expedita et velit vel. Harum voluptatem quia qui sit dolores magnam dolores.", "Lake Bonita", 1, 711.87m, "Unbranded Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 70,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2018, 5, 6, 18, 3, 3, 670, DateTimeKind.Unspecified).AddTicks(1196), "Illo enim qui officiis autem amet sunt maxime dolores. Tempora tempora culpa amet atque quidem voluptates. Iste accusamus ut ducimus quo velit. Dolorum laboriosam exercitationem id minus nemo rerum commodi. In quia odio ducimus non repellat ipsa. Alias rerum et saepe magni quisquam cumque.", "New Skye", 667.47m, "Tasty Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 71,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2016, 8, 3, 12, 1, 55, 504, DateTimeKind.Unspecified).AddTicks(9863), "Autem eos in voluptatem qui eos doloribus laborum neque. Praesentium et natus eum. Dignissimos eum qui pariatur quos et mollitia quia ipsa. Aut in et delectus est qui. Blanditiis ratione dolore commodi animi. Doloremque doloremque eos odit ut ut tempora.", "Bennyland", 1, 761.98m, "Rustic Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 72,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2016, 2, 7, 12, 17, 57, 526, DateTimeKind.Unspecified).AddTicks(1926), "Ex pariatur est laudantium molestiae facilis iusto autem ratione repellendus. Culpa in nulla quia omnis illum. Excepturi illo earum illum voluptas.", "Gislasonburgh", 802.41m, "Tasty Soft Chair" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2016, 2, 3, 5, 25, 53, 272, DateTimeKind.Unspecified).AddTicks(629), "Aliquam non aut esse aut saepe qui id eum eum. Laboriosam numquam et accusamus magni eaque iste qui vel aut. Fugiat aliquid quia dolor dolor molestiae adipisci. Labore quia aut facilis quia quibusdam voluptas aliquid et vitae. Voluptas recusandae officiis doloremque consequatur. Minima quo ullam et hic.", "Angelfort", 1, 655.90m, "Handcrafted Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 77,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2018, 1, 3, 11, 45, 40, 261, DateTimeKind.Unspecified).AddTicks(1946), "Ratione officia sit similique quasi architecto quis est et. Cupiditate voluptatem libero a quia velit voluptatum. Sunt saepe consequuntur quis temporibus hic nulla. Aut modi eos blanditiis ut illum ullam. Qui odio cum.", "Cordiemouth", 12.77m, "Intelligent Steel Chair" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2016, 10, 11, 21, 23, 19, 724, DateTimeKind.Unspecified).AddTicks(2540), "Mollitia et fugiat in esse excepturi velit quos. Quia illo voluptas possimus laborum quae ut quam voluptatem est. Nihil quo sit ut. Sit ea et tempora qui. Sed itaque quia facilis aliquam culpa qui fugit. Sint harum possimus doloremque vel necessitatibus harum quaerat deserunt.", "New Loren", 182.49m, "Licensed Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 80,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2020, 4, 4, 11, 41, 27, 499, DateTimeKind.Unspecified).AddTicks(4438), "Dolorem ut magnam est. Dolorem et delectus temporibus reprehenderit eligendi et. Fuga autem tenetur voluptatem rerum esse unde aut est.", "Connellytown", 353.36m, "Rustic Wooden Cheese" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2017, 12, 12, 21, 11, 8, 455, DateTimeKind.Unspecified).AddTicks(9510), "Quae est nisi esse nobis aspernatur et. Sequi animi non et qui fuga. Nihil aut sint accusantium debitis. Blanditiis error et sed ipsam cupiditate debitis excepturi repellendus doloribus. Quo tempore optio officiis aperiam.", "Flomouth", 2, 956.58m, "Small Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 84,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2015, 10, 20, 8, 13, 15, 250, DateTimeKind.Unspecified).AddTicks(9033), "Accusantium consequatur saepe omnis. Laborum deserunt neque repudiandae numquam consequatur in doloribus. Quis laborum labore voluptate omnis non quam libero eius nesciunt. Et earum nesciunt maxime ut nostrum.", "East Meta", 1, 488.13m, "Licensed Wooden Fish" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2016, 6, 26, 16, 41, 47, 908, DateTimeKind.Unspecified).AddTicks(3083), "Tempore exercitationem odit occaecati illo iste. Impedit voluptas optio dolor labore iure id eaque. Aut error sed illum voluptas adipisci aut qui dolores. Nam nemo ad id ratione quo saepe.", "East Hank", 442.54m, "Gorgeous Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 87,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2018, 11, 8, 2, 38, 20, 62, DateTimeKind.Unspecified).AddTicks(2140), "Omnis itaque eos recusandae voluptas reiciendis et dolores iste. Voluptatum esse quo eum dignissimos necessitatibus eum. Est unde rerum nisi veritatis qui. Commodi facere ducimus error omnis est quis ipsa. Qui tempore cupiditate autem hic fuga ut. Laboriosam dolor cum repellat qui officiis cum vitae.", "Parisianville", 289.78m, "Unbranded Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 88,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2015, 7, 29, 8, 25, 4, 517, DateTimeKind.Unspecified).AddTicks(1307), "Similique consequatur qui consectetur quis. Et assumenda commodi aut. Aspernatur sed labore consequatur veniam omnis.", "Lorihaven", 2, 771.65m, "Sleek Metal Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 89,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2015, 8, 5, 3, 6, 3, 499, DateTimeKind.Unspecified).AddTicks(7167), "Quo et maiores in asperiores dolores sit a atque. In architecto et porro officiis consectetur dicta. Et sed mollitia. Cum voluptas nisi qui dicta suscipit omnis dicta et atque.", "Port Julianne", 1, 942.94m, "Sleek Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 90,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2018, 1, 10, 17, 43, 9, 809, DateTimeKind.Unspecified).AddTicks(4030), "Inventore consequatur et. Quibusdam vero sit libero sit quia sed molestiae iure. Inventore velit quae repellat sit qui consequatur explicabo. Recusandae consectetur non nobis iure debitis perspiciatis non.", "New Margret", 1, 268.61m, "Awesome Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2018, 5, 6, 6, 4, 17, 835, DateTimeKind.Unspecified).AddTicks(1014), "Dolore assumenda animi iste voluptas rerum. Inventore cum qui eveniet repellat delectus nesciunt recusandae in. Ipsum harum temporibus rem est non corporis quo reprehenderit. Eligendi est blanditiis quaerat quia illo et. Neque officia autem nulla maxime vitae. Pariatur magni est cum corporis autem.", "Rogahnfurt", 751.47m, "Practical Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 92,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2017, 1, 6, 11, 54, 32, 979, DateTimeKind.Unspecified).AddTicks(8365), "Sed aut suscipit modi aut sunt. Suscipit facere est maiores quos voluptas rerum impedit maiores quibusdam. Culpa eaque sunt ratione voluptates reiciendis dolor molestias rerum. Quidem aut quia nostrum provident qui et reiciendis voluptatem et. Sequi minus delectus fuga. Omnis sit molestiae.", "Jacklyntown", 1, 798.56m, "Small Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 93,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2016, 1, 18, 13, 36, 4, 153, DateTimeKind.Unspecified).AddTicks(6695), "Quis nobis ab cumque rerum ducimus. A non aliquam qui quo ipsum omnis molestiae. Quia occaecati eveniet numquam mollitia. Sit iusto harum.", "East Kirkchester", 35.03m, "Handcrafted Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 94,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2016, 4, 3, 19, 50, 9, 753, DateTimeKind.Unspecified).AddTicks(3973), "Cum error et modi dolores. Est dolorem et corrupti quis. Labore qui nostrum qui voluptas quis ex. Et itaque dolorem sed incidunt eveniet animi. Ipsa voluptatibus tempore a et at voluptas suscipit voluptatem autem.", "Alexandreachester", 1, 464.88m, "Fantastic Soft Ball" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2020, 2, 3, 21, 52, 10, 744, DateTimeKind.Unspecified).AddTicks(9381), "Laboriosam id maiores a laboriosam velit deserunt ut distinctio officiis. Temporibus ipsum animi sit doloremque fugit maiores dolores ullam suscipit. Consequatur qui deleniti nisi qui molestias sit repellendus. Nihil doloribus reiciendis.", "Lake Geraldine", 871.99m, "Handcrafted Metal Bacon" });

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
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2015, 12, 24, 3, 27, 43, 390, DateTimeKind.Unspecified).AddTicks(8225), "Cum officia aut optio optio non tenetur eum expedita dicta. Qui tempore alias porro. Eos voluptatibus alias voluptatem dolor porro. Quaerat nulla architecto nobis perspiciatis dolorem est.", "New Amy", 26.82m, "Small Granite Shirt" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2016, 7, 17, 1, 39, 19, 497, DateTimeKind.Unspecified).AddTicks(7350), "Aspernatur molestias asperiores consequatur omnis veritatis blanditiis commodi. Maxime esse molestiae omnis odit vero consectetur. Rerum sunt qui ex et dignissimos velit hic. Esse commodi molestiae qui voluptatibus dolor ea officia facilis. Iusto et numquam et perferendis accusamus.", "Camdenfort", 122.96m, "Handcrafted Granite Shoes" });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Sex",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2015, 5, 12, 21, 6, 59, 465, DateTimeKind.Unspecified).AddTicks(8085), "Nihil libero qui officia repudiandae ut quisquam quia. Ut aut aliquam est consequatur dignissimos provident. Et laborum nobis quia eum quos quia sed eius. Necessitatibus ipsam quidem doloremque nisi dolorem. Saepe expedita blanditiis quod voluptates et non sapiente quae.", "Barrowsville", 825.31m, "Intelligent Plastic Sausages" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2015, 4, 26, 11, 37, 40, 234, DateTimeKind.Unspecified).AddTicks(2754), "Illo velit voluptatum autem accusamus. Sit voluptates consequatur maiores enim expedita sapiente iusto accusantium ex. Hic natus libero et et maiores delectus et consequuntur. Omnis enim reiciendis perspiciatis repellendus vel omnis in. In eius rem maiores.", "D'Amoreville", 375.95m, "Unbranded Wooden Computer" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2015, 3, 15, 16, 36, 46, 668, DateTimeKind.Unspecified).AddTicks(1662), "Qui facere nostrum. Est recusandae ea veniam est adipisci necessitatibus. Optio ratione sequi amet vero qui illum voluptatum nobis porro. Et sequi facere cupiditate rem delectus nisi. Vitae quasi id. Dolorem praesentium ab enim cum harum quia suscipit iusto.", "Lebsackside", 771.71m, "Unbranded Metal Mouse" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2017, 1, 7, 0, 43, 57, 655, DateTimeKind.Unspecified).AddTicks(2277), "Expedita dolore maxime cum. Harum nostrum ut cumque necessitatibus doloribus suscipit magni tempore nulla. Sunt delectus in et quibusdam sunt.", "Murazikshire", 626.15m, "Licensed Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 12,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2019, 5, 19, 10, 56, 54, 632, DateTimeKind.Unspecified).AddTicks(7715), "Consectetur voluptas et expedita omnis quia consequuntur officiis. Officia reprehenderit fugiat minus. Aut autem repellat nemo quod dignissimos nisi dicta consequatur sed.", "Evelynhaven", 88.14m, "Generic Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 13,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2019, 6, 24, 18, 47, 51, 182, DateTimeKind.Unspecified).AddTicks(4144), "Est sint quia. Corrupti molestiae molestiae nostrum. Ratione necessitatibus dolorem incidunt. Commodi id praesentium mollitia quia.", "South Kadeshire", 417.15m, "Incredible Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 14,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2016, 6, 13, 23, 40, 56, 715, DateTimeKind.Unspecified).AddTicks(94), "Voluptatum ut est vitae aut. Tenetur quam expedita beatae aut unde qui. Vero suscipit aut. Quia nihil qui. Non consectetur a temporibus necessitatibus ducimus.", "Lindseymouth", 1, 631.72m, "Generic Rubber Pants" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2016, 4, 28, 19, 47, 48, 849, DateTimeKind.Unspecified).AddTicks(6597), "Enim eos sequi esse eos. Voluptatum dolores quidem officia eius eos. Saepe assumenda saepe ipsum.", "Port Kristian", 2, 491.63m, "Small Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 17,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2017, 11, 4, 0, 13, 50, 758, DateTimeKind.Unspecified).AddTicks(7311), "Nihil omnis provident ut voluptatem. Molestiae vitae excepturi. Eos quasi est earum cum.", "Madonnachester", 458.24m, "Small Rubber Car" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2015, 10, 12, 13, 52, 24, 989, DateTimeKind.Unspecified).AddTicks(2016), "Ab voluptas molestiae quisquam minima aut. Est vel iure consequatur mollitia. Eum optio exercitationem ratione qui quos sed rerum illum.", "New Litzy", 205.77m, "Licensed Metal Cheese" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2019, 10, 28, 18, 9, 4, 98, DateTimeKind.Unspecified).AddTicks(3861), "Minima aut est. Itaque vero nostrum maiores labore. A dolores sit.", "West Ellis", 1, 67.67m, "Licensed Soft Fish" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2020, 1, 18, 21, 24, 32, 649, DateTimeKind.Unspecified).AddTicks(242), "Velit laborum modi et inventore facilis laboriosam. Est sunt iste et tempora dolores nihil consequuntur dolore. Est officia ut et ad. Consequatur beatae et et at deleniti eaque maiores.", "Wunschton", 641.51m, "Unbranded Soft Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 27,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2017, 9, 18, 7, 12, 29, 528, DateTimeKind.Unspecified).AddTicks(1953), "Iure architecto et est omnis quidem debitis quos quas. Mollitia dolor suscipit ut dolores voluptatibus culpa voluptas. Nostrum illo similique nisi dolore ea et ut iusto tempora. Quidem pariatur impedit qui exercitationem non non blanditiis hic. Animi perspiciatis atque tempora. Ipsam corporis ut ipsam inventore voluptas.", "East Lizethmouth", 817.08m, "Handmade Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 28,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2016, 8, 9, 5, 15, 37, 609, DateTimeKind.Unspecified).AddTicks(6547), "Aperiam maxime quasi rerum dolore error assumenda quia. Porro eligendi molestias dicta fugit eos dicta omnis rerum sed. Sed non libero vitae. Voluptatum velit mollitia magnam praesentium illum sequi minima.", "Dietrichfurt", 1, 244.01m, "Practical Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2016, 1, 10, 15, 19, 29, 454, DateTimeKind.Unspecified).AddTicks(3455), "Voluptatem qui et possimus sed qui sint quia aspernatur aut. Architecto doloribus sed est consequatur quia accusamus. Ut sed tempora et et modi. Laboriosam repellendus consequatur aut voluptas enim quia ratione quam.", "Kristafort", 134.56m, "Handmade Plastic Bacon" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2015, 5, 2, 10, 40, 54, 237, DateTimeKind.Unspecified).AddTicks(415), "Velit iusto corporis animi omnis animi dicta sapiente. Repellat maiores totam debitis soluta ut enim aut. Dolor nam tempora sunt ea voluptas. Doloremque debitis ex accusantium eum architecto sed minus a dolor.", "Carabury", 1, 990.76m, "Fantastic Cotton Chicken" });

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
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2017, 6, 7, 11, 10, 46, 155, DateTimeKind.Unspecified).AddTicks(2794), "Sit iusto sed velit consectetur ab. Quidem similique quo. Non sit enim non delectus enim possimus voluptatibus id maiores. Pariatur officiis reiciendis iusto voluptatum accusantium sit dolores voluptas. Ut inventore ea et.", "Berniermouth", 1, 381.47m, "Small Cotton Chicken" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2019, 7, 18, 14, 33, 51, 844, DateTimeKind.Unspecified).AddTicks(4318), "Et blanditiis dolore pariatur est similique et itaque ipsam. Eaque quibusdam expedita nihil iste aut. Iusto aperiam nesciunt amet asperiores. Nobis ipsam aut mollitia eos nam libero nisi saepe quasi. Eius sequi consectetur doloremque.", "Anselmouth", 92.16m, "Handcrafted Concrete Chair" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2019, 4, 15, 14, 58, 36, 649, DateTimeKind.Unspecified).AddTicks(4541), "Sunt consequuntur assumenda numquam quam qui voluptatem vitae quia non. Id et aperiam perferendis harum. Consequatur tempore est ullam incidunt at necessitatibus porro voluptatem.", "Reichelhaven", 698.41m, "Gorgeous Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 40,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2020, 2, 2, 16, 24, 56, 341, DateTimeKind.Unspecified).AddTicks(2386), "Ipsa in perferendis. Voluptatem inventore veniam rerum est laudantium quasi totam saepe. Autem quam officia. Enim debitis dolores ut officia ut numquam voluptatum magnam. Consectetur dolores dolorum.", "Andreannemouth", 2, 769.52m, "Ergonomic Soft Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 41,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2020, 7, 7, 5, 22, 44, 715, DateTimeKind.Unspecified).AddTicks(6104), "Nisi est in aut enim rerum. Sit iste magni. Ut est maiores rem perspiciatis voluptas aut tempora. Officia nulla praesentium voluptate sed labore minima distinctio ab. Voluptatum ut qui voluptas dolore saepe illum tempore voluptatibus quia. Tenetur et deleniti.", "East Zelma", 109.33m, "Gorgeous Frozen Car" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2016, 1, 2, 3, 3, 36, 805, DateTimeKind.Unspecified).AddTicks(8245), "Porro quia hic et. Iusto dicta quasi maxime ipsum perspiciatis aspernatur non doloribus. Et amet aut atque dicta vel voluptas nesciunt odit laudantium. Et tempore quibusdam delectus.", "South Gianni", 1, 800.55m, "Small Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 44,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2017, 4, 14, 18, 55, 29, 114, DateTimeKind.Unspecified).AddTicks(1197), "Impedit et qui quia dolores autem dolorem ea porro. Pariatur labore reprehenderit reprehenderit quae. Laboriosam et harum velit ad omnis pariatur doloribus impedit. Sapiente vel doloremque consequatur. Ut similique veritatis et molestias impedit eos eaque.", "Lake Ida", 250.28m, "Small Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 45,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2016, 10, 18, 1, 24, 29, 5, DateTimeKind.Unspecified).AddTicks(1103), "Sed quas odit voluptatum non et ea laborum aut. Ducimus voluptas impedit natus et tempore. Omnis sed dolores sed in.", "South Robertamouth", 2, 814.76m, "Gorgeous Rubber Fish" });

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
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2017, 3, 3, 20, 22, 41, 490, DateTimeKind.Unspecified).AddTicks(6420), "Dignissimos et facilis. Quisquam ut repellendus ea omnis. Dolor adipisci possimus perferendis non earum illo necessitatibus. Ipsum animi nihil sequi quam ad id velit fuga.", "Leonoraland", 36.89m, "Incredible Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 51,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2020, 6, 21, 9, 20, 55, 334, DateTimeKind.Unspecified).AddTicks(7616), "Dolores voluptatem ducimus harum corporis libero repellat quisquam. Expedita assumenda nemo. Ut iusto voluptatem et modi aspernatur sed ratione nesciunt. Earum quas placeat et sit sint ut explicabo minus. Dolorem eaque culpa aut cupiditate sed id id voluptatum animi. Voluptas qui incidunt inventore corporis deleniti necessitatibus dolorum tempora debitis.", "Whitneyberg", 508.55m, "Rustic Rubber Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 52,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2017, 1, 9, 9, 2, 7, 409, DateTimeKind.Unspecified).AddTicks(7320), "Esse rerum incidunt. Quae reiciendis odit dolores sint libero iste illum aspernatur. Sint consequatur quo aperiam est voluptatum quas perferendis. Inventore voluptatem laudantium qui natus et dolorum ut. Vel aut ea.", "Rhiannonview", 1, 431.74m, "Unbranded Granite Fish" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2015, 7, 25, 0, 39, 46, 575, DateTimeKind.Unspecified).AddTicks(6098), "Consequatur quo voluptates laborum aspernatur cum porro deleniti accusantium. Nobis distinctio quaerat rem qui rerum. Inventore quisquam ea voluptas rerum.", "Sageside", 1, 499.27m, "Awesome Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 57,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2018, 11, 2, 9, 30, 31, 560, DateTimeKind.Unspecified).AddTicks(986), "Dolor possimus sint. Asperiores non inventore. Hic alias laboriosam non itaque dolorum. Et nihil occaecati sed aut alias sed ut. Nobis animi aut.", "South Thurman", 58.15m, "Fantastic Wooden Bike" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2020, 7, 22, 6, 48, 34, 594, DateTimeKind.Unspecified).AddTicks(5226), "Delectus eaque ratione tempore quaerat non eos. Blanditiis quia doloremque qui aut sit libero. Culpa voluptatem voluptates expedita iste fuga vero accusantium recusandae. Accusantium praesentium odio dicta consequatur voluptatum. Nisi ut ea minima ab assumenda et aut autem quidem.", "Port Edd", 730.63m, "Incredible Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 60,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2020, 7, 17, 23, 56, 57, 918, DateTimeKind.Unspecified).AddTicks(792), "Nisi dolor quia id aut et soluta sequi consequatur voluptas. Natus omnis libero nemo corrupti provident unde. Pariatur sit maiores commodi consequuntur est. Cum libero et dicta doloremque velit repudiandae autem. Dolor nesciunt enim. Repellat consequuntur modi ut expedita ut est ut nobis atque.", "South Pamelahaven", 126.30m, "Licensed Plastic Bacon" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2017, 5, 8, 1, 3, 21, 850, DateTimeKind.Unspecified).AddTicks(4850), "Aut adipisci ipsam. Temporibus voluptates sit qui est sapiente rerum fuga. Iste ut quod aliquid et.", "East Jasmin", 2, 500.12m, "Handmade Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 70,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2015, 1, 15, 18, 51, 20, 497, DateTimeKind.Unspecified).AddTicks(9506), "Sapiente doloribus tempora deserunt. Aliquid repellendus officia. Autem nesciunt eligendi mollitia quod dolor. Neque totam est ut.", "Monaport", 856.19m, "Generic Granite Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 71,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2020, 4, 11, 23, 31, 53, 650, DateTimeKind.Unspecified).AddTicks(7796), "Consequatur molestias repellat est in. Unde unde tenetur omnis dolore harum ipsa repellendus et. Non quam quaerat.", "East Cory", 2, 402.99m, "Gorgeous Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 72,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2017, 10, 23, 21, 47, 46, 286, DateTimeKind.Unspecified).AddTicks(5128), "Eaque eligendi et est dicta quod dolores. Voluptate sint inventore minima reiciendis deleniti vero vel eos. Velit deleniti culpa odit omnis eos autem. Omnis ratione doloremque. Illo et quia quia quia itaque labore aspernatur illum. Qui est at quam nesciunt.", "Kassulkemouth", 646.86m, "Awesome Steel Salad" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2020, 6, 18, 9, 49, 51, 992, DateTimeKind.Unspecified).AddTicks(3074), "Nobis doloremque corporis ut corrupti nemo debitis. Corporis incidunt harum repellat voluptates repellat natus a. Soluta ratione repellat repellendus dolore eaque inventore cupiditate assumenda. In veritatis facere distinctio eos animi. Necessitatibus quia provident sit sint occaecati.", "Lake Herta", 595.41m, "Tasty Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2015, 2, 27, 1, 14, 18, 213, DateTimeKind.Unspecified).AddTicks(4118), "Rerum cum aut odio doloribus et ducimus. Vel voluptatum quidem omnis similique quos qui corrupti. Iure molestiae dolores. Et dolorum molestiae qui dignissimos et eaque hic excepturi. Et quia magni aliquam et et ducimus sit.", "Port Clinton", 708.75m, "Unbranded Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 76,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2020, 7, 22, 20, 38, 53, 922, DateTimeKind.Unspecified).AddTicks(2922), "Quis porro quae assumenda aliquam inventore debitis dolorum unde. Voluptate assumenda ullam voluptas. Ut odio labore voluptatum officiis distinctio quia qui. Error sint quisquam impedit rerum esse similique.", "Morissettefurt", 2, 266.92m, "Intelligent Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 77,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2017, 5, 25, 20, 52, 18, 55, DateTimeKind.Unspecified).AddTicks(7963), "Odit voluptatum molestiae velit veritatis et non officia. Et praesentium non dolorem in. Quia suscipit laboriosam dolorem cum magni. Praesentium sequi expedita sunt sint amet beatae. Est dolores fugiat sunt. Dolores eos molestias.", "Corneliusbury", 826.08m, "Incredible Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 78,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2018, 10, 16, 12, 44, 36, 255, DateTimeKind.Unspecified).AddTicks(2968), "Distinctio non similique voluptatem. Et perferendis ad facere corrupti maiores nisi. Voluptatem consequatur quia vel deserunt perspiciatis ullam. Eum soluta a. Corporis ullam consequuntur asperiores tempora.", "Port Jailyn", 925.37m, "Awesome Steel Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 79,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2017, 12, 9, 4, 16, 19, 729, DateTimeKind.Unspecified).AddTicks(9142), "Facere dolorem modi architecto ipsam quis voluptas fugiat illo. Dicta nihil dicta fugiat nulla laborum saepe. Velit necessitatibus minima non.", "North Shannastad", 442.45m, "Unbranded Soft Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 80,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2019, 11, 29, 11, 14, 2, 446, DateTimeKind.Unspecified).AddTicks(3672), "Excepturi minus sit. Aut et neque ipsum delectus et aperiam quo maxime ut. Temporibus et suscipit incidunt qui tempora voluptatem consequuntur adipisci qui.", "Jacobston", 357.24m, "Tasty Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 81,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2019, 1, 4, 20, 34, 58, 459, DateTimeKind.Unspecified).AddTicks(1180), "Non amet sunt fugit ex illo exercitationem nulla. Optio eligendi aut voluptates nam tempore hic dolorum. Commodi est doloribus quaerat dolorem in sunt illum maiores. Temporibus a maiores ut architecto beatae et ratione. Totam accusamus aspernatur eum. Voluptatibus voluptatem impedit ut ducimus.", "West Eli", 262.68m, "Unbranded Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 82,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2017, 12, 23, 9, 18, 47, 275, DateTimeKind.Unspecified).AddTicks(1266), "Ut quasi similique. Temporibus impedit autem. Fugiat aut non aut voluptatem aut voluptatem omnis. Minima perferendis est dolorem consequatur libero quia quos. Architecto non et ex cumque consequuntur qui dignissimos.", "North Devonte", 1, 291.00m, "Intelligent Cotton Sausages" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2020, 5, 23, 1, 46, 58, 468, DateTimeKind.Unspecified).AddTicks(3378), "Facilis eum animi cum eos. Sit enim laudantium voluptate laudantium exercitationem optio cum. Autem fuga magnam eaque necessitatibus voluptas blanditiis vero. Nihil aut earum. Velit praesentium aliquam et provident est exercitationem saepe officia natus. Et nulla non harum sit velit eius provident quia.", "North Arleneton", 615.70m, "Tasty Granite Mouse" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2015, 9, 8, 8, 44, 13, 928, DateTimeKind.Unspecified).AddTicks(4158), "Quam eum expedita autem ut. Rerum consequatur in nihil. Reprehenderit velit deserunt eum consequatur ullam est fugit delectus. Dolorum praesentium sint nulla similique asperiores itaque et accusamus. Accusamus asperiores minus quidem tempora error. Molestiae quis libero dolor sed.", "Santinaville", 2, 973.67m, "Small Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2015, 7, 3, 22, 27, 49, 211, DateTimeKind.Unspecified).AddTicks(5411), "Et et quod non ut consectetur. Porro non quae. In laudantium a id dolore non nobis eum exercitationem harum. Tenetur ab nobis. Rerum qui aut placeat vitae nisi et. Fugiat corporis qui voluptas a.", "New Jamartown", 460.18m, "Tasty Soft Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 92,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2020, 2, 15, 13, 20, 4, 693, DateTimeKind.Unspecified).AddTicks(4674), "Optio et illum porro delectus eligendi nulla. Et iste impedit dolor delectus sunt. Sit quia ullam nihil dicta.", "Mosefurt", 2, 169.96m, "Ergonomic Granite Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 93,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2019, 11, 20, 18, 7, 48, 742, DateTimeKind.Unspecified).AddTicks(781), "Omnis rem est odio laudantium sed laboriosam. Repellat culpa at aut. Tempora dolores vel et voluptas delectus culpa aut aut. Delectus doloribus est rerum rem deserunt molestiae nostrum iure maiores. Tempora dolores molestiae.", "Reicheltown", 962.78m, "Gorgeous Steel Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 94,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2017, 6, 21, 19, 0, 4, 303, DateTimeKind.Unspecified).AddTicks(7117), "Porro corrupti possimus. Doloribus rerum dignissimos qui soluta ducimus vel deleniti et ut. Quis totam sed. Repellat repellat blanditiis ut est sapiente et soluta. Quod dicta blanditiis. Temporibus rem debitis iusto.", "Jessycashire", 2, 455.02m, "Licensed Frozen Bike" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2016, 2, 19, 8, 21, 47, 84, DateTimeKind.Unspecified).AddTicks(9004), "Hic exercitationem natus error et recusandae dicta voluptas. Recusandae aut minus quas et beatae. Quae ut id illo autem dolorem repellendus necessitatibus corrupti.", "North Shauntown", 1, 198.22m, "Licensed Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2019, 3, 7, 19, 22, 38, 763, DateTimeKind.Unspecified).AddTicks(7584), "Occaecati iusto corporis quod magnam molestiae. Eum eos magni non aperiam temporibus vel ipsa quia tenetur. Excepturi tempore beatae. At sed est voluptatem sed sint.", "West Beaulahstad", 422.25m, "Awesome Metal Gloves" });

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
        }
    }
}
