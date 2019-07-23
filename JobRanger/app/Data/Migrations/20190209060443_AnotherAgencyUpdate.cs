using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class AnotherAgencyUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Agency_Icons_IconSrcId",
                "Agency");

            migrationBuilder.RenameColumn(
                "IconSrcId",
                "Agency",
                "IconsId");

            migrationBuilder.RenameIndex(
                "IX_Agency_IconSrcId",
                table: "Agency",
                newName: "IX_Agency_IconsId");

            migrationBuilder.AddForeignKey(
                "FK_Agency_Icons_IconsId",
                "Agency",
                "IconsId",
                "Icons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Agency_Icons_IconsId",
                "Agency");

            migrationBuilder.RenameColumn(
                "IconsId",
                "Agency",
                "IconSrcId");

            migrationBuilder.RenameIndex(
                "IX_Agency_IconsId",
                table: "Agency",
                newName: "IX_Agency_IconSrcId");

            migrationBuilder.AddForeignKey(
                "FK_Agency_Icons_IconSrcId",
                "Agency",
                "IconSrcId",
                "Icons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}