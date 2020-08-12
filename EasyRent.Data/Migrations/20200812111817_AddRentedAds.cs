using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EasyRent.Data.Migrations
{
    public partial class AddRentedAds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RentedAd",
                columns: table => new
                {
                    RentedAdId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RentedAdUserId = table.Column<int>(nullable: false),
                    AdId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentedAd", x => x.RentedAdId);
                    table.ForeignKey(
                        name: "FK_RentedAd_Ads_AdId",
                        column: x => x.AdId,
                        principalTable: "Ads",
                        principalColumn: "AdId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentedAd_AspNetUsers_RentedAdUserId",
                        column: x => x.RentedAdUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2019, 2, 15, 10, 23, 6, 285, DateTimeKind.Unspecified).AddTicks(2106), "Distinctio quas voluptatem perferendis. Reiciendis voluptate voluptatem vero delectus quia repudiandae minus dolores. Qui quis et velit occaecati omnis in occaecati. Distinctio aut et et enim in vel quibusdam soluta. Rerum quia perspiciatis error dolore ea est.", "Hagenesburgh", 9.73m, "Practical Soft Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 3,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2016, 3, 12, 19, 45, 21, 317, DateTimeKind.Unspecified).AddTicks(9095), "Voluptatem quam voluptatem maiores adipisci aliquid eos architecto. Placeat minima officia velit ut neque. Corrupti eaque aut cum voluptas autem doloribus. Non illum quia. Dolor amet voluptas atque.", "Caramouth", 153.31m, "Generic Concrete Pants" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2016, 2, 26, 5, 36, 10, 924, DateTimeKind.Unspecified).AddTicks(6835), "Vel sint et a. Ut facilis natus iusto aut minima maiores. Veritatis ipsum quia. Velit non exercitationem et veniam cum accusamus nostrum.", "East Ashley", 342.17m, "Licensed Wooden Chair" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2017, 7, 29, 23, 31, 17, 743, DateTimeKind.Unspecified).AddTicks(662), "Commodi quibusdam itaque vel esse et. Et quo natus aut fuga ullam assumenda tempora aliquid asperiores. Sint alias est quasi debitis magni est ducimus aut. Voluptatem omnis a laborum illo dolor sed.", "Brigitteborough", 2, 529.19m, "Sleek Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 10,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2016, 11, 9, 22, 43, 59, 876, DateTimeKind.Unspecified).AddTicks(7558), "Voluptatibus voluptate accusantium voluptatem molestias dolore. Est exercitationem sint aut. Delectus consequatur enim. Recusandae animi ea similique occaecati similique perspiciatis. Harum quaerat velit reprehenderit. Laborum iure similique a voluptatem dolorem quia labore.", "Kleinborough", 2, 803.56m, "Ergonomic Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 11,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2017, 1, 18, 23, 29, 40, 245, DateTimeKind.Unspecified).AddTicks(2877), "Dolores cupiditate necessitatibus sed dolore. Esse eos vel iure magnam quo vero eaque soluta provident. Vitae rerum maiores dolores. Dolor voluptatem asperiores voluptas molestiae. Dolor aut ipsam optio quo sunt sequi dicta.", "West Melody", 2, 119.46m, "Fantastic Plastic Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 12,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2020, 5, 19, 19, 17, 25, 434, DateTimeKind.Unspecified).AddTicks(5876), "Tempora ut sunt. Et quo neque adipisci. Quod non deleniti deleniti facere. Non architecto omnis. Assumenda aut mollitia aperiam. Autem dolorem in qui debitis vel hic totam qui quis.", "South Patricia", 2, 79.80m, "Ergonomic Frozen Sausages" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2016, 2, 27, 19, 35, 49, 599, DateTimeKind.Unspecified).AddTicks(2130), "Tempore aut voluptates molestias sit similique. Sit ut voluptatem veniam rerum ipsam ipsam in et. Debitis doloremque tempora quia et ipsam hic.", "West Arnoldport", 684.32m, "Generic Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2020, 3, 25, 16, 56, 49, 649, DateTimeKind.Unspecified).AddTicks(8685), "Fugiat cupiditate repellendus occaecati asperiores repellat quasi. Eos est dolor qui tenetur facilis rerum ut dolor consequatur. Eligendi a atque facere atque minima et et dignissimos. Et voluptas in perferendis doloremque maxime aliquid. Impedit magni et dolore.", "Townefort", 1, 904.88m, "Fantastic Soft Chips" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2015, 4, 2, 22, 21, 15, 327, DateTimeKind.Unspecified).AddTicks(6284), "Quas tenetur porro id id quidem qui. Voluptate aut minima eligendi a non. Et et officiis. Est soluta quidem maxime eius voluptatem et est excepturi sapiente. Voluptatem ea dolore aliquam mollitia odio. Facere voluptatem dolorem animi corporis aliquid.", "Kilbackstad", 770.54m, "Intelligent Frozen Chair" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2019, 10, 19, 22, 10, 59, 492, DateTimeKind.Unspecified).AddTicks(8912), "Sit quasi veniam voluptatem eum qui perspiciatis. Eos et culpa quam est. Natus voluptatum quibusdam voluptatum voluptatum doloribus rem praesentium quia sed.", "East Leda", 1, 47.46m, "Sleek Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 22,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2017, 1, 6, 15, 38, 16, 133, DateTimeKind.Unspecified).AddTicks(1934), "Amet adipisci fugit. Quia eos pariatur aut ratione. Quia consequatur consequatur quod quos voluptate tenetur odit aspernatur. Maxime vitae debitis culpa ut dolores facere ullam.", "Lake Mireyaport", 2, 591.37m, "Sleek Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 23,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2015, 8, 8, 12, 21, 42, 338, DateTimeKind.Unspecified).AddTicks(705), "Odio illo et ipsa ut ipsa assumenda. Dicta ut deserunt aut dolorum. Odit voluptatem sed possimus eum. Unde debitis nihil sunt est omnis.", "Ivahhaven", 47.54m, "Licensed Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2015, 6, 9, 8, 0, 59, 894, DateTimeKind.Unspecified).AddTicks(8718), "Corporis blanditiis maiores tenetur sint dolorem magni. Ut dolorem amet veniam qui quam. Tenetur et error harum ut aliquid praesentium cupiditate voluptatem.", "North Bobby", 1, 152.56m, "Incredible Granite Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 25,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2018, 2, 13, 0, 4, 36, 159, DateTimeKind.Unspecified).AddTicks(1536), "Qui deserunt a mollitia a. Aut ut ut est modi. Animi consequatur ipsa quod qui. Sit voluptas recusandae nam et debitis nihil reiciendis.", "South Candidoland", 214.28m, "Licensed Frozen Shoes" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2016, 8, 11, 11, 55, 45, 550, DateTimeKind.Unspecified).AddTicks(3813), "Sequi labore et. Ut tempore cupiditate voluptas laborum blanditiis est eum est. In facere facere eveniet a rerum deleniti eius. Recusandae nihil saepe voluptatem rerum nisi qui dolorem. Alias aut cum vero alias perspiciatis minus ut.", "Waltonchester", 964.40m, "Handmade Rubber Hat" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2017, 8, 7, 17, 3, 21, 838, DateTimeKind.Unspecified).AddTicks(9712), "Cumque enim et omnis quod sit aperiam. Est itaque aut omnis. Sit et eius et veniam qui voluptas doloremque sapiente maxime. Ipsa iusto omnis quibusdam. Fuga et laborum deserunt non non officiis. Aperiam voluptatem iure porro quae odio.", "Providencishire", 576.64m, "Practical Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2017, 12, 31, 1, 18, 55, 613, DateTimeKind.Unspecified).AddTicks(5393), "Quod non quo molestias corporis omnis ut. Aut molestias corrupti a porro ea quod. Rerum voluptatem possimus ab voluptatibus cupiditate architecto iure.", "Port Francescoberg", 1, 954.96m, "Rustic Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 35,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2016, 12, 15, 0, 59, 25, 812, DateTimeKind.Unspecified).AddTicks(3935), "Non sapiente fugiat deleniti dignissimos suscipit neque ipsam repellat. Perferendis illum eos in tempore quia aut sunt eius. Quia nihil dignissimos consectetur repellat est. Assumenda placeat nihil inventore non in reiciendis ea veritatis et.", "Kaleyville", 908.10m, "Ergonomic Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 36,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2017, 11, 17, 14, 2, 4, 810, DateTimeKind.Unspecified).AddTicks(7696), "Et cupiditate dicta. Rerum odio aut sint facilis atque autem qui qui similique. Et et quam aut eius laborum velit. Aperiam doloremque unde magnam laboriosam dignissimos. Culpa iste ea nihil dolores ut aut labore excepturi.", "Desireemouth", 279.85m, "Ergonomic Soft Bacon" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2017, 8, 18, 2, 42, 32, 453, DateTimeKind.Unspecified).AddTicks(4814), "Qui molestiae nostrum ipsum aliquid quos rem deleniti. Molestias possimus qui architecto. Autem voluptatibus explicabo accusamus voluptate eum dolores quisquam voluptas. Corporis dignissimos recusandae eum et voluptas saepe ipsa.", "Lake Russel", 900.73m, "Gorgeous Soft Chips" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2019, 6, 18, 0, 47, 20, 50, DateTimeKind.Unspecified).AddTicks(91), "Nihil blanditiis in dolores possimus quod est et vitae. A praesentium voluptatem neque omnis fugiat ipsam voluptatem reprehenderit est. Deserunt est beatae.", "South Cecileborough", 1, 778.91m, "Rustic Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 41,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2018, 9, 16, 0, 48, 33, 487, DateTimeKind.Unspecified).AddTicks(7365), "Et eius minus voluptatem quos quibusdam accusantium eum deserunt. Dolorem rem aliquam blanditiis. Similique in quisquam fugiat aut et voluptas quia sunt suscipit. Rerum nostrum minima.", "Elsashire", 2, 501.30m, "Small Cotton Bacon" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2019, 6, 5, 4, 30, 31, 983, DateTimeKind.Unspecified).AddTicks(9935), "Id sed enim deserunt repellat delectus. Qui nostrum omnis nam. Expedita error nam reprehenderit.", "Lake Elvie", 1, 166.34m, "Sleek Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 45,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2020, 4, 30, 17, 39, 41, 762, DateTimeKind.Unspecified).AddTicks(4312), "Suscipit tempora aut et. Distinctio adipisci cumque error asperiores ratione quam voluptatem. Tenetur qui voluptas. Nam nulla nihil totam id omnis et hic sapiente quos. Atque perferendis minus quia quasi atque et. Neque voluptatum repellat consequatur sapiente dolorem commodi animi saepe.", "Kemmerburgh", 2, 850.83m, "Tasty Rubber Soap" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2018, 12, 11, 3, 37, 31, 862, DateTimeKind.Unspecified).AddTicks(6731), "Est impedit voluptas voluptate. Enim ratione non voluptatum quaerat tempora aut. Et libero dolorem molestias totam perspiciatis. Veniam voluptatem pariatur reiciendis nemo hic assumenda.", "Gabriellafort", 2, 663.23m, "Unbranded Frozen Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 48,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2018, 9, 1, 6, 46, 58, 579, DateTimeKind.Unspecified).AddTicks(5980), "Ut et velit placeat. Reprehenderit totam sint. Sunt magni nesciunt sit velit autem ut fuga eos et. Error et nihil. Nam mollitia voluptas quia cumque sed sit. Porro nostrum minima ut vitae enim.", "McDermottfort", 2, 34.06m, "Licensed Rubber Bike" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2020, 4, 8, 1, 10, 31, 406, DateTimeKind.Unspecified).AddTicks(1177), "Deleniti odit qui mollitia totam dolores. Fugit quae dicta. Molestiae enim aut. Temporibus itaque commodi fugiat tempore iste unde. Cum consequatur quis sed officia ad aliquam in labore. Quaerat nihil saepe quo omnis rerum quam.", "North Orrin", 670.52m, "Handcrafted Plastic Table" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2016, 9, 26, 22, 55, 24, 621, DateTimeKind.Unspecified).AddTicks(6004), "Quis non quam. Perspiciatis similique qui placeat consequatur voluptatem modi perspiciatis architecto libero. Tempora veniam et cumque rem. Quia ratione qui quam et accusantium tenetur quia.", "Lake Kaylee", 2, 427.64m, "Sleek Concrete Mouse" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2015, 3, 31, 14, 35, 37, 709, DateTimeKind.Unspecified).AddTicks(5999), "Ipsum sint eum molestiae sint debitis. Voluptatem velit eum. Rerum et hic aut dolorem dolorem. Corrupti ab veritatis eos rem laboriosam. Facilis illum sapiente ullam ut provident necessitatibus ex ut.", "Brakuston", 1, 101.35m, "Handcrafted Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 58,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2015, 2, 13, 0, 37, 20, 238, DateTimeKind.Unspecified).AddTicks(2763), "Necessitatibus qui cupiditate eveniet qui veniam et excepturi nisi. Dignissimos quae sunt. Inventore aspernatur at expedita pariatur cupiditate provident soluta sed.", "Lake Mohamedchester", 429.10m, "Generic Steel Ball" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2017, 6, 10, 11, 25, 57, 601, DateTimeKind.Unspecified).AddTicks(9164), "Id sint velit quisquam. Enim odit iste qui aliquam atque optio sunt natus. Non voluptatem ea ut id quo. Inventore nostrum odio aut ex incidunt necessitatibus iusto sed ipsum. Ut ut vitae nesciunt voluptates reprehenderit sed quasi eos quia.", "West Roberto", 405.18m, "Rustic Rubber Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 62,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2018, 8, 28, 6, 12, 36, 945, DateTimeKind.Unspecified).AddTicks(2369), "Et vero voluptates veniam hic. Debitis nam eum eos ipsam quibusdam unde distinctio laboriosam illo. Aut repellendus libero.", "Murraychester", 1, 5.04m, "Generic Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 63,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2018, 10, 27, 10, 55, 49, 284, DateTimeKind.Unspecified).AddTicks(6975), "Necessitatibus dolor dolore modi dolore. Odio sed adipisci velit itaque incidunt ut eaque. Rem labore sit quia voluptatem vitae nisi eum voluptatem. Et cum unde est. Pariatur eum sit perferendis. Consequatur velit fugit aut atque similique qui rem omnis eligendi.", "North Kenyon", 1, 547.02m, "Handmade Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 64,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2017, 8, 5, 0, 9, 55, 296, DateTimeKind.Unspecified).AddTicks(4218), "Tempora illo nisi hic saepe sint ut aliquid omnis. A consequuntur atque. Consequuntur numquam quo. Dolores accusamus est voluptas porro officiis aut. Recusandae vel ab.", "Gabriellefort", 363.21m, "Awesome Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 65,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2019, 4, 17, 13, 8, 6, 966, DateTimeKind.Unspecified).AddTicks(6903), "Molestiae qui ea architecto odio veritatis optio. Qui nulla tempora est cum. Eveniet laboriosam rem voluptas.", "McCulloughland", 2, 300.05m, "Refined Metal Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 66,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2015, 1, 17, 15, 39, 35, 98, DateTimeKind.Unspecified).AddTicks(5211), "Corporis et molestiae commodi dolor amet enim quibusdam libero. Ut non totam vero qui et nobis iure veniam est. Est repellendus corrupti ut consequuntur nostrum est et cum voluptatem.", "Fadelfort", 540.71m, "Incredible Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 67,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2015, 5, 20, 13, 58, 45, 763, DateTimeKind.Unspecified).AddTicks(9909), "Hic ut fuga fugiat. Sed aut vitae non deserunt suscipit omnis laborum sed earum. Ab saepe officia. Doloribus autem quam nemo quidem voluptatem qui assumenda quis vel. Cumque voluptatem excepturi quo eos est exercitationem.", "East Rachael", 596.84m, "Generic Concrete Salad" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2016, 4, 12, 22, 26, 23, 939, DateTimeKind.Unspecified).AddTicks(8035), "Optio voluptatum et deleniti nisi quis omnis. Maxime earum debitis porro. Voluptatem sapiente fugit. Magnam odit dicta veniam quis facere minus. Porro ea inventore sunt molestias minus ratione quasi. Et fugit iure ipsum.", "Keelyton", 1, 260.47m, "Tasty Steel Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 71,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2016, 8, 17, 13, 7, 39, 237, DateTimeKind.Unspecified).AddTicks(630), "Libero minima sed placeat magnam voluptate quisquam assumenda et et. Quos cum labore quia qui facilis illum velit nulla est. Et unde doloremque accusantium suscipit quo. Qui quia voluptatem neque dolorum voluptas. Accusantium quia voluptatibus dolores qui dolorum. Repellat deserunt error qui quo.", "Mannstad", 2, 692.16m, "Tasty Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 72,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2015, 2, 4, 8, 27, 33, 716, DateTimeKind.Unspecified).AddTicks(7688), "Quasi consequatur voluptas aliquid. Earum sit illo in facere cumque. Quo repudiandae qui odit aut. Tenetur laudantium odio fuga debitis officiis accusamus excepturi. Aut in unde.", "Klingstad", 755.88m, "Practical Cotton Gloves" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2016, 10, 6, 10, 24, 56, 881, DateTimeKind.Unspecified).AddTicks(9202), "Asperiores inventore nemo tempora voluptates nemo et aut est. Consequatur excepturi minima enim dolor fugiat nisi ut. Quaerat voluptas provident distinctio omnis sit officiis totam consequuntur et.", "Oranmouth", 2, 539.28m, "Incredible Plastic Chips" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2016, 7, 24, 1, 20, 42, 317, DateTimeKind.Unspecified).AddTicks(3717), "Expedita voluptate aut nemo et necessitatibus. Sed voluptatem nam ab id laboriosam dolorem error est qui. Ullam expedita ab et autem iusto id ea mollitia. Saepe architecto voluptatem cum accusamus. Aut doloribus distinctio ut sed hic quisquam. Et numquam qui ut.", "Carlottaberg", 2, 747.79m, "Sleek Concrete Hat" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2019, 10, 16, 3, 28, 29, 520, DateTimeKind.Unspecified).AddTicks(1245), "Distinctio ipsam laborum aliquid ad quaerat in neque. Quo ipsam nobis accusamus iusto quis illum ipsam est. Minus soluta maiores. Harum id dolorem. Incidunt quo alias beatae enim nulla dolores autem odio.", "Hillsside", 771.87m, "Fantastic Concrete Shoes" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2015, 11, 8, 10, 41, 9, 258, DateTimeKind.Unspecified).AddTicks(4323), "Atque quis libero sunt a dolores eos et aut velit. Vel molestias occaecati minus sit minus quia quaerat tenetur mollitia. Ea culpa ut atque cum alias officia.", "East Muhammadborough", 235.16m, "Ergonomic Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 85,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2016, 6, 3, 4, 55, 26, 257, DateTimeKind.Unspecified).AddTicks(3954), "Nisi veritatis reiciendis non ex aut minus amet aut dolor. Enim quia voluptates delectus dicta quia rem blanditiis. Accusantium porro sapiente adipisci. Enim quam sint sit culpa quia. Aut eligendi tempora. Id omnis magni in enim.", "East Andreane", 1, 88.70m, "Small Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2018, 2, 7, 11, 0, 16, 212, DateTimeKind.Unspecified).AddTicks(8062), "Impedit debitis et aspernatur repellendus est vitae nobis eius. Ullam aut fuga. Et nobis fuga deleniti. Nisi debitis et fuga et.", "Breitenbergview", 359.66m, "Intelligent Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2019, 7, 31, 10, 36, 1, 739, DateTimeKind.Unspecified).AddTicks(235), "Mollitia dolore qui aperiam ab saepe ab in voluptatibus. Laudantium eveniet veniam. Et iusto nam nesciunt ut voluptas magnam. Adipisci cum exercitationem est.", "Port Myriam", 748.45m, "Gorgeous Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2019, 3, 12, 15, 40, 7, 685, DateTimeKind.Unspecified).AddTicks(5083), "Nostrum maiores vel tempora qui. Facilis provident architecto est harum eum rerum unde suscipit. Natus in ab qui quod voluptas odio. Distinctio ut illum. Eos totam quam.", "Lake Eunice", 1, 864.71m, "Unbranded Steel Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 89,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2018, 8, 26, 4, 47, 5, 577, DateTimeKind.Unspecified).AddTicks(3482), "Qui quia voluptates eos porro ab sed aliquam. Voluptas sint qui delectus unde quisquam error numquam. Error qui est corporis vel illo unde nobis quam non. Et cum aut reiciendis soluta impedit est. Quis aut doloremque itaque numquam id molestiae voluptatem facere. Quis enim laudantium provident autem totam quis eaque molestiae earum.", "Halvorsontown", 630.45m, "Handcrafted Metal Chair" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2016, 5, 10, 13, 28, 38, 807, DateTimeKind.Unspecified).AddTicks(6382), "Et aliquid assumenda alias est iste sed repudiandae. Eum eos consectetur ut vero dolor itaque est quia. Vero quam iusto qui nihil optio asperiores. Laboriosam fugiat provident dolorem illum vel.", "Schmittside", 2, 86.01m, "Rustic Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 92,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2019, 3, 28, 19, 53, 7, 24, DateTimeKind.Unspecified).AddTicks(3068), "Quisquam quod consequatur nemo consequuntur officiis quasi veritatis mollitia. Rem non veritatis nemo. Eos dolor beatae aliquam alias quia vel inventore. Aliquam at quas. Perspiciatis et soluta sed.", "Port Wernerberg", 412.17m, "Small Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 93,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2019, 12, 30, 10, 43, 29, 678, DateTimeKind.Unspecified).AddTicks(3764), "Qui voluptatem quo enim fugiat. Distinctio est est rem laboriosam nobis. Illo enim quis vero occaecati reiciendis unde recusandae ea voluptatem. In qui facere consequatur mollitia. Similique neque dignissimos est.", "Simonisfurt", 1, 904.00m, "Handmade Wooden Chair" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2018, 6, 9, 8, 37, 25, 662, DateTimeKind.Unspecified).AddTicks(8425), "Sequi asperiores animi ducimus qui quo quia ut praesentium sit. Omnis asperiores culpa rerum. Esse perspiciatis ex quia dolorem illum. Voluptas recusandae ea. Ab similique aliquam et ut vel corrupti omnis. Non autem quibusdam quia impedit dolorem ut et aperiam repellat.", "Rempelbury", 1, 918.49m, "Sleek Fresh Chips" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2015, 1, 23, 13, 58, 49, 350, DateTimeKind.Unspecified).AddTicks(4295), "Exercitationem delectus harum saepe totam a nostrum. Temporibus aliquam maiores velit autem nulla labore ut voluptas. Iure dolor quos ullam. Saepe ut labore quaerat necessitatibus pariatur repellat expedita non maiores. Vel quis aliquid esse voluptas reiciendis doloribus dolor ipsam qui.", "Gislasonside", 1, 649.59m, "Small Granite Ball" });

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

            migrationBuilder.CreateIndex(
                name: "IX_RentedAd_AdId",
                table: "RentedAd",
                column: "AdId");

            migrationBuilder.CreateIndex(
                name: "IX_RentedAd_RentedAdUserId",
                table: "RentedAd",
                column: "RentedAdUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RentedAd");

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 1,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2015, 4, 4, 20, 5, 10, 603, DateTimeKind.Unspecified).AddTicks(2855), "Earum aut ut. Voluptatibus reiciendis minus sed debitis ea et. Rerum dicta quo non molestias. Quae dignissimos eos magni qui nulla optio qui. Est et enim et expedita. Fuga sunt assumenda et vero laborum iure unde delectus cupiditate.", "New Josephine", 1, 404.31m, "Handcrafted Rubber Bacon" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2019, 6, 19, 9, 8, 4, 960, DateTimeKind.Unspecified).AddTicks(8340), "Sit quisquam voluptatibus optio voluptatem. Animi nihil iusto velit quidem quae accusantium tempora quis. Quia ipsum excepturi commodi qui est. Aperiam consectetur dolorum dolor at ipsa aut. Repellat nam quis atque dolorem doloribus saepe ipsa tempora.", "Bergnaumstad", 119.82m, "Unbranded Cotton Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 9,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2018, 4, 20, 11, 3, 48, 821, DateTimeKind.Unspecified).AddTicks(2617), "Velit ad dolorem sed consectetur hic molestias in. Placeat vel nihil iure quidem eum et maxime. Voluptatum et consequuntur. Qui beatae doloremque esse aut.", "Kiehnbury", 1, 588.34m, "Awesome Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 10,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2017, 8, 11, 5, 29, 9, 69, DateTimeKind.Unspecified).AddTicks(4688), "Ipsa eum facilis qui numquam nobis adipisci qui exercitationem perferendis. Ab qui sit doloremque animi quia debitis. Quas omnis nulla. A aliquam neque eum accusamus corporis ab asperiores. Quibusdam ratione et quae atque cumque. Qui quo nobis consequatur.", "Vandervortborough", 1, 445.77m, "Awesome Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 11,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2018, 4, 12, 6, 58, 33, 96, DateTimeKind.Unspecified).AddTicks(2918), "Velit libero nobis sit. At quia molestiae. Voluptatem dicta aliquam repellat. Voluptatibus sed quam optio eligendi libero explicabo.", "Port Amandaside", 1, 717.05m, "Incredible Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 12,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2018, 3, 16, 20, 52, 40, 132, DateTimeKind.Unspecified).AddTicks(9424), "Ut autem quibusdam quis consequuntur ut excepturi aliquam error facere. Vitae ducimus earum ut consequatur ipsa vel molestiae est. Neque minus quidem. Laboriosam omnis reiciendis id distinctio ut.", "Trompton", 1, 351.63m, "Generic Plastic Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 13,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2015, 7, 8, 19, 9, 20, 722, DateTimeKind.Unspecified).AddTicks(4701), "Sit modi quo enim ea aut. Ut nam eveniet culpa quo architecto. Neque a temporibus doloribus sed et ut numquam. Sit reprehenderit deserunt. Ab asperiores et ad dolorum enim eligendi unde velit sunt. Consectetur quia voluptatem.", "Port Saigeborough", 219.28m, "Gorgeous Frozen Keyboard" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2018, 7, 22, 6, 49, 39, 238, DateTimeKind.Unspecified).AddTicks(895), "Ea nihil et commodi quaerat nobis temporibus harum tenetur. Cumque qui et excepturi facilis sapiente molestias a voluptatum. Occaecati quos rem non quis. Possimus quia rerum. Et occaecati quam aspernatur corrupti adipisci qui facere maxime ea. Rerum corporis sed quos aut.", "East Titus", 490.62m, "Handmade Cotton Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2016, 11, 23, 18, 4, 4, 455, DateTimeKind.Unspecified).AddTicks(1702), "Doloribus velit non qui maxime doloribus ullam. Doloremque aut voluptatem qui. Facere numquam quasi molestiae in amet aliquid.", "West Malachiport", 2, 277.46m, "Fantastic Concrete Computer" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2019, 5, 6, 5, 43, 58, 254, DateTimeKind.Unspecified).AddTicks(5939), "Voluptatibus at architecto. Dolorem aut quasi dignissimos at. Et laudantium optio sed assumenda maiores numquam.", "Lebsackport", 1, 531.01m, "Fantastic Fresh Pants" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2015, 9, 2, 1, 22, 21, 547, DateTimeKind.Unspecified).AddTicks(6891), "Ad deserunt quam modi architecto commodi dolore. Odit occaecati porro placeat quisquam totam. Architecto est et esse dolore. Autem ea itaque molestiae reiciendis. Eos explicabo ex possimus iusto aut voluptatem. At dicta nesciunt pariatur adipisci.", "East Bryana", 2, 396.70m, "Intelligent Fresh Cheese" });

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
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2016, 2, 15, 5, 31, 26, 354, DateTimeKind.Unspecified).AddTicks(9647), "Ut molestiae facere vel harum. Et maxime sed. Quis fugiat earum pariatur natus. Eligendi unde qui eum porro vitae. Deleniti et fuga eos consequuntur sunt eaque quo voluptatem non. Explicabo atque voluptatem voluptas voluptatem nam sed repellat pariatur.", "Ramonside", 2, 292.49m, "Small Soft Towels" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2016, 6, 14, 20, 8, 8, 561, DateTimeKind.Unspecified).AddTicks(4647), "Deleniti voluptatibus suscipit quo tenetur odit id omnis cum. Veniam sed quia qui delectus. Illum nulla architecto voluptatem omnis excepturi nihil. Autem unde tempora beatae delectus qui perspiciatis minus quia.", "West Donnashire", 445.60m, "Tasty Fresh Shirt" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2015, 5, 16, 0, 58, 6, 112, DateTimeKind.Unspecified).AddTicks(6948), "Et in sed velit sunt dicta facere fuga. Quis nemo repellat quisquam est itaque inventore et. Iusto fuga saepe et consequuntur odio qui. Consequatur corrupti eaque sed sed ipsa quis vitae incidunt.", "North Laurynstad", 2, 884.14m, "Intelligent Rubber Shirt" });

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
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2016, 3, 13, 17, 40, 51, 140, DateTimeKind.Unspecified).AddTicks(5174), "Placeat cumque a ipsam molestiae quidem. Hic nobis sit pariatur accusamus recusandae magni et. A sapiente eos ipsam maxime ex ducimus tempore autem.", "Cristinafort", 2, 541.71m, "Gorgeous Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 35,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2017, 5, 13, 17, 50, 50, 853, DateTimeKind.Unspecified).AddTicks(8450), "Hic nesciunt aut. Ipsam rerum enim. Molestiae aspernatur qui consectetur placeat dignissimos eum.", "Lake Marquisbury", 255.35m, "Gorgeous Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 36,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2017, 8, 10, 10, 43, 59, 359, DateTimeKind.Unspecified).AddTicks(3903), "Sit expedita ut voluptate quo soluta consequatur aut voluptatibus veniam. Velit eos ratione qui deleniti architecto. Autem nulla voluptatem excepturi totam reiciendis voluptas eum. Perferendis nemo praesentium dolores et omnis iure adipisci ut.", "Reynoldsport", 69.39m, "Practical Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 37,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2015, 1, 5, 18, 14, 34, 753, DateTimeKind.Unspecified).AddTicks(2042), "Corrupti consequatur ut quaerat. Unde ut qui consectetur nostrum vitae rerum. Asperiores et occaecati ratione non eos placeat hic sit.", "Evangelineville", 1, 725.15m, "Fantastic Cotton Shoes" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 38,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2016, 5, 7, 14, 18, 19, 141, DateTimeKind.Unspecified).AddTicks(7068), "Cupiditate itaque aut debitis quis alias atque autem. Ut et officia. Odio vitae quas voluptatem. Quia consequatur consectetur corporis porro consequatur explicabo saepe. Blanditiis suscipit amet similique.", "Celestineland", 468.97m, "Awesome Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 39,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2017, 3, 22, 16, 4, 17, 407, DateTimeKind.Unspecified).AddTicks(256), "Aut est sunt. Ut commodi voluptatibus nobis asperiores modi. Excepturi modi eius odit dolor. Et doloremque eaque saepe ut repudiandae. Sunt aut occaecati explicabo quae corrupti.", "North Lessie", 1, 200.02m, "Generic Plastic Hat" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2017, 2, 16, 17, 4, 44, 300, DateTimeKind.Unspecified).AddTicks(5414), "Laudantium ut consequatur doloribus dolorem magnam rem et architecto natus. Minus modi est sint incidunt nulla nostrum. Eos qui facere vel natus.", "Gloverfurt", 1, 98.96m, "Ergonomic Fresh Chicken" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2018, 10, 13, 2, 11, 13, 558, DateTimeKind.Unspecified).AddTicks(6991), "Occaecati alias placeat quo quisquam dicta. Qui placeat ipsam. Ipsa non ducimus est ab minus ut ab quisquam sed. Voluptas delectus impedit odio placeat. Repellendus cupiditate at quis consequatur nemo accusamus. Culpa reiciendis ab aut commodi in.", "New Cristopher", 1, 424.84m, "Gorgeous Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 46,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2016, 1, 28, 0, 12, 8, 469, DateTimeKind.Unspecified).AddTicks(5776), "Necessitatibus voluptatem tempore. Consequuntur minima laboriosam voluptatum libero tempora laudantium culpa ut. Culpa et rem facere. Eaque ea dolores delectus. Facere veniam ratione architecto vel aut ut esse. Omnis quam est est quibusdam pariatur.", "Pacochahaven", 1, 733.50m, "Ergonomic Concrete Tuna" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2016, 7, 14, 1, 58, 19, 281, DateTimeKind.Unspecified).AddTicks(4414), "Esse sunt eos ipsam voluptates. Eos magnam culpa quia. Cupiditate quisquam voluptatem asperiores quia ratione praesentium vel et. Aut perspiciatis a.", "West Erickburgh", 1, 382.55m, "Gorgeous Cotton Ball" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2017, 4, 4, 16, 55, 28, 918, DateTimeKind.Unspecified).AddTicks(4620), "Ullam laboriosam in. Libero ullam ab modi pariatur. Nostrum rerum labore non atque voluptatibus est. Quia autem fugit est. Aut quasi ipsam at.", "Port Prudence", 165.14m, "Rustic Concrete Shoes" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2017, 2, 17, 9, 49, 54, 623, DateTimeKind.Unspecified).AddTicks(850), "Voluptas natus voluptas repellat. Sint porro dolores cumque beatae corporis qui quo culpa consequatur. Fuga aut culpa dolorem et delectus necessitatibus eum.", "Julianamouth", 934.38m, "Small Rubber Chicken" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2016, 11, 29, 22, 30, 36, 696, DateTimeKind.Unspecified).AddTicks(2867), "Corrupti sit minus saepe vitae est. Aut laborum nesciunt doloribus similique sed architecto doloribus. Aliquid distinctio illum molestias porro magni dolores enim rerum.", "Thielburgh", 527.72m, "Handcrafted Steel Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 57,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2020, 3, 15, 16, 59, 26, 108, DateTimeKind.Unspecified).AddTicks(5923), "Commodi minima veritatis autem sit dolor deserunt temporibus. Doloribus voluptas itaque dicta debitis ut quas. Placeat ex fugiat quam rerum nemo minus consequatur.", "Thoraland", 2, 369.79m, "Intelligent Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 58,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2017, 12, 3, 20, 34, 32, 965, DateTimeKind.Unspecified).AddTicks(5502), "Magni eum aliquid ut occaecati nihil repellendus omnis sit. Vel ratione sed impedit quaerat omnis. Et esse ut sit. Placeat vero atque.", "West Shanel", 369.53m, "Small Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 59,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2016, 12, 3, 23, 53, 42, 867, DateTimeKind.Unspecified).AddTicks(5952), "Non eveniet cupiditate. Dolor eaque qui fugit delectus magnam occaecati. Velit cumque molestiae sunt velit molestiae sed quidem quos. Aut magni et sit voluptatem cupiditate.", "Mullerbury", 1, 204.83m, "Unbranded Soft Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 60,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2018, 10, 26, 17, 22, 29, 71, DateTimeKind.Unspecified).AddTicks(6098), "Id maxime sint ipsum est doloremque ipsum enim asperiores enim. Voluptatem eum qui. Excepturi quibusdam reprehenderit et repellat porro et.", "West Shadburgh", 1, 953.52m, "Practical Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 61,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2017, 8, 2, 4, 0, 45, 697, DateTimeKind.Unspecified).AddTicks(2195), "Placeat et non. Officiis aut aut provident laborum. Ab illum dolorem et repellendus perspiciatis quas.", "Cristberg", 988.38m, "Awesome Wooden Gloves" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2020, 4, 15, 10, 19, 48, 363, DateTimeKind.Unspecified).AddTicks(9641), "Ex dolores illo sed iusto hic autem. Architecto aut quod eligendi. Consequatur dolores et quis necessitatibus atque.", "East Rick", 491.57m, "Awesome Fresh Hat" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2017, 12, 14, 0, 59, 33, 212, DateTimeKind.Unspecified).AddTicks(9366), "Similique aut doloremque et officiis consequatur et. Voluptatem tempora aut et voluptatem officiis ipsam. Reprehenderit animi dolores voluptates cupiditate velit illum consequatur. Eveniet autem debitis quasi animi.", "Turcotteview", 28.00m, "Unbranded Wooden Bike" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2017, 7, 2, 6, 53, 18, 262, DateTimeKind.Unspecified).AddTicks(4992), "Omnis nulla rerum quae itaque facere aut velit accusantium expedita. Blanditiis accusantium amet ut in alias. Eligendi similique nam aut.", "South Rosinatown", 2, 654.18m, "Generic Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 69,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2017, 3, 17, 1, 55, 8, 211, DateTimeKind.Unspecified).AddTicks(7050), "Sint totam officia ullam sed dolor voluptas voluptas nemo exercitationem. Eaque voluptatem et. Nam ea ducimus. Non repellendus repellendus dicta velit voluptates aut. Libero consectetur non sed eligendi.", "East Gideon", 931.78m, "Practical Fresh Shoes" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2018, 2, 23, 16, 21, 48, 540, DateTimeKind.Unspecified).AddTicks(3550), "Sit ipsum aut cupiditate. Illo expedita unde. Odio iure unde. Deleniti distinctio quas iure quam et est ad.", "Konopelskiview", 1, 974.06m, "Sleek Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 72,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2016, 2, 21, 15, 5, 43, 22, DateTimeKind.Unspecified).AddTicks(2669), "Molestiae quidem et facilis eos blanditiis eaque. Laborum incidunt dolores sunt est amet ipsum. Voluptatem eaque dolores cupiditate et. Explicabo nihil facilis unde rerum provident a maiores illo ut.", "North Dessiehaven", 737.91m, "Refined Granite Chips" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2015, 12, 9, 20, 13, 17, 343, DateTimeKind.Unspecified).AddTicks(1413), "Corporis occaecati vero numquam sequi optio voluptatum aperiam sint. Quis quisquam ea accusantium. Dolor velit dignissimos corrupti reprehenderit dolor eos nulla.", "North Jaeden", 1, 325.79m, "Small Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 75,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2017, 2, 1, 21, 5, 11, 234, DateTimeKind.Unspecified).AddTicks(3679), "Fugit animi ullam. Fuga voluptatem aliquam rerum sed autem. Asperiores sequi itaque sapiente porro omnis placeat.", "Moenville", 1, 673.61m, "Generic Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 76,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2017, 6, 21, 15, 58, 1, 222, DateTimeKind.Unspecified).AddTicks(2810), "Sunt ad numquam. Culpa sit fugit. Et consequatur molestiae. Facilis aut qui laudantium ipsum.", "Port Estastad", 1, 534.14m, "Handcrafted Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 77,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2015, 2, 6, 0, 22, 13, 458, DateTimeKind.Unspecified).AddTicks(8742), "Error odit quam velit veniam. Dolor voluptatem ex dolor. Corrupti rerum in soluta voluptates doloremque quisquam. Tempora sed vel incidunt dolores iure iste. Cum qui qui sit earum vel laborum.", "Schuppefort", 445.24m, "Generic Plastic Chicken" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2016, 11, 26, 11, 53, 36, 239, DateTimeKind.Unspecified).AddTicks(1973), "Excepturi perspiciatis et. Quis cum asperiores. Dolorem voluptatem ducimus repudiandae et provident dolor debitis perspiciatis illum. Veniam dolorem atque est aliquid. Porro reiciendis sint occaecati.", "Gaylordview", 959.46m, "Intelligent Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 80,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2019, 3, 22, 5, 23, 40, 146, DateTimeKind.Unspecified).AddTicks(1966), "Nemo ut possimus eos aut eligendi sunt neque cum. Ab iusto ullam. Accusantium vero quo eum. Cumque beatae commodi debitis eveniet repellat tenetur est. Ut sed exercitationem veniam est praesentium.", "Krisside", 492.81m, "Rustic Steel Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 81,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2016, 11, 2, 18, 0, 1, 117, DateTimeKind.Unspecified).AddTicks(9967), "Distinctio asperiores fugit. Fuga quam aut hic maxime earum accusantium eos. Illo consequatur cumque non eos autem assumenda repellendus quo.", "Isacside", 1, 222.09m, "Handcrafted Rubber Bacon" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2018, 12, 22, 16, 3, 35, 81, DateTimeKind.Unspecified).AddTicks(1636), "Inventore est rerum quo voluptatem quaerat qui et sed qui. Maxime accusantium earum eligendi laudantium molestiae reprehenderit eos aut quia. Ratione non magnam. Totam suscipit repellat et eum in sint. Vel autem quam omnis veniam modi aliquam magni. Earum rerum beatae minus reprehenderit nesciunt nesciunt.", "Port Kenneth", 2, 974.39m, "Licensed Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2016, 3, 24, 11, 52, 46, 0, DateTimeKind.Unspecified).AddTicks(1837), "Quas tempore doloribus deserunt eum corporis. Ut ipsa officiis aut. Quisquam beatae qui quia maiores quia at beatae. Voluptas in et fugiat. A et numquam quo delectus animi et eos et at. Ex dolore molestiae voluptatem quaerat fugit deserunt autem molestiae aliquam.", "Franciscabury", 722.54m, "Practical Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2017, 1, 10, 4, 21, 30, 378, DateTimeKind.Unspecified).AddTicks(3726), "Rerum ut voluptatem nobis sit voluptates molestias quia vero. Minus aliquam harum molestiae nihil illum. Est consequatur consequuntur et est ut quas voluptas doloribus omnis.", "Reichelfurt", 963.90m, "Awesome Fresh Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2015, 5, 12, 22, 50, 40, 490, DateTimeKind.Unspecified).AddTicks(8815), "Nobis veniam quisquam qui labore harum sed sunt corrupti. Eveniet corporis itaque laudantium earum pariatur. Beatae omnis nulla nisi. Id atque numquam atque voluptatem. Aperiam error laboriosam illum nisi earum.", "Lake Cieloburgh", 2, 28.94m, "Refined Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 89,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2017, 1, 22, 4, 54, 10, 872, DateTimeKind.Unspecified).AddTicks(6874), "Sed itaque placeat. Consequatur labore est dignissimos. Unde ut sit facere deleniti. Inventore et et vitae a repellat laboriosam aspernatur.", "Sylviatown", 888.37m, "Rustic Cotton Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 90,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2019, 2, 3, 19, 1, 3, 612, DateTimeKind.Unspecified).AddTicks(1338), "Iusto veniam ea. In dolorum et quibusdam exercitationem. Odit ad reprehenderit reiciendis voluptas qui corporis maxime eum accusantium. Voluptas dicta magnam tenetur aliquid mollitia repellat aperiam sit.", "Elyssaburgh", 1, 448.62m, "Incredible Soft Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 91,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2018, 3, 26, 20, 0, 40, 652, DateTimeKind.Unspecified).AddTicks(338), "Et impedit aut omnis dolores voluptatem id. Veritatis sint corrupti et. Mollitia velit voluptatem vel modi. Et voluptas fugit.", "Lake Wilhelm", 1, 943.35m, "Handcrafted Steel Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 92,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2019, 1, 29, 12, 10, 27, 500, DateTimeKind.Unspecified).AddTicks(6772), "Eaque vel ducimus dolor. Ducimus qui rerum sed et dolorem eos adipisci impedit. Consequatur ut veniam ipsam repellat omnis est. Aut quibusdam omnis deleniti ut. Corrupti soluta odio et sit iste illum.", "Conniebury", 576.19m, "Ergonomic Fresh Chips" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2018, 2, 20, 18, 18, 8, 650, DateTimeKind.Unspecified).AddTicks(5102), "Laudantium excepturi incidunt impedit voluptatem cum quia nobis impedit. Alias perspiciatis quia debitis sed sunt sequi ducimus. Maiores molestias ut officia tenetur eos. Velit voluptas adipisci et asperiores dolor voluptas animi.", "Dickiburgh", 2, 746.48m, "Sleek Cotton Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 96,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2020, 4, 2, 19, 0, 35, 509, DateTimeKind.Unspecified).AddTicks(2568), "Libero occaecati velit ad reiciendis adipisci. Nisi laboriosam error molestiae minima nulla culpa deleniti voluptate quos. Placeat qui numquam quisquam hic non nemo voluptate sapiente. Repellendus hic non. Laboriosam praesentium architecto cum error sint rerum et incidunt.", "Gerlachborough", 265.65m, "Tasty Fresh Salad" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2016, 12, 1, 1, 3, 40, 934, DateTimeKind.Unspecified).AddTicks(7750), "Aut nam perspiciatis enim magni odit nostrum rerum ipsam similique. Nihil accusamus est sunt quae. In dolores rerum quos dolorem qui sed. Deleniti voluptatibus est et veritatis dolor pariatur similique molestias fugiat. Qui sed autem eligendi omnis fuga rerum. Nostrum consequatur deserunt et sunt enim.", "O'Keefeside", 2, 45.74m, "Fantastic Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 99,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2019, 6, 27, 22, 5, 46, 827, DateTimeKind.Unspecified).AddTicks(3316), "Exercitationem magnam reprehenderit qui at commodi saepe qui. Qui accusantium dignissimos reprehenderit et cupiditate voluptas repudiandae. Necessitatibus fugit aperiam vel.", "South Stephaniaport", 2, 119.55m, "Intelligent Frozen Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 100,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2018, 2, 8, 22, 17, 0, 44, DateTimeKind.Unspecified).AddTicks(7905), "Reprehenderit maiores quo a incidunt. Doloribus dolorum animi et quas et occaecati aut omnis molestiae. Omnis aut et sint. Accusamus omnis voluptas et. Mollitia mollitia mollitia ullam debitis cupiditate sed dolores. Beatae amet distinctio ratione ipsa possimus rem saepe qui.", "Metzton", 227.31m, "Generic Rubber Chips" });

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
        }
    }
}
