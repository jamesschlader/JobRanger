using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class AddedApplicationUserModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                "ApplicationUserId",
                "Job",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                "ApplicationUserId",
                "Interactions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                "ApplicationUserId",
                "Employer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                "ApplicationUserId",
                "Document",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                "FirstName",
                "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                "LastName",
                "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                "ApplicationUserId",
                "Agency",
                nullable: true);

            migrationBuilder.CreateIndex(
                "IX_Job_ApplicationUserId",
                "Job",
                "ApplicationUserId");

            migrationBuilder.CreateIndex(
                "IX_Interactions_ApplicationUserId",
                "Interactions",
                "ApplicationUserId");

            migrationBuilder.CreateIndex(
                "IX_Employer_ApplicationUserId",
                "Employer",
                "ApplicationUserId");

            migrationBuilder.CreateIndex(
                "IX_Document_ApplicationUserId",
                "Document",
                "ApplicationUserId");

            migrationBuilder.CreateIndex(
                "IX_Agency_ApplicationUserId",
                "Agency",
                "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                "FK_Agency_AspNetUsers_ApplicationUserId",
                "Agency",
                "ApplicationUserId",
                "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_Document_AspNetUsers_ApplicationUserId",
                "Document",
                "ApplicationUserId",
                "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_Employer_AspNetUsers_ApplicationUserId",
                "Employer",
                "ApplicationUserId",
                "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_Interactions_AspNetUsers_ApplicationUserId",
                "Interactions",
                "ApplicationUserId",
                "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_Job_AspNetUsers_ApplicationUserId",
                "Job",
                "ApplicationUserId",
                "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Agency_AspNetUsers_ApplicationUserId",
                "Agency");

            migrationBuilder.DropForeignKey(
                "FK_Document_AspNetUsers_ApplicationUserId",
                "Document");

            migrationBuilder.DropForeignKey(
                "FK_Employer_AspNetUsers_ApplicationUserId",
                "Employer");

            migrationBuilder.DropForeignKey(
                "FK_Interactions_AspNetUsers_ApplicationUserId",
                "Interactions");

            migrationBuilder.DropForeignKey(
                "FK_Job_AspNetUsers_ApplicationUserId",
                "Job");

            migrationBuilder.DropIndex(
                "IX_Job_ApplicationUserId",
                "Job");

            migrationBuilder.DropIndex(
                "IX_Interactions_ApplicationUserId",
                "Interactions");

            migrationBuilder.DropIndex(
                "IX_Employer_ApplicationUserId",
                "Employer");

            migrationBuilder.DropIndex(
                "IX_Document_ApplicationUserId",
                "Document");

            migrationBuilder.DropIndex(
                "IX_Agency_ApplicationUserId",
                "Agency");

            migrationBuilder.DropColumn(
                "ApplicationUserId",
                "Job");

            migrationBuilder.DropColumn(
                "ApplicationUserId",
                "Interactions");

            migrationBuilder.DropColumn(
                "ApplicationUserId",
                "Employer");

            migrationBuilder.DropColumn(
                "ApplicationUserId",
                "Document");

            migrationBuilder.DropColumn(
                "FirstName",
                "AspNetUsers");

            migrationBuilder.DropColumn(
                "LastName",
                "AspNetUsers");

            migrationBuilder.DropColumn(
                "ApplicationUserId",
                "Agency");
        }
    }
}