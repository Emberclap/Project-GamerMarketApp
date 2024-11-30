using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamerMarketApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameDbSets2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserItems_AspNetUsers_UserId",
                table: "UserItems");

            migrationBuilder.DropForeignKey(
                name: "FK_UserItems_Items_ItemId",
                table: "UserItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserItems",
                table: "UserItems");

            migrationBuilder.RenameTable(
                name: "UserItems",
                newName: "UsersItems");

            migrationBuilder.RenameIndex(
                name: "IX_UserItems_UserId",
                table: "UsersItems",
                newName: "IX_UsersItems_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersItems",
                table: "UsersItems",
                columns: new[] { "ItemId", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UsersItems_AspNetUsers_UserId",
                table: "UsersItems",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersItems_Items_ItemId",
                table: "UsersItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersItems_AspNetUsers_UserId",
                table: "UsersItems");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersItems_Items_ItemId",
                table: "UsersItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersItems",
                table: "UsersItems");

            migrationBuilder.RenameTable(
                name: "UsersItems",
                newName: "UserItems");

            migrationBuilder.RenameIndex(
                name: "IX_UsersItems_UserId",
                table: "UserItems",
                newName: "IX_UserItems_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserItems",
                table: "UserItems",
                columns: new[] { "ItemId", "UserId" });

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
                onDelete: ReferentialAction.Cascade);
        }
    }
}
