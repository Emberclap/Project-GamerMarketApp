using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamerMarketApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangedItemTypeToItemSubTypeFIx : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemsTypes_SubTypeId",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "ItemTypeId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemTypeId",
                table: "Items",
                column: "ItemTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemSubtypes_SubTypeId",
                table: "Items",
                column: "SubTypeId",
                principalTable: "ItemSubtypes",
                principalColumn: "SubtypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemsTypes_ItemTypeId",
                table: "Items",
                column: "ItemTypeId",
                principalTable: "ItemsTypes",
                principalColumn: "ItemTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemSubtypes_SubTypeId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemsTypes_ItemTypeId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ItemTypeId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ItemTypeId",
                table: "Items");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemsTypes_SubTypeId",
                table: "Items",
                column: "SubTypeId",
                principalTable: "ItemsTypes",
                principalColumn: "ItemTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
