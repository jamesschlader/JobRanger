using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class FixedAgencyIndexAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Agency_Icons_IconsId",
                "Agency");

            migrationBuilder.DropColumn(
                "IronSrcId",
                "Agency");

            migrationBuilder.AlterColumn<int>(
                "IconsId",
                "Agency",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                "FK_Agency_Icons_IconsId",
                "Agency",
                "IconsId",
                "Icons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Agency_Icons_IconsId",
                "Agency");

            migrationBuilder.AlterColumn<int>(
                "IconsId",
                "Agency",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                "IronSrcId",
                "Agency",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                "FK_Agency_Icons_IconsId",
                "Agency",
                "IconsId",
                "Icons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}