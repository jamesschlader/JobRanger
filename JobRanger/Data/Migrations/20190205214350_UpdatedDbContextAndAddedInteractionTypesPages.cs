using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class UpdatedDbContextAndAddedInteractionTypesPages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Action_Job_JobId",
                table: "Action");

            migrationBuilder.DropForeignKey(
                name: "FK_Action_InteractionTypes_TypeId",
                table: "Action");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Action",
                table: "Action");

            migrationBuilder.RenameTable(
                name: "Action",
                newName: "Interactions");

            migrationBuilder.RenameIndex(
                name: "IX_Action_TypeId",
                table: "Interactions",
                newName: "IX_Interactions_TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Action_JobId",
                table: "Interactions",
                newName: "IX_Interactions_JobId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Interactions",
                table: "Interactions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Interactions_Job_JobId",
                table: "Interactions",
                column: "JobId",
                principalTable: "Job",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Interactions_Job_JobId",
                table: "Interactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Interactions_InteractionTypes_TypeId",
                table: "Interactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Interactions",
                table: "Interactions");

            migrationBuilder.RenameTable(
                name: "Interactions",
                newName: "Action");

            migrationBuilder.RenameIndex(
                name: "IX_Interactions_TypeId",
                table: "Action",
                newName: "IX_Action_TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Interactions_JobId",
                table: "Action",
                newName: "IX_Action_JobId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Action",
                table: "Action",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Action_Job_JobId",
                table: "Action",
                column: "JobId",
                principalTable: "Job",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Action_InteractionTypes_TypeId",
                table: "Action",
                column: "TypeId",
                principalTable: "InteractionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
