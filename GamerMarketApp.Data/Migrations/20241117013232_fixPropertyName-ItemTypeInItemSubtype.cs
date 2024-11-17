using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GamerMarketApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixPropertyNameItemTypeInItemSubtype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemCategories_ItemsTypes_TypeId",
                table: "ItemCategories");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "ItemCategories",
                newName: "ItemTypeId");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "ItemCategories",
                newName: "SubtypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemCategories_TypeId",
                table: "ItemCategories",
                newName: "IX_ItemCategories_ItemTypeId");

           
            migrationBuilder.AddForeignKey(
                name: "FK_ItemCategories_ItemsTypes_ItemTypeId",
                table: "ItemCategories",
                column: "ItemTypeId",
                principalTable: "ItemsTypes",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemCategories_ItemsTypes_ItemTypeId",
                table: "ItemCategories");

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "SubtypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "SubtypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "SubtypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "SubtypeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "SubtypeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "SubtypeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "SubtypeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "SubtypeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "SubtypeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "SubtypeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "SubtypeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "SubtypeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "SubtypeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "SubtypeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "SubtypeId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "SubtypeId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "SubtypeId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "SubtypeId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "SubtypeId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "SubtypeId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "SubtypeId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "SubtypeId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "SubtypeId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "SubtypeId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "TypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "TypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "TypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "TypeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "TypeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "TypeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "TypeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "TypeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "TypeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "TypeId",
                keyValue: 10);

            migrationBuilder.RenameColumn(
                name: "ItemTypeId",
                table: "ItemCategories",
                newName: "TypeId");

            migrationBuilder.RenameColumn(
                name: "SubtypeId",
                table: "ItemCategories",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemCategories_ItemTypeId",
                table: "ItemCategories",
                newName: "IX_ItemCategories_TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemCategories_ItemsTypes_TypeId",
                table: "ItemCategories",
                column: "TypeId",
                principalTable: "ItemsTypes",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
