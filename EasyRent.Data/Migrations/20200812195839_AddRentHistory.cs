using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EasyRent.Data.Migrations
{
    public partial class AddRentHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentedAd_Ads_AdId",
                table: "RentedAd");

            migrationBuilder.DropForeignKey(
                name: "FK_RentedAd_AspNetUsers_RentedAdUserId",
                table: "RentedAd");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RentedAd",
                table: "RentedAd");

            migrationBuilder.RenameTable(
                name: "RentedAd",
                newName: "RentedAds");

            migrationBuilder.RenameIndex(
                name: "IX_RentedAd_RentedAdUserId",
                table: "RentedAds",
                newName: "IX_RentedAds_RentedAdUserId");

            migrationBuilder.RenameIndex(
                name: "IX_RentedAd_AdId",
                table: "RentedAds",
                newName: "IX_RentedAds_AdId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RentedAds",
                table: "RentedAds",
                column: "RentedAdId");

            migrationBuilder.CreateTable(
                name: "RentHistory",
                columns: table => new
                {
                    RentHistoryId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RentingUserId = table.Column<int>(nullable: false),
                    AdOwnerId = table.Column<int>(nullable: false),
                    AdId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentHistory", x => x.RentHistoryId);
                    table.ForeignKey(
                        name: "FK_RentHistory_Ads_AdId",
                        column: x => x.AdId,
                        principalTable: "Ads",
                        principalColumn: "AdId");
                    table.ForeignKey(
                        name: "FK_RentHistory_AspNetUsers_AdOwnerId",
                        column: x => x.AdOwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentHistory_AspNetUsers_RentingUserId",
                        column: x => x.RentingUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 1,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2020, 3, 1, 22, 43, 53, 173, DateTimeKind.Unspecified).AddTicks(4532), "Quia voluptatem numquam incidunt aspernatur laborum illum in. Dolor ex consectetur cumque qui neque sapiente sit cum aspernatur. Officiis neque tempora est veniam. Sed cumque officia provident autem quasi aut. Ratione perspiciatis illo est quod cum.", "Maximeborough", 1, 540.25m, "Handmade Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 2,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2017, 7, 29, 11, 16, 51, 894, DateTimeKind.Unspecified).AddTicks(8394), "Natus tempora possimus ipsa aperiam. Hic natus velit fugit maiores aliquid eum. Dolor sed nemo et et. Itaque nihil cumque quia fugiat nobis accusamus. Expedita veniam in dolorem dolorum. Excepturi dolor quod aut molestias qui.", "Deckowburgh", 2, 469.26m, "Handmade Frozen Keyboard" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2017, 3, 11, 8, 21, 38, 706, DateTimeKind.Unspecified).AddTicks(2882), "Numquam est ea modi voluptate. Veritatis et nam aut nostrum sed aliquid. Voluptas voluptatem non praesentium alias dolorem blanditiis sint qui. Ullam nemo hic id. Voluptatum accusantium deleniti sunt id enim quisquam. Placeat quaerat eos officia.", "Fosterbury", 969.07m, "Small Granite Pants" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2015, 6, 29, 5, 35, 44, 595, DateTimeKind.Unspecified).AddTicks(805), "Rerum quo eligendi qui enim dolores tenetur nesciunt dolorem dolores. Possimus aut vero beatae repellendus. Voluptas et laborum consequatur molestiae ut voluptas minus ea. Ipsa saepe commodi tempora quam aut aspernatur impedit dolore. Sed tempora eaque. Velit eius at accusantium dolores enim nobis recusandae maiores.", "South Tyrellburgh", 1, 154.59m, "Practical Plastic Pizza" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2020, 4, 26, 4, 54, 43, 905, DateTimeKind.Unspecified).AddTicks(4421), "Et eum ut alias voluptas quibusdam nam nisi odit. Ut nam ut provident dolores. Corporis error qui odit et aperiam saepe. Harum repudiandae temporibus sunt velit. Expedita eum sed sed pariatur minus rerum atque officia. Et sed delectus voluptatum sunt.", "Mohammadchester", 105.72m, "Rustic Concrete Salad" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2015, 7, 3, 18, 33, 10, 482, DateTimeKind.Unspecified).AddTicks(3874), "Veritatis est voluptas labore ea. Repellat nisi natus. Et ut natus consectetur qui architecto. Ut nam ut officia dicta quisquam eos esse.", "West Elisabeth", 519.74m, "Awesome Metal Bike" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2018, 5, 9, 6, 23, 16, 893, DateTimeKind.Unspecified).AddTicks(6619), "Quia cum consequuntur nam esse deserunt eos facilis cupiditate. Qui sint ut sed dignissimos cupiditate. Reiciendis nam deleniti minima similique laborum quibusdam. Nisi reiciendis nemo sint consequatur iure.", "New Stephon", 487.65m, "Licensed Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 15,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2016, 9, 2, 9, 41, 11, 436, DateTimeKind.Unspecified).AddTicks(2614), "Reprehenderit quia architecto ad quibusdam architecto laborum nihil sit est. In est veritatis voluptas veniam quasi laborum fugiat qui. Sit ut eos dignissimos. Libero a tempore vel facere quo aliquid officia. Cum nemo quasi sit. Nemo distinctio illo dolor.", "Hansenhaven", 1, 711.11m, "Gorgeous Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 16,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2019, 7, 16, 23, 26, 29, 13, DateTimeKind.Unspecified).AddTicks(2980), "Omnis numquam fugiat dicta voluptate et. Tenetur itaque consequatur. Sit voluptas et aut. Et animi nihil. Sapiente similique quae sed fugiat a. Et at blanditiis accusantium nesciunt est nulla eveniet.", "East Autumnfort", 2, 653.70m, "Generic Wooden Pizza" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2020, 6, 21, 0, 2, 16, 47, DateTimeKind.Unspecified).AddTicks(332), "Accusamus quo placeat possimus non molestiae alias. Iste deleniti non cumque ad ea. Provident voluptas saepe nesciunt cum autem error inventore sapiente.", "South Haileetown", 1, 208.72m, "Refined Cotton Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 19,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2017, 5, 17, 1, 43, 2, 147, DateTimeKind.Unspecified).AddTicks(2590), "In inventore reprehenderit iure consequatur debitis non asperiores. Sunt aut voluptates dolores et laudantium tempore commodi qui. Omnis repellendus excepturi ipsa voluptatem. Labore nihil fugit occaecati est repudiandae qui sint nulla amet.", "Runteburgh", 1, 784.68m, "Handcrafted Fresh Chips" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2015, 7, 11, 18, 5, 4, 837, DateTimeKind.Unspecified).AddTicks(3545), "Quia fuga aut. Explicabo numquam repellendus fugit. Tempora consequatur rerum quia illum in. Perferendis occaecati facere et voluptas voluptatem non facere temporibus. Enim fugiat sed et corporis qui dicta. Eveniet maxime harum id architecto aut nobis reiciendis minima facilis.", "West Tracey", 813.80m, "Sleek Concrete Chair" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2016, 11, 16, 5, 1, 20, 998, DateTimeKind.Unspecified).AddTicks(3831), "Repudiandae corrupti maiores similique fuga dignissimos voluptate aut. Qui tempore eius. Ut et beatae distinctio quod consequatur et iure aut molestias. Est voluptas atque iusto exercitationem autem. Eos ut qui ut aut. Laborum quo sit molestias sint aperiam sit quos.", "New Lueside", 869.95m, "Licensed Plastic Computer" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2017, 10, 22, 17, 45, 7, 700, DateTimeKind.Unspecified).AddTicks(3139), "Rem neque sit. Illo placeat facere iusto nulla dolores ut molestiae nam est. Veritatis cumque ipsam consequatur dolorem quos corporis voluptates dolore non. Autem quasi cupiditate explicabo quisquam est nemo dolore. Voluptas vel similique.", "Antoniastad", 909.68m, "Incredible Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 30,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2018, 6, 25, 20, 35, 42, 903, DateTimeKind.Unspecified).AddTicks(113), "Aut amet ex nulla et. Magnam vitae autem quis. Soluta voluptates placeat velit officia. Esse perspiciatis dolor nobis magni nobis id.", "New Verniemouth", 2, 732.21m, "Small Plastic Bacon" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2019, 1, 5, 21, 57, 34, 798, DateTimeKind.Unspecified).AddTicks(9008), "Sunt aut ratione quis possimus. Expedita sit eaque cum quo. Est quibusdam rerum voluptas dolorem quia et. Voluptas dicta harum quisquam adipisci. Est sed aperiam quasi in suscipit.", "Lake Caesar", 2, 546.76m, "Intelligent Soft Bacon" });

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
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2016, 10, 17, 15, 52, 14, 626, DateTimeKind.Unspecified).AddTicks(2267), "Vitae tempora amet et incidunt voluptatem mollitia aliquam. Aut eos veritatis eos tempore odio incidunt et totam. Error et qui a dolorum officia error vel aut ipsa. Amet et est et ea. Optio eligendi exercitationem eligendi rerum.", "Doviemouth", 2, 153.80m, "Refined Rubber Hat" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2018, 12, 31, 3, 59, 10, 104, DateTimeKind.Unspecified).AddTicks(8497), "Laboriosam mollitia laudantium saepe similique nulla explicabo ullam libero molestiae. Ut maiores et quia et aperiam omnis repellat. Ut omnis quibusdam quis eos ad. Provident veniam est perferendis perspiciatis quo quos sit dignissimos. Minima ratione labore. Consequatur a natus.", "Sterlinghaven", 1, 374.45m, "Licensed Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 38,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2017, 7, 29, 20, 8, 54, 372, DateTimeKind.Unspecified).AddTicks(6996), "Quibusdam quia possimus exercitationem eaque error perferendis sit repudiandae. Nihil dolores repudiandae qui. Facere voluptate possimus consequatur eveniet mollitia ut et ut. Et voluptas maxime sit ullam corporis. Et ut facilis et cupiditate at.", "South Ferneside", 2, 646.74m, "Sleek Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 39,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2018, 5, 2, 22, 23, 26, 492, DateTimeKind.Unspecified).AddTicks(8110), "Atque et temporibus adipisci natus. Occaecati aut est quibusdam ut est laborum. Ullam eligendi autem vitae alias tempora iste iste necessitatibus. Distinctio deserunt fugit ipsa quae aut qui. Voluptas repellat qui.", "North Ezequiel", 1, 85.23m, "Incredible Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 40,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2020, 8, 6, 8, 41, 47, 878, DateTimeKind.Unspecified).AddTicks(1372), "Harum eveniet tempore. A libero suscipit. Non quia et sed ut ducimus deleniti quo harum.", "East Tiarastad", 49.70m, "Tasty Metal Chair" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2019, 4, 1, 14, 7, 47, 355, DateTimeKind.Unspecified).AddTicks(8740), "Modi doloremque ad et dolores. Voluptates atque laboriosam. Nostrum labore qui itaque. Amet hic molestias dolor repellendus exercitationem ducimus. Explicabo rem illo nemo alias. Voluptatem eveniet commodi hic pariatur possimus distinctio nihil.", "Bednarstad", 307.71m, "Refined Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 44,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2016, 2, 3, 13, 14, 53, 478, DateTimeKind.Unspecified).AddTicks(890), "Necessitatibus ipsum et recusandae sit. Est possimus sit. Beatae omnis et placeat sit quis molestiae.", "Lake Chelsey", 872.35m, "Handmade Wooden Table" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2020, 2, 11, 3, 4, 8, 915, DateTimeKind.Unspecified).AddTicks(5362), "Beatae qui voluptates veniam quas qui. Non ut quisquam aspernatur sed est veritatis velit. Omnis qui non eum sed consectetur ipsum necessitatibus inventore suscipit. Saepe omnis praesentium animi nesciunt.", "Hermistonstad", 1, 196.54m, "Intelligent Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 47,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2020, 1, 1, 1, 15, 4, 779, DateTimeKind.Unspecified).AddTicks(1394), "Est omnis aut praesentium. Ipsam adipisci magni sapiente sunt sit rerum modi. Tempora dolorem sit. Qui consequatur quia earum omnis suscipit iusto alias est. Illo sit dignissimos consequatur magnam doloribus sed ullam provident repudiandae. Dignissimos voluptatem rem velit.", "D'Amoremouth", 973.19m, "Rustic Rubber Mouse" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2015, 4, 2, 12, 58, 2, 534, DateTimeKind.Unspecified).AddTicks(4340), "Aliquam corrupti quam commodi deserunt quis aliquam. Nisi nisi soluta non cupiditate occaecati velit unde. Similique nihil cumque illo adipisci dignissimos at nostrum qui.", "New Ruben", 2, 963.47m, "Awesome Cotton Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 51,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2017, 9, 12, 20, 13, 12, 76, DateTimeKind.Unspecified).AddTicks(7912), "Minus quam vero voluptatem vero totam impedit in asperiores omnis. Quis illum facilis atque quos quos. Ipsa similique quasi.", "Lake Lenoramouth", 2, 379.64m, "Licensed Plastic Mouse" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2016, 11, 22, 20, 7, 21, 183, DateTimeKind.Unspecified).AddTicks(6412), "Qui rerum non ad aperiam eos itaque fugit quo. Amet eos minima est voluptas quasi aliquam. Optio dolores sed cumque animi autem.", "South Brennon", 514.75m, "Incredible Cotton Pizza" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2020, 2, 24, 7, 56, 46, 354, DateTimeKind.Unspecified).AddTicks(153), "Nihil nihil necessitatibus atque quia id eligendi. Quam numquam perspiciatis. Quas cumque et atque. Voluptatum debitis dolorem qui magni sit explicabo qui modi dolore. Et aut quia voluptas est. Consequatur repellat qui et.", "Hoppefort", 39.50m, "Incredible Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 56,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2018, 12, 5, 3, 13, 59, 24, DateTimeKind.Unspecified).AddTicks(3983), "Accusamus quo pariatur voluptatem voluptatum exercitationem quis autem aperiam ut. Quam voluptate sed ipsa eius. Quaerat suscipit iusto nisi beatae cum. Consequatur odit dolorem pariatur exercitationem provident.", "Jaskolskishire", 714.86m, "Small Plastic Shoes" });

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
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2019, 8, 31, 18, 59, 7, 409, DateTimeKind.Unspecified).AddTicks(8007), "Sit non aut sunt ea cum ut et vero nesciunt. Non culpa impedit fuga accusamus omnis aut fugiat voluptatem molestiae. Odit quisquam reprehenderit non omnis id aut aut id saepe. Repellat enim pariatur suscipit. Odit ratione enim similique ad laudantium velit qui. Blanditiis eos nemo dolorem rerum.", "New Kelley", 400.45m, "Practical Concrete Mouse" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2015, 8, 11, 15, 49, 15, 681, DateTimeKind.Unspecified).AddTicks(7886), "Et et quia porro quia explicabo quae deleniti. In ut velit distinctio. Dolor dolor mollitia voluptatem ad porro sit ut. Consequuntur id itaque enim fugit labore. Alias molestiae dolores voluptate est. Veritatis sit illum cum earum et iste.", "New Arlie", 181.99m, "Handcrafted Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 66,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2016, 12, 26, 18, 25, 27, 49, DateTimeKind.Unspecified).AddTicks(147), "Est perferendis velit reiciendis labore repellendus recusandae labore. In enim cumque aliquam perferendis voluptatem quisquam voluptatem suscipit mollitia. Occaecati nisi explicabo blanditiis expedita facere quidem deleniti optio.", "Lake Adalbertoburgh", 2, 765.39m, "Unbranded Granite Pizza" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2018, 10, 17, 14, 5, 40, 509, DateTimeKind.Unspecified).AddTicks(7624), "Minima dolorem reiciendis. Officiis ex consequatur. Eos rerum perspiciatis qui sed aperiam explicabo maxime. Quisquam et aut illo aut odio similique.", "Virginiaside", 2, 75.02m, "Generic Metal Pizza" });

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
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2017, 1, 13, 1, 51, 51, 394, DateTimeKind.Unspecified).AddTicks(2781), "Iusto molestiae deserunt voluptatem odio. Inventore velit distinctio laudantium. Necessitatibus dolore est id ut. At possimus rerum aut iste ex quasi soluta ipsum. Rerum eius iure asperiores corrupti.", "North Leilahaven", 794.22m, "Fantastic Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2018, 4, 13, 4, 25, 47, 429, DateTimeKind.Unspecified).AddTicks(1316), "Aut possimus eos aliquam quia aut. Exercitationem laborum rem aut quasi. Laboriosam enim delectus ipsum adipisci ad rem. Nam adipisci consequatur vero voluptatum vel et beatae qui. Voluptatem et laborum nihil esse.", "New Alysa", 580.65m, "Generic Concrete Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 72,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2020, 6, 2, 9, 3, 8, 691, DateTimeKind.Unspecified).AddTicks(8372), "Dolor porro consectetur. Magni aliquam dolorum enim error. In optio molestiae omnis eius doloremque sit qui odio. Quidem at error perspiciatis ratione eligendi fugiat facilis quae est.", "North Connor", 1, 336.71m, "Small Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 73,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2020, 3, 16, 20, 6, 27, 850, DateTimeKind.Unspecified).AddTicks(2716), "At perspiciatis tempora ut sequi dicta. Officia in asperiores consequatur ea voluptate molestiae voluptatem facilis quia. Nihil aut ut tenetur in aliquid. Sunt provident vero quidem eius impedit. Sint et alias. Ipsam quibusdam ut.", "Margaritaview", 208.11m, "Gorgeous Metal Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 74,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2017, 2, 19, 19, 19, 54, 294, DateTimeKind.Unspecified).AddTicks(20), "Qui tenetur sit consequuntur eveniet delectus officiis at veritatis. Fugit tenetur sit quis ullam dignissimos dolorem. Magni sit vel eveniet cum corporis aut maxime nostrum tempore. Neque iusto est necessitatibus molestiae quia fugit eveniet. Aut illo odio.", "Kreigerville", 560.28m, "Sleek Steel Chips" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2016, 8, 21, 16, 37, 19, 591, DateTimeKind.Unspecified).AddTicks(7352), "Aspernatur molestias tempora veniam enim eos velit. Perspiciatis omnis voluptatem a dolores et omnis autem nam. Officiis nesciunt inventore omnis. Est omnis molestias beatae officia recusandae vel. Quis aut et officia illum soluta deleniti.", "McKenziefort", 79.11m, "Licensed Metal Soap" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2016, 5, 27, 20, 50, 40, 679, DateTimeKind.Unspecified).AddTicks(1838), "Sed quas ipsa dolore et ullam eos voluptas. Sunt nisi quibusdam incidunt autem qui minima et voluptatum. Vel dicta accusamus consequatur culpa earum deserunt voluptates. Blanditiis ad ut. Nihil nesciunt sapiente perferendis molestiae corporis laudantium ut dolores sequi. Quia exercitationem modi voluptas.", "North Carolinabury", 1, 3.65m, "Sleek Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 83,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2016, 1, 24, 7, 16, 21, 604, DateTimeKind.Unspecified).AddTicks(6767), "Reprehenderit voluptas iure voluptatum suscipit. Explicabo architecto fugiat sunt pariatur voluptas. Quam ipsam recusandae. Quidem quis porro dolorem quo explicabo exercitationem accusamus.", "West Melyssastad", 710.97m, "Incredible Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 84,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2015, 3, 29, 20, 5, 32, 28, DateTimeKind.Unspecified).AddTicks(6380), "Quo debitis magni est labore iusto ipsam vitae. Sunt cum harum molestias illo quia qui ducimus omnis libero. Est aut asperiores. Atque quia dolore aut voluptas dolorem. Qui dolorem sunt quibusdam voluptate officia eos. Distinctio voluptatibus repellendus et sit aperiam a.", "East Paulabury", 2, 741.87m, "Gorgeous Steel Chicken" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2018, 3, 8, 0, 32, 29, 912, DateTimeKind.Unspecified).AddTicks(9523), "Beatae vel itaque. Dolor aut voluptatem quam et laboriosam. Iste modi debitis. Qui cum velit quia. Quo vitae ut sunt ut.", "East Dejah", 2, 154.92m, "Fantastic Granite Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2016, 7, 8, 10, 24, 58, 836, DateTimeKind.Unspecified).AddTicks(6303), "Aperiam eos ut et dolores et. Rem itaque dolorem sit corporis ducimus aliquam veniam ut sed. Asperiores culpa consequatur cupiditate. Vel omnis voluptatem illo accusamus excepturi. Iusto explicabo quis voluptatibus facilis inventore ut minima nisi et. Aut doloremque unde perferendis earum.", "Bobbyville", 2, 273.23m, "Fantastic Rubber Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 88,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2015, 1, 31, 17, 20, 28, 315, DateTimeKind.Unspecified).AddTicks(7962), "Quis incidunt mollitia quasi. Rerum reprehenderit dicta recusandae laudantium laborum modi doloremque molestiae at. Veniam ut dolores eos et quo iste. Cum labore et nulla enim aspernatur itaque dolores sit beatae. Aut quo modi qui vitae nesciunt molestiae consequatur et excepturi.", "Flatleyview", 736.89m, "Intelligent Frozen Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 89,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2019, 4, 11, 15, 24, 6, 938, DateTimeKind.Unspecified).AddTicks(1015), "Distinctio qui porro voluptatem unde omnis fugiat non. Saepe hic recusandae maxime est inventore. Velit nihil debitis. Ipsam nihil impedit repellat amet odit dicta fugit neque.", "South Mitchellmouth", 1, 434.08m, "Rustic Fresh Table" });

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
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2017, 9, 2, 18, 11, 33, 83, DateTimeKind.Unspecified).AddTicks(9005), "Ad quia magnam impedit doloribus quidem similique iusto quidem corrupti. Error tempora quos tenetur ipsam vitae sunt. Ipsum nulla ut repudiandae quos voluptas molestias dicta.", "Ilaborough", 2, 610.94m, "Tasty Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 93,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2015, 6, 13, 16, 51, 46, 625, DateTimeKind.Unspecified).AddTicks(2520), "Vel rerum necessitatibus. Ab corporis ad voluptates quos non. Provident repellat corporis pariatur vitae non nostrum possimus accusamus deleniti.", "Tressieshire", 303.40m, "Refined Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 94,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2018, 12, 19, 16, 13, 57, 568, DateTimeKind.Unspecified).AddTicks(9171), "Accusantium nemo quis a officiis et consectetur similique mollitia mollitia. Occaecati et laborum. Beatae et unde laudantium placeat ad qui eum. Saepe dolorem quia quo quidem eum rem sit fugit deserunt. Asperiores error consequuntur illo molestiae similique corporis aut a fugiat. Quas voluptatem non natus perferendis totam.", "Andersonfurt", 441.35m, "Sleek Plastic Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2018, 11, 21, 1, 14, 12, 996, DateTimeKind.Unspecified).AddTicks(2601), "Quia omnis voluptate quia rerum nam excepturi earum quos. Sit aut nihil. Fugit quam nam voluptates repellendus beatae illum alias mollitia. Non provident sint. Veritatis ut quod sunt. Fugit quo inventore et exercitationem.", "Dolorestown", 2, 76.55m, "Tasty Metal Pizza" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2019, 3, 24, 7, 27, 6, 932, DateTimeKind.Unspecified).AddTicks(2105), "Cupiditate consequatur aut sed molestiae corporis magni. Quasi pariatur laudantium voluptatem voluptas ducimus dolorem veniam qui consequatur. Beatae sint a perferendis in autem quia et rerum. Similique in similique earum.", "East Morganhaven", 2, 694.84m, "Fantastic Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 100,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2020, 7, 15, 9, 17, 23, 155, DateTimeKind.Unspecified).AddTicks(3935), "Aspernatur perferendis quia adipisci sapiente est quia exercitationem architecto error. Ea voluptate modi tempore corrupti tempore quas ducimus eveniet. Et adipisci iusto esse aperiam qui. Enim voluptas sed voluptate non. Aut et et illo est fuga et facilis eaque est. Praesentium veniam eos et minima beatae laboriosam sequi aut molestias.", "Lake Olin", 776.58m, "Unbranded Plastic Chair" });

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

            migrationBuilder.CreateIndex(
                name: "IX_RentHistory_AdId",
                table: "RentHistory",
                column: "AdId");

            migrationBuilder.CreateIndex(
                name: "IX_RentHistory_AdOwnerId",
                table: "RentHistory",
                column: "AdOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_RentHistory_RentingUserId",
                table: "RentHistory",
                column: "RentingUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RentedAds_Ads_AdId",
                table: "RentedAds",
                column: "AdId",
                principalTable: "Ads",
                principalColumn: "AdId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentedAds_AspNetUsers_RentedAdUserId",
                table: "RentedAds",
                column: "RentedAdUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentedAds_Ads_AdId",
                table: "RentedAds");

            migrationBuilder.DropForeignKey(
                name: "FK_RentedAds_AspNetUsers_RentedAdUserId",
                table: "RentedAds");

            migrationBuilder.DropTable(
                name: "RentHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RentedAds",
                table: "RentedAds");

            migrationBuilder.RenameTable(
                name: "RentedAds",
                newName: "RentedAd");

            migrationBuilder.RenameIndex(
                name: "IX_RentedAds_RentedAdUserId",
                table: "RentedAd",
                newName: "IX_RentedAd_RentedAdUserId");

            migrationBuilder.RenameIndex(
                name: "IX_RentedAds_AdId",
                table: "RentedAd",
                newName: "IX_RentedAd_AdId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RentedAd",
                table: "RentedAd",
                column: "RentedAdId");

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 1,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2017, 8, 6, 4, 28, 15, 298, DateTimeKind.Unspecified).AddTicks(4994), "Eveniet ut pariatur voluptatem quos eaque. Voluptatem rerum alias ut et. Error quibusdam ipsa doloremque dignissimos cupiditate ipsam. Ipsa alias rerum aliquid possimus. Cum error in beatae laboriosam dolores autem.", "East Curtborough", 2, 472.24m, "Generic Cotton Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 2,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2019, 2, 15, 10, 23, 6, 285, DateTimeKind.Unspecified).AddTicks(2106), "Distinctio quas voluptatem perferendis. Reiciendis voluptate voluptatem vero delectus quia repudiandae minus dolores. Qui quis et velit occaecati omnis in occaecati. Distinctio aut et et enim in vel quibusdam soluta. Rerum quia perspiciatis error dolore ea est.", "Hagenesburgh", 1, 9.73m, "Practical Soft Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 3,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2016, 3, 12, 19, 45, 21, 317, DateTimeKind.Unspecified).AddTicks(9095), "Voluptatem quam voluptatem maiores adipisci aliquid eos architecto. Placeat minima officia velit ut neque. Corrupti eaque aut cum voluptas autem doloribus. Non illum quia. Dolor amet voluptas atque.", "Caramouth", 1, 153.31m, "Generic Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 4,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2019, 6, 13, 10, 53, 53, 91, DateTimeKind.Unspecified).AddTicks(3687), "Doloremque est mollitia. In sint dolore totam. Accusantium et ea et ipsum.", "Hodkiewiczland", 624.02m, "Incredible Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 5,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2017, 8, 4, 9, 48, 35, 193, DateTimeKind.Unspecified).AddTicks(5381), "Doloribus ullam est. Nostrum iste omnis ut inventore corrupti eius. Distinctio voluptatem itaque exercitationem velit et aliquid dolorem quisquam ducimus. Ut quasi omnis doloribus earum eaque. Illum nisi excepturi similique.", "Urbanmouth", 693.57m, "Handmade Concrete Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 6,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2015, 8, 4, 19, 21, 19, 203, DateTimeKind.Unspecified).AddTicks(1212), "Sapiente doloremque ea eligendi. Aliquam et ut quis ut rerum porro. Non error est non illum libero debitis.", "North Myrtie", 1, 991.12m, "Sleek Granite Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 7,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2016, 2, 26, 5, 36, 10, 924, DateTimeKind.Unspecified).AddTicks(6835), "Vel sint et a. Ut facilis natus iusto aut minima maiores. Veritatis ipsum quia. Velit non exercitationem et veniam cum accusamus nostrum.", "East Ashley", 2, 342.17m, "Licensed Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 8,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2015, 2, 2, 10, 11, 34, 658, DateTimeKind.Unspecified).AddTicks(7987), "Id accusantium qui quia aut odio quas vel. Molestiae qui suscipit impedit nihil neque minus eaque molestias. Et recusandae libero numquam ipsum natus eius. Autem aliquam dolor corporis sequi error deleniti architecto. Rerum quia quas voluptas.", "North Kaleview", 722.71m, "Handmade Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 9,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2017, 7, 29, 23, 31, 17, 743, DateTimeKind.Unspecified).AddTicks(662), "Commodi quibusdam itaque vel esse et. Et quo natus aut fuga ullam assumenda tempora aliquid asperiores. Sint alias est quasi debitis magni est ducimus aut. Voluptatem omnis a laborum illo dolor sed.", "Brigitteborough", 529.19m, "Sleek Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 10,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2016, 11, 9, 22, 43, 59, 876, DateTimeKind.Unspecified).AddTicks(7558), "Voluptatibus voluptate accusantium voluptatem molestias dolore. Est exercitationem sint aut. Delectus consequatur enim. Recusandae animi ea similique occaecati similique perspiciatis. Harum quaerat velit reprehenderit. Laborum iure similique a voluptatem dolorem quia labore.", "Kleinborough", 803.56m, "Ergonomic Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 11,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2017, 1, 18, 23, 29, 40, 245, DateTimeKind.Unspecified).AddTicks(2877), "Dolores cupiditate necessitatibus sed dolore. Esse eos vel iure magnam quo vero eaque soluta provident. Vitae rerum maiores dolores. Dolor voluptatem asperiores voluptas molestiae. Dolor aut ipsam optio quo sunt sequi dicta.", "West Melody", 119.46m, "Fantastic Plastic Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 12,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2020, 5, 19, 19, 17, 25, 434, DateTimeKind.Unspecified).AddTicks(5876), "Tempora ut sunt. Et quo neque adipisci. Quod non deleniti deleniti facere. Non architecto omnis. Assumenda aut mollitia aperiam. Autem dolorem in qui debitis vel hic totam qui quis.", "South Patricia", 79.80m, "Ergonomic Frozen Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 13,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2016, 10, 9, 13, 30, 23, 703, DateTimeKind.Unspecified).AddTicks(2494), "Rerum expedita ut dolores. Est in quia ipsum et. Numquam eos temporibus eos.", "West Justen", 792.20m, "Handmade Metal Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 14,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2016, 3, 25, 10, 34, 46, 917, DateTimeKind.Unspecified).AddTicks(4607), "Magni voluptas molestiae at minima est. Amet sint qui eum. Ullam quasi est velit aut ut sunt. Nostrum eos culpa facilis. Delectus velit sunt provident. Nihil ex exercitationem quia ut.", "East Orland", 921.75m, "Sleek Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 15,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2016, 2, 27, 19, 35, 49, 599, DateTimeKind.Unspecified).AddTicks(2130), "Tempore aut voluptates molestias sit similique. Sit ut voluptatem veniam rerum ipsam ipsam in et. Debitis doloremque tempora quia et ipsam hic.", "West Arnoldport", 2, 684.32m, "Generic Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 16,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2020, 3, 25, 16, 56, 49, 649, DateTimeKind.Unspecified).AddTicks(8685), "Fugiat cupiditate repellendus occaecati asperiores repellat quasi. Eos est dolor qui tenetur facilis rerum ut dolor consequatur. Eligendi a atque facere atque minima et et dignissimos. Et voluptas in perferendis doloremque maxime aliquid. Impedit magni et dolore.", "Townefort", 1, 904.88m, "Fantastic Soft Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 17,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2015, 1, 15, 21, 0, 48, 206, DateTimeKind.Unspecified).AddTicks(8397), "Accusamus nam aliquid assumenda corporis labore dolores quis fuga. Nihil voluptas id magni et eveniet. Distinctio quasi labore et ducimus aut deserunt.", "McClureside", 767.38m, "Generic Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 18,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2018, 11, 30, 22, 44, 13, 311, DateTimeKind.Unspecified).AddTicks(7463), "Qui culpa earum totam quidem. Fuga deserunt amet illo corporis incidunt. Aspernatur qui voluptatem ex et aut nihil est possimus.", "Reichertborough", 2, 727.98m, "Handmade Wooden Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 19,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2015, 4, 2, 22, 21, 15, 327, DateTimeKind.Unspecified).AddTicks(6284), "Quas tenetur porro id id quidem qui. Voluptate aut minima eligendi a non. Et et officiis. Est soluta quidem maxime eius voluptatem et est excepturi sapiente. Voluptatem ea dolore aliquam mollitia odio. Facere voluptatem dolorem animi corporis aliquid.", "Kilbackstad", 2, 770.54m, "Intelligent Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 20,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2016, 8, 12, 11, 22, 24, 753, DateTimeKind.Unspecified).AddTicks(9147), "Et non et qui optio hic enim nihil sint. Debitis ducimus cumque non tempore sit ut laborum minus. Autem quis autem. Occaecati eos rem sint rerum dignissimos accusamus ea maiores.", "Lake Dario", 1, 932.49m, "Incredible Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 21,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2019, 10, 19, 22, 10, 59, 492, DateTimeKind.Unspecified).AddTicks(8912), "Sit quasi veniam voluptatem eum qui perspiciatis. Eos et culpa quam est. Natus voluptatum quibusdam voluptatum voluptatum doloribus rem praesentium quia sed.", "East Leda", 47.46m, "Sleek Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 22,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2017, 1, 6, 15, 38, 16, 133, DateTimeKind.Unspecified).AddTicks(1934), "Amet adipisci fugit. Quia eos pariatur aut ratione. Quia consequatur consequatur quod quos voluptate tenetur odit aspernatur. Maxime vitae debitis culpa ut dolores facere ullam.", "Lake Mireyaport", 591.37m, "Sleek Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 23,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2015, 8, 8, 12, 21, 42, 338, DateTimeKind.Unspecified).AddTicks(705), "Odio illo et ipsa ut ipsa assumenda. Dicta ut deserunt aut dolorum. Odit voluptatem sed possimus eum. Unde debitis nihil sunt est omnis.", "Ivahhaven", 1, 47.54m, "Licensed Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 24,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2015, 6, 9, 8, 0, 59, 894, DateTimeKind.Unspecified).AddTicks(8718), "Corporis blanditiis maiores tenetur sint dolorem magni. Ut dolorem amet veniam qui quam. Tenetur et error harum ut aliquid praesentium cupiditate voluptatem.", "North Bobby", 1, 152.56m, "Incredible Granite Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 25,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2018, 2, 13, 0, 4, 36, 159, DateTimeKind.Unspecified).AddTicks(1536), "Qui deserunt a mollitia a. Aut ut ut est modi. Animi consequatur ipsa quod qui. Sit voluptas recusandae nam et debitis nihil reiciendis.", "South Candidoland", 2, 214.28m, "Licensed Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 26,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2016, 6, 2, 8, 32, 56, 38, DateTimeKind.Unspecified).AddTicks(8314), "Quasi expedita dolor illo nulla illum omnis. Ut rem enim soluta commodi illum laborum. Minus sunt vitae necessitatibus voluptatibus modi.", "East Carmel", 394.56m, "Fantastic Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 27,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2015, 10, 8, 16, 9, 56, 373, DateTimeKind.Unspecified).AddTicks(6000), "Aut amet facere laborum. Inventore earum molestiae occaecati maiores aut nihil pariatur. Aliquid doloremque dolorem. Cupiditate ratione animi pariatur nemo maiores.", "Kleinbury", 369.60m, "Practical Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 28,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2016, 9, 26, 18, 53, 14, 797, DateTimeKind.Unspecified).AddTicks(9888), "Nobis sed iusto voluptatem hic omnis. Commodi enim minus perspiciatis ea ipsa odit molestiae. Laborum numquam non voluptatem. Assumenda porro sed est sunt perferendis incidunt vitae maxime aut. Exercitationem molestiae nisi nihil rerum et adipisci.", "East Tyrafurt", 2, 163.70m, "Unbranded Steel Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 29,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2019, 8, 9, 19, 46, 31, 817, DateTimeKind.Unspecified).AddTicks(6271), "Impedit dignissimos unde. In ut autem autem sed rem minima similique et non. Fugit omnis est. Aut sit deleniti sed. Aspernatur iste exercitationem quidem et nihil quis quis eius asperiores.", "Stantonbury", 430.95m, "Incredible Metal Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 30,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2020, 7, 31, 20, 18, 5, 936, DateTimeKind.Unspecified).AddTicks(3901), "Provident voluptatibus ut. Unde dolores totam velit. Incidunt voluptas et. Nulla itaque quod magni fugiat aspernatur voluptates ut quidem. Quaerat id sit.", "South Xavier", 1, 198.32m, "Tasty Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 31,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2016, 8, 11, 11, 55, 45, 550, DateTimeKind.Unspecified).AddTicks(3813), "Sequi labore et. Ut tempore cupiditate voluptas laborum blanditiis est eum est. In facere facere eveniet a rerum deleniti eius. Recusandae nihil saepe voluptatem rerum nisi qui dolorem. Alias aut cum vero alias perspiciatis minus ut.", "Waltonchester", 2, 964.40m, "Handmade Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 32,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2017, 2, 28, 12, 33, 1, 31, DateTimeKind.Unspecified).AddTicks(3950), "Ex explicabo omnis. Non ut vel aut voluptate quidem quam autem harum ratione. Officia alias quisquam placeat non neque.", "Stuartport", 1, 502.07m, "Handmade Wooden Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 33,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2017, 8, 7, 17, 3, 21, 838, DateTimeKind.Unspecified).AddTicks(9712), "Cumque enim et omnis quod sit aperiam. Est itaque aut omnis. Sit et eius et veniam qui voluptas doloremque sapiente maxime. Ipsa iusto omnis quibusdam. Fuga et laborum deserunt non non officiis. Aperiam voluptatem iure porro quae odio.", "Providencishire", 2, 576.64m, "Practical Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 34,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2017, 12, 31, 1, 18, 55, 613, DateTimeKind.Unspecified).AddTicks(5393), "Quod non quo molestias corporis omnis ut. Aut molestias corrupti a porro ea quod. Rerum voluptatem possimus ab voluptatibus cupiditate architecto iure.", "Port Francescoberg", 1, 954.96m, "Rustic Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2016, 12, 15, 0, 59, 25, 812, DateTimeKind.Unspecified).AddTicks(3935), "Non sapiente fugiat deleniti dignissimos suscipit neque ipsam repellat. Perferendis illum eos in tempore quia aut sunt eius. Quia nihil dignissimos consectetur repellat est. Assumenda placeat nihil inventore non in reiciendis ea veritatis et.", "Kaleyville", 1, 908.10m, "Ergonomic Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 36,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2017, 11, 17, 14, 2, 4, 810, DateTimeKind.Unspecified).AddTicks(7696), "Et cupiditate dicta. Rerum odio aut sint facilis atque autem qui qui similique. Et et quam aut eius laborum velit. Aperiam doloremque unde magnam laboriosam dignissimos. Culpa iste ea nihil dolores ut aut labore excepturi.", "Desireemouth", 2, 279.85m, "Ergonomic Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 37,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2018, 3, 28, 7, 25, 8, 514, DateTimeKind.Unspecified).AddTicks(3542), "Alias numquam consequatur qui esse beatae ab. Laboriosam amet voluptas architecto et ut ut aperiam eligendi et. Dolorem error et nisi sapiente et et ea.", "East Alfonzo", 2, 745.51m, "Refined Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 38,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2017, 8, 18, 2, 42, 32, 453, DateTimeKind.Unspecified).AddTicks(4814), "Qui molestiae nostrum ipsum aliquid quos rem deleniti. Molestias possimus qui architecto. Autem voluptatibus explicabo accusamus voluptate eum dolores quisquam voluptas. Corporis dignissimos recusandae eum et voluptas saepe ipsa.", "Lake Russel", 1, 900.73m, "Gorgeous Soft Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 39,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2019, 5, 1, 1, 33, 47, 113, DateTimeKind.Unspecified).AddTicks(6443), "Voluptatum numquam tempore repellat accusamus voluptatem atque rem officia. Modi aspernatur nesciunt qui accusamus voluptates iste rerum reiciendis. Et porro vel ea aut voluptatum impedit ea aut.", "Schaeferton", 2, 547.11m, "Tasty Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 40,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2019, 6, 18, 0, 47, 20, 50, DateTimeKind.Unspecified).AddTicks(91), "Nihil blanditiis in dolores possimus quod est et vitae. A praesentium voluptatem neque omnis fugiat ipsam voluptatem reprehenderit est. Deserunt est beatae.", "South Cecileborough", 778.91m, "Rustic Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 41,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2018, 9, 16, 0, 48, 33, 487, DateTimeKind.Unspecified).AddTicks(7365), "Et eius minus voluptatem quos quibusdam accusantium eum deserunt. Dolorem rem aliquam blanditiis. Similique in quisquam fugiat aut et voluptas quia sunt suscipit. Rerum nostrum minima.", "Elsashire", 501.30m, "Small Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 42,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2019, 12, 28, 5, 54, 44, 856, DateTimeKind.Unspecified).AddTicks(9277), "Dolore sunt quia nisi rerum cupiditate soluta. Aut eius quis ea qui nemo sed perferendis. Est ea pariatur minus. Molestiae sint at ut tempora consequatur fugit. Maiores sunt eaque sit magnam possimus aut tempora ducimus error. Officia dolorem ducimus voluptatem laborum.", "Lake Tavaresfort", 499.74m, "Unbranded Concrete Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 43,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2015, 7, 16, 7, 21, 34, 555, DateTimeKind.Unspecified).AddTicks(472), "Repudiandae exercitationem tempore officia sed incidunt. Voluptatem ut inventore omnis. Recusandae labore quo qui. Eum deleniti eveniet et.", "Lakinton", 323.58m, "Fantastic Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 44,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2019, 6, 5, 4, 30, 31, 983, DateTimeKind.Unspecified).AddTicks(9935), "Id sed enim deserunt repellat delectus. Qui nostrum omnis nam. Expedita error nam reprehenderit.", "Lake Elvie", 166.34m, "Sleek Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 45,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2020, 4, 30, 17, 39, 41, 762, DateTimeKind.Unspecified).AddTicks(4312), "Suscipit tempora aut et. Distinctio adipisci cumque error asperiores ratione quam voluptatem. Tenetur qui voluptas. Nam nulla nihil totam id omnis et hic sapiente quos. Atque perferendis minus quia quasi atque et. Neque voluptatum repellat consequatur sapiente dolorem commodi animi saepe.", "Kemmerburgh", 850.83m, "Tasty Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 46,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2018, 9, 23, 23, 7, 56, 812, DateTimeKind.Unspecified).AddTicks(1471), "Quaerat porro optio nihil neque vitae. Esse dolore adipisci deserunt rerum suscipit cum deleniti libero voluptatum. Facilis autem tenetur aliquid quae non. Eligendi sed iure magni.", "West Lewisstad", 2, 386.01m, "Unbranded Soft Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 47,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2018, 12, 11, 3, 37, 31, 862, DateTimeKind.Unspecified).AddTicks(6731), "Est impedit voluptas voluptate. Enim ratione non voluptatum quaerat tempora aut. Et libero dolorem molestias totam perspiciatis. Veniam voluptatem pariatur reiciendis nemo hic assumenda.", "Gabriellafort", 663.23m, "Unbranded Frozen Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 48,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2018, 9, 1, 6, 46, 58, 579, DateTimeKind.Unspecified).AddTicks(5980), "Ut et velit placeat. Reprehenderit totam sint. Sunt magni nesciunt sit velit autem ut fuga eos et. Error et nihil. Nam mollitia voluptas quia cumque sed sit. Porro nostrum minima ut vitae enim.", "McDermottfort", 34.06m, "Licensed Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 49,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2016, 6, 27, 0, 4, 51, 425, DateTimeKind.Unspecified).AddTicks(7466), "Architecto voluptatum dolorem eligendi laborum assumenda qui rerum dicta. Veritatis nisi eius autem possimus et. Eaque et dignissimos illum aliquid aspernatur.", "East Justina", 2, 727.96m, "Licensed Plastic Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 50,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2020, 6, 12, 2, 21, 0, 487, DateTimeKind.Unspecified).AddTicks(2630), "Vero et voluptatem soluta. Non dignissimos amet enim occaecati dolores vel. Debitis qui non exercitationem est placeat quae quisquam autem perspiciatis. Vitae ipsa doloremque voluptatem architecto modi. Esse iure nam ut alias quam. Velit sint autem dolorem eum.", "Rowechester", 1, 751.72m, "Unbranded Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 51,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2020, 4, 8, 1, 10, 31, 406, DateTimeKind.Unspecified).AddTicks(1177), "Deleniti odit qui mollitia totam dolores. Fugit quae dicta. Molestiae enim aut. Temporibus itaque commodi fugiat tempore iste unde. Cum consequatur quis sed officia ad aliquam in labore. Quaerat nihil saepe quo omnis rerum quam.", "North Orrin", 1, 670.52m, "Handcrafted Plastic Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 52,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2019, 10, 5, 4, 57, 3, 276, DateTimeKind.Unspecified).AddTicks(3721), "Nisi aut pariatur non voluptatem voluptates. Dolor vel sed voluptas. Excepturi nulla eum ab omnis eligendi tenetur quia quam.", "West Joel", 769.94m, "Ergonomic Steel Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 53,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2016, 2, 19, 10, 28, 0, 273, DateTimeKind.Unspecified).AddTicks(1628), "Vitae saepe corrupti velit. Sunt non provident voluptas eaque quisquam. Maiores nesciunt fugiat praesentium. Eum blanditiis inventore vero architecto molestiae.", "Evangelineville", 204.56m, "Unbranded Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 54,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2019, 2, 25, 23, 34, 23, 974, DateTimeKind.Unspecified).AddTicks(7989), "Hic laboriosam quidem veritatis sed accusantium. Et vel cumque ullam repellendus a dolorem dolorum. Autem voluptatibus quia commodi consequatur ut. Quasi sit consequatur voluptatem vel et fugiat fuga harum. Minus aut sed facere quia suscipit.", "East Hellenmouth", 992.94m, "Small Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 55,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2016, 9, 26, 22, 55, 24, 621, DateTimeKind.Unspecified).AddTicks(6004), "Quis non quam. Perspiciatis similique qui placeat consequatur voluptatem modi perspiciatis architecto libero. Tempora veniam et cumque rem. Quia ratione qui quam et accusantium tenetur quia.", "Lake Kaylee", 427.64m, "Sleek Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 56,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2017, 4, 21, 18, 34, 5, 630, DateTimeKind.Unspecified).AddTicks(1966), "Officia accusantium hic velit consequatur sint autem. Sit blanditiis accusantium. Itaque laudantium adipisci veritatis.", "MacGyvermouth", 540.42m, "Licensed Rubber Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 57,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2015, 3, 31, 14, 35, 37, 709, DateTimeKind.Unspecified).AddTicks(5999), "Ipsum sint eum molestiae sint debitis. Voluptatem velit eum. Rerum et hic aut dolorem dolorem. Corrupti ab veritatis eos rem laboriosam. Facilis illum sapiente ullam ut provident necessitatibus ex ut.", "Brakuston", 101.35m, "Handcrafted Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 58,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2015, 2, 13, 0, 37, 20, 238, DateTimeKind.Unspecified).AddTicks(2763), "Necessitatibus qui cupiditate eveniet qui veniam et excepturi nisi. Dignissimos quae sunt. Inventore aspernatur at expedita pariatur cupiditate provident soluta sed.", "Lake Mohamedchester", 2, 429.10m, "Generic Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 59,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2019, 2, 1, 17, 15, 10, 147, DateTimeKind.Unspecified).AddTicks(2371), "Iusto in tenetur dolore voluptatem voluptas fuga et expedita accusantium. Temporibus alias nemo. Quia animi dolorum quia. Nihil occaecati ratione eos. Velit accusamus quia possimus nihil at fugit. Veritatis distinctio qui.", "Leathaburgh", 2, 692.21m, "Small Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 60,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2017, 7, 28, 13, 38, 36, 989, DateTimeKind.Unspecified).AddTicks(1944), "Eum et quam similique expedita. Nostrum sint aliquam explicabo nobis veritatis ut. Quae ut quia saepe cum. Facilis id molestias repellat ea harum voluptatem iure dolor esse.", "New Olinmouth", 2, 495.40m, "Handcrafted Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2017, 6, 10, 11, 25, 57, 601, DateTimeKind.Unspecified).AddTicks(9164), "Id sint velit quisquam. Enim odit iste qui aliquam atque optio sunt natus. Non voluptatem ea ut id quo. Inventore nostrum odio aut ex incidunt necessitatibus iusto sed ipsum. Ut ut vitae nesciunt voluptates reprehenderit sed quasi eos quia.", "West Roberto", 405.18m, "Rustic Rubber Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 62,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2018, 8, 28, 6, 12, 36, 945, DateTimeKind.Unspecified).AddTicks(2369), "Et vero voluptates veniam hic. Debitis nam eum eos ipsam quibusdam unde distinctio laboriosam illo. Aut repellendus libero.", "Murraychester", 5.04m, "Generic Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 63,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2018, 10, 27, 10, 55, 49, 284, DateTimeKind.Unspecified).AddTicks(6975), "Necessitatibus dolor dolore modi dolore. Odio sed adipisci velit itaque incidunt ut eaque. Rem labore sit quia voluptatem vitae nisi eum voluptatem. Et cum unde est. Pariatur eum sit perferendis. Consequatur velit fugit aut atque similique qui rem omnis eligendi.", "North Kenyon", 547.02m, "Handmade Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 64,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2017, 8, 5, 0, 9, 55, 296, DateTimeKind.Unspecified).AddTicks(4218), "Tempora illo nisi hic saepe sint ut aliquid omnis. A consequuntur atque. Consequuntur numquam quo. Dolores accusamus est voluptas porro officiis aut. Recusandae vel ab.", "Gabriellefort", 2, 363.21m, "Awesome Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 65,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2019, 4, 17, 13, 8, 6, 966, DateTimeKind.Unspecified).AddTicks(6903), "Molestiae qui ea architecto odio veritatis optio. Qui nulla tempora est cum. Eveniet laboriosam rem voluptas.", "McCulloughland", 300.05m, "Refined Metal Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 66,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2015, 1, 17, 15, 39, 35, 98, DateTimeKind.Unspecified).AddTicks(5211), "Corporis et molestiae commodi dolor amet enim quibusdam libero. Ut non totam vero qui et nobis iure veniam est. Est repellendus corrupti ut consequuntur nostrum est et cum voluptatem.", "Fadelfort", 1, 540.71m, "Incredible Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 67,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2015, 5, 20, 13, 58, 45, 763, DateTimeKind.Unspecified).AddTicks(9909), "Hic ut fuga fugiat. Sed aut vitae non deserunt suscipit omnis laborum sed earum. Ab saepe officia. Doloribus autem quam nemo quidem voluptatem qui assumenda quis vel. Cumque voluptatem excepturi quo eos est exercitationem.", "East Rachael", 1, 596.84m, "Generic Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 68,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2016, 6, 23, 3, 29, 25, 405, DateTimeKind.Unspecified).AddTicks(1833), "A illum iusto dolor amet. Non voluptatem adipisci tempore. Sit impedit voluptatem sit quidem dignissimos aspernatur veniam. Nostrum facere mollitia in vitae qui ipsum consectetur quam.", "Gissellestad", 1, 413.90m, "Ergonomic Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 69,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2016, 3, 25, 18, 11, 33, 226, DateTimeKind.Unspecified).AddTicks(3273), "Ea aut fuga rem. Rerum rem quia magnam fuga dolorem. Omnis consequatur sed modi eaque cumque autem maiores id ut. Veniam aspernatur et quidem qui ut autem. Est animi deserunt necessitatibus et ut non laborum molestias optio.", "Cummingsside", 565.94m, "Handcrafted Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2016, 4, 12, 22, 26, 23, 939, DateTimeKind.Unspecified).AddTicks(8035), "Optio voluptatum et deleniti nisi quis omnis. Maxime earum debitis porro. Voluptatem sapiente fugit. Magnam odit dicta veniam quis facere minus. Porro ea inventore sunt molestias minus ratione quasi. Et fugit iure ipsum.", "Keelyton", 260.47m, "Tasty Steel Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2016, 8, 17, 13, 7, 39, 237, DateTimeKind.Unspecified).AddTicks(630), "Libero minima sed placeat magnam voluptate quisquam assumenda et et. Quos cum labore quia qui facilis illum velit nulla est. Et unde doloremque accusantium suscipit quo. Qui quia voluptatem neque dolorum voluptas. Accusantium quia voluptatibus dolores qui dolorum. Repellat deserunt error qui quo.", "Mannstad", 692.16m, "Tasty Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 72,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2015, 2, 4, 8, 27, 33, 716, DateTimeKind.Unspecified).AddTicks(7688), "Quasi consequatur voluptas aliquid. Earum sit illo in facere cumque. Quo repudiandae qui odit aut. Tenetur laudantium odio fuga debitis officiis accusamus excepturi. Aut in unde.", "Klingstad", 2, 755.88m, "Practical Cotton Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 73,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2019, 1, 23, 18, 3, 2, 670, DateTimeKind.Unspecified).AddTicks(1624), "Ipsam beatae et quaerat vero ab animi. Minima voluptatem dolorum. Temporibus ducimus consequuntur qui atque.", "Torphyberg", 655.42m, "Refined Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 74,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2016, 10, 6, 10, 24, 56, 881, DateTimeKind.Unspecified).AddTicks(9202), "Asperiores inventore nemo tempora voluptates nemo et aut est. Consequatur excepturi minima enim dolor fugiat nisi ut. Quaerat voluptas provident distinctio omnis sit officiis totam consequuntur et.", "Oranmouth", 539.28m, "Incredible Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 75,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2016, 9, 25, 9, 10, 21, 127, DateTimeKind.Unspecified).AddTicks(4932), "Dignissimos officiis aliquam aut impedit. Culpa quia esse eum aut excepturi. Ut praesentium in perspiciatis non aperiam voluptas tempore qui.", "Port Irmashire", 2, 971.82m, "Tasty Soft Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 76,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2016, 7, 24, 1, 20, 42, 317, DateTimeKind.Unspecified).AddTicks(3717), "Expedita voluptate aut nemo et necessitatibus. Sed voluptatem nam ab id laboriosam dolorem error est qui. Ullam expedita ab et autem iusto id ea mollitia. Saepe architecto voluptatem cum accusamus. Aut doloribus distinctio ut sed hic quisquam. Et numquam qui ut.", "Carlottaberg", 747.79m, "Sleek Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 77,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2015, 10, 16, 7, 56, 43, 11, DateTimeKind.Unspecified).AddTicks(309), "Sunt aspernatur nostrum mollitia nemo beatae. Quis accusamus assumenda voluptatem in aut sint nemo. Recusandae vero debitis nesciunt eaque.", "Olaview", 108.06m, "Rustic Rubber Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 78,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2019, 1, 29, 15, 36, 10, 303, DateTimeKind.Unspecified).AddTicks(1969), "Non sit odio distinctio quia rerum voluptas sunt voluptatem commodi. Eos cum quidem similique earum amet nisi quos reiciendis. Voluptate et voluptas at corrupti nesciunt quos officiis incidunt. Perspiciatis quasi et eveniet qui. Est vel ut aperiam officia sit eos et corporis. Excepturi sit eum tenetur dolore qui.", "Boganfort", 265.98m, "Ergonomic Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 79,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2015, 4, 18, 11, 48, 0, 207, DateTimeKind.Unspecified).AddTicks(1074), "Voluptatem et inventore. Voluptatibus architecto dolores non occaecati earum quis reprehenderit. Nihil omnis inventore est voluptatum ipsa minima doloremque illum aspernatur. Explicabo voluptatem possimus rerum dolor et nobis. Tempora illo qui ut quis omnis eaque possimus praesentium porro. Doloremque quibusdam esse suscipit.", "Deonmouth", 80.34m, "Refined Metal Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 80,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2019, 10, 16, 3, 28, 29, 520, DateTimeKind.Unspecified).AddTicks(1245), "Distinctio ipsam laborum aliquid ad quaerat in neque. Quo ipsam nobis accusamus iusto quis illum ipsam est. Minus soluta maiores. Harum id dolorem. Incidunt quo alias beatae enim nulla dolores autem odio.", "Hillsside", 2, 771.87m, "Fantastic Concrete Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 81,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2017, 12, 7, 0, 30, 31, 745, DateTimeKind.Unspecified).AddTicks(4025), "Consequatur eligendi id eveniet saepe autem. Cum magnam reiciendis maxime aut ducimus dolorem qui officiis possimus. Voluptas id inventore.", "Wittingside", 2, 674.76m, "Incredible Plastic Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 82,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2016, 10, 26, 12, 13, 39, 619, DateTimeKind.Unspecified).AddTicks(9848), "Consequatur et sit voluptatem sit vel ab ipsum cumque consectetur. Dolorum qui quia incidunt et officia explicabo saepe ab. Vel occaecati quisquam autem modi deserunt. Provident sequi eaque veniam aperiam sequi. Corporis et est.", "Mandyfort", 2, 566.32m, "Fantastic Metal Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 83,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2018, 6, 19, 20, 20, 45, 291, DateTimeKind.Unspecified).AddTicks(7725), "Recusandae sed et nam corrupti doloribus nisi ullam. A repellendus deserunt quidem unde sequi. Officia libero et non quis voluptatibus occaecati.", "East Sunnytown", 860.37m, "Generic Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 84,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2015, 11, 8, 10, 41, 9, 258, DateTimeKind.Unspecified).AddTicks(4323), "Atque quis libero sunt a dolores eos et aut velit. Vel molestias occaecati minus sit minus quia quaerat tenetur mollitia. Ea culpa ut atque cum alias officia.", "East Muhammadborough", 1, 235.16m, "Ergonomic Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 85,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2016, 6, 3, 4, 55, 26, 257, DateTimeKind.Unspecified).AddTicks(3954), "Nisi veritatis reiciendis non ex aut minus amet aut dolor. Enim quia voluptates delectus dicta quia rem blanditiis. Accusantium porro sapiente adipisci. Enim quam sint sit culpa quia. Aut eligendi tempora. Id omnis magni in enim.", "East Andreane", 88.70m, "Small Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 86,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2018, 2, 7, 11, 0, 16, 212, DateTimeKind.Unspecified).AddTicks(8062), "Impedit debitis et aspernatur repellendus est vitae nobis eius. Ullam aut fuga. Et nobis fuga deleniti. Nisi debitis et fuga et.", "Breitenbergview", 1, 359.66m, "Intelligent Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2019, 7, 31, 10, 36, 1, 739, DateTimeKind.Unspecified).AddTicks(235), "Mollitia dolore qui aperiam ab saepe ab in voluptatibus. Laudantium eveniet veniam. Et iusto nam nesciunt ut voluptas magnam. Adipisci cum exercitationem est.", "Port Myriam", 1, 748.45m, "Gorgeous Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 88,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2019, 3, 12, 15, 40, 7, 685, DateTimeKind.Unspecified).AddTicks(5083), "Nostrum maiores vel tempora qui. Facilis provident architecto est harum eum rerum unde suscipit. Natus in ab qui quod voluptas odio. Distinctio ut illum. Eos totam quam.", "Lake Eunice", 864.71m, "Unbranded Steel Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 89,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2018, 8, 26, 4, 47, 5, 577, DateTimeKind.Unspecified).AddTicks(3482), "Qui quia voluptates eos porro ab sed aliquam. Voluptas sint qui delectus unde quisquam error numquam. Error qui est corporis vel illo unde nobis quam non. Et cum aut reiciendis soluta impedit est. Quis aut doloremque itaque numquam id molestiae voluptatem facere. Quis enim laudantium provident autem totam quis eaque molestiae earum.", "Halvorsontown", 2, 630.45m, "Handcrafted Metal Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 90,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2017, 12, 7, 19, 12, 38, 746, DateTimeKind.Unspecified).AddTicks(9654), "Hic consequatur nulla eveniet sed blanditiis qui error blanditiis. Autem repellendus ab eius quasi quia ullam rerum est. Minima eum eveniet inventore quasi in voluptatem quos. Ad at ratione laborum provident commodi et est.", "Port Tanya", 2, 644.78m, "Refined Granite Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 91,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2016, 5, 10, 13, 28, 38, 807, DateTimeKind.Unspecified).AddTicks(6382), "Et aliquid assumenda alias est iste sed repudiandae. Eum eos consectetur ut vero dolor itaque est quia. Vero quam iusto qui nihil optio asperiores. Laboriosam fugiat provident dolorem illum vel.", "Schmittside", 86.01m, "Rustic Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2019, 3, 28, 19, 53, 7, 24, DateTimeKind.Unspecified).AddTicks(3068), "Quisquam quod consequatur nemo consequuntur officiis quasi veritatis mollitia. Rem non veritatis nemo. Eos dolor beatae aliquam alias quia vel inventore. Aliquam at quas. Perspiciatis et soluta sed.", "Port Wernerberg", 1, 412.17m, "Small Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 93,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2019, 12, 30, 10, 43, 29, 678, DateTimeKind.Unspecified).AddTicks(3764), "Qui voluptatem quo enim fugiat. Distinctio est est rem laboriosam nobis. Illo enim quis vero occaecati reiciendis unde recusandae ea voluptatem. In qui facere consequatur mollitia. Similique neque dignissimos est.", "Simonisfurt", 904.00m, "Handmade Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 94,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2020, 3, 8, 7, 14, 11, 513, DateTimeKind.Unspecified).AddTicks(4685), "Praesentium aut iusto quis eveniet incidunt labore. In eaque officiis. Voluptates odit impedit nostrum illo in ut. Labore tempora velit dignissimos. Tenetur vel qui cupiditate ipsa fugiat impedit eligendi.", "Gleichnermouth", 933.13m, "Incredible Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2018, 6, 9, 8, 37, 25, 662, DateTimeKind.Unspecified).AddTicks(8425), "Sequi asperiores animi ducimus qui quo quia ut praesentium sit. Omnis asperiores culpa rerum. Esse perspiciatis ex quia dolorem illum. Voluptas recusandae ea. Ab similique aliquam et ut vel corrupti omnis. Non autem quibusdam quia impedit dolorem ut et aperiam repellat.", "Rempelbury", 1, 918.49m, "Sleek Fresh Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 96,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2017, 5, 28, 17, 32, 41, 2, DateTimeKind.Unspecified).AddTicks(8130), "Excepturi quis explicabo architecto aut quia laudantium suscipit in. Accusantium doloribus quia eaque maxime ratione dolores. Qui culpa aut itaque quam perferendis est est maxime doloremque. Assumenda cumque numquam ipsa qui et nihil fugit quidem adipisci. Aperiam optio mollitia. Nihil velit quo totam dicta dolorem.", "Lake Nicklausborough", 954.95m, "Awesome Frozen Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 97,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2015, 3, 17, 19, 37, 58, 660, DateTimeKind.Unspecified).AddTicks(9736), "Harum aut consequatur rerum facere quia. Aperiam eos et iste perspiciatis. Laboriosam voluptatibus enim. Recusandae minima rerum odit.", "Taniaview", 2, 707.53m, "Sleek Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 98,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2015, 1, 23, 13, 58, 49, 350, DateTimeKind.Unspecified).AddTicks(4295), "Exercitationem delectus harum saepe totam a nostrum. Temporibus aliquam maiores velit autem nulla labore ut voluptas. Iure dolor quos ullam. Saepe ut labore quaerat necessitatibus pariatur repellat expedita non maiores. Vel quis aliquid esse voluptas reiciendis doloribus dolor ipsam qui.", "Gislasonside", 649.59m, "Small Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 99,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2019, 1, 25, 11, 21, 52, 571, DateTimeKind.Unspecified).AddTicks(4754), "Maiores quod unde tempora cumque ea sint autem animi illo. Pariatur aperiam et dolorum. Molestiae velit consectetur enim maiores.", "Vitaton", 1, 324.16m, "Generic Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 100,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2020, 7, 28, 4, 40, 12, 10, DateTimeKind.Unspecified).AddTicks(2577), "Qui iure laborum accusamus ut minima qui voluptatem occaecati. Accusamus illo et et sit aut molestiae culpa quasi. Quibusdam consequatur in est. Et sunt natus similique quasi a. Est perferendis non deleniti consequatur deleniti necessitatibus.", "New Ameliaview", 792.56m, "Ergonomic Steel Ball" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "PhoneNumber", "UserName" },
                values: new object[] { "4ba07e7c-3728-4d8f-96ba-a1219be8e241", "Rochelle_Predovic@yahoo.com", "Predovic", "1-286-472-6494 x65848", "Rochelle_Predovic" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "PhoneNumber", "UserName" },
                values: new object[] { "b60857bc-5cef-40ac-b54b-d0c51e86c2b0", "Constance_Stamm77@hotmail.com", "Stamm", "1-937-853-3576 x01641", "Constance.Stamm" });

            migrationBuilder.AddForeignKey(
                name: "FK_RentedAd_Ads_AdId",
                table: "RentedAd",
                column: "AdId",
                principalTable: "Ads",
                principalColumn: "AdId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentedAd_AspNetUsers_RentedAdUserId",
                table: "RentedAd",
                column: "RentedAdUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
