using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class ResetUserAssociations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserUserName",
                table: "Job",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserUserName",
                table: "Interactions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserUserName",
                table: "Employer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicationUserUserName",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "ApplicationUserUserName",
                table: "Interactions");

            migrationBuilder.DropColumn(
                name: "ApplicationUserUserName",
                table: "Employer");
        }
    }
}
