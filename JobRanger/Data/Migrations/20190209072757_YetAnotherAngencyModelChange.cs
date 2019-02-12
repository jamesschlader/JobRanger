using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class YetAnotherAngencyModelChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agency_Icons_IconsId",
                table: "Agency");

            migrationBuilder.DropIndex(
                name: "IX_Agency_IconsId",
                table: "Agency");

            migrationBuilder.DropColumn(
                name: "IconsId",
                table: "Agency");

            migrationBuilder.AddColumn<string>(
                name: "IconSrc",
                table: "Agency",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconSrc",
                table: "Agency");

            migrationBuilder.AddColumn<int>(
                name: "IconsId",
                table: "Agency",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Agency_IconsId",
                table: "Agency",
                column: "IconsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agency_Icons_IconsId",
                table: "Agency",
                column: "IconsId",
                principalTable: "Icons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
