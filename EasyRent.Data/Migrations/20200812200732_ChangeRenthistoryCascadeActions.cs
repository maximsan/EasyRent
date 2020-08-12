using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyRent.Data.Migrations
{
    public partial class ChangeRenthistoryCascadeActions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentHistory_Ads_AdId",
                table: "RentHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_RentHistory_AspNetUsers_AdOwnerId",
                table: "RentHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_RentHistory_AspNetUsers_RentingUserId",
                table: "RentHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RentHistory",
                table: "RentHistory");

            migrationBuilder.RenameTable(
                name: "RentHistory",
                newName: "RentHistories");

            migrationBuilder.RenameIndex(
                name: "IX_RentHistory_RentingUserId",
                table: "RentHistories",
                newName: "IX_RentHistories_RentingUserId");

            migrationBuilder.RenameIndex(
                name: "IX_RentHistory_AdOwnerId",
                table: "RentHistories",
                newName: "IX_RentHistories_AdOwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_RentHistory_AdId",
                table: "RentHistories",
                newName: "IX_RentHistories_AdId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RentHistories",
                table: "RentHistories",
                column: "RentHistoryId");

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 1,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2018, 4, 1, 14, 11, 14, 521, DateTimeKind.Unspecified).AddTicks(1939), "Soluta fugit est aut occaecati consequatur omnis. Est modi sapiente corrupti id perspiciatis beatae nobis quas aut. Provident tenetur iure. Voluptate dicta porro optio.", "Reinholdfort", 860.89m, "Rustic Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 2,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2017, 8, 5, 13, 1, 16, 415, DateTimeKind.Unspecified).AddTicks(3893), "Ut aut nobis molestiae itaque harum consequatur voluptas eligendi quia. Accusantium ratione unde est iste nostrum earum ipsam necessitatibus et. Adipisci quia delectus ea consequatur autem sed delectus.", "Delphiaview", 103.94m, "Refined Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 3,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2016, 2, 24, 22, 4, 2, 768, DateTimeKind.Unspecified).AddTicks(8774), "Consequatur quaerat rerum omnis quo id laboriosam veritatis quis perspiciatis. Amet adipisci error. Excepturi a in qui iusto facilis qui qui fuga. Ipsa quo numquam nostrum eum nihil sed.", "Rowenafurt", 1, 936.43m, "Intelligent Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 4,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2016, 10, 30, 16, 36, 4, 545, DateTimeKind.Unspecified).AddTicks(9539), "Consequuntur et voluptates. Dolor possimus quas distinctio a. Nemo minima non quia dolor libero saepe quia assumenda. Voluptas qui sunt nisi ut voluptas. Assumenda non et ea officia.", "New Jessicaborough", 2, 136.79m, "Practical Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 5,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2018, 4, 25, 8, 21, 2, 190, DateTimeKind.Unspecified).AddTicks(1502), "Eum voluptate et perferendis reiciendis enim repudiandae. Eius non perspiciatis tempore error. Itaque voluptatum id minus nisi. Quisquam tempora pariatur qui dolorem provident. Nobis ut magni quibusdam consequatur autem. Occaecati iusto autem facere hic corporis corrupti ullam fugiat.", "Port Marielle", 572.73m, "Ergonomic Granite Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 6,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2017, 6, 23, 1, 52, 14, 894, DateTimeKind.Unspecified).AddTicks(7762), "Sequi natus vitae consectetur dignissimos eos tempora illo dicta. Sed aut voluptas nulla quas aspernatur. Dolor eaque rerum nihil qui vel et ratione sapiente consequatur. Quia perspiciatis corrupti assumenda.", "Port Frederique", 1, 876.22m, "Gorgeous Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 7,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2015, 11, 11, 1, 55, 29, 99, DateTimeKind.Unspecified).AddTicks(3107), "Quam quibusdam consequatur. Repellat sapiente est non. In ea possimus dolor. Ipsa deleniti dolores ipsa. Perspiciatis molestiae voluptas et temporibus voluptatum et consequatur quam enim.", "Maritzaville", 650.97m, "Incredible Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 8,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2018, 11, 29, 10, 50, 34, 947, DateTimeKind.Unspecified).AddTicks(7285), "A sunt ab sunt est cumque architecto occaecati accusantium rerum. Consequatur sed consequuntur et. Voluptatem possimus consequatur sequi consectetur.", "New Michele", 225.97m, "Ergonomic Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 9,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2015, 7, 21, 1, 38, 5, 350, DateTimeKind.Unspecified).AddTicks(616), "Est ut adipisci vel numquam et non minus. Dolore et laudantium vel ducimus velit autem voluptatibus dolores autem. Inventore maxime cumque ut suscipit ut quas pariatur nemo. Optio qui commodi cumque deserunt nesciunt praesentium maiores aut. Odio quam nostrum aut hic magnam esse expedita est aut. Adipisci maiores aperiam id eos enim modi quae.", "Hickleton", 427.12m, "Ergonomic Rubber Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 10,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2020, 7, 31, 22, 56, 14, 178, DateTimeKind.Unspecified).AddTicks(5764), "Asperiores voluptas atque vel rerum. Eligendi voluptatem vitae recusandae nulla velit. Odit et mollitia sit aspernatur.", "Shermanberg", 1, 940.68m, "Unbranded Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 11,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2016, 9, 25, 10, 6, 14, 425, DateTimeKind.Unspecified).AddTicks(8518), "Corporis aut id quidem. Accusamus quas expedita delectus voluptate culpa sed sapiente. Occaecati debitis explicabo delectus quae totam assumenda perferendis quia sequi. Illo reprehenderit tenetur. Facilis ut incidunt. Molestiae harum ipsa deserunt.", "Germainefurt", 93.82m, "Handcrafted Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2015, 7, 14, 5, 17, 43, 344, DateTimeKind.Unspecified).AddTicks(5443), "Atque ut magnam. Esse iure nostrum soluta qui sed. Deleniti omnis facilis voluptatem ipsum ut veritatis eaque.", "South Eddie", 400.07m, "Awesome Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 13,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2019, 9, 5, 18, 25, 29, 324, DateTimeKind.Unspecified).AddTicks(1617), "Beatae eum rerum. Maxime maiores illum quisquam ut nisi ea. Nesciunt porro sequi ut. Consequatur voluptatem sapiente. Earum cumque provident velit et tempore alias ipsa nostrum voluptate. Id totam deserunt explicabo est fugit in amet provident laboriosam.", "Port Bill", 142.10m, "Gorgeous Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 14,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2016, 2, 11, 7, 13, 58, 133, DateTimeKind.Unspecified).AddTicks(6319), "Explicabo dolores nobis velit sit et enim illum soluta dolore. Deleniti ut est quia veritatis recusandae sint ut sapiente et. Dignissimos quod esse inventore quaerat consequatur quod quia. Suscipit tempora porro autem. Voluptate adipisci dolor sit debitis quo.", "Delmertown", 1, 637.04m, "Generic Rubber Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 15,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2017, 11, 11, 12, 54, 43, 446, DateTimeKind.Unspecified).AddTicks(877), "Blanditiis totam eligendi rerum repellat enim maiores quas. Rem sit animi. Dolorem ipsam libero et id. Et dicta porro ut. Quo omnis praesentium nihil. Perspiciatis enim vitae.", "South Destiny", 907.88m, "Licensed Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2020, 8, 5, 21, 5, 49, 882, DateTimeKind.Unspecified).AddTicks(9240), "Tempora molestiae eum omnis. Quasi unde neque aut. Id quod dolores dolores incidunt eius vel minima et provident. Itaque aspernatur porro error. Ut amet ut fuga natus quo.", "Lake Vivianburgh", 1, 395.07m, "Handcrafted Granite Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 17,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2018, 7, 23, 21, 35, 23, 201, DateTimeKind.Unspecified).AddTicks(4831), "Sint velit enim ut reiciendis optio veritatis earum odit doloremque. Voluptas nam non fugiat dolorem. Dolorum eum consequatur saepe nam. Non rerum dolorem magni vel et sed perferendis. Non repellendus quae repellat harum tenetur error non dolores.", "Wisozkmouth", 677.79m, "Tasty Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 18,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2016, 8, 27, 23, 28, 23, 744, DateTimeKind.Unspecified).AddTicks(3108), "Sed ipsa at eligendi quod quis voluptatem error. Excepturi sunt perferendis nihil quibusdam. Neque quo sed voluptate illo blanditiis accusamus quia optio ut. Maiores aspernatur expedita dolor animi eveniet atque sit voluptas. Adipisci corporis necessitatibus nam esse consequatur dolore quaerat.", "Lake Derick", 164.38m, "Refined Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 19,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2019, 8, 12, 13, 43, 49, 443, DateTimeKind.Unspecified).AddTicks(2792), "Sint sequi quisquam saepe corporis. Et quasi voluptates. Provident labore rem eos delectus provident est quod.", "Ashtynstad", 863.50m, "Incredible Concrete Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 20,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2019, 10, 26, 12, 32, 3, 660, DateTimeKind.Unspecified).AddTicks(1278), "Libero aut hic doloribus dolorem. Culpa repellat ea. Praesentium dolor ut est sed. Eligendi impedit nisi.", "New Jeff", 1, 834.88m, "Rustic Metal Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 21,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2015, 8, 7, 22, 58, 12, 842, DateTimeKind.Unspecified).AddTicks(1079), "Natus est id alias occaecati quis deleniti enim non. Est vel ad et dignissimos sint sunt doloremque culpa consequuntur. Alias sed expedita sit quia consequatur minima. Sit explicabo cumque debitis error eveniet corrupti maxime est.", "Mollyberg", 2, 395.68m, "Practical Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 22,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2016, 5, 23, 16, 31, 6, 908, DateTimeKind.Unspecified).AddTicks(7750), "Quis praesentium porro ex aliquam iste similique. Qui nisi deleniti velit ut placeat vero hic quas quo. Tenetur assumenda pariatur ut at repudiandae voluptatem officia. Expedita architecto et ullam aut incidunt saepe quidem voluptatibus.", "Eltaborough", 919.68m, "Licensed Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 23,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2016, 2, 27, 0, 26, 2, 889, DateTimeKind.Unspecified).AddTicks(9740), "Ab id pariatur dolor ipsam assumenda. Aut et odio aut ut assumenda. Placeat qui sit consectetur nemo. Modi delectus reiciendis in reprehenderit aperiam reiciendis hic consequatur. Ut exercitationem sint nisi est rem assumenda.", "Maudeview", 1, 459.41m, "Sleek Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 24,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2016, 10, 21, 16, 3, 48, 593, DateTimeKind.Unspecified).AddTicks(1152), "Laborum et qui unde. Ut dicta et ducimus iure minima autem corrupti odit. Ut consequatur illo nihil nobis. A nam dolores nulla reprehenderit. Nulla saepe adipisci voluptatem aut rem autem reprehenderit.", "Ariellemouth", 1, 103.54m, "Ergonomic Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 25,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2019, 2, 25, 2, 55, 40, 299, DateTimeKind.Unspecified).AddTicks(4981), "Quam vero perspiciatis qui ipsam qui qui debitis et ea. Nihil nihil ut labore minus. Consequatur qui voluptatem eligendi quo. Praesentium veritatis hic ipsam neque et quidem sed. Quia nihil minima.", "Heidenreichfort", 2, 704.62m, "Rustic Metal Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 26,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2019, 3, 12, 22, 43, 42, 448, DateTimeKind.Unspecified).AddTicks(9354), "Similique veniam aut quasi omnis sit aliquid ad. Dolores dicta suscipit consequatur esse expedita dignissimos sit. Et provident repellat quaerat magnam iure qui nam et.", "Orionshire", 588.76m, "Handmade Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2016, 9, 16, 0, 44, 32, 846, DateTimeKind.Unspecified).AddTicks(3490), "Veritatis qui ratione sunt at voluptatem laudantium suscipit quod. Rem quisquam voluptatem molestias sint soluta nemo doloremque est et. Omnis soluta dolores. Unde vel voluptatem aspernatur libero est sed qui. Sit impedit at.", "Grahamland", 989.21m, "Incredible Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 28,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2018, 5, 11, 21, 1, 44, 104, DateTimeKind.Unspecified).AddTicks(9548), "Officia odio pariatur animi hic cum quis. Est quo corporis aut. Labore architecto modi ex.", "East Erika", 2, 805.94m, "Refined Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 29,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2016, 3, 17, 8, 52, 57, 45, DateTimeKind.Unspecified).AddTicks(7753), "Adipisci atque modi. Illum molestias tempora molestiae. Et quam saepe similique sed pariatur explicabo. Voluptas dicta et ducimus.", "Wuckertland", 1, 870.01m, "Handcrafted Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2015, 8, 26, 21, 59, 5, 767, DateTimeKind.Unspecified).AddTicks(946), "Magni blanditiis ex. Cumque sit minus. Ullam fugiat est facere et labore fuga est ut. Repellendus nobis voluptas natus et. Quasi enim sed placeat velit impedit sint. Excepturi aut odio maxime.", "North Kari", 1, 513.05m, "Fantastic Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 31,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2016, 8, 30, 1, 57, 49, 950, DateTimeKind.Unspecified).AddTicks(6323), "Dolores quae tempore est ut modi. Similique numquam at aut. Non maiores iusto officia ipsam mollitia. Omnis quibusdam aut minima.", "Randiburgh", 2, 330.34m, "Gorgeous Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 32,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2018, 11, 2, 21, 7, 17, 822, DateTimeKind.Unspecified).AddTicks(7718), "Commodi aperiam accusamus quidem nostrum impedit officiis. Rerum alias sequi ullam quis voluptatem error. Laborum neque rerum nam aliquam assumenda ratione fugiat ut. Repudiandae sequi dicta iste nisi excepturi omnis quis quasi omnis. A hic voluptas et ut quidem.", "Madonnashire", 959.56m, "Ergonomic Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 33,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2015, 3, 1, 7, 26, 35, 716, DateTimeKind.Unspecified).AddTicks(1274), "Deserunt necessitatibus aperiam quis in. Porro ducimus dicta distinctio rerum maxime repellat beatae aut. Et numquam quae quod voluptates. Dolorum dolor exercitationem recusandae. Nemo possimus officiis quo non natus perferendis deleniti nam. Officia unde quae quia eveniet unde.", "Armstrongberg", 2, 961.51m, "Small Fresh Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 34,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2018, 2, 7, 15, 44, 59, 854, DateTimeKind.Unspecified).AddTicks(5581), "Praesentium ut vero architecto totam maiores. Est numquam dolorem fugit amet voluptatibus. Ut earum et nam repellat provident aut. Possimus neque quasi ut dolor totam dolor.", "Lockmanstad", 1, 303.00m, "Awesome Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 35,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2015, 3, 10, 5, 59, 10, 736, DateTimeKind.Unspecified).AddTicks(3550), "Non suscipit eaque ut eaque reiciendis molestiae quos aperiam. Fuga earum quisquam odio debitis excepturi optio alias dolores quia. Et quis ad provident rerum esse qui tenetur iure omnis.", "Tristianmouth", 1, 801.56m, "Gorgeous Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 36,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2020, 5, 10, 18, 16, 6, 741, DateTimeKind.Unspecified).AddTicks(8011), "Aut et rerum culpa magni qui aut vero. Officia pariatur at corporis delectus omnis quis. Natus nulla ut facilis. Quae alias voluptatibus quidem et autem. Ut quas vero sapiente nesciunt corrupti. Necessitatibus nemo quis odio quasi.", "Aliyahshire", 2, 90.16m, "Unbranded Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 37,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2017, 12, 7, 19, 20, 58, 86, DateTimeKind.Unspecified).AddTicks(6048), "Odio odit rem debitis quidem mollitia quos. Dicta quam perspiciatis dicta asperiores necessitatibus qui. Voluptate deleniti nulla ad ea totam. Quis illo repudiandae.", "North Evelinefort", 544.85m, "Ergonomic Steel Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 38,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2017, 9, 6, 10, 48, 6, 472, DateTimeKind.Unspecified).AddTicks(8038), "Impedit autem molestiae voluptatibus aut. Et explicabo asperiores ex consequatur unde. Aperiam sequi aut ut asperiores aspernatur. Est et ex ipsum dolore debitis blanditiis perferendis facilis.", "North Jack", 929.17m, "Intelligent Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2018, 3, 26, 0, 13, 39, 718, DateTimeKind.Unspecified).AddTicks(3553), "Illum aut dolor provident. Dolores illo sint dolore omnis. Et et non. Odio facere id ut. Necessitatibus ducimus et. Ex et sit saepe cum.", "Jazmyneshire", 2, 227.35m, "Handcrafted Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 40,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2020, 6, 3, 19, 40, 44, 951, DateTimeKind.Unspecified).AddTicks(2337), "Aspernatur in illum doloremque sed ad. Non ipsa est placeat voluptas eum aliquam quis. Excepturi dolor cum hic nesciunt labore. Et et eligendi aut fuga consequatur et. Dolor quos facilis.", "Bechtelarfort", 2, 237.91m, "Licensed Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 41,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2019, 12, 24, 23, 18, 9, 0, DateTimeKind.Unspecified).AddTicks(8302), "Qui nihil sed molestiae. Laudantium ad quibusdam. Vero omnis facere sapiente. Ullam beatae sed dolor est ut ad amet laudantium. Nam ad ex suscipit laudantium.", "New Miltonborough", 838.17m, "Incredible Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 42,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2019, 12, 15, 11, 20, 42, 405, DateTimeKind.Unspecified).AddTicks(5991), "Ea recusandae ad inventore ad reiciendis ipsa voluptate. Blanditiis exercitationem voluptas tenetur non sapiente eius quaerat repellendus. Earum sit quae. Illo quam quia perspiciatis maxime. Incidunt autem a praesentium in repellendus non ipsa id alias.", "West Amira", 346.92m, "Rustic Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 43,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2018, 7, 25, 19, 0, 14, 683, DateTimeKind.Unspecified).AddTicks(4065), "Sit unde error commodi ex soluta eius quidem. Et exercitationem quam et. Suscipit nemo vel. Et quia expedita dolor est est. Cumque odit et vero et. Sequi quia id ea voluptate saepe.", "West Rosellafort", 1, 965.83m, "Refined Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 44,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2018, 11, 16, 22, 47, 3, 592, DateTimeKind.Unspecified).AddTicks(2264), "Quas distinctio nesciunt eligendi ut. Qui sint vitae et. Officia dolor voluptates aut qui ullam aut.", "Titobury", 2, 164.00m, "Tasty Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 45,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2017, 11, 6, 1, 38, 42, 56, DateTimeKind.Unspecified).AddTicks(192), "Ut eaque ut mollitia id quibusdam asperiores molestiae. Quia officia reiciendis magni est enim ut sit. Ut at suscipit quisquam laboriosam neque pariatur laboriosam nam in. Minima corporis ipsa voluptatem odio. Sed ab amet ipsum dolor ratione officiis autem.", "Evansview", 32.44m, "Intelligent Plastic Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 46,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2019, 1, 11, 17, 32, 16, 379, DateTimeKind.Unspecified).AddTicks(179), "Dolore cumque vel placeat qui. Quam dicta ex illum. Quo eligendi sunt id sit repellat est. Impedit laudantium ut id illum esse enim odio quaerat. Est voluptatem ut totam. Iusto quo tempore iusto.", "Bayerchester", 786.99m, "Small Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 47,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2017, 9, 11, 4, 32, 41, 45, DateTimeKind.Unspecified).AddTicks(1135), "Molestias numquam sit sunt voluptas ut sapiente natus sit dicta. Nesciunt eos qui et enim dolore natus et. Excepturi natus alias maxime reiciendis cum voluptas tenetur voluptatem cumque. Nemo soluta quis voluptatem aut eius autem quis sed debitis. Odit nobis ex.", "Tianaview", 1, 283.42m, "Sleek Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 48,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2017, 8, 29, 5, 56, 34, 567, DateTimeKind.Unspecified).AddTicks(6256), "Enim aut dolorem sunt. Sed harum sed. Voluptatum in voluptatem qui explicabo accusamus. Sed voluptatem in blanditiis ipsam. Voluptate facere saepe tempore sed incidunt. Eum alias eos ipsam.", "Westburgh", 122.99m, "Tasty Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 49,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2015, 11, 8, 8, 35, 55, 365, DateTimeKind.Unspecified).AddTicks(7008), "Fugit rerum reprehenderit animi et. Expedita accusantium quos eveniet debitis. Velit soluta sit alias ea et iste rem.", "Abigayleport", 2, 148.64m, "Generic Wooden Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 50,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2019, 12, 6, 19, 4, 22, 55, DateTimeKind.Unspecified).AddTicks(2576), "Enim ea omnis repellendus ratione et. Totam ut fugiat qui repellat et natus impedit. Ut in quasi facilis esse. Quidem aut eum et asperiores ut sed quas. Excepturi ratione praesentium qui.", "Port Karliehaven", 774.20m, "Intelligent Steel Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2016, 8, 30, 23, 17, 2, 688, DateTimeKind.Unspecified).AddTicks(9009), "Dignissimos officiis laborum. Voluptates aut alias nobis. Nam ea et quidem nisi voluptatem voluptas harum nemo.", "Mohrville", 1, 699.68m, "Fantastic Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 52,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2019, 7, 6, 3, 47, 54, 254, DateTimeKind.Unspecified).AddTicks(9476), "Molestiae officiis neque hic et sit necessitatibus tenetur animi. Praesentium quo dolore. Qui hic eos rerum. Veniam dolore debitis distinctio rem aut maxime dolores dolorum. Laborum nobis tempore sit consequatur id provident.", "Marlonview", 933.16m, "Tasty Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 53,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2019, 4, 24, 9, 50, 32, 13, DateTimeKind.Unspecified).AddTicks(6149), "At est nesciunt provident. Eius sint ab numquam est et neque. Enim nihil maiores ea repellendus non et et est. Qui ducimus saepe sit.", "Cecilehaven", 1, 324.25m, "Practical Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 54,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2017, 1, 3, 13, 46, 41, 26, DateTimeKind.Unspecified).AddTicks(9335), "Delectus quos est ipsam. Dolorum ad aut. Aliquam porro dignissimos commodi molestiae non rerum et.", "Mckennaton", 610.08m, "Unbranded Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 55,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2017, 9, 20, 1, 58, 34, 995, DateTimeKind.Unspecified).AddTicks(9668), "Quas libero non sed laborum natus. Vel nostrum sequi fugiat ipsum autem et enim qui. A molestias beatae quisquam cupiditate consectetur. Quasi natus beatae ut consequatur a nobis maiores ea. Quia qui amet labore placeat commodi laudantium dolorem. Velit officiis repudiandae illum ut rerum molestiae rerum voluptate consequuntur.", "Roobshire", 1, 480.15m, "Licensed Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 56,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2016, 6, 3, 14, 6, 39, 821, DateTimeKind.Unspecified).AddTicks(6367), "Nulla voluptas dolorem voluptatum est voluptatem. Quia ratione et saepe. Omnis aut sequi maxime voluptas ut vel. Minima eos laborum.", "Donnellyland", 2, 412.11m, "Ergonomic Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 57,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2017, 9, 16, 16, 51, 23, 876, DateTimeKind.Unspecified).AddTicks(7008), "Voluptatem et omnis. Neque est velit voluptatibus dolor eos ea cumque eveniet reiciendis. Facilis nemo fuga voluptatem consectetur. Sequi exercitationem minima et at et molestias ut commodi quasi. Quo at consequatur explicabo beatae doloribus numquam et beatae aut. Consequatur autem voluptate sint consequuntur reprehenderit.", "Port Clintonburgh", 750.46m, "Small Frozen Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 58,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2016, 7, 18, 4, 46, 0, 715, DateTimeKind.Unspecified).AddTicks(3046), "Quo illum autem ducimus eos ipsa aut numquam. Ipsam voluptate beatae aut odit quisquam nostrum. Non suscipit itaque sed aperiam esse. Distinctio dicta vel aut quod mollitia eligendi ut sed. Dolorem et numquam ut perspiciatis rem.", "East Marcusstad", 2, 789.55m, "Intelligent Metal Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 59,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2016, 8, 27, 18, 15, 22, 284, DateTimeKind.Unspecified).AddTicks(8917), "Assumenda similique soluta ea sint repellendus omnis incidunt delectus voluptatum. Fuga quas ut quisquam itaque odit beatae eos libero eos. Earum commodi repellendus vitae iusto ducimus officiis minus cum.", "Lennieside", 2, 768.14m, "Licensed Granite Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 60,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2019, 5, 23, 20, 22, 54, 538, DateTimeKind.Unspecified).AddTicks(8602), "Cumque nihil consequatur veniam. Sint alias ipsum maiores vero esse fugit voluptatibus. Ipsam et fugiat aliquid voluptas ex incidunt quibusdam.", "North Korbin", 2, 773.63m, "Unbranded Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 61,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2016, 7, 21, 5, 34, 26, 742, DateTimeKind.Unspecified).AddTicks(8727), "Et expedita dolor et possimus non officiis. Eligendi maxime consectetur vel repellendus adipisci ipsum. Praesentium non odio rerum a ut laboriosam. Nihil et voluptatem omnis minima sed minima excepturi dolores iure. Distinctio quo aperiam deserunt quibusdam deleniti.", "Berenicestad", 1, 826.49m, "Licensed Frozen Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 62,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2016, 8, 13, 8, 35, 35, 631, DateTimeKind.Unspecified).AddTicks(3850), "Minus quidem nisi voluptatem autem explicabo. Molestias quia quis corrupti laudantium cum voluptatem qui vel. Possimus nihil et facilis voluptate nostrum autem. Nesciunt itaque sint voluptatem ad voluptatibus aut voluptates.", "Lake Nicholetown", 342.04m, "Small Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 63,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2016, 4, 27, 21, 54, 57, 865, DateTimeKind.Unspecified).AddTicks(9851), "Ratione ducimus mollitia necessitatibus. Sed eveniet facere illum voluptas ut unde animi harum. Recusandae consectetur quae corporis. Iste fuga iste rerum est ipsum quo. Officiis ex dolore voluptates quia natus.", "South Enosview", 511.85m, "Practical Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 64,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2019, 8, 26, 0, 6, 13, 690, DateTimeKind.Unspecified).AddTicks(3570), "Velit dolor consequatur explicabo aut beatae perferendis animi. Necessitatibus tenetur sed deserunt dolorem velit debitis. Beatae iusto autem eaque dolorum libero. Voluptas sed at dolorum in reprehenderit quia.", "East Hiltonburgh", 2, 704.71m, "Ergonomic Concrete Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2015, 6, 10, 3, 52, 9, 807, DateTimeKind.Unspecified).AddTicks(9056), "Quis enim sint fuga sunt minima est. Ut sed cumque autem aut. Sit in tempora qui. Magni assumenda quisquam quo.", "South Melisafort", 1, 202.30m, "Tasty Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 66,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2018, 9, 23, 17, 10, 1, 383, DateTimeKind.Unspecified).AddTicks(2489), "Et incidunt ab quia et voluptas. Neque qui quas deserunt eos. Natus animi omnis omnis ea eum et rem possimus aspernatur.", "Kossmouth", 411.65m, "Fantastic Fresh Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 67,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2018, 2, 7, 1, 47, 37, 172, DateTimeKind.Unspecified).AddTicks(7917), "Asperiores nisi beatae sint alias blanditiis cum et sit fugit. Ad eum consequatur blanditiis ipsam est et officia voluptatibus vero. Amet et ipsa ex. Quaerat odit voluptas omnis ut ab id est quam nobis. Dolorem adipisci quibusdam voluptas vitae placeat occaecati ullam accusantium. Ducimus nemo saepe quibusdam autem.", "Boylehaven", 1, 159.64m, "Practical Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 68,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2017, 2, 16, 16, 3, 56, 490, DateTimeKind.Unspecified).AddTicks(1367), "Ab modi dolor in eaque et non. Reprehenderit sit provident ab odio dolores. Voluptas unde vel quibusdam hic facere cupiditate sequi.", "Napoleonberg", 261.38m, "Fantastic Wooden Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 69,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2019, 7, 9, 21, 50, 35, 724, DateTimeKind.Unspecified).AddTicks(9952), "Beatae dolore tenetur velit cum sapiente. Maiores quo error illum quisquam nostrum. Voluptatem alias id non tempora consequatur cupiditate quasi.", "New Orie", 369.85m, "Awesome Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 70,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2017, 6, 16, 8, 19, 53, 789, DateTimeKind.Unspecified).AddTicks(5012), "Libero beatae mollitia in sed doloribus quis ut. Itaque molestiae ut ut rerum vero. Est rem cum autem rerum consequatur aut exercitationem. Nemo in qui labore voluptates aperiam libero totam.", "Angelicaberg", 2, 405.79m, "Intelligent Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 71,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2018, 8, 24, 0, 6, 23, 754, DateTimeKind.Unspecified).AddTicks(295), "Labore in et eum odit doloremque veritatis totam. Quo distinctio odit corporis assumenda consequatur officia incidunt ullam provident. Aliquam quasi laboriosam culpa et ut sunt inventore odio itaque. Autem quidem error qui voluptates voluptatum possimus magni debitis ut.", "New Teaganbury", 137.31m, "Ergonomic Cotton Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 72,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2019, 6, 8, 1, 49, 16, 18, DateTimeKind.Unspecified).AddTicks(7941), "Voluptatum dolorem veritatis nisi voluptas accusamus. Alias doloremque earum facere veniam totam. Quis ut aut voluptatum ipsum et itaque illo.", "West Chaya", 480.42m, "Rustic Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 73,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2020, 6, 23, 17, 48, 12, 610, DateTimeKind.Unspecified).AddTicks(9776), "Dicta tempora pariatur dolores. Quaerat esse delectus ipsum facilis neque sed libero ea veritatis. Sed minus sint dignissimos dolores quam nobis quidem. Quis id voluptas perspiciatis.", "East Javontetown", 2, 260.13m, "Handcrafted Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 74,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2018, 1, 5, 19, 24, 24, 737, DateTimeKind.Unspecified).AddTicks(7596), "Aut voluptas voluptatem veritatis consequatur est quasi possimus magnam repellat. Fugiat quo libero perspiciatis non aut nihil cupiditate sunt. Non et soluta fugit velit impedit.", "O'Connellmouth", 1, 250.53m, "Generic Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 75,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2015, 11, 5, 21, 34, 8, 307, DateTimeKind.Unspecified).AddTicks(7849), "Delectus aliquam repellendus doloribus numquam quisquam. Unde maiores animi voluptas. Est eum ratione.", "Vanbury", 2, 579.94m, "Tasty Cotton Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 76,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2015, 1, 18, 21, 42, 25, 252, DateTimeKind.Unspecified).AddTicks(6752), "Et amet magni cumque. Accusamus incidunt natus quo harum earum eius a rerum. Quisquam voluptatem aut natus voluptatum modi veritatis aut qui. Quibusdam sequi architecto ut odit cum. Laudantium in ut ea at.", "Altenwerthland", 544.71m, "Refined Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 77,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2017, 5, 29, 7, 21, 56, 230, DateTimeKind.Unspecified).AddTicks(7933), "Nisi fugiat nemo magni ad molestiae error. Perspiciatis voluptatem eaque porro. Distinctio minus a facilis.", "Howebury", 506.69m, "Refined Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 78,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2018, 4, 21, 6, 37, 17, 907, DateTimeKind.Unspecified).AddTicks(5447), "In et dolor. Ut iste enim consequatur. Amet est reiciendis qui. Quidem aut esse iure dolorem. A commodi iusto ut mollitia doloremque rem. Excepturi cumque nisi non consequatur sequi.", "Aufderharhaven", 561.66m, "Generic Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2019, 7, 6, 9, 25, 55, 291, DateTimeKind.Unspecified).AddTicks(1144), "Commodi natus dolor qui perferendis ut. Dolor aspernatur non consequatur. Iste molestias vitae vero vero laudantium voluptas quia ipsum maiores. Dolorum fugit at est et. Quis rerum accusamus.", "East Marc", 913.35m, "Generic Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 80,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2015, 3, 23, 15, 52, 36, 190, DateTimeKind.Unspecified).AddTicks(7074), "Non sint alias odit sit animi minus perferendis est. Aliquam autem modi neque impedit nesciunt assumenda. Veritatis qui voluptas earum.", "West Ron", 2, 171.62m, "Intelligent Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 81,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2016, 5, 25, 11, 54, 43, 58, DateTimeKind.Unspecified).AddTicks(7662), "Voluptate adipisci pariatur nam ab sint rerum. Qui rerum sint nostrum eligendi voluptatum voluptatibus non aperiam. Similique voluptas et enim. Et ut nulla autem error ut. Temporibus quo dignissimos rerum facere excepturi enim aut. Perspiciatis sunt qui.", "Lynchview", 2, 549.33m, "Sleek Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 82,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2019, 1, 1, 14, 36, 37, 223, DateTimeKind.Unspecified).AddTicks(7511), "Voluptatem eos quisquam ut in sed qui. Quidem praesentium aspernatur. Pariatur ab quisquam rem. Recusandae sit accusantium labore. Rem sint ratione porro consequatur et eum maiores soluta aspernatur. Quo quos laborum autem architecto cumque repudiandae ea.", "Lake Eudoraview", 269.85m, "Handcrafted Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 83,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2016, 10, 22, 13, 35, 38, 504, DateTimeKind.Unspecified).AddTicks(9144), "Consequatur ipsum libero et dicta nobis quo excepturi eligendi et. Alias praesentium aut natus aut soluta qui incidunt odit. Modi neque dolores praesentium debitis sit itaque. Libero a id molestiae quibusdam rem voluptatem. Doloribus doloribus sit architecto necessitatibus quia neque iste blanditiis consequatur.", "Sashaside", 1, 34.57m, "Unbranded Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2018, 7, 20, 14, 8, 23, 424, DateTimeKind.Unspecified).AddTicks(4979), "Non nam eveniet repudiandae voluptatem. Quia in distinctio ut labore neque eligendi sequi. Aperiam minus eveniet alias. Consequatur et voluptas et soluta quidem et. Et voluptatum voluptas enim esse facilis dolor aliquid dolor.", "Gutmannview", 1, 383.83m, "Refined Wooden Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 85,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2019, 9, 16, 4, 27, 46, 645, DateTimeKind.Unspecified).AddTicks(5647), "Non officia dolore consequatur tenetur laboriosam qui suscipit. Incidunt eum et velit impedit amet numquam molestiae placeat. Quis vero at. Mollitia sed adipisci quia sint dolor et molestiae exercitationem. Magni suscipit necessitatibus beatae nemo.", "West Lou", 16.28m, "Incredible Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2018, 9, 28, 18, 42, 2, 720, DateTimeKind.Unspecified).AddTicks(224), "Nihil consequatur ullam commodi est cum eum et rem omnis. Tempora sequi in corporis. Exercitationem veniam autem. Dolores dolorum nostrum id id. Excepturi perferendis cum optio modi tenetur tenetur dolore qui. Asperiores ut ex distinctio inventore molestiae fugiat cumque explicabo voluptate.", "Welchview", 1, 825.96m, "Awesome Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 87,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2015, 10, 4, 13, 31, 15, 805, DateTimeKind.Unspecified).AddTicks(3620), "Fuga non neque illum aut omnis sed. Ad voluptates libero iure explicabo. Molestiae porro labore impedit temporibus. Facilis voluptas maiores error sunt pariatur sequi. Nesciunt quis dignissimos facilis sed iusto nisi.", "South Dayne", 1, 450.59m, "Small Wooden Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 88,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2019, 2, 6, 23, 35, 37, 282, DateTimeKind.Unspecified).AddTicks(1493), "Numquam voluptas beatae molestiae sunt exercitationem consequuntur repudiandae. Rerum mollitia dolore consequuntur dolorum. Aut doloribus totam.", "East Magnoliashire", 2, 502.45m, "Intelligent Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 89,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2015, 8, 7, 4, 18, 11, 164, DateTimeKind.Unspecified).AddTicks(61), "Nostrum sint quia. Assumenda vitae vero aliquid aliquid architecto occaecati quae voluptatum eveniet. Voluptas iusto nesciunt qui ratione deleniti magnam accusamus quasi incidunt.", "Lake Hester", 833.39m, "Awesome Metal Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 90,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2016, 8, 20, 21, 54, 36, 184, DateTimeKind.Unspecified).AddTicks(7307), "Soluta ut voluptatem. Fugit tempore aut eos. Accusantium quia alias recusandae nostrum ut dicta quae iste ipsa. Illo impedit molestias modi et occaecati repellendus quis. Itaque similique deserunt ut quia possimus.", "Quigleytown", 2, 369.37m, "Awesome Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 91,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2016, 1, 5, 8, 50, 8, 398, DateTimeKind.Unspecified).AddTicks(6182), "Enim et sit inventore ex voluptatem dicta hic ut qui. Optio deserunt necessitatibus id quisquam alias blanditiis qui id. Sed nisi autem doloremque amet totam rerum. Quam enim est.", "New Jordonside", 401.49m, "Refined Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 92,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2019, 1, 3, 18, 9, 40, 982, DateTimeKind.Unspecified).AddTicks(5235), "Ipsam omnis est voluptatem quia nostrum dolor aut nobis nostrum. Sunt rerum doloremque ipsum quibusdam sed dolorem omnis. Odit est aut quis et quia.", "East Gudrunmouth", 239.14m, "Handmade Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2018, 8, 5, 23, 56, 10, 680, DateTimeKind.Unspecified).AddTicks(1618), "Consequuntur quos rerum quia sit dolor pariatur omnis pariatur ipsa. Reiciendis perspiciatis ut id aut fuga et. Modi rerum ipsum provident in. Ab maiores itaque quia. Omnis sit laboriosam voluptates nihil. Eius consequatur facilis deserunt hic natus enim quia officiis culpa.", "Jonatanbury", 2, 660.65m, "Ergonomic Rubber Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2020, 5, 24, 20, 28, 38, 307, DateTimeKind.Unspecified).AddTicks(7504), "Adipisci minima autem voluptates officia sed. Excepturi rerum quidem consequatur assumenda. Quaerat nesciunt quisquam enim quia eveniet voluptas. Unde ea voluptatum non excepturi tempora voluptatem. Cumque debitis totam aut minus ipsum commodi. Eaque aut id molestiae commodi earum inventore cumque facilis.", "Lake Issacmouth", 2, 369.56m, "Handmade Steel Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 95,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2017, 9, 16, 11, 0, 34, 528, DateTimeKind.Unspecified).AddTicks(6242), "Architecto nemo magni a earum possimus. Possimus vero dicta autem et. Aliquid nesciunt ea neque. Ullam est aut odio in cumque vel.", "East Guillermo", 381.38m, "Licensed Granite Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 96,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2019, 4, 5, 1, 40, 29, 430, DateTimeKind.Unspecified).AddTicks(8629), "Voluptate repellat ullam ex rerum eius quod expedita qui. Ea ut tempora quibusdam. Dolorum unde et. Et molestiae qui laborum officia earum autem dicta.", "Federicoview", 576.88m, "Practical Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 97,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2015, 7, 4, 8, 21, 56, 332, DateTimeKind.Unspecified).AddTicks(1907), "Modi expedita ipsa asperiores adipisci vel et sequi aut voluptatum. Itaque sequi ut cupiditate consequatur voluptatem iure impedit esse. Dolores quia nemo vel natus voluptates quia. Eaque iusto et magni quas voluptate dolore.", "East Hayley", 2, 778.00m, "Practical Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 98,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2018, 1, 19, 20, 14, 39, 823, DateTimeKind.Unspecified).AddTicks(8394), "Sed et dolores eius. Repellat corrupti sunt atque id. Harum ut voluptas provident recusandae ipsa quia. Est vero ad voluptatibus fugit ut non reiciendis veniam.", "North Oscarhaven", 138.43m, "Handmade Frozen Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 99,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2015, 11, 6, 21, 17, 59, 821, DateTimeKind.Unspecified).AddTicks(8219), "Voluptatem voluptas est. Repellendus officiis fugit eligendi dolor ab voluptatem. Omnis voluptatem molestiae quaerat vel dolore commodi voluptatem.", "North Gregoriashire", 737.79m, "Sleek Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 100,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2017, 1, 20, 15, 39, 1, 613, DateTimeKind.Unspecified).AddTicks(9388), "Harum ut excepturi sit culpa amet inventore et. Nulla aperiam laudantium dolor commodi voluptate quae. Neque aut a. Vel magnam commodi. Quibusdam nostrum optio omnis ut repellendus tempora iusto. Ratione dolor velit.", "Schmidtton", 2, 307.13m, "Rustic Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "PhoneNumber", "UserName" },
                values: new object[] { "9f9db8d1-ed79-4ba6-bc2c-18a4d48ecaf1", "Drew.Schmidt84@hotmail.com", "Schmidt", "1-415-837-9187", "Drew4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "PhoneNumber", "UserName" },
                values: new object[] { "751a13af-f494-463e-83b8-5079cb8ffdd8", "Patrick.Stroman72@gmail.com", "Stroman", "279.488.6856", "Patrick58" });

            migrationBuilder.AddForeignKey(
                name: "FK_RentHistories_Ads_AdId",
                table: "RentHistories",
                column: "AdId",
                principalTable: "Ads",
                principalColumn: "AdId");

            migrationBuilder.AddForeignKey(
                name: "FK_RentHistories_AspNetUsers_AdOwnerId",
                table: "RentHistories",
                column: "AdOwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RentHistories_AspNetUsers_RentingUserId",
                table: "RentHistories",
                column: "RentingUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentHistories_Ads_AdId",
                table: "RentHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_RentHistories_AspNetUsers_AdOwnerId",
                table: "RentHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_RentHistories_AspNetUsers_RentingUserId",
                table: "RentHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RentHistories",
                table: "RentHistories");

            migrationBuilder.RenameTable(
                name: "RentHistories",
                newName: "RentHistory");

            migrationBuilder.RenameIndex(
                name: "IX_RentHistories_RentingUserId",
                table: "RentHistory",
                newName: "IX_RentHistory_RentingUserId");

            migrationBuilder.RenameIndex(
                name: "IX_RentHistories_AdOwnerId",
                table: "RentHistory",
                newName: "IX_RentHistory_AdOwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_RentHistories_AdId",
                table: "RentHistory",
                newName: "IX_RentHistory_AdId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RentHistory",
                table: "RentHistory",
                column: "RentHistoryId");

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 1,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2020, 3, 1, 22, 43, 53, 173, DateTimeKind.Unspecified).AddTicks(4532), "Quia voluptatem numquam incidunt aspernatur laborum illum in. Dolor ex consectetur cumque qui neque sapiente sit cum aspernatur. Officiis neque tempora est veniam. Sed cumque officia provident autem quasi aut. Ratione perspiciatis illo est quod cum.", "Maximeborough", 540.25m, "Handmade Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 2,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2017, 7, 29, 11, 16, 51, 894, DateTimeKind.Unspecified).AddTicks(8394), "Natus tempora possimus ipsa aperiam. Hic natus velit fugit maiores aliquid eum. Dolor sed nemo et et. Itaque nihil cumque quia fugiat nobis accusamus. Expedita veniam in dolorem dolorum. Excepturi dolor quod aut molestias qui.", "Deckowburgh", 469.26m, "Handmade Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 3,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2016, 7, 25, 22, 1, 49, 673, DateTimeKind.Unspecified).AddTicks(6264), "Sint aliquid esse dolores cupiditate qui quia aliquid. Id ut magni porro illum qui earum est. Praesentium sed odit qui minus facere. Ut laudantium at non. Qui aut libero porro et enim.", "West Destineyville", 2, 895.75m, "Rustic Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 4,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2017, 3, 11, 8, 21, 38, 706, DateTimeKind.Unspecified).AddTicks(2882), "Numquam est ea modi voluptate. Veritatis et nam aut nostrum sed aliquid. Voluptas voluptatem non praesentium alias dolorem blanditiis sint qui. Ullam nemo hic id. Voluptatum accusantium deleniti sunt id enim quisquam. Placeat quaerat eos officia.", "Fosterbury", 1, 969.07m, "Small Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 5,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2016, 6, 26, 16, 25, 40, 10, DateTimeKind.Unspecified).AddTicks(4303), "Est autem ullam nostrum eius molestiae aut et voluptas. Amet hic consequatur. Placeat excepturi id quibusdam sit sed eos. Aut iste asperiores ipsum quaerat voluptas laborum. Ipsam consequuntur ex qui nulla.", "Ankundingview", 4.93m, "Refined Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 6,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2020, 6, 14, 20, 43, 49, 665, DateTimeKind.Unspecified).AddTicks(5164), "Corrupti autem dolorem repellendus. Dolorem totam saepe voluptatem doloribus quod. Ab nam suscipit perferendis reiciendis. Veritatis deserunt vitae nihil itaque dolores ipsum autem ea.", "West Elveraberg", 2, 384.38m, "Awesome Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 7,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2015, 6, 29, 5, 35, 44, 595, DateTimeKind.Unspecified).AddTicks(805), "Rerum quo eligendi qui enim dolores tenetur nesciunt dolorem dolores. Possimus aut vero beatae repellendus. Voluptas et laborum consequatur molestiae ut voluptas minus ea. Ipsa saepe commodi tempora quam aut aspernatur impedit dolore. Sed tempora eaque. Velit eius at accusantium dolores enim nobis recusandae maiores.", "South Tyrellburgh", 154.59m, "Practical Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 8,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2019, 10, 12, 16, 41, 37, 501, DateTimeKind.Unspecified).AddTicks(5572), "Praesentium enim et debitis aut. Fugiat est id aut. Est est non est vel ut dicta. Odit et dolore. Rem qui rerum magnam tenetur nesciunt doloremque enim distinctio. Non possimus culpa nesciunt dolorum quaerat provident aspernatur numquam vel.", "West Judd", 544.32m, "Gorgeous Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 9,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2018, 3, 22, 0, 31, 35, 535, DateTimeKind.Unspecified).AddTicks(422), "Non molestias qui exercitationem et. Aut laborum impedit temporibus sint pariatur cum qui odit expedita. Dolorem ut aut eligendi accusamus ea odit. Ea alias ut. Dolor corrupti aliquid. Sunt unde architecto.", "Haneville", 628.39m, "Intelligent Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 10,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2020, 4, 26, 4, 54, 43, 905, DateTimeKind.Unspecified).AddTicks(4421), "Et eum ut alias voluptas quibusdam nam nisi odit. Ut nam ut provident dolores. Corporis error qui odit et aperiam saepe. Harum repudiandae temporibus sunt velit. Expedita eum sed sed pariatur minus rerum atque officia. Et sed delectus voluptatum sunt.", "Mohammadchester", 2, 105.72m, "Rustic Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 11,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2015, 1, 3, 21, 41, 48, 500, DateTimeKind.Unspecified).AddTicks(2847), "Earum quis at consequatur in qui. Harum pariatur consequuntur cumque nobis. Qui illum reiciendis ea velit cumque quasi esse sed. Amet aut maiores.", "South Ofeliaview", 776.71m, "Incredible Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2015, 7, 3, 18, 33, 10, 482, DateTimeKind.Unspecified).AddTicks(3874), "Veritatis est voluptas labore ea. Repellat nisi natus. Et ut natus consectetur qui architecto. Ut nam ut officia dicta quisquam eos esse.", "West Elisabeth", 519.74m, "Awesome Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 13,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2016, 7, 9, 2, 1, 11, 164, DateTimeKind.Unspecified).AddTicks(1343), "Sapiente optio neque odit facilis dolores aut. Saepe numquam sed doloribus dolorem quaerat nulla quasi velit. Aut delectus reiciendis dolorem ab quidem cumque dolorem. Possimus distinctio qui eligendi omnis perferendis quas dolor similique quas.", "Welchstad", 621.46m, "Small Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 14,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2018, 5, 9, 6, 23, 16, 893, DateTimeKind.Unspecified).AddTicks(6619), "Quia cum consequuntur nam esse deserunt eos facilis cupiditate. Qui sint ut sed dignissimos cupiditate. Reiciendis nam deleniti minima similique laborum quibusdam. Nisi reiciendis nemo sint consequatur iure.", "New Stephon", 2, 487.65m, "Licensed Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 15,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2016, 9, 2, 9, 41, 11, 436, DateTimeKind.Unspecified).AddTicks(2614), "Reprehenderit quia architecto ad quibusdam architecto laborum nihil sit est. In est veritatis voluptas veniam quasi laborum fugiat qui. Sit ut eos dignissimos. Libero a tempore vel facere quo aliquid officia. Cum nemo quasi sit. Nemo distinctio illo dolor.", "Hansenhaven", 711.11m, "Gorgeous Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 26, 29, 13, DateTimeKind.Unspecified).AddTicks(2980), "Omnis numquam fugiat dicta voluptate et. Tenetur itaque consequatur. Sit voluptas et aut. Et animi nihil. Sapiente similique quae sed fugiat a. Et at blanditiis accusantium nesciunt est nulla eveniet.", "East Autumnfort", 2, 653.70m, "Generic Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 17,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2015, 1, 14, 6, 21, 40, 48, DateTimeKind.Unspecified).AddTicks(999), "Harum cupiditate et quia est voluptatem esse. Dolorem quo magnam qui. Delectus aspernatur atque reiciendis veritatis dolore repellat facere rerum voluptas. Dolor assumenda accusamus vero est. Perferendis aut sunt consequuntur. Sit officia illum iure blanditiis et.", "Theresaport", 846.63m, "Fantastic Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 18,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2020, 6, 21, 0, 2, 16, 47, DateTimeKind.Unspecified).AddTicks(332), "Accusamus quo placeat possimus non molestiae alias. Iste deleniti non cumque ad ea. Provident voluptas saepe nesciunt cum autem error inventore sapiente.", "South Haileetown", 208.72m, "Refined Cotton Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 19,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2017, 5, 17, 1, 43, 2, 147, DateTimeKind.Unspecified).AddTicks(2590), "In inventore reprehenderit iure consequatur debitis non asperiores. Sunt aut voluptates dolores et laudantium tempore commodi qui. Omnis repellendus excepturi ipsa voluptatem. Labore nihil fugit occaecati est repudiandae qui sint nulla amet.", "Runteburgh", 784.68m, "Handcrafted Fresh Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 20,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2015, 3, 19, 19, 53, 56, 331, DateTimeKind.Unspecified).AddTicks(2823), "Est ut id. Sed sint excepturi ut et sit quis. Assumenda ipsum explicabo rem explicabo expedita.", "Hudsonburgh", 2, 56.66m, "Generic Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 21,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2015, 7, 11, 18, 5, 4, 837, DateTimeKind.Unspecified).AddTicks(3545), "Quia fuga aut. Explicabo numquam repellendus fugit. Tempora consequatur rerum quia illum in. Perferendis occaecati facere et voluptas voluptatem non facere temporibus. Enim fugiat sed et corporis qui dicta. Eveniet maxime harum id architecto aut nobis reiciendis minima facilis.", "West Tracey", 1, 813.80m, "Sleek Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 22,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2017, 11, 1, 0, 25, 6, 454, DateTimeKind.Unspecified).AddTicks(3478), "Aspernatur illo autem perspiciatis earum hic culpa debitis et. Vero ratione sint et eius velit. Officiis vel aliquid maiores aut consequatur. Dolorum blanditiis sit enim voluptatum non. Voluptas numquam eaque est culpa incidunt. Itaque id qui in est delectus atque.", "Tremblayhaven", 3.45m, "Generic Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 23,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2015, 8, 18, 17, 18, 40, 241, DateTimeKind.Unspecified).AddTicks(6525), "Recusandae et atque dolorum ut in quo aut. Non aut consequatur. Dolor voluptates itaque beatae tenetur officia nesciunt ea.", "Simonismouth", 2, 481.30m, "Incredible Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 24,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2015, 9, 18, 20, 7, 43, 826, DateTimeKind.Unspecified).AddTicks(8341), "Saepe exercitationem est qui sed magni. Aut tenetur reprehenderit vero perferendis nulla ea et id ea. Praesentium quis inventore veniam aut explicabo.", "Connshire", 2, 537.08m, "Rustic Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 25,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2017, 10, 30, 7, 19, 22, 140, DateTimeKind.Unspecified).AddTicks(5668), "Ullam corrupti sapiente qui officia ratione ducimus error aut unde. Hic et qui facere fugiat nisi debitis quis. Quia sint non reiciendis ipsum praesentium vero. Error minus exercitationem. Laborum unde iusto officiis totam.", "Maxside", 1, 835.72m, "Fantastic Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 26,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2017, 7, 28, 0, 50, 29, 697, DateTimeKind.Unspecified).AddTicks(1712), "Asperiores repellendus quo velit. Error repellendus sapiente voluptatibus. Magni nostrum reprehenderit alias labore magnam ea suscipit. Eum aut consequatur nihil dolor praesentium est repudiandae qui sequi.", "East Florence", 525.76m, "Unbranded Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2016, 11, 16, 5, 1, 20, 998, DateTimeKind.Unspecified).AddTicks(3831), "Repudiandae corrupti maiores similique fuga dignissimos voluptate aut. Qui tempore eius. Ut et beatae distinctio quod consequatur et iure aut molestias. Est voluptas atque iusto exercitationem autem. Eos ut qui ut aut. Laborum quo sit molestias sint aperiam sit quos.", "New Lueside", 869.95m, "Licensed Plastic Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 28,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2019, 7, 10, 5, 43, 32, 464, DateTimeKind.Unspecified).AddTicks(3378), "Quibusdam vero sapiente ut officia voluptas. Consequatur ipsam eius ullam maxime ea ab et aperiam. Officiis assumenda quia repellat. Amet quo dolores nihil repellat tenetur possimus similique. Eos ut modi vel reiciendis quis. Non impedit rem soluta qui ea ut.", "South Nelsview", 1, 73.14m, "Intelligent Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 29,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2017, 10, 22, 17, 45, 7, 700, DateTimeKind.Unspecified).AddTicks(3139), "Rem neque sit. Illo placeat facere iusto nulla dolores ut molestiae nam est. Veritatis cumque ipsam consequatur dolorem quos corporis voluptates dolore non. Autem quasi cupiditate explicabo quisquam est nemo dolore. Voluptas vel similique.", "Antoniastad", 2, 909.68m, "Incredible Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2018, 6, 25, 20, 35, 42, 903, DateTimeKind.Unspecified).AddTicks(113), "Aut amet ex nulla et. Magnam vitae autem quis. Soluta voluptates placeat velit officia. Esse perspiciatis dolor nobis magni nobis id.", "New Verniemouth", 2, 732.21m, "Small Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 31,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2017, 5, 25, 3, 36, 33, 468, DateTimeKind.Unspecified).AddTicks(3660), "Laudantium dolorum eveniet excepturi exercitationem. Quaerat optio molestiae repellat. Sapiente molestiae aut doloribus eaque ad deserunt. Et et fuga ipsa non porro aliquid aliquid explicabo in. Distinctio possimus debitis.", "East Percy", 1, 647.23m, "Handcrafted Cotton Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 32,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2019, 1, 5, 21, 57, 34, 798, DateTimeKind.Unspecified).AddTicks(9008), "Sunt aut ratione quis possimus. Expedita sit eaque cum quo. Est quibusdam rerum voluptas dolorem quia et. Voluptas dicta harum quisquam adipisci. Est sed aperiam quasi in suscipit.", "Lake Caesar", 546.76m, "Intelligent Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 33,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2015, 9, 7, 11, 27, 24, 388, DateTimeKind.Unspecified).AddTicks(3779), "Voluptatem eius a accusamus dignissimos explicabo quaerat. Nihil magnam occaecati atque quia nihil sunt consequatur id qui. Delectus aspernatur et sed quo est qui rerum ea corporis. Sit odit dolore aut. Reiciendis et quod omnis itaque vel. Voluptates quia sit distinctio quis dolor porro qui.", "Lubowitzmouth", 1, 873.45m, "Sleek Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 34,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2017, 11, 22, 19, 47, 58, 320, DateTimeKind.Unspecified).AddTicks(3932), "Et ad sint velit labore neque voluptatem fugit itaque asperiores. Quae sequi odio deserunt repudiandae quas maiores accusantium. Facilis pariatur ipsum dolor aliquid autem corrupti qui aut. Cupiditate quo atque repudiandae ipsa.", "Efrainside", 2, 425.38m, "Intelligent Soft Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 35,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2016, 10, 17, 15, 52, 14, 626, DateTimeKind.Unspecified).AddTicks(2267), "Vitae tempora amet et incidunt voluptatem mollitia aliquam. Aut eos veritatis eos tempore odio incidunt et totam. Error et qui a dolorum officia error vel aut ipsa. Amet et est et ea. Optio eligendi exercitationem eligendi rerum.", "Doviemouth", 2, 153.80m, "Refined Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 36,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2016, 12, 23, 15, 25, 49, 80, DateTimeKind.Unspecified).AddTicks(2856), "Qui deleniti est enim error accusantium libero quia dolores numquam. Repudiandae numquam velit non enim vitae. Recusandae quia veniam cum qui sed nihil. Qui alias minima dolor tempore ducimus. Ipsa quas quia porro dicta magni nam fuga.", "West Irma", 1, 845.70m, "Generic Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 37,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2018, 12, 31, 3, 59, 10, 104, DateTimeKind.Unspecified).AddTicks(8497), "Laboriosam mollitia laudantium saepe similique nulla explicabo ullam libero molestiae. Ut maiores et quia et aperiam omnis repellat. Ut omnis quibusdam quis eos ad. Provident veniam est perferendis perspiciatis quo quos sit dignissimos. Minima ratione labore. Consequatur a natus.", "Sterlinghaven", 374.45m, "Licensed Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 38,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2017, 7, 29, 20, 8, 54, 372, DateTimeKind.Unspecified).AddTicks(6996), "Quibusdam quia possimus exercitationem eaque error perferendis sit repudiandae. Nihil dolores repudiandae qui. Facere voluptate possimus consequatur eveniet mollitia ut et ut. Et voluptas maxime sit ullam corporis. Et ut facilis et cupiditate at.", "South Ferneside", 646.74m, "Sleek Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2018, 5, 2, 22, 23, 26, 492, DateTimeKind.Unspecified).AddTicks(8110), "Atque et temporibus adipisci natus. Occaecati aut est quibusdam ut est laborum. Ullam eligendi autem vitae alias tempora iste iste necessitatibus. Distinctio deserunt fugit ipsa quae aut qui. Voluptas repellat qui.", "North Ezequiel", 1, 85.23m, "Incredible Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 40,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2020, 8, 6, 8, 41, 47, 878, DateTimeKind.Unspecified).AddTicks(1372), "Harum eveniet tempore. A libero suscipit. Non quia et sed ut ducimus deleniti quo harum.", "East Tiarastad", 1, 49.70m, "Tasty Metal Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 41,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2015, 7, 9, 21, 57, 53, 551, DateTimeKind.Unspecified).AddTicks(2418), "Numquam praesentium velit iste atque qui quis necessitatibus est velit. Dolore necessitatibus dolorem voluptas consequatur fugit. Cupiditate dolores a est eveniet voluptatem esse qui itaque. Illo a delectus fugit dolorem ut sapiente repellendus quia esse. Suscipit laudantium maxime ullam dolor et quis nesciunt temporibus sint.", "Port Rosachester", 451.04m, "Small Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 42,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2015, 9, 10, 16, 54, 51, 967, DateTimeKind.Unspecified).AddTicks(1431), "Quo vel dignissimos ipsam beatae sint. Reiciendis est optio saepe. Libero numquam enim fugit.", "Beahanview", 150.56m, "Ergonomic Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 43,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2019, 4, 1, 14, 7, 47, 355, DateTimeKind.Unspecified).AddTicks(8740), "Modi doloremque ad et dolores. Voluptates atque laboriosam. Nostrum labore qui itaque. Amet hic molestias dolor repellendus exercitationem ducimus. Explicabo rem illo nemo alias. Voluptatem eveniet commodi hic pariatur possimus distinctio nihil.", "Bednarstad", 2, 307.71m, "Refined Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 44,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2016, 2, 3, 13, 14, 53, 478, DateTimeKind.Unspecified).AddTicks(890), "Necessitatibus ipsum et recusandae sit. Est possimus sit. Beatae omnis et placeat sit quis molestiae.", "Lake Chelsey", 1, 872.35m, "Handmade Wooden Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 45,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2020, 6, 16, 19, 12, 49, 141, DateTimeKind.Unspecified).AddTicks(62), "Suscipit quis corrupti ipsum optio nulla ratione doloribus. Assumenda temporibus voluptatibus ut labore ut. Consequatur in architecto omnis aliquid fugiat saepe fugiat a et. Ab blanditiis quod nihil. Aut consequuntur nulla corporis deserunt est quia.", "Strosinburgh", 495.20m, "Sleek Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 46,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2020, 2, 11, 3, 4, 8, 915, DateTimeKind.Unspecified).AddTicks(5362), "Beatae qui voluptates veniam quas qui. Non ut quisquam aspernatur sed est veritatis velit. Omnis qui non eum sed consectetur ipsum necessitatibus inventore suscipit. Saepe omnis praesentium animi nesciunt.", "Hermistonstad", 196.54m, "Intelligent Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 47,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2020, 1, 1, 1, 15, 4, 779, DateTimeKind.Unspecified).AddTicks(1394), "Est omnis aut praesentium. Ipsam adipisci magni sapiente sunt sit rerum modi. Tempora dolorem sit. Qui consequatur quia earum omnis suscipit iusto alias est. Illo sit dignissimos consequatur magnam doloribus sed ullam provident repudiandae. Dignissimos voluptatem rem velit.", "D'Amoremouth", 2, 973.19m, "Rustic Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 48,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2015, 1, 18, 16, 50, 5, 443, DateTimeKind.Unspecified).AddTicks(5017), "Fugiat quia totam. Id et voluptatem. Earum est autem.", "Darianside", 927.46m, "Generic Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 49,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2018, 3, 22, 3, 22, 31, 999, DateTimeKind.Unspecified).AddTicks(8693), "Neque optio doloremque sint ipsam debitis magni quaerat. Fugit recusandae quis sunt veritatis saepe esse vel repellat. Aliquam et quibusdam aut quod voluptatem. Sed repellendus in recusandae officia velit sunt perspiciatis. Voluptas impedit aut rerum velit.", "Hudsonport", 1, 521.64m, "Incredible Rubber Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 50,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2015, 4, 2, 12, 58, 2, 534, DateTimeKind.Unspecified).AddTicks(4340), "Aliquam corrupti quam commodi deserunt quis aliquam. Nisi nisi soluta non cupiditate occaecati velit unde. Similique nihil cumque illo adipisci dignissimos at nostrum qui.", "New Ruben", 963.47m, "Awesome Cotton Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2017, 9, 12, 20, 13, 12, 76, DateTimeKind.Unspecified).AddTicks(7912), "Minus quam vero voluptatem vero totam impedit in asperiores omnis. Quis illum facilis atque quos quos. Ipsa similique quasi.", "Lake Lenoramouth", 2, 379.64m, "Licensed Plastic Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 52,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2015, 12, 31, 23, 40, 3, 717, DateTimeKind.Unspecified).AddTicks(8319), "Fugiat quis nulla minus laboriosam aut qui quo officia. Modi error ratione non ut dolore omnis sunt. Natus officiis quisquam in magnam perspiciatis voluptatum. Esse eum sint velit eum accusamus aut consequatur.", "New Noechester", 68.44m, "Practical Plastic Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 53,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2016, 11, 22, 20, 7, 21, 183, DateTimeKind.Unspecified).AddTicks(6412), "Qui rerum non ad aperiam eos itaque fugit quo. Amet eos minima est voluptas quasi aliquam. Optio dolores sed cumque animi autem.", "South Brennon", 2, 514.75m, "Incredible Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 54,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2019, 7, 29, 18, 53, 45, 921, DateTimeKind.Unspecified).AddTicks(8388), "Officia dolores autem consequatur architecto optio. Illo sunt et temporibus cumque doloremque. Et doloribus excepturi aspernatur est.", "Ezekielland", 909.92m, "Awesome Soft Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 55,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2020, 2, 24, 7, 56, 46, 354, DateTimeKind.Unspecified).AddTicks(153), "Nihil nihil necessitatibus atque quia id eligendi. Quam numquam perspiciatis. Quas cumque et atque. Voluptatum debitis dolorem qui magni sit explicabo qui modi dolore. Et aut quia voluptas est. Consequatur repellat qui et.", "Hoppefort", 2, 39.50m, "Incredible Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 56,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2018, 12, 5, 3, 13, 59, 24, DateTimeKind.Unspecified).AddTicks(3983), "Accusamus quo pariatur voluptatem voluptatum exercitationem quis autem aperiam ut. Quam voluptate sed ipsa eius. Quaerat suscipit iusto nisi beatae cum. Consequatur odit dolorem pariatur exercitationem provident.", "Jaskolskishire", 1, 714.86m, "Small Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 57,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2016, 4, 3, 1, 16, 37, 43, DateTimeKind.Unspecified).AddTicks(210), "Fugiat eveniet doloremque in et. Odio culpa quam voluptatem molestias eos mollitia temporibus nesciunt. Sit quis totam cupiditate et. Vitae hic odio eligendi cupiditate nihil quod. Corrupti quaerat vel repellat dolore dolor laudantium id voluptatum.", "West Micaelaland", 667.02m, "Unbranded Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 58,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2015, 1, 7, 10, 4, 37, 366, DateTimeKind.Unspecified).AddTicks(67), "Id aut nulla sit vel vitae. Recusandae et minus quo fuga nam dolore ab mollitia perspiciatis. Saepe velit saepe velit aut repellendus. Esse quae quia sunt ullam provident. Fugit dicta expedita impedit voluptatem repudiandae delectus.", "New Kameron", 1, 815.79m, "Handcrafted Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 59,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2018, 9, 9, 10, 39, 6, 370, DateTimeKind.Unspecified).AddTicks(720), "Autem tempora ut quas adipisci doloribus inventore earum. Aperiam quidem ea earum sed eius. In deserunt laboriosam ducimus et esse excepturi. Ex mollitia et voluptates eveniet velit qui quaerat ab. Id qui nulla culpa praesentium porro sunt.", "Mannborough", 1, 7.06m, "Intelligent Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 60,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2019, 1, 18, 0, 26, 29, 21, DateTimeKind.Unspecified).AddTicks(4150), "Architecto ab vel porro et voluptatem animi natus. Ipsa maiores rerum vel. Voluptatem totam dolorem distinctio repellat.", "New Filibertofurt", 1, 849.63m, "Rustic Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 61,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2019, 8, 31, 18, 59, 7, 409, DateTimeKind.Unspecified).AddTicks(8007), "Sit non aut sunt ea cum ut et vero nesciunt. Non culpa impedit fuga accusamus omnis aut fugiat voluptatem molestiae. Odit quisquam reprehenderit non omnis id aut aut id saepe. Repellat enim pariatur suscipit. Odit ratione enim similique ad laudantium velit qui. Blanditiis eos nemo dolorem rerum.", "New Kelley", 2, 400.45m, "Practical Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 62,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2020, 3, 7, 4, 21, 36, 987, DateTimeKind.Unspecified).AddTicks(6169), "Omnis ab aut qui in omnis sed aut ut nobis. Eos expedita facilis. Nam quaerat aspernatur mollitia nam. Distinctio rem non iusto voluptates molestiae beatae error.", "North Maximilian", 110.97m, "Incredible Frozen Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 63,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2015, 12, 7, 4, 35, 47, 556, DateTimeKind.Unspecified).AddTicks(5211), "Ea ipsa id officia cumque maxime dolor earum sint. Accusantium sit autem voluptatem saepe culpa ad. Corrupti aliquid blanditiis et. Nam enim placeat ea minus tenetur quod culpa.", "East Simoneborough", 616.07m, "Handmade Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 64,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2018, 12, 16, 18, 45, 57, 533, DateTimeKind.Unspecified).AddTicks(2335), "Repellat soluta voluptatem aperiam sit dolor facilis provident. Aut ipsam sed esse architecto minima hic. Ab doloribus est doloribus reiciendis dolor.", "Uptonburgh", 1, 843.86m, "Incredible Cotton Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2015, 8, 11, 15, 49, 15, 681, DateTimeKind.Unspecified).AddTicks(7886), "Et et quia porro quia explicabo quae deleniti. In ut velit distinctio. Dolor dolor mollitia voluptatem ad porro sit ut. Consequuntur id itaque enim fugit labore. Alias molestiae dolores voluptate est. Veritatis sit illum cum earum et iste.", "New Arlie", 2, 181.99m, "Handcrafted Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 66,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2016, 12, 26, 18, 25, 27, 49, DateTimeKind.Unspecified).AddTicks(147), "Est perferendis velit reiciendis labore repellendus recusandae labore. In enim cumque aliquam perferendis voluptatem quisquam voluptatem suscipit mollitia. Occaecati nisi explicabo blanditiis expedita facere quidem deleniti optio.", "Lake Adalbertoburgh", 765.39m, "Unbranded Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 67,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2019, 4, 12, 4, 22, 54, 680, DateTimeKind.Unspecified).AddTicks(8569), "Rerum placeat ea vel non. Quis qui nulla eum quia et quia vel. Quod voluptatem atque voluptatem qui ut porro quod corporis voluptate.", "North Nikko", 2, 857.05m, "Unbranded Soft Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 68,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2018, 10, 17, 14, 5, 40, 509, DateTimeKind.Unspecified).AddTicks(7624), "Minima dolorem reiciendis. Officiis ex consequatur. Eos rerum perspiciatis qui sed aperiam explicabo maxime. Quisquam et aut illo aut odio similique.", "Virginiaside", 75.02m, "Generic Metal Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 69,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2018, 3, 18, 20, 45, 13, 411, DateTimeKind.Unspecified).AddTicks(1206), "Ipsum ut nam commodi id dolorum perspiciatis nulla. Quia id debitis distinctio a quia ut. Sit eaque nemo iure voluptate quos voluptates quam non.", "East Orionhaven", 4.60m, "Sleek Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 70,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2017, 1, 13, 1, 51, 51, 394, DateTimeKind.Unspecified).AddTicks(2781), "Iusto molestiae deserunt voluptatem odio. Inventore velit distinctio laudantium. Necessitatibus dolore est id ut. At possimus rerum aut iste ex quasi soluta ipsum. Rerum eius iure asperiores corrupti.", "North Leilahaven", 1, 794.22m, "Fantastic Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 71,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2018, 4, 13, 4, 25, 47, 429, DateTimeKind.Unspecified).AddTicks(1316), "Aut possimus eos aliquam quia aut. Exercitationem laborum rem aut quasi. Laboriosam enim delectus ipsum adipisci ad rem. Nam adipisci consequatur vero voluptatum vel et beatae qui. Voluptatem et laborum nihil esse.", "New Alysa", 580.65m, "Generic Concrete Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 72,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2020, 6, 2, 9, 3, 8, 691, DateTimeKind.Unspecified).AddTicks(8372), "Dolor porro consectetur. Magni aliquam dolorum enim error. In optio molestiae omnis eius doloremque sit qui odio. Quidem at error perspiciatis ratione eligendi fugiat facilis quae est.", "North Connor", 336.71m, "Small Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 73,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2020, 3, 16, 20, 6, 27, 850, DateTimeKind.Unspecified).AddTicks(2716), "At perspiciatis tempora ut sequi dicta. Officia in asperiores consequatur ea voluptate molestiae voluptatem facilis quia. Nihil aut ut tenetur in aliquid. Sunt provident vero quidem eius impedit. Sint et alias. Ipsam quibusdam ut.", "Margaritaview", 1, 208.11m, "Gorgeous Metal Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 74,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2017, 2, 19, 19, 19, 54, 294, DateTimeKind.Unspecified).AddTicks(20), "Qui tenetur sit consequuntur eveniet delectus officiis at veritatis. Fugit tenetur sit quis ullam dignissimos dolorem. Magni sit vel eveniet cum corporis aut maxime nostrum tempore. Neque iusto est necessitatibus molestiae quia fugit eveniet. Aut illo odio.", "Kreigerville", 2, 560.28m, "Sleek Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 75,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2019, 12, 28, 4, 3, 46, 989, DateTimeKind.Unspecified).AddTicks(2258), "Esse velit est. Porro voluptatem voluptatem tempore sed. Eveniet sed totam veritatis.", "Cruickshankville", 1, 547.76m, "Small Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 76,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2017, 2, 9, 7, 13, 14, 665, DateTimeKind.Unspecified).AddTicks(6812), "Ullam quisquam exercitationem nostrum magnam ea voluptatem similique. Sit iusto voluptas dolor autem hic. Labore quod in quasi explicabo dignissimos. Fugiat adipisci at impedit aliquid.", "South Westonburgh", 785.18m, "Tasty Steel Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 77,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2015, 8, 2, 13, 2, 16, 286, DateTimeKind.Unspecified).AddTicks(3667), "Eveniet deserunt id qui ut consequatur quaerat accusamus eligendi. Eligendi voluptas quam est vero qui laudantium aspernatur. Optio repudiandae error earum ipsa ipsum. Sed est cupiditate.", "West Pabloton", 213.15m, "Intelligent Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 78,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2019, 3, 7, 5, 46, 13, 28, DateTimeKind.Unspecified).AddTicks(1885), "Enim debitis veniam nihil commodi voluptas. Aut voluptates illum natus. Earum sit et eligendi natus exercitationem neque corrupti ut. Voluptas et omnis quia qui consequatur sint ea.", "Port Delphia", 433.16m, "Gorgeous Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2016, 8, 21, 16, 37, 19, 591, DateTimeKind.Unspecified).AddTicks(7352), "Aspernatur molestias tempora veniam enim eos velit. Perspiciatis omnis voluptatem a dolores et omnis autem nam. Officiis nesciunt inventore omnis. Est omnis molestias beatae officia recusandae vel. Quis aut et officia illum soluta deleniti.", "McKenziefort", 79.11m, "Licensed Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 80,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2016, 1, 2, 9, 4, 18, 152, DateTimeKind.Unspecified).AddTicks(9908), "Beatae provident alias ducimus quos perspiciatis. In qui omnis dolor laborum et minus hic aperiam architecto. Eaque id eligendi amet eius. Ex reiciendis id et inventore. Non qui architecto unde id.", "West Hubertburgh", 1, 43.02m, "Refined Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 81,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2015, 3, 22, 5, 31, 16, 900, DateTimeKind.Unspecified).AddTicks(6738), "Placeat iste eius. Officia est est saepe ipsam porro sunt excepturi consequatur beatae. Rem unde sit sed ea repellat aut.", "Lowelltown", 1, 996.67m, "Refined Rubber Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 82,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2016, 5, 27, 20, 50, 40, 679, DateTimeKind.Unspecified).AddTicks(1838), "Sed quas ipsa dolore et ullam eos voluptas. Sunt nisi quibusdam incidunt autem qui minima et voluptatum. Vel dicta accusamus consequatur culpa earum deserunt voluptates. Blanditiis ad ut. Nihil nesciunt sapiente perferendis molestiae corporis laudantium ut dolores sequi. Quia exercitationem modi voluptas.", "North Carolinabury", 3.65m, "Sleek Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 83,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2016, 1, 24, 7, 16, 21, 604, DateTimeKind.Unspecified).AddTicks(6767), "Reprehenderit voluptas iure voluptatum suscipit. Explicabo architecto fugiat sunt pariatur voluptas. Quam ipsam recusandae. Quidem quis porro dolorem quo explicabo exercitationem accusamus.", "West Melyssastad", 2, 710.97m, "Incredible Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2015, 3, 29, 20, 5, 32, 28, DateTimeKind.Unspecified).AddTicks(6380), "Quo debitis magni est labore iusto ipsam vitae. Sunt cum harum molestias illo quia qui ducimus omnis libero. Est aut asperiores. Atque quia dolore aut voluptas dolorem. Qui dolorem sunt quibusdam voluptate officia eos. Distinctio voluptatibus repellendus et sit aperiam a.", "East Paulabury", 2, 741.87m, "Gorgeous Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 85,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2020, 3, 28, 23, 53, 10, 853, DateTimeKind.Unspecified).AddTicks(673), "Sed amet et facere. Sint explicabo laudantium quam. Assumenda repellat enim tenetur aut. Qui vero nam. Non et reiciendis sunt repudiandae.", "East Jovannyport", 47.77m, "Ergonomic Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2018, 3, 8, 0, 32, 29, 912, DateTimeKind.Unspecified).AddTicks(9523), "Beatae vel itaque. Dolor aut voluptatem quam et laboriosam. Iste modi debitis. Qui cum velit quia. Quo vitae ut sunt ut.", "East Dejah", 2, 154.92m, "Fantastic Granite Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 87,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2016, 7, 8, 10, 24, 58, 836, DateTimeKind.Unspecified).AddTicks(6303), "Aperiam eos ut et dolores et. Rem itaque dolorem sit corporis ducimus aliquam veniam ut sed. Asperiores culpa consequatur cupiditate. Vel omnis voluptatem illo accusamus excepturi. Iusto explicabo quis voluptatibus facilis inventore ut minima nisi et. Aut doloremque unde perferendis earum.", "Bobbyville", 2, 273.23m, "Fantastic Rubber Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 88,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2015, 1, 31, 17, 20, 28, 315, DateTimeKind.Unspecified).AddTicks(7962), "Quis incidunt mollitia quasi. Rerum reprehenderit dicta recusandae laudantium laborum modi doloremque molestiae at. Veniam ut dolores eos et quo iste. Cum labore et nulla enim aspernatur itaque dolores sit beatae. Aut quo modi qui vitae nesciunt molestiae consequatur et excepturi.", "Flatleyview", 1, 736.89m, "Intelligent Frozen Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 89,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2019, 4, 11, 15, 24, 6, 938, DateTimeKind.Unspecified).AddTicks(1015), "Distinctio qui porro voluptatem unde omnis fugiat non. Saepe hic recusandae maxime est inventore. Velit nihil debitis. Ipsam nihil impedit repellat amet odit dicta fugit neque.", "South Mitchellmouth", 434.08m, "Rustic Fresh Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 90,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2018, 12, 2, 9, 0, 29, 703, DateTimeKind.Unspecified).AddTicks(3682), "Aperiam architecto exercitationem molestias doloribus et non et. Dolorem deleniti dolorum ea labore nobis quisquam. Odio eligendi quisquam commodi.", "South Danial", 1, 396.44m, "Incredible Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 91,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2018, 6, 17, 4, 52, 49, 957, DateTimeKind.Unspecified).AddTicks(6714), "Animi iure harum nihil soluta fugit qui sit. Sint exercitationem et sint architecto recusandae qui. Et ipsum blanditiis qui aliquid soluta facilis et. Soluta hic optio. Tenetur quasi facere sapiente possimus at illo sit blanditiis quia.", "South Russellfort", 136.67m, "Tasty Granite Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 92,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2017, 9, 2, 18, 11, 33, 83, DateTimeKind.Unspecified).AddTicks(9005), "Ad quia magnam impedit doloribus quidem similique iusto quidem corrupti. Error tempora quos tenetur ipsam vitae sunt. Ipsum nulla ut repudiandae quos voluptas molestias dicta.", "Ilaborough", 610.94m, "Tasty Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2015, 6, 13, 16, 51, 46, 625, DateTimeKind.Unspecified).AddTicks(2520), "Vel rerum necessitatibus. Ab corporis ad voluptates quos non. Provident repellat corporis pariatur vitae non nostrum possimus accusamus deleniti.", "Tressieshire", 1, 303.40m, "Refined Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2018, 12, 19, 16, 13, 57, 568, DateTimeKind.Unspecified).AddTicks(9171), "Accusantium nemo quis a officiis et consectetur similique mollitia mollitia. Occaecati et laborum. Beatae et unde laudantium placeat ad qui eum. Saepe dolorem quia quo quidem eum rem sit fugit deserunt. Asperiores error consequuntur illo molestiae similique corporis aut a fugiat. Quas voluptatem non natus perferendis totam.", "Andersonfurt", 1, 441.35m, "Sleek Plastic Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 95,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2018, 11, 21, 1, 14, 12, 996, DateTimeKind.Unspecified).AddTicks(2601), "Quia omnis voluptate quia rerum nam excepturi earum quos. Sit aut nihil. Fugit quam nam voluptates repellendus beatae illum alias mollitia. Non provident sint. Veritatis ut quod sunt. Fugit quo inventore et exercitationem.", "Dolorestown", 76.55m, "Tasty Metal Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 96,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2020, 1, 16, 19, 57, 21, 255, DateTimeKind.Unspecified).AddTicks(1557), "Ipsa omnis eligendi pariatur hic sed dolor aliquid. Aut voluptatem quis debitis ratione. Sunt animi officia aperiam inventore.", "West Eileen", 516.95m, "Small Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 97,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2016, 1, 7, 4, 14, 8, 91, DateTimeKind.Unspecified).AddTicks(2146), "Alias esse nemo sapiente in occaecati neque porro debitis porro. Molestias sed possimus. Fugiat ea repellendus sunt. In dolorem exercitationem libero. Quia illum non sunt veniam ipsum. Voluptatem et quis.", "Lake Estrella", 1, 690.49m, "Ergonomic Cotton Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 98,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2018, 11, 17, 13, 55, 26, 591, DateTimeKind.Unspecified).AddTicks(5364), "Minima perspiciatis adipisci dolores qui qui. Sit fugiat quia quidem rem tempora nihil hic. Mollitia perspiciatis reiciendis consectetur officiis totam id asperiores. Explicabo perferendis quisquam. Maiores distinctio voluptatem nihil omnis. Libero eveniet repellendus omnis eveniet tempore repudiandae.", "West Colin", 862.85m, "Practical Cotton Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 99,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2019, 3, 24, 7, 27, 6, 932, DateTimeKind.Unspecified).AddTicks(2105), "Cupiditate consequatur aut sed molestiae corporis magni. Quasi pariatur laudantium voluptatem voluptas ducimus dolorem veniam qui consequatur. Beatae sint a perferendis in autem quia et rerum. Similique in similique earum.", "East Morganhaven", 694.84m, "Fantastic Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 100,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2020, 7, 15, 9, 17, 23, 155, DateTimeKind.Unspecified).AddTicks(3935), "Aspernatur perferendis quia adipisci sapiente est quia exercitationem architecto error. Ea voluptate modi tempore corrupti tempore quas ducimus eveniet. Et adipisci iusto esse aperiam qui. Enim voluptas sed voluptate non. Aut et et illo est fuga et facilis eaque est. Praesentium veniam eos et minima beatae laboriosam sequi aut molestias.", "Lake Olin", 1, 776.58m, "Unbranded Plastic Chair" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "PhoneNumber", "UserName" },
                values: new object[] { "a83998e4-f6b2-43dd-89c0-49518ee9c972", "Nadine26@gmail.com", "Johnson", "327.988.8879 x510", "Nadine_Johnson88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "PhoneNumber", "UserName" },
                values: new object[] { "f2015b30-ea2b-454d-9c75-d96c9b5f87c8", "Franklin77@gmail.com", "Morar", "356-900-7889", "Franklin_Morar" });

            migrationBuilder.AddForeignKey(
                name: "FK_RentHistory_Ads_AdId",
                table: "RentHistory",
                column: "AdId",
                principalTable: "Ads",
                principalColumn: "AdId");

            migrationBuilder.AddForeignKey(
                name: "FK_RentHistory_AspNetUsers_AdOwnerId",
                table: "RentHistory",
                column: "AdOwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentHistory_AspNetUsers_RentingUserId",
                table: "RentHistory",
                column: "RentingUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
