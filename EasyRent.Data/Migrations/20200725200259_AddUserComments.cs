using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EasyRent.Data.Migrations
{
    public partial class AddUserComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdComments",
                columns: table => new
                {
                    AdCommentId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AdId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdComments", x => x.AdCommentId);
                    table.ForeignKey(
                        name: "FK_AdComments_Ads_AdId",
                        column: x => x.AdId,
                        principalTable: "Ads",
                        principalColumn: "AdId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdComments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserComments",
                columns: table => new
                {
                    UserCommentId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PublisherId = table.Column<int>(nullable: false),
                    OwnerId = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserComments", x => x.UserCommentId);
                    table.ForeignKey(
                        name: "FK_UserComments_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserComments_AspNetUsers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 1,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2015, 7, 29, 19, 13, 25, 609, DateTimeKind.Unspecified).AddTicks(8374), "Vero esse qui ipsum qui molestiae voluptas rerum nostrum aspernatur. Consequatur reiciendis minima. Voluptate consequuntur veniam in.", "Jesusport", 2, 522.74m, "Unbranded Steel Chicken" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2015, 3, 7, 2, 54, 25, 213, DateTimeKind.Unspecified).AddTicks(7819), "Voluptas aliquam vitae enim dolores excepturi. Quia enim sapiente dolorem culpa et a adipisci est natus. Animi ad velit dolorem ut. Qui mollitia quisquam labore debitis sed nisi distinctio nihil blanditiis.", "New Andreanneshire", 1, 316.07m, "Sleek Fresh Ball" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2019, 6, 30, 16, 3, 5, 450, DateTimeKind.Unspecified).AddTicks(5523), "Pariatur sed dolorem blanditiis autem expedita expedita. Molestiae iusto quam non quia porro ex et. Perspiciatis harum dignissimos magnam sunt quo assumenda deserunt natus. Quis velit voluptatum. Odit autem sed et non rem laudantium tempore.", "Baileyview", 1, 109.98m, "Refined Plastic Salad" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2015, 1, 1, 23, 49, 3, 433, DateTimeKind.Unspecified).AddTicks(1747), "Consectetur quod et expedita vitae accusantium quae placeat aliquid. Minus quisquam ut deserunt porro occaecati omnis qui fuga ratione. Molestiae ipsam quo. Labore nam mollitia. Eius consectetur ex est aut.", "Marianneside", 2, 325.72m, "Unbranded Cotton Chicken" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2019, 4, 12, 10, 35, 20, 748, DateTimeKind.Unspecified).AddTicks(9209), "Dolores culpa et ut at recusandae non error sed iure. Sed sapiente aut ipsam. Nemo tenetur aut voluptates. Omnis veritatis numquam blanditiis amet voluptate. Sit perspiciatis occaecati exercitationem corrupti quod. Ut aspernatur quis vero sit praesentium qui.", "Kerlukebury", 1, 175.24m, "Unbranded Metal Pants" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2015, 4, 22, 1, 42, 34, 24, DateTimeKind.Unspecified).AddTicks(868), "Consectetur et quidem voluptates debitis similique voluptatum perspiciatis nihil esse. Nobis vero nesciunt. Totam corporis ducimus saepe aperiam.", "West Raheemfort", 1, 670.74m, "Gorgeous Rubber Chicken" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 8, new DateTime(2019, 4, 5, 9, 22, 18, 859, DateTimeKind.Unspecified).AddTicks(906), "Impedit odio omnis veritatis aliquid aut. Voluptatem reiciendis facere aliquam cum consequatur. Quisquam ab quia sit ratione consequuntur nobis delectus quaerat. Sed rerum sed similique deleniti fuga nulla cum ut. Itaque illum minus voluptatem quos facilis porro voluptas consectetur. Fuga voluptatibus vitae.", "Stehrfurt", 1, 16.46m, "Practical Steel Chicken" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2019, 3, 17, 10, 57, 38, 396, DateTimeKind.Unspecified).AddTicks(9051), "Perspiciatis aut pariatur placeat voluptatum sint velit. Nobis voluptatem sed. Facere impedit molestias dolorem itaque sapiente qui rerum rerum eum. Corrupti assumenda vero voluptatem aperiam incidunt modi dolorum sit. Perspiciatis dolore et et sunt quisquam magni eos.", "Franeckichester", 801.41m, "Tasty Fresh Bacon" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2018, 9, 20, 8, 26, 30, 351, DateTimeKind.Unspecified).AddTicks(4602), "Placeat autem laboriosam. Inventore amet quia earum provident rerum. Nisi sint ut dolorem molestiae nisi. Et quod ducimus soluta a perferendis ex cum dolore ad. Qui voluptate accusamus. Ut voluptas voluptas hic et quia inventore quos quibusdam.", "Mayeville", 1, 783.97m, "Refined Steel Bike" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2016, 10, 13, 9, 12, 52, 129, DateTimeKind.Unspecified).AddTicks(8286), "Dolorem et sed. Est nulla doloribus tempore. Ex quia et harum natus eius sit reiciendis.", "Port Cecilia", 1, 982.43m, "Handcrafted Steel Computer" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2015, 7, 27, 8, 11, 2, 981, DateTimeKind.Unspecified).AddTicks(3081), "Impedit aliquid nam quia vel tempore est adipisci ut dicta. Nisi autem sit ex cumque voluptates qui voluptatum optio. Quo eaque autem asperiores. Quisquam nihil magnam ex est cumque eaque alias. Vel eveniet vitae sed soluta aperiam quidem illum.", "West Margarettamouth", 766.13m, "Fantastic Steel Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2019, 9, 28, 2, 17, 42, 181, DateTimeKind.Unspecified).AddTicks(3502), "Enim nostrum sit optio tenetur ullam rerum repudiandae iusto. Corporis autem cumque reiciendis. Dolorem veniam autem distinctio quas voluptatem a doloremque voluptatem. Tenetur voluptatem tempora et. Facilis sit sed omnis et est facere. Qui id eligendi ut facilis non consequatur neque et.", "East Linnie", 1, 817.27m, "Gorgeous Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2017, 2, 22, 6, 48, 24, 231, DateTimeKind.Unspecified).AddTicks(5039), "Repellat minima quisquam consequatur necessitatibus quos quis. Itaque repudiandae adipisci architecto. Et molestiae vel sed enim qui.", "Wuckerthaven", 596.48m, "Small Plastic Fish" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2020, 4, 12, 11, 50, 1, 0, DateTimeKind.Unspecified).AddTicks(5944), "Consectetur numquam nihil quia cum. Soluta porro fuga assumenda magnam ipsum deserunt laborum ducimus est. Ipsam quia eius. Eos ut rerum excepturi. Laboriosam consectetur culpa ut animi quod.", "Schmittside", 1, 417.26m, "Refined Fresh Hat" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 3, new DateTime(2018, 4, 3, 9, 11, 22, 421, DateTimeKind.Unspecified).AddTicks(1143), "Neque nemo et non architecto debitis. Temporibus qui iure velit. Culpa rerum autem ipsum reiciendis id velit cum impedit est. Officia laboriosam culpa est dolores odit eos qui inventore.", "Lake Grayce", 1, 461.79m, "Handmade Soft Chips" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2019, 8, 12, 11, 21, 44, 877, DateTimeKind.Unspecified).AddTicks(4836), "Nobis quis modi aperiam enim cupiditate occaecati. Voluptatem id nesciunt deleniti quisquam quisquam. Est quos magni aut consequatur nisi at velit aliquid odit. Aut nemo quidem harum eaque ea. In ut ut sequi veniam omnis. Vitae sequi unde libero rerum impedit enim.", "North Lavernberg", 448.64m, "Handcrafted Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 40,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2018, 12, 26, 22, 46, 15, 893, DateTimeKind.Unspecified).AddTicks(6306), "Unde numquam maxime sint similique possimus inventore quia qui cum. Non quis voluptas veniam consectetur corporis provident. Qui fugit fugiat consectetur ipsa quam. Optio pariatur ipsum odio dolor veniam aliquid. Consequatur accusamus voluptate aperiam aspernatur consequuntur et hic est odio. Alias beatae vel.", "North Judah", 2, 556.34m, "Fantastic Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2019, 6, 9, 0, 56, 59, 534, DateTimeKind.Unspecified).AddTicks(5167), "Inventore non sequi aut dolores magnam vero dolores voluptatem velit. Enim et laboriosam maxime neque qui placeat reiciendis quam. Ipsam omnis magni sint fuga aut qui.", "West Rosechester", 2, 937.02m, "Rustic Steel Table" });

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
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2018, 1, 21, 23, 43, 31, 146, DateTimeKind.Unspecified).AddTicks(2390), "Placeat eligendi doloremque perspiciatis magnam laborum odit velit. Aut quo aut et voluptatem cumque saepe odit exercitationem. Voluptatem architecto voluptas ratione voluptas aut est modi. Voluptas ut et ut fuga laudantium nobis soluta.", "Jadafurt", 695.70m, "Unbranded Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 45,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2016, 4, 28, 22, 26, 1, 465, DateTimeKind.Unspecified).AddTicks(1057), "Aperiam dolorem veritatis dignissimos dolores eaque dolorum et. Consectetur similique animi reprehenderit autem sunt fuga. Similique dolor sequi totam voluptatem. Est et doloremque iusto vel. Animi qui ut cum quos optio perferendis quia. Est officia voluptas omnis eos.", "Port Allie", 2, 304.28m, "Sleek Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 46,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 6, new DateTime(2017, 10, 25, 17, 32, 25, 376, DateTimeKind.Unspecified).AddTicks(8366), "Perferendis qui esse temporibus laudantium. Labore minima rerum praesentium corporis molestiae ut. Iste qui tenetur quibusdam deserunt enim eligendi rerum. Possimus est est. Quaerat doloremque ea sit id vero tempora nobis error possimus. Nemo maiores id dolores adipisci accusamus qui.", "West Reyesmouth", 1, 144.37m, "Gorgeous Soft Sausages" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2020, 1, 18, 11, 33, 3, 277, DateTimeKind.Unspecified).AddTicks(720), "Mollitia ad sed iusto quia dolor. Omnis veniam sed molestiae dolorum nihil. Quod sit necessitatibus aut.", "Deltaborough", 712.67m, "Fantastic Soft Pizza" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2018, 11, 23, 4, 15, 15, 917, DateTimeKind.Unspecified).AddTicks(4634), "Hic sequi reiciendis. Qui saepe et. Atque hic autem autem consequatur quam aut. Voluptate temporibus ut et illum officiis quia debitis error quidem. Qui odio fugit animi dicta non facere a. Et fugiat natus soluta et quis rerum eveniet deleniti iure.", "Port Fredy", 400.71m, "Small Cotton Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2017, 4, 19, 6, 11, 59, 203, DateTimeKind.Unspecified).AddTicks(6886), "Quos amet eius. Quia consequatur aliquid quis dolorem illo laudantium consequuntur doloremque. Tempora nam esse non molestiae molestiae in. Ipsum et blanditiis eaque. Tempora totam excepturi. Aut ratione aut laboriosam autem laudantium.", "Cruickshankmouth", 1, 545.98m, "Intelligent Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 53,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2016, 4, 10, 15, 36, 52, 816, DateTimeKind.Unspecified).AddTicks(8925), "Tenetur veniam id voluptatem. Cumque ipsam sit esse laboriosam dicta. Quia illum et similique culpa. Tempora labore pariatur velit natus consequatur ut aut non a.", "Howellberg", 667.53m, "Generic Steel Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2017, 9, 28, 11, 35, 59, 405, DateTimeKind.Unspecified).AddTicks(8962), "Voluptatem ea ab. Beatae exercitationem nihil quis similique nulla fugiat. Ratione numquam nostrum facere est. Aut cupiditate quos ea voluptatem. Consequuntur quam expedita.", "West Henryfort", 850.43m, "Intelligent Wooden Bike" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 5, new DateTime(2015, 10, 7, 3, 13, 23, 115, DateTimeKind.Unspecified).AddTicks(5585), "Dolor saepe et dolore perspiciatis sint. Molestiae perferendis molestias omnis qui dolores. Fuga esse architecto assumenda dolore aut sunt sint. Esse doloribus sequi qui exercitationem quia sequi.", "Predovicmouth", 1, 544.77m, "Intelligent Soft Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 57,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2019, 8, 30, 3, 56, 31, 302, DateTimeKind.Unspecified).AddTicks(9162), "Perferendis excepturi dignissimos. Totam aperiam blanditiis suscipit doloribus rerum. Rem ut quaerat qui dolorem aliquam reprehenderit aspernatur. Placeat vero omnis vero. Officia odio eos voluptatem itaque dolore voluptatem nostrum.", "Susanashire", 972.62m, "Awesome Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 58,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2020, 1, 19, 2, 4, 1, 159, DateTimeKind.Unspecified).AddTicks(3003), "Ad facilis hic quis similique aut magni consequuntur ducimus enim. Sapiente officia possimus aut. Mollitia enim illo rerum optio sit eum.", "West Ruben", 670.14m, "Handcrafted Plastic Gloves" });

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
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2018, 10, 24, 11, 23, 45, 397, DateTimeKind.Unspecified).AddTicks(9354), "Doloremque eaque recusandae nihil rem sequi. Cupiditate est eveniet hic. Rem voluptatem vel fuga omnis voluptate. Sunt ut dolorum. Omnis iste tenetur illo placeat sed nihil tempore quod. Voluptatibus quas distinctio qui voluptatem voluptate.", "Port Kirsten", 1, 641.69m, "Incredible Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 62,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2017, 1, 4, 10, 2, 5, 100, DateTimeKind.Unspecified).AddTicks(5871), "Repudiandae porro modi ipsa voluptate quia vel. Sint aut vel ea. Tempora quia ipsa corrupti est quisquam atque praesentium repellat pariatur.", "Olenshire", 540.43m, "Unbranded Frozen Ball" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 4, new DateTime(2017, 2, 16, 11, 4, 24, 874, DateTimeKind.Unspecified).AddTicks(2114), "Omnis ut quisquam nostrum odit soluta asperiores. Et dignissimos dolores ex architecto voluptatem dolor. Ut nulla nesciunt animi libero libero pariatur. Hic rerum et fuga officiis. Et et voluptas est quos reprehenderit aut nulla consequatur consectetur. Libero amet consectetur sapiente eos quia nihil consectetur.", "Richmondstad", 1, 23.83m, "Intelligent Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 65,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2020, 3, 27, 19, 14, 13, 357, DateTimeKind.Unspecified).AddTicks(2089), "Quis est corporis vel. Officia molestiae dolorem reprehenderit omnis. Aperiam ut ut. Atque distinctio nisi sunt totam aut et nesciunt odit consequatur.", "South Ociestad", 2, 8.99m, "Fantastic Granite Pants" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2019, 11, 17, 20, 21, 8, 558, DateTimeKind.Unspecified).AddTicks(8864), "Et dicta autem esse omnis sunt saepe accusantium. Dolorem et odio odio odio ad dolorem. Nisi quibusdam eum eos quo. Sit aspernatur quasi consequatur nisi voluptas vel tempore repudiandae. Tenetur sunt harum eaque numquam libero enim cupiditate.", "Lake Angelinebury", 1, 845.08m, "Refined Soft Car" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 9, new DateTime(2017, 9, 27, 0, 15, 38, 652, DateTimeKind.Unspecified).AddTicks(9216), "Rerum molestiae sunt recusandae ea ea. Explicabo mollitia est minus et. Dolorem ad magnam quibusdam sint.", "DuBuqueborough", 2, 824.52m, "Incredible Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 70,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2020, 3, 3, 21, 29, 34, 743, DateTimeKind.Unspecified).AddTicks(7764), "Et odit eos consequatur est. Ea nihil minima dolorum velit quae ducimus impedit hic. Ut quam cumque consectetur eum qui et voluptates quae. Aspernatur doloribus quod.", "Langview", 815.60m, "Gorgeous Soft Tuna" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2018, 7, 22, 4, 53, 15, 840, DateTimeKind.Unspecified).AddTicks(2897), "Consectetur minima iusto similique. Vel dolorem itaque iusto. Illum exercitationem provident quibusdam. Non adipisci nihil occaecati est. Quia recusandae maxime molestiae dignissimos labore aut id.", "Lake Chetburgh", 2, 993.15m, "Fantastic Metal Salad" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2015, 7, 12, 15, 1, 33, 819, DateTimeKind.Unspecified).AddTicks(565), "Velit aperiam expedita impedit voluptas ipsum aperiam rem qui exercitationem. Modi asperiores blanditiis rerum enim. Quas tempora sint asperiores. Est maxime consequatur minus consequatur qui rem consequuntur. Aperiam aspernatur cumque et sed qui quos praesentium.", "New Joseshire", 138.47m, "Fantastic Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 79,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2017, 5, 9, 0, 30, 4, 633, DateTimeKind.Unspecified).AddTicks(9969), "Vitae architecto hic quos voluptatem repudiandae cumque aut dolorem. Repellat praesentium unde ad quia exercitationem a voluptate repudiandae placeat. Repellat sint voluptatum.", "Nicolasborough", 2, 211.07m, "Rustic Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2016, 7, 2, 16, 21, 30, 310, DateTimeKind.Unspecified).AddTicks(8874), "Facere aut ad. Temporibus aliquid veritatis nihil sint dolores. Sed cum ut eos est eos nostrum. Dicta sequi rem id fuga error quos itaque aliquam. In autem laborum quia explicabo perspiciatis hic dolores molestiae. Eligendi recusandae non sapiente aliquam quae tempora sed et est.", "East Penelope", 2, 160.66m, "Refined Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 81,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 10, new DateTime(2017, 5, 24, 2, 30, 4, 115, DateTimeKind.Unspecified).AddTicks(5292), "Consequatur eveniet earum quia reiciendis quibusdam. Est amet sint impedit sit beatae voluptatem. Excepturi deleniti culpa suscipit tenetur aperiam atque quis nostrum culpa. Qui modi quaerat soluta atque molestias.", "Dwightland", 1, 313.29m, "Small Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 82,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2017, 1, 20, 16, 2, 7, 54, DateTimeKind.Unspecified).AddTicks(3662), "Sunt laudantium beatae porro non est temporibus et qui nisi. Quia non est ut cupiditate ut. Laudantium molestias doloremque sed libero. Accusantium harum quos nisi sint et repellat at eveniet. Porro fugit autem minus exercitationem corrupti.", "Johnsside", 319.57m, "Unbranded Soft Cheese" });

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
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2018, 3, 22, 11, 50, 38, 785, DateTimeKind.Unspecified).AddTicks(6422), "In eos dolorem natus ut voluptatem explicabo ipsa repellat. Ducimus eos dolore aut. Autem nihil odio ipsum qui. Ut quod blanditiis ad explicabo ducimus. Laudantium qui nesciunt eligendi qui at. Reprehenderit animi occaecati qui odit illo similique veritatis assumenda ipsum.", "Barrowsbury", 1, 526.37m, "Refined Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 85,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2018, 1, 7, 12, 6, 30, 571, DateTimeKind.Unspecified).AddTicks(4610), "Consequatur veniam aliquam officiis quo culpa. Ab facere minima qui doloremque voluptatibus omnis. Vero et laboriosam et. Ut veniam occaecati et architecto at. Enim rem fugit aut quas sunt asperiores. Ut voluptas incidunt nisi.", "Langworthchester", 2, 418.32m, "Sleek Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 86,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 7, new DateTime(2016, 9, 1, 10, 56, 35, 875, DateTimeKind.Unspecified).AddTicks(1227), "Incidunt dignissimos autem molestiae dicta voluptas amet. Vero delectus labore in rerum enim necessitatibus itaque doloribus. Rerum non fugiat repellat sint ut aliquam. Quae et est enim sed aliquid facilis id omnis. Porro similique ratione. Eos et atque voluptatem ad eos.", "DuBuquemouth", 408.32m, "Awesome Granite Chair" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2015, 11, 12, 12, 10, 52, 165, DateTimeKind.Unspecified).AddTicks(4345), "Consequuntur dolores sed repudiandae. Porro et quo inventore magni. Et facere repellendus nihil perspiciatis qui aut hic ullam repudiandae. Totam est alias. In nemo nemo. Nisi consequuntur omnis dolores harum officiis consequatur et est dolorem.", "Mertzborough", 799.01m, "Refined Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 89,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2018, 3, 18, 10, 22, 41, 129, DateTimeKind.Unspecified).AddTicks(607), "Voluptas est enim aspernatur nam vel voluptates incidunt. Quia voluptate voluptatem repellendus. Nostrum dolorum voluptatem omnis id voluptatem praesentium quia in. Eligendi libero at est dignissimos. Eos praesentium veniam quo ea dolorem.", "Leuschkeville", 995.91m, "Sleek Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 90,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 1, new DateTime(2019, 8, 2, 16, 59, 32, 814, DateTimeKind.Unspecified).AddTicks(3191), "Accusantium voluptatibus consequatur. Odit rem ipsum facilis non tenetur voluptate. A modi repellendus quisquam amet rerum accusamus quasi qui quia.", "Mooreborough", 2, 741.06m, "Generic Steel Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 91,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 2, new DateTime(2019, 3, 24, 19, 7, 23, 644, DateTimeKind.Unspecified).AddTicks(954), "Distinctio praesentium esse cupiditate ex consequatur perspiciatis porro. Voluptates magni numquam eaque corporis harum delectus reprehenderit et ipsam. Quisquam ut modi reprehenderit ad consequatur nulla consequuntur quia eum. Ut laboriosam modi natus voluptas corporis nam deserunt veritatis. Cum neque pariatur atque magni nihil quia.", "South Hollie", 1, 889.13m, "Intelligent Metal Chair" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2016, 5, 23, 20, 35, 35, 60, DateTimeKind.Unspecified).AddTicks(8222), "Ipsum deserunt voluptas. Aliquam necessitatibus culpa aut aut. Labore itaque exercitationem aut voluptatem eos aut aut.", "South Maud", 770.55m, "Generic Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 94,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 7, new DateTime(2016, 7, 23, 10, 56, 23, 76, DateTimeKind.Unspecified).AddTicks(1528), "Ipsam ipsa voluptatem nemo officiis ratione. Et necessitatibus est earum dolorum recusandae magnam. Omnis voluptas incidunt dolor tempora ipsum enim minima.", "Hassanbury", 2, 970.77m, "Generic Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2019, 2, 2, 19, 1, 10, 8, DateTimeKind.Unspecified).AddTicks(2265), "Adipisci repellendus doloribus aut officiis aliquam. Non omnis et architecto quo consequatur. Id et vel neque maiores non. Voluptas quos necessitatibus.", "East Yasmin", 2, 910.25m, "Unbranded Granite Gloves" });

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
                name: "IX_AdComments_AdId",
                table: "AdComments",
                column: "AdId");

            migrationBuilder.CreateIndex(
                name: "IX_AdComments_UserId",
                table: "AdComments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComments_OwnerId",
                table: "UserComments",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComments_PublisherId",
                table: "UserComments",
                column: "PublisherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdComments");

            migrationBuilder.DropTable(
                name: "UserComments");

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2015, 8, 1, 4, 16, 10, 616, DateTimeKind.Unspecified).AddTicks(557), "Consequuntur et et. Id aliquam ipsum voluptas laborum earum qui. Sit aperiam iusto dolores repellendus.", "Port Loy", 2, 507.03m, "Generic Wooden Car" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2016, 3, 7, 9, 29, 25, 136, DateTimeKind.Unspecified).AddTicks(5607), "Qui et tempore eos molestiae ipsa non earum ea quam. Dolorem odio autem velit. Aliquid voluptatem tempora. Dolores placeat ratione nisi non itaque consequatur quo et. Non asperiores pariatur et qui magni quos est molestiae.", "West Omahaven", 1, 773.38m, "Small Concrete Gloves" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2015, 10, 17, 13, 6, 30, 372, DateTimeKind.Unspecified).AddTicks(7640), "Numquam et ipsa ipsum deserunt. Sapiente autem voluptatem sed dolorem quo nobis facere. Quo aut eos assumenda.", "Port Lowellmouth", 2, 910.35m, "Practical Soft Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 14,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2015, 4, 8, 0, 2, 2, 401, DateTimeKind.Unspecified).AddTicks(4548), "Quis est qui aut odit. Nostrum nostrum ullam aliquid repudiandae dolorem doloribus voluptatum optio ea. Autem perspiciatis molestiae dolore officiis odio in inventore. Maxime pariatur eum illum. Quod dignissimos vero laboriosam aperiam. Dignissimos minus maiores sunt.", "Port Keira", 724.51m, "Awesome Frozen Sausages" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2015, 3, 10, 17, 44, 54, 293, DateTimeKind.Unspecified).AddTicks(7924), "Possimus quod consequuntur perferendis et culpa omnis pariatur. Consequatur iure aliquid velit maiores deleniti voluptatum nostrum ut. Nesciunt quaerat omnis ducimus facilis.", "North Darrenview", 114.53m, "Incredible Plastic Pizza" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2018, 12, 11, 3, 31, 48, 31, DateTimeKind.Unspecified).AddTicks(8422), "Rerum sit ut ducimus nihil eum ut quos reprehenderit quas. Ipsam quo aut. Ut inventore ratione distinctio quisquam illum aliquid reprehenderit ut maiores. Consequatur ullam reiciendis alias magnam sunt.", "Bashirianchester", 292.79m, "Practical Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 21,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2015, 1, 17, 11, 57, 18, 696, DateTimeKind.Unspecified).AddTicks(3661), "Dolor voluptates eos laborum ut at. Labore atque libero. Nostrum itaque nihil praesentium. Vel quae excepturi iure aliquam non ea et voluptatem soluta.", "Maryhaven", 1, 953.75m, "Intelligent Rubber Salad" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2019, 10, 7, 19, 18, 28, 557, DateTimeKind.Unspecified).AddTicks(8956), "Repudiandae expedita accusantium. In consequatur sapiente distinctio tenetur corporis culpa porro. Nostrum sit modi dolorum veritatis et et quis maiores harum.", "North Josianne", 60.04m, "Unbranded Fresh Towels" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2020, 7, 4, 15, 24, 31, 318, DateTimeKind.Unspecified).AddTicks(1989), "Est saepe nihil repellat voluptas accusamus. Accusamus ad distinctio recusandae eum aut harum. Qui eius rerum excepturi. Maiores tenetur iste velit. Eius quasi non aspernatur soluta voluptas quidem nam nisi est. Maxime accusamus et odio non et.", "Port Zander", 1, 946.07m, "Incredible Wooden Shoes" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2015, 10, 30, 19, 15, 6, 959, DateTimeKind.Unspecified).AddTicks(4797), "Corporis asperiores id eum ratione distinctio ut deleniti. Et excepturi aut error laudantium. Quis et nisi possimus voluptas est molestias.", "North Roxanefurt", 824.37m, "Unbranded Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 30,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2017, 8, 13, 14, 43, 5, 773, DateTimeKind.Unspecified).AddTicks(7283), "At quo consequatur rem quasi dolorem cupiditate ea ut ea. Tempora qui velit. Ipsum et voluptatem dignissimos. Quibusdam maxime quisquam.", "Kunzefort", 51.27m, "Generic Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2019, 8, 19, 7, 40, 35, 436, DateTimeKind.Unspecified).AddTicks(398), "Distinctio dolorum officiis nobis earum consequuntur ratione impedit. Voluptas molestiae consequatur quisquam minus consectetur porro saepe. Voluptate eos odit doloribus. Reiciendis incidunt est non vel ducimus necessitatibus error aut. Unde dolores unde iste laudantium.", "Syblefurt", 2, 35.19m, "Ergonomic Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2016, 11, 6, 23, 53, 58, 227, DateTimeKind.Unspecified).AddTicks(1107), "Culpa modi porro reprehenderit perspiciatis. Temporibus eveniet qui ipsum adipisci voluptas voluptatem voluptas. Quia quo quia labore rerum. Molestiae quisquam et corrupti. Et optio et. Dignissimos quasi deserunt quasi enim nisi.", "Port Abbey", 823.31m, "Handmade Metal Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 33,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2018, 12, 16, 12, 29, 30, 717, DateTimeKind.Unspecified).AddTicks(7339), "Vero maxime sed voluptatem fuga. Numquam voluptatem et eius. Rem facere sunt doloribus illo est consequuntur ipsum consectetur blanditiis. Earum vel quia esse rerum et esse iure temporibus id. Et voluptas neque veniam exercitationem. Ducimus vero nesciunt nulla dolorem alias.", "Antoniettafurt", 669.94m, "Tasty Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 34,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2019, 10, 30, 14, 5, 19, 32, DateTimeKind.Unspecified).AddTicks(8470), "Nemo reiciendis non voluptatem quo id fugit molestiae exercitationem. Dolores magnam eum assumenda. Nobis est suscipit exercitationem dicta est. Facilis nisi numquam eum blanditiis omnis quia saepe est. Repudiandae ex reiciendis ipsam ut amet qui quam qui. Nihil ea itaque esse voluptas consectetur dolor eveniet.", "Framimouth", 2, 840.03m, "Small Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 35,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2020, 2, 5, 14, 38, 4, 61, DateTimeKind.Unspecified).AddTicks(4277), "Eius in dignissimos quis laboriosam. Autem fugit ducimus sed consectetur officiis. Aperiam odit quis voluptate quibusdam. Ut animi nemo voluptates deleniti non architecto voluptas atque maiores.", "North Devon", 140.47m, "Fantastic Granite Gloves" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2017, 3, 26, 3, 21, 27, 600, DateTimeKind.Unspecified).AddTicks(6821), "Expedita omnis repellat. At nemo vero qui et at quaerat et consequatur explicabo. Tempora dolorum et consequatur sequi neque est non molestiae.", "Lake Eldabury", 107.32m, "Handcrafted Cotton Bike" });

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
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2019, 3, 5, 4, 45, 22, 98, DateTimeKind.Unspecified).AddTicks(1776), "Voluptatum aut quo nulla. Distinctio velit sit rem eos in magni. Quam placeat nulla quasi odit ratione ex.", "Haleytown", 1, 487.19m, "Practical Granite Car" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2015, 3, 10, 21, 32, 52, 654, DateTimeKind.Unspecified).AddTicks(6789), "Accusamus omnis doloribus excepturi repellendus. Sequi eum adipisci est adipisci voluptas. Nesciunt id modi nostrum voluptate ut rerum reiciendis iure. Quas dolores quaerat aspernatur.", "Durganland", 583.04m, "Tasty Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2019, 3, 12, 5, 40, 33, 628, DateTimeKind.Unspecified).AddTicks(9270), "Cumque est necessitatibus ut modi sequi qui voluptatem iusto. Voluptatem nobis qui odio odio exercitationem atque id corrupti. Cupiditate aliquid in quia quae accusantium. Est ea consequuntur eius. Deserunt deserunt sed ullam dicta quam non ut omnis.", "O'Reillyside", 60.84m, "Practical Wooden Hat" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2019, 9, 4, 16, 20, 17, 879, DateTimeKind.Unspecified).AddTicks(7858), "Occaecati unde assumenda nemo aperiam atque ex assumenda. Consequatur quasi minus voluptates excepturi dolorem dolor accusamus ipsa. Distinctio molestias enim voluptas. Quaerat ut et est delectus voluptatum quo impedit molestias sint.", "Port Vellabury", 690.35m, "Awesome Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 50,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2017, 4, 13, 20, 47, 41, 211, DateTimeKind.Unspecified).AddTicks(9388), "Dignissimos ad animi et rerum dolores consequatur. Magnam impedit vel quae. At maxime et commodi aut ea tempora qui. Non tempora laudantium aliquid culpa. Dolorum et repellat maxime vel nulla amet. Consequatur incidunt necessitatibus in optio.", "Port Demarcus", 1, 142.01m, "Fantastic Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 51,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2019, 3, 28, 16, 59, 35, 205, DateTimeKind.Unspecified).AddTicks(5668), "Et odit magni veritatis quis omnis deserunt iste nemo. Qui impedit et nam quo libero velit. Magni vitae repellendus provident beatae consequatur. Dicta odit ut rerum explicabo ut tenetur consequuntur eveniet qui. Illo enim asperiores qui exercitationem voluptatem iure quod. Ut architecto eligendi dolorem.", "Port Luluborough", 786.73m, "Ergonomic Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2019, 10, 18, 14, 35, 33, 558, DateTimeKind.Unspecified).AddTicks(3194), "Tempore non eaque accusamus. Dolorem itaque aspernatur et eos dignissimos soluta. Voluptas qui laboriosam et esse aut esse sit vero. Saepe id nisi. Est impedit exercitationem dolorem impedit dolor ab ut dolor.", "Destineyshire", 2, 906.06m, "Handmade Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 53,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2019, 12, 15, 19, 30, 57, 849, DateTimeKind.Unspecified).AddTicks(1458), "Reiciendis eligendi occaecati est ad. Veritatis vel sed qui voluptatem. Sit voluptas reprehenderit quia. Minus eveniet id esse delectus quidem voluptatibus blanditiis odit distinctio. Qui incidunt est. Nisi ut harum perferendis est deleniti et cupiditate maiores sed.", "South Zitachester", 574.34m, "Practical Metal Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { new DateTime(2015, 12, 25, 5, 55, 27, 929, DateTimeKind.Unspecified).AddTicks(706), "Perferendis inventore sed incidunt ipsum mollitia rerum commodi rerum qui. Eveniet autem optio vel unde. Corporis autem facere debitis et beatae. Id provident incidunt ducimus commodi nisi modi ipsum vitae distinctio.", "Vernaberg", 248.55m, "Gorgeous Frozen Chair" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2017, 8, 28, 23, 51, 29, 982, DateTimeKind.Unspecified).AddTicks(4320), "Delectus ducimus dolorem id. Consectetur alias aperiam cumque ratione est sit dicta. Est distinctio impedit veritatis et est. Repudiandae qui nobis autem aut.", "New Rafaelberg", 549.27m, "Practical Wooden Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 58,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 2, new DateTime(2019, 11, 17, 7, 33, 56, 187, DateTimeKind.Unspecified).AddTicks(7674), "Maiores cupiditate et in. Consequuntur sint voluptas pariatur maiores magni eius voluptas. Officia vero illo asperiores. Earum est quia esse modi qui. Voluptatem architecto et hic et suscipit doloremque.", "Murrayberg", 210.10m, "Sleek Soft Towels" });

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
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2020, 7, 5, 21, 33, 41, 216, DateTimeKind.Unspecified).AddTicks(4447), "Officia earum reprehenderit delectus maiores rerum voluptates in. Quidem placeat consequatur occaecati harum non ipsam totam. Accusamus est illo quo ad quia a nisi non et. Sed quis velit rerum accusantium architecto est cupiditate sit iure. Minus tempore vero maiores culpa dignissimos sit. Quia numquam excepturi dolorem ut modi.", "Sedrickfurt", 2, 220.03m, "Small Metal Table" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 62,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2019, 11, 29, 23, 39, 56, 261, DateTimeKind.Unspecified).AddTicks(9314), "Qui dolores iste veniam autem dolores provident. Doloribus eum at nostrum deserunt. Aut est quibusdam tempore eligendi laudantium sapiente. Suscipit velit voluptatibus corporis quia quod.", "Lake Wilmaborough", 636.32m, "Small Metal Pizza" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2015, 12, 6, 11, 46, 6, 694, DateTimeKind.Unspecified).AddTicks(7045), "Perferendis culpa consectetur dolorem quo tempore et quidem non inventore. Vero soluta quaerat molestias facere quia aut saepe. Non pariatur sit et placeat.", "Mosciskiside", 1, 253.60m, "Practical Frozen Cheese" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2018, 5, 17, 16, 47, 48, 64, DateTimeKind.Unspecified).AddTicks(2139), "Dolores animi facere sint quis. Natus aliquam quis est. Impedit ab dolor similique ab molestias. Qui modi libero asperiores amet dolor. Doloribus asperiores dolores et nobis. Nobis eaque qui reiciendis dolore.", "Lake Georgianaburgh", 606.55m, "Incredible Fresh Tuna" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2015, 12, 29, 9, 9, 53, 95, DateTimeKind.Unspecified).AddTicks(6185), "Tempore atque quibusdam ut sequi et dolore omnis aperiam. Ea accusamus consequatur non. Omnis autem aut consequatur voluptatum.", "East Jermaineborough", 489.61m, "Incredible Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 71,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2018, 12, 14, 16, 7, 37, 785, DateTimeKind.Unspecified).AddTicks(3250), "Porro enim unde deserunt consequatur odio. Voluptas dolorem ex est quasi delectus error ea. Commodi maxime optio quo soluta nihil reprehenderit doloribus. Esse qui dignissimos numquam animi a. Molestias voluptatum quis ut quibusdam ipsum molestiae. Distinctio quo voluptas et assumenda quaerat cupiditate.", "Schummbury", 814.03m, "Incredible Frozen Car" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 4, new DateTime(2017, 1, 28, 10, 22, 54, 739, DateTimeKind.Unspecified).AddTicks(9354), "Quod quidem qui suscipit repudiandae veritatis similique rerum porro odio. Molestias fugit quisquam consequatur voluptatum et ratione voluptas dolor. Aut minima earum officia excepturi at natus ut nemo. Dolorum temporibus error accusantium. Non ut dolores velit eum possimus ducimus distinctio. Consequuntur culpa voluptatem atque aut repudiandae voluptatum dolorem expedita.", "Port Flossieport", 750.91m, "Fantastic Concrete Chair" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2017, 1, 10, 18, 34, 18, 52, DateTimeKind.Unspecified).AddTicks(1858), "Itaque nesciunt vel laudantium consectetur reiciendis beatae illo consequatur. Officiis quae explicabo aliquam ipsam temporibus corrupti. At non minima architecto laboriosam itaque molestias qui. Doloribus assumenda est.", "Watsonview", 677.82m, "Generic Fresh Shirt" });

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
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2019, 7, 1, 5, 42, 29, 774, DateTimeKind.Unspecified).AddTicks(9270), "Porro eveniet occaecati atque consequatur fugit ea perspiciatis. Et nesciunt et modi rerum culpa quisquam asperiores aspernatur. Officiis ea saepe quo. Modi est omnis.", "North Angelinaburgh", 1, 300.24m, "Licensed Wooden Sausages" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2017, 5, 6, 13, 11, 42, 980, DateTimeKind.Unspecified).AddTicks(6526), "Delectus nesciunt sint fugiat quia ipsum quia. Sunt autem quis optio et perspiciatis consectetur voluptatem. Aut fuga ipsum nesciunt corrupti quisquam beatae odit et.", "Wildermanmouth", 577.98m, "Gorgeous Frozen Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 83,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { 0, new DateTime(2019, 5, 18, 3, 7, 21, 537, DateTimeKind.Unspecified).AddTicks(3197), "Et perferendis ullam id omnis natus voluptates. Optio inventore nam nihil tempora est ratione officiis. Deleniti iusto odio est veniam tempora. Sed sint sed iure ipsam. Repellendus et vel voluptatem corrupti laborum accusamus iste. Neque dolorem eum tempora rerum quis fugiat ut est quo.", "Adelaburgh", 1, 515.70m, "Sleek Soft Gloves" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2019, 12, 9, 7, 41, 13, 386, DateTimeKind.Unspecified).AddTicks(7881), "Occaecati voluptate ab. Nihil voluptas voluptates quia sed. Vero perspiciatis enim.", "West Anastasia", 2, 341.63m, "Tasty Plastic Keyboard" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 10, new DateTime(2019, 1, 2, 3, 50, 44, 173, DateTimeKind.Unspecified).AddTicks(9487), "Atque omnis atque est aspernatur. Vel id officiis doloremque repellat cum autem voluptas at dolorem. Quasi iste deserunt.", "West Augusta", 108.97m, "Generic Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 87,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2020, 4, 15, 5, 52, 52, 414, DateTimeKind.Unspecified).AddTicks(7514), "Est ullam molestiae maiores numquam et enim sunt voluptas. Voluptates laborum dolores hic asperiores fugit. Non qui expedita consequatur et voluptatibus sed nobis autem.", "North Jazminfurt", 753.22m, "Practical Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 88,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 6, new DateTime(2017, 10, 20, 5, 23, 38, 782, DateTimeKind.Unspecified).AddTicks(9084), "Aliquam quibusdam laudantium ut officiis blanditiis atque aut et beatae. Pariatur illo est corrupti delectus. Voluptatem consequatur corporis. Facere et id libero eligendi qui est repudiandae alias. Minima alias reiciendis rem eos ut iure aut nam sed. Qui hic quia vel cumque est.", "East Shakira", 756.64m, "Small Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 89,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2019, 2, 20, 1, 59, 21, 347, DateTimeKind.Unspecified).AddTicks(8661), "Alias possimus inventore et. Repellat nulla architecto numquam. Dolorum nobis quia ratione aspernatur iusto ex exercitationem. At asperiores soluta voluptas et quia. Magnam et vero ut.", "South Patsy", 931.35m, "Handcrafted Cotton Pants" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 5, new DateTime(2015, 1, 9, 0, 14, 4, 287, DateTimeKind.Unspecified).AddTicks(3182), "Odit consequatur necessitatibus. In blanditiis maxime aliquam. Dignissimos dolores ab provident. At iure facere debitis voluptatibus ipsa quam.", "South Brian", 984.50m, "Incredible Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 93,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 1, new DateTime(2019, 2, 20, 11, 29, 28, 291, DateTimeKind.Unspecified).AddTicks(1779), "Distinctio tempora mollitia et earum. Dolorem mollitia impedit. Eos sequi labore incidunt nam architecto facere qui tempore fuga. Expedita consequatur et possimus amet. Quibusdam qui magnam. Voluptas nisi facere accusamus ullam quaerat totam vel.", "Schultzview", 707.54m, "Incredible Plastic Chips" });

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
                columns: new[] { "CreatedDate", "Description", "Location", "OwnerId", "Price", "Title" },
                values: new object[] { new DateTime(2017, 10, 9, 1, 29, 50, 802, DateTimeKind.Unspecified).AddTicks(1108), "Ipsum quaerat maxime. Quo delectus molestias voluptatem ex repellat inventore molestiae. Reprehenderit enim aspernatur.", "Rodgerview", 1, 699.76m, "Fantastic Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 96,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 8, new DateTime(2015, 5, 25, 12, 16, 42, 942, DateTimeKind.Unspecified).AddTicks(830), "Amet consequatur itaque cumque totam natus id. Quia quia et eaque. Necessitatibus qui fugiat. A totam repudiandae placeat dolorum aut sequi temporibus quia. Provident id dolore qui totam voluptatibus voluptatibus fugiat. Veritatis ex blanditiis perspiciatis repellendus quia saepe iure non nihil.", "Jeremyfort", 820.06m, "Handcrafted Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 97,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 3, new DateTime(2017, 10, 20, 22, 9, 33, 80, DateTimeKind.Unspecified).AddTicks(1964), "Repudiandae qui sint quasi qui a aperiam odio illo. Illo fugiat est. Et molestiae consequuntur fuga est quos. Consequatur quo ratione quisquam.", "Lynchstad", 690.45m, "Unbranded Concrete Ball" });

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
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 0, new DateTime(2015, 5, 11, 7, 38, 21, 816, DateTimeKind.Unspecified).AddTicks(629), "Repellat sed impedit id id voluptatem officia quo. Quae nihil molestias porro eveniet aut at ea id sed. Maxime modi id et et unde ut quo omnis non.", "North Rylanfort", 549.21m, "Intelligent Steel Soap" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 100,
                columns: new[] { "Available", "CreatedDate", "Description", "Location", "Price", "Title" },
                values: new object[] { 9, new DateTime(2018, 9, 12, 10, 0, 44, 377, DateTimeKind.Unspecified).AddTicks(8626), "Eos commodi illum dolor. Nemo ducimus illo. Magnam adipisci maiores omnis animi. Vitae amet vitae. Veniam odio aut quis est rerum ut et temporibus. Tempore blanditiis fugit fugiat ipsa maxime quis fugiat.", "Caspermouth", 106.15m, "Sleek Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "PhoneNumber", "UserName" },
                values: new object[] { "4800fa54-5f03-43c0-9a45-4fdbc6bd2cb9", "Patrick.Raynor63@yahoo.com", "Raynor", "1-708-575-3690", "Patrick_Raynor" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "PhoneNumber", "UserName" },
                values: new object[] { "49cf63c6-3b73-4693-ad6f-f0c10ec0aa89", "Mathew.Boyer@yahoo.com", "Boyer", "957.971.3376 x4163", "Mathew94" });
        }
    }
}
