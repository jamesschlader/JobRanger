using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class AddedApplicationUserModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Job",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Interactions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Employer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Document",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Agency",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Job_ApplicationUserId",
                table: "Job",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Interactions_ApplicationUserId",
                table: "Interactions",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Employer_ApplicationUserId",
                table: "Employer",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_ApplicationUserId",
                table: "Document",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Agency_ApplicationUserId",
                table: "Agency",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agency_AspNetUsers_ApplicationUserId",
                table: "Agency",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Document_AspNetUsers_ApplicationUserId",
                table: "Document",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employer_AspNetUsers_ApplicationUserId",
                table: "Employer",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Interactions_AspNetUsers_ApplicationUserId",
                table: "Interactions",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Job_AspNetUsers_ApplicationUserId",
                table: "Job",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agency_AspNetUsers_ApplicationUserId",
                table: "Agency");

            migrationBuilder.DropForeignKey(
                name: "FK_Document_AspNetUsers_ApplicationUserId",
                table: "Document");

            migrationBuilder.DropForeignKey(
                name: "FK_Employer_AspNetUsers_ApplicationUserId",
                table: "Employer");

            migrationBuilder.DropForeignKey(
                name: "FK_Interactions_AspNetUsers_ApplicationUserId",
                table: "Interactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Job_AspNetUsers_ApplicationUserId",
                table: "Job");

            migrationBuilder.DropIndex(
                name: "IX_Job_ApplicationUserId",
                table: "Job");

            migrationBuilder.DropIndex(
                name: "IX_Interactions_ApplicationUserId",
                table: "Interactions");

            migrationBuilder.DropIndex(
                name: "IX_Employer_ApplicationUserId",
                table: "Employer");

            migrationBuilder.DropIndex(
                name: "IX_Document_ApplicationUserId",
                table: "Document");

            migrationBuilder.DropIndex(
                name: "IX_Agency_ApplicationUserId",
                table: "Agency");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Interactions");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Employer");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Document");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Agency");
        }
    }
}
