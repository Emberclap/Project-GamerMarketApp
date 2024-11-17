using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamerMarketApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class changeTableNameItemCategoriesToItemSubtypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemCategories_ItemsTypes_ItemTypeId",
                table: "ItemCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemCategories",
                table: "ItemCategories");

            migrationBuilder.RenameTable(
                name: "ItemCategories",
                newName: "ItemSubtypes");

            migrationBuilder.RenameIndex(
                name: "IX_ItemCategories_ItemTypeId",
                table: "ItemSubtypes",
                newName: "IX_ItemSubtypes_ItemTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemSubtypes",
                table: "ItemSubtypes",
                column: "SubtypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemSubtypes_ItemsTypes_ItemTypeId",
                table: "ItemSubtypes",
                column: "ItemTypeId",
                principalTable: "ItemsTypes",
                principalColumn: "ItemTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemSubtypes_ItemsTypes_ItemTypeId",
                table: "ItemSubtypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemSubtypes",
                table: "ItemSubtypes");

            migrationBuilder.RenameTable(
                name: "ItemSubtypes",
                newName: "ItemCategories");

            migrationBuilder.RenameIndex(
                name: "IX_ItemSubtypes_ItemTypeId",
                table: "ItemCategories",
                newName: "IX_ItemCategories_ItemTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemCategories",
                table: "ItemCategories",
                column: "SubtypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemCategories_ItemsTypes_ItemTypeId",
                table: "ItemCategories",
                column: "ItemTypeId",
                principalTable: "ItemsTypes",
                principalColumn: "ItemTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
