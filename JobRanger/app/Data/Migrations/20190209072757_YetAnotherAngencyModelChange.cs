using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class YetAnotherAngencyModelChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Agency_Icons_IconsId",
                "Agency");

            migrationBuilder.DropIndex(
                "IX_Agency_IconsId",
                "Agency");

            migrationBuilder.DropColumn(
                "IconsId",
                "Agency");

            migrationBuilder.AddColumn<string>(
                "IconSrc",
                "Agency",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "IconSrc",
                "Agency");

            migrationBuilder.AddColumn<int>(
                "IconsId",
                "Agency",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                "IX_Agency_IconsId",
                "Agency",
                "IconsId");

            migrationBuilder.AddForeignKey(
                "FK_Agency_Icons_IconsId",
                "Agency",
                "IconsId",
                "Icons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}