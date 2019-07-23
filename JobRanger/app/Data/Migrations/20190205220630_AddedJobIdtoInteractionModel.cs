using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class AddedJobIdtoInteractionModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Interactions_Job_JobId",
                "Interactions");

            migrationBuilder.AlterColumn<int>(
                "JobId",
                "Interactions",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                "FK_Interactions_Job_JobId",
                "Interactions",
                "JobId",
                "Job",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Interactions_Job_JobId",
                "Interactions");

            migrationBuilder.AlterColumn<int>(
                "JobId",
                "Interactions",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                "FK_Interactions_Job_JobId",
                "Interactions",
                "JobId",
                "Job",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}