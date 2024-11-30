using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamerMarketApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeGamerItemToUserItemEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GamersItems_AspNetUsers_GamerId",
                table: "GamersItems");

            migrationBuilder.RenameColumn(
                name: "GamerId",
                table: "GamersItems",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_GamersItems_GamerId",
                table: "GamersItems",
                newName: "IX_GamersItems_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_GamersItems_AspNetUsers_UserId",
                table: "GamersItems",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GamersItems_AspNetUsers_UserId",
                table: "GamersItems");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "GamersItems",
                newName: "GamerId");

            migrationBuilder.RenameIndex(
                name: "IX_GamersItems_UserId",
                table: "GamersItems",
                newName: "IX_GamersItems_GamerId");

            migrationBuilder.AddForeignKey(
                name: "FK_GamersItems_AspNetUsers_GamerId",
                table: "GamersItems",
                column: "GamerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
