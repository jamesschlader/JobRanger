using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class AdjustedAgencyModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IronSrcId",
                table: "Agency",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IronSrcId",
                table: "Agency");
        }
    }
}
