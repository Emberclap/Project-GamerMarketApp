using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamerMarketApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeToPropNameSubTypeToSubtype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemSubtypes_SubTypeId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "SubTypeId",
                table: "Items",
                newName: "SubtypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_SubTypeId",
                table: "Items",
                newName: "IX_Items_SubtypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemSubtypes_SubtypeId",
                table: "Items",
                column: "SubtypeId",
                principalTable: "ItemSubtypes",
                principalColumn: "SubtypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemSubtypes_SubtypeId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "SubtypeId",
                table: "Items",
                newName: "SubTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_SubtypeId",
                table: "Items",
                newName: "IX_Items_SubTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemSubtypes_SubTypeId",
                table: "Items",
                column: "SubTypeId",
                principalTable: "ItemSubtypes",
                principalColumn: "SubtypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
