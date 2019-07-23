using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class UpdatedEmployerContactJobRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                "ContactId",
                "Job",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                "Title",
                "Contact",
                nullable: true);

            migrationBuilder.CreateIndex(
                "IX_Job_ContactId",
                "Job",
                "ContactId");

            migrationBuilder.AddForeignKey(
                "FK_Job_Contact_ContactId",
                "Job",
                "ContactId",
                "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Job_Contact_ContactId",
                "Job");

            migrationBuilder.DropIndex(
                "IX_Job_ContactId",
                "Job");

            migrationBuilder.DropColumn(
                "ContactId",
                "Job");

            migrationBuilder.DropColumn(
                "Title",
                "Contact");
        }
    }
}