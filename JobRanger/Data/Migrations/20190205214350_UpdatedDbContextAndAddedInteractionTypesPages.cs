using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class UpdatedDbContextAndAddedInteractionTypesPages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Action_Job_JobId",
                "Action");

            migrationBuilder.DropForeignKey(
                "FK_Action_InteractionTypes_TypeId",
                "Action");

            migrationBuilder.DropPrimaryKey(
                "PK_Action",
                "Action");

            migrationBuilder.RenameTable(
                "Action",
                newName: "Interactions");

            migrationBuilder.RenameIndex(
                "IX_Action_TypeId",
                table: "Interactions",
                newName: "IX_Interactions_TypeId");

            migrationBuilder.RenameIndex(
                "IX_Action_JobId",
                table: "Interactions",
                newName: "IX_Interactions_JobId");

            migrationBuilder.AddPrimaryKey(
                "PK_Interactions",
                "Interactions",
                "Id");

            migrationBuilder.AddForeignKey(
                "FK_Interactions_Job_JobId",
                "Interactions",
                "JobId",
                "Job",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_Interactions_InteractionTypes_TypeId",
                "Interactions",
                "TypeId",
                "InteractionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Interactions_Job_JobId",
                "Interactions");

            migrationBuilder.DropForeignKey(
                "FK_Interactions_InteractionTypes_TypeId",
                "Interactions");

            migrationBuilder.DropPrimaryKey(
                "PK_Interactions",
                "Interactions");

            migrationBuilder.RenameTable(
                "Interactions",
                newName: "Action");

            migrationBuilder.RenameIndex(
                "IX_Interactions_TypeId",
                table: "Action",
                newName: "IX_Action_TypeId");

            migrationBuilder.RenameIndex(
                "IX_Interactions_JobId",
                table: "Action",
                newName: "IX_Action_JobId");

            migrationBuilder.AddPrimaryKey(
                "PK_Action",
                "Action",
                "Id");

            migrationBuilder.AddForeignKey(
                "FK_Action_Job_JobId",
                "Action",
                "JobId",
                "Job",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_Action_InteractionTypes_TypeId",
                "Action",
                "TypeId",
                "InteractionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}