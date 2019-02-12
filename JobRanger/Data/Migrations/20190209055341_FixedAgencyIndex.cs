using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class FixedAgencyIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconSrc",
                table: "Agency");

            migrationBuilder.AddColumn<int>(
                name: "IconSrcId",
                table: "Agency",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Agency_IconSrcId",
                table: "Agency",
                column: "IconSrcId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agency_Icons_IconSrcId",
                table: "Agency",
                column: "IconSrcId",
                principalTable: "Icons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agency_Icons_IconSrcId",
                table: "Agency");

            migrationBuilder.DropIndex(
                name: "IX_Agency_IconSrcId",
                table: "Agency");

            migrationBuilder.DropColumn(
                name: "IconSrcId",
                table: "Agency");

            migrationBuilder.AddColumn<string>(
                name: "IconSrc",
                table: "Agency",
                nullable: true);
        }
    }
}
