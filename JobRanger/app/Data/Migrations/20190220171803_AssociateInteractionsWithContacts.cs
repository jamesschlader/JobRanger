using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class AssociateInteractionsWithContacts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "Interactions",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Interactions_ContactId",
                table: "Interactions",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interactions_Contact_ContactId",
                table: "Interactions",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interactions_Contact_ContactId",
                table: "Interactions");

            migrationBuilder.DropIndex(
                name: "IX_Interactions_ContactId",
                table: "Interactions");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "Interactions");
        }
    }
}
