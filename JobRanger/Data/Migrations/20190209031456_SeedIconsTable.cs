using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class SeedIconsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/glassdoor.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/indeed-logo-768x199.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/monster-com-logo-768x126.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/ziprecruiter-blacktext.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/dice-com-icon.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/techcrunch-icon.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/e-financialcareers-icon.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/jobsonthemenu-icon.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/healthcarejobsitecom-icon.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/jobsinlogistics-icon.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/mediabistro-icon.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/journalismjobs-icon.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/salesgravy-icon.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/talentzoo-icon.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/techcareerscom-icon.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/idealist-icon.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/stackoverflow-icon.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/usajobs-icon.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/behance-icon.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/IEEE_JS_LOGO.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/venturebeat-icon.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/mashableJobBoardLogo-icon.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/snag-logo.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/flexjobs-logo.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/upwork-icon.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/careerbuilder-icon.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/simplyhired-icon.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/ladders-icon.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/craigslist-icon.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/linkedin-icon.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/careerarc-icon.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/college-recruiter-icon.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/internships-icon.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/linkup-icon.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/jobappsonline-icon.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/careercloud-icon.svg')");
            migrationBuilder.Sql("INSERT INTO Icons (Source) VALUES ('/lib/images/payscale-icon.svg')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}