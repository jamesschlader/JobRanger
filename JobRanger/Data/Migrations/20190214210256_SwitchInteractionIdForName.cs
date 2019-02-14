using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class SwitchInteractionIdForName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interactions_InteractionTypes_InteractionTypesId",
                table: "Interactions");

            migrationBuilder.DropIndex(
                name: "IX_Interactions_InteractionTypesId",
                table: "Interactions");

            migrationBuilder.DropColumn(
                name: "InteractionTypesId",
                table: "Interactions");

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Interactions",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Interactions_TypeId",
                table: "Interactions",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interactions_InteractionTypes_TypeId",
                table: "Interactions",
                column: "TypeId",
                principalTable: "InteractionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interactions_InteractionTypes_TypeId",
                table: "Interactions");

            migrationBuilder.DropIndex(
                name: "IX_Interactions_TypeId",
                table: "Interactions");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Interactions");

            migrationBuilder.AddColumn<int>(
                name: "InteractionTypesId",
                table: "Interactions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Interactions_InteractionTypesId",
                table: "Interactions",
                column: "InteractionTypesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interactions_InteractionTypes_InteractionTypesId",
                table: "Interactions",
                column: "InteractionTypesId",
                principalTable: "InteractionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
