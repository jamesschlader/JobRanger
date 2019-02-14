using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class AddedInteractionTypeNameToInteractions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicationUserName",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "ApplicationUserName",
                table: "Employer");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserName",
                table: "Interactions",
                newName: "InteractionTypeName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InteractionTypeName",
                table: "Interactions",
                newName: "ApplicationUserName");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserName",
                table: "Job",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserName",
                table: "Employer",
                nullable: true);
        }
    }
}
