using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class AddedInteractionTypeNameToInteractions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "ApplicationUserName",
                "Job");

            migrationBuilder.DropColumn(
                "ApplicationUserName",
                "Employer");

            migrationBuilder.RenameColumn(
                "ApplicationUserName",
                "Interactions",
                "InteractionTypeName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                "InteractionTypeName",
                "Interactions",
                "ApplicationUserName");

            migrationBuilder.AddColumn<string>(
                "ApplicationUserName",
                "Job",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                "ApplicationUserName",
                "Employer",
                nullable: true);
        }
    }
}