using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EasyRent.Data.Migrations
{
    public partial class Seed_Categories_And_SubCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategorySubcategories");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Subcategories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Детские товары" },
                    { 2, "Техника и электроника" },
                    { 3, "Хобби и отдых" },
                    { 4, "Свадьба и праздники" },
                    { 5, "Автотовары" },
                    { 6, "Сад и огород" },
                    { 7, "Здоровье" },
                    { 8, "Спорт, туризм и активный отдых" },
                    { 9, "Ремонт и стройка" },
                    { 10, "Другое" }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "SubcategoryId", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Мужская одежда" },
                    { 20, 3, "Охота и рыбалка" },
                    { 21, 3, "Другое" },
                    { 22, 4, "Мебель" },
                    { 23, 4, "Автомобили" },
                    { 24, 4, "Мотоциклы, квадроциклы" },
                    { 25, 4, "Инструмент" },
                    { 19, 3, "Книги и журналы" },
                    { 26, 4, "Другое" },
                    { 28, 5, "Другое" },
                    { 29, 6, "Зимние спорттовары" },
                    { 30, 6, "Летние спорттовары" },
                    { 31, 6, "Всесезонные спорттовары" },
                    { 32, 6, "Туристические товары" },
                    { 33, 6, "Велотовары" },
                    { 27, 5, "Тренажеры" },
                    { 34, 6, "Туристические услуги" },
                    { 18, 3, "Музыкальные инструменты" },
                    { 16, 3, "Компьютерные игры" },
                    { 2, 1, "Женская одежда" },
                    { 3, 1, "Обувь" },
                    { 4, 1, "Для мероприятий" },
                    { 5, 1, "Аксессуары" },
                    { 6, 1, "Другое" },
                    { 7, 2, "Одежда" },
                    { 17, 3, "Настольные игры" },
                    { 8, 2, "Игрушки" },
                    { 10, 2, "Другое" },
                    { 11, 3, "Бытовая техника" },
                    { 12, 3, "Телефоны, планшеты, гаджеты" },
                    { 13, 3, "Компьютерная техника" },
                    { 14, 3, "Консоли" },
                    { 15, 3, "Другое" },
                    { 9, 2, "Транспорт и коляски" },
                    { 35, 6, "Другое" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subcategories_CategoryId",
                table: "Subcategories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subcategories_Categories_CategoryId",
                table: "Subcategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subcategories_Categories_CategoryId",
                table: "Subcategories");

            migrationBuilder.DropIndex(
                name: "IX_Subcategories_CategoryId",
                table: "Subcategories");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Subcategories");

            migrationBuilder.CreateTable(
                name: "CategorySubcategories",
                columns: table => new
                {
                    CategorySubcategoryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    SubcategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorySubcategories", x => x.CategorySubcategoryId);
                    table.ForeignKey(
                        name: "FK_CategorySubcategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategorySubcategories_Subcategories_SubcategoryId",
                        column: x => x.SubcategoryId,
                        principalTable: "Subcategories",
                        principalColumn: "SubcategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategorySubcategories_CategoryId",
                table: "CategorySubcategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategorySubcategories_SubcategoryId",
                table: "CategorySubcategories",
                column: "SubcategoryId");
        }
    }
}
