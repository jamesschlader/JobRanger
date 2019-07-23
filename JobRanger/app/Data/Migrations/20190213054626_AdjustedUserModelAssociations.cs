using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class AdjustedUserModelAssociations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                "ApplicationUserUserName",
                "Job",
                "ApplicationUserName");

            migrationBuilder.RenameColumn(
                "ApplicationUserUserName",
                "Interactions",
                "ApplicationUserName");

            migrationBuilder.RenameColumn(
                "ApplicationUserUserName",
                "Employer",
                "ApplicationUserName");

            migrationBuilder.AddColumn<string>(
                "ApplicationUserId",
                "Contact",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                "ApplicationUserName",
                "Contact",
                nullable: true);

            migrationBuilder.CreateIndex(
                "IX_Contact_ApplicationUserId",
                "Contact",
                "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                "FK_Contact_AspNetUsers_ApplicationUserId",
                "Contact",
                "ApplicationUserId",
                "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Contact_AspNetUsers_ApplicationUserId",
                "Contact");

            migrationBuilder.DropIndex(
                "IX_Contact_ApplicationUserId",
                "Contact");

            migrationBuilder.DropColumn(
                "ApplicationUserId",
                "Contact");

            migrationBuilder.DropColumn(
                "ApplicationUserName",
                "Contact");

            migrationBuilder.RenameColumn(
                "ApplicationUserName",
                "Job",
                "ApplicationUserUserName");

            migrationBuilder.RenameColumn(
                "ApplicationUserName",
                "Interactions",
                "ApplicationUserUserName");

            migrationBuilder.RenameColumn(
                "ApplicationUserName",
                "Employer",
                "ApplicationUserUserName");
        }
    }
}