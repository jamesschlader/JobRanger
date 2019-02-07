using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class UpdatedEmployerContactJobRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "Job",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Contact",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Job_ContactId",
                table: "Job",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Job_Contact_ContactId",
                table: "Job",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Job_Contact_ContactId",
                table: "Job");

            migrationBuilder.DropIndex(
                name: "IX_Job_ContactId",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Contact");
        }
    }
}
