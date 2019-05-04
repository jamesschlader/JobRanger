using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class FixJobsOnlineLogo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Agency SET IconSrc = '/lib/images/jobappsonline-logo (1).svg' WHERE Id = 17");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
