using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class UpdateAgencySeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Agency SET IconSrc = '/lib/images/internships.svg' WHERE Id = 16");
            migrationBuilder.Sql("UPDATE Agency SET IconSrc = '/lib/images/simplyhired-logo.svg' WHERE Id =25");
            migrationBuilder.Sql("UPDATE Agency SET IconSrc = '/lib/images/snag-logo.svg' WHERE Id = 26");
            migrationBuilder.Sql("UPDATE Agency SET IconSrc = '/lib/images/stackoverflow-logo.svg' WHERE Id = 27");
            migrationBuilder.Sql("UPDATE Agency SET IconSrc = '/lib/images/talentzoo-logo.svg' WHERE Id = 28");
            migrationBuilder.Sql("UPDATE Agency SET IconSrc = '/lib/images/techcareer-logo.svg' WHERE Id = 29");
            migrationBuilder.Sql("UPDATE Agency SET IconSrc = '/lib/images/logo-upwork.svg' WHERE Id = 30");
            migrationBuilder.Sql("UPDATE Agency SET IconSrc = '/lib/images/USAJOBS.gov_logo.svg' WHERE Id = 31");
            migrationBuilder.Sql("UPDATE Agency SET IconSrc = '/lib/images/ziprecruiter-blacktext.svg' WHERE Id = 32");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, Website, IconSrc) VALUES ('AngelList', 'https://angel.co/', '/lib/images/angellist-logo.svg' )");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
