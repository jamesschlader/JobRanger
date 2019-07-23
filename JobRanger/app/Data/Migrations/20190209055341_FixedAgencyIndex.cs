using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class FixedAgencyIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "IconSrc",
                "Agency");

            migrationBuilder.AddColumn<int>(
                "IconSrcId",
                "Agency",
                nullable: true);

            migrationBuilder.CreateIndex(
                "IX_Agency_IconSrcId",
                "Agency",
                "IconSrcId");

            migrationBuilder.AddForeignKey(
                "FK_Agency_Icons_IconSrcId",
                "Agency",
                "IconSrcId",
                "Icons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Agency_Icons_IconSrcId",
                "Agency");

            migrationBuilder.DropIndex(
                "IX_Agency_IconSrcId",
                "Agency");

            migrationBuilder.DropColumn(
                "IconSrcId",
                "Agency");

            migrationBuilder.AddColumn<string>(
                "IconSrc",
                "Agency",
                nullable: true);
        }
    }
}