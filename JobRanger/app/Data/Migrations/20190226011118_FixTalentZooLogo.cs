using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class FixTalentZooLogo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Agency SET IconSrc = '/lib/images/talentzoo-logo (1).svg' WHERE Id = 28");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
