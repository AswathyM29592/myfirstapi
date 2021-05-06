using Microsoft.EntityFrameworkCore.Migrations;

namespace myfirstapi.Migrations
{
    public partial class CharacterCharUserRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CharUserId",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Characters_CharUserId",
                table: "Characters",
                column: "CharUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_CharUsers_CharUserId",
                table: "Characters",
                column: "CharUserId",
                principalTable: "CharUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_CharUsers_CharUserId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_CharUserId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "CharUserId",
                table: "Characters");
        }
    }
}
