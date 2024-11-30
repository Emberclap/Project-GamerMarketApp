using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamerMarketApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameDbSets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GamersItems_AspNetUsers_UserId",
                table: "GamersItems");

            migrationBuilder.DropForeignKey(
                name: "FK_GamersItems_Items_ItemId",
                table: "GamersItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemSubtypes_ItemsTypes_ItemTypeId",
                table: "ItemSubtypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemsTypes",
                table: "ItemsTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GamersItems",
                table: "GamersItems");

            migrationBuilder.RenameTable(
                name: "ItemsTypes",
                newName: "ItemTypes");

            migrationBuilder.RenameTable(
                name: "GamersItems",
                newName: "UserItems");

            migrationBuilder.RenameIndex(
                name: "IX_GamersItems_UserId",
                table: "UserItems",
                newName: "IX_UserItems_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemTypes",
                table: "ItemTypes",
                column: "ItemTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserItems",
                table: "UserItems",
                columns: new[] { "ItemId", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ItemSubtypes_ItemTypes_ItemTypeId",
                table: "ItemSubtypes",
                column: "ItemTypeId",
                principalTable: "ItemTypes",
                principalColumn: "ItemTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserItems_AspNetUsers_UserId",
                table: "UserItems",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserItems_Items_ItemId",
                table: "UserItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemSubtypes_ItemTypes_ItemTypeId",
                table: "ItemSubtypes");

            migrationBuilder.DropForeignKey(
                name: "FK_UserItems_AspNetUsers_UserId",
                table: "UserItems");

            migrationBuilder.DropForeignKey(
                name: "FK_UserItems_Items_ItemId",
                table: "UserItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserItems",
                table: "UserItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemTypes",
                table: "ItemTypes");

            migrationBuilder.RenameTable(
                name: "UserItems",
                newName: "GamersItems");

            migrationBuilder.RenameTable(
                name: "ItemTypes",
                newName: "ItemsTypes");

            migrationBuilder.RenameIndex(
                name: "IX_UserItems_UserId",
                table: "GamersItems",
                newName: "IX_GamersItems_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GamersItems",
                table: "GamersItems",
                columns: new[] { "ItemId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemsTypes",
                table: "ItemsTypes",
                column: "ItemTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_GamersItems_AspNetUsers_UserId",
                table: "GamersItems",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GamersItems_Items_ItemId",
                table: "GamersItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemSubtypes_ItemsTypes_ItemTypeId",
                table: "ItemSubtypes",
                column: "ItemTypeId",
                principalTable: "ItemsTypes",
                principalColumn: "ItemTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
