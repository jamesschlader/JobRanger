using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class AdjustedUserModelAssociations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ApplicationUserUserName",
                table: "Job",
                newName: "ApplicationUserName");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserUserName",
                table: "Interactions",
                newName: "ApplicationUserName");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserUserName",
                table: "Employer",
                newName: "ApplicationUserName");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Contact",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserName",
                table: "Contact",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contact_ApplicationUserId",
                table: "Contact",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_AspNetUsers_ApplicationUserId",
                table: "Contact",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_AspNetUsers_ApplicationUserId",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_ApplicationUserId",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "ApplicationUserName",
                table: "Contact");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserName",
                table: "Job",
                newName: "ApplicationUserUserName");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserName",
                table: "Interactions",
                newName: "ApplicationUserUserName");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserName",
                table: "Employer",
                newName: "ApplicationUserUserName");
        }
    }
}
