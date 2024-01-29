using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RelationsNaN.Migrations
{
    /// <inheritdoc />
    public partial class xxx : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Game",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Game_GameId",
                table: "Game",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Game_GameId",
                table: "Game",
                column: "GameId",
                principalTable: "Game",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Game_GameId",
                table: "Game");

            migrationBuilder.DropIndex(
                name: "IX_Game_GameId",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Game");
        }
    }
}
