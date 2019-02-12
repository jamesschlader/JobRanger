using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class FixedAgencyIndexAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agency_Icons_IconsId",
                table: "Agency");

            migrationBuilder.DropColumn(
                name: "IronSrcId",
                table: "Agency");

            migrationBuilder.AlterColumn<int>(
                name: "IconsId",
                table: "Agency",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Agency_Icons_IconsId",
                table: "Agency",
                column: "IconsId",
                principalTable: "Icons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agency_Icons_IconsId",
                table: "Agency");

            migrationBuilder.AlterColumn<int>(
                name: "IconsId",
                table: "Agency",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "IronSrcId",
                table: "Agency",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Agency_Icons_IconsId",
                table: "Agency",
                column: "IconsId",
                principalTable: "Icons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
