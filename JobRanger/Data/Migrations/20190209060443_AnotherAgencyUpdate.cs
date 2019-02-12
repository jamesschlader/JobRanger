using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class AnotherAgencyUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agency_Icons_IconSrcId",
                table: "Agency");

            migrationBuilder.RenameColumn(
                name: "IconSrcId",
                table: "Agency",
                newName: "IconsId");

            migrationBuilder.RenameIndex(
                name: "IX_Agency_IconSrcId",
                table: "Agency",
                newName: "IX_Agency_IconsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agency_Icons_IconsId",
                table: "Agency",
                column: "IconsId",
                principalTable: "Icons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agency_Icons_IconsId",
                table: "Agency");

            migrationBuilder.RenameColumn(
                name: "IconsId",
                table: "Agency",
                newName: "IconSrcId");

            migrationBuilder.RenameIndex(
                name: "IX_Agency_IconsId",
                table: "Agency",
                newName: "IX_Agency_IconSrcId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agency_Icons_IconSrcId",
                table: "Agency",
                column: "IconSrcId",
                principalTable: "Icons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
