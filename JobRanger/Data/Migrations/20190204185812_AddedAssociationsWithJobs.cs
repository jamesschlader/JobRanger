using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class AddedAssociationsWithJobs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                "AgencyId",
                "Job",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                "EmployerId",
                "Job",
                nullable: true);

            migrationBuilder.CreateIndex(
                "IX_Job_AgencyId",
                "Job",
                "AgencyId");

            migrationBuilder.CreateIndex(
                "IX_Job_EmployerId",
                "Job",
                "EmployerId");

            migrationBuilder.AddForeignKey(
                "FK_Job_Agency_AgencyId",
                "Job",
                "AgencyId",
                "Agency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_Job_Employer_EmployerId",
                "Job",
                "EmployerId",
                "Employer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Job_Agency_AgencyId",
                "Job");

            migrationBuilder.DropForeignKey(
                "FK_Job_Employer_EmployerId",
                "Job");

            migrationBuilder.DropIndex(
                "IX_Job_AgencyId",
                "Job");

            migrationBuilder.DropIndex(
                "IX_Job_EmployerId",
                "Job");

            migrationBuilder.DropColumn(
                "AgencyId",
                "Job");

            migrationBuilder.DropColumn(
                "EmployerId",
                "Job");
        }
    }
}