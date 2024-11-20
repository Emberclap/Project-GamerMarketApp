using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamerMarketApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangedItemTypeToItemSubType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemsTypes_TypeId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Items",
                newName: "SubTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_TypeId",
                table: "Items",
                newName: "IX_Items_SubTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemsTypes_SubTypeId",
                table: "Items",
                column: "SubTypeId",
                principalTable: "ItemsTypes",
                principalColumn: "ItemTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemsTypes_SubTypeId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "SubTypeId",
                table: "Items",
                newName: "TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_SubTypeId",
                table: "Items",
                newName: "IX_Items_TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemsTypes_TypeId",
                table: "Items",
                column: "TypeId",
                principalTable: "ItemsTypes",
                principalColumn: "ItemTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
