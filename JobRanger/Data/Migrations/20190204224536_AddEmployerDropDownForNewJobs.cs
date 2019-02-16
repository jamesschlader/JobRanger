using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class AddEmployerDropDownForNewJobs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Job_Employer_EmployerId",
                "Job");

            migrationBuilder.AlterColumn<int>(
                "EmployerId",
                "Job",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                "FK_Job_Employer_EmployerId",
                "Job",
                "EmployerId",
                "Employer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Job_Employer_EmployerId",
                "Job");

            migrationBuilder.AlterColumn<int>(
                "EmployerId",
                "Job",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                "FK_Job_Employer_EmployerId",
                "Job",
                "EmployerId",
                "Employer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}