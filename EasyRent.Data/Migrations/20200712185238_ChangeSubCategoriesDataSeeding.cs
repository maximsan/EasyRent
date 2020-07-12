using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyRent.Data.Migrations
{
    public partial class ChangeSubCategoriesDataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 8,
                column: "Name",
                value: "Обувь");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 9,
                column: "Name",
                value: "Игрушки");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 10,
                column: "Name",
                value: "Транспорт и коляски");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 11,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 2, "Другое" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 12,
                column: "Name",
                value: "Бытовая техника");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 13,
                column: "Name",
                value: "Телефоны, планшеты, гаджеты");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 14,
                column: "Name",
                value: "Компьютерная техника");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 15,
                column: "Name",
                value: "Консоли");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 16,
                column: "Name",
                value: "Другое");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 17,
                column: "Name",
                value: "Компьютерные игры");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 18,
                column: "Name",
                value: "Настольные игры");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 19,
                column: "Name",
                value: "Музыкальные инструменты");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 20,
                column: "Name",
                value: "Книги и журналы");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 21,
                column: "Name",
                value: "Охота и рыбалка");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 22,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 3, "Другое" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 23,
                column: "Name",
                value: "Одежда");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 24,
                column: "Name",
                value: "Обувь");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 25,
                column: "Name",
                value: "Аксессуары");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 26,
                column: "Name",
                value: "Мебель");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 27,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 4, "Другое" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 28,
                column: "Name",
                value: "Автомобили");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 29,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 5, "Мотоциклы, квадроциклы" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 30,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 5, "Аксессуары" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 31,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 5, "Инструмент" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 32,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 5, "Другое" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 33,
                column: "Name",
                value: "Инструмент");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 34,
                column: "Name",
                value: "Другое");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 35,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 7, "Тренажеры" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "SubcategoryId", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 44, 9, "Инструмент" },
                    { 43, 8, "Другое" },
                    { 42, 8, "Туристические услуги" },
                    { 41, 8, "Велотовары" },
                    { 40, 8, "Туристические товары" },
                    { 39, 8, "Всесезонные спорттовары" },
                    { 38, 8, "Летние спорттовары" },
                    { 37, 8, "Зимние спорттовары" },
                    { 45, 9, "Другое" },
                    { 36, 7, "Другое" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 45);

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 8,
                column: "Name",
                value: "Игрушки");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 9,
                column: "Name",
                value: "Транспорт и коляски");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 10,
                column: "Name",
                value: "Другое");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 11,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 3, "Бытовая техника" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 12,
                column: "Name",
                value: "Телефоны, планшеты, гаджеты");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 13,
                column: "Name",
                value: "Компьютерная техника");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 14,
                column: "Name",
                value: "Консоли");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 15,
                column: "Name",
                value: "Другое");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 16,
                column: "Name",
                value: "Компьютерные игры");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 17,
                column: "Name",
                value: "Настольные игры");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 18,
                column: "Name",
                value: "Музыкальные инструменты");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 19,
                column: "Name",
                value: "Книги и журналы");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 20,
                column: "Name",
                value: "Охота и рыбалка");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 21,
                column: "Name",
                value: "Другое");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 22,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 4, "Мебель" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 23,
                column: "Name",
                value: "Автомобили");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 24,
                column: "Name",
                value: "Мотоциклы, квадроциклы");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 25,
                column: "Name",
                value: "Инструмент");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 26,
                column: "Name",
                value: "Другое");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 27,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 5, "Тренажеры" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 28,
                column: "Name",
                value: "Другое");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 29,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 6, "Зимние спорттовары" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 30,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 6, "Летние спорттовары" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 31,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 6, "Всесезонные спорттовары" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 32,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 6, "Туристические товары" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 33,
                column: "Name",
                value: "Велотовары");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 34,
                column: "Name",
                value: "Туристические услуги");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: 35,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 6, "Другое" });
        }
    }
}
