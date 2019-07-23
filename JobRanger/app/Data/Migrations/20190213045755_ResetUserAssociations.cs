using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class ResetUserAssociations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                "ApplicationUserUserName",
                "Job",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                "ApplicationUserUserName",
                "Interactions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                "ApplicationUserUserName",
                "Employer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "ApplicationUserUserName",
                "Job");

            migrationBuilder.DropColumn(
                "ApplicationUserUserName",
                "Interactions");

            migrationBuilder.DropColumn(
                "ApplicationUserUserName",
                "Employer");
        }
    }
}