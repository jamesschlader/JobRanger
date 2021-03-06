﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class SeedAgencies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Glassdoor','https://www.glassdoor.com/index.htm','/lib/images/glassdoor.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Behance','https://www.behance.net/joblist','/lib/images/behance-icon.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('CareerArc','https://www.careerarc.com/','/lib/images/careerarc-icon.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('CareerBuilder','https://www.careerbuilder.com/','/lib/images/careerbuilder-icon.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('CareerCloud','https://www.careercloud.com/','/lib/images/careercloud-icon.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('CollegeRecruiter','https://www.collegerecruiter.com/','/lib/images/college-recruiter-icon.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('CraigsList','https://craigslist.org/','/lib/images/craigslist-icon.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('CulIntro','https://culintro.com/','/lib/images/culintro-icon.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Dice','https://www.dice.com/','/lib/images/dice-com-icon.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('efinancialcareers','https://www.efinancialcareers.com/','/lib/images/e-financialcareers-icon.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Flexjobs','https://www.flexjobs.com/','/lib/images/flexjobs-logo.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Healthcare Jobsite.com','https://www.healthcarejobsite.com/','/lib/images/healthcarejobsitecom-icon.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Idealist','https://www.idealist.org/en/?type=JOB','/lib/images/idealist-icon.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('IEEE JobSite','https://jobs.ieee.org/','/lib/images/IEEE_JS_LOGO.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Indeed','https://www.indeed.com/','/lib/images/indeed-logo-768x199.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Interships.com','https://www.internships.com/','/lib/images/interships-icon.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('JobApplicationsOnline.com','https://www.jobapplicationsonline.com/','/lib/images/jobsappsonline-logo.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('The Ladders','https://www.theladders.com/','/lib/images/ladders-icon.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('LinkedIn Jobs','https://www.linkedin.com/jobs/','/lib/images/linkedin-icon.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('LinkUp','https://www.linkup.com/','/lib/images/linkup-icon.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Mashable Job Board','http://jobs.mashable.com/','/lib/images/mashableJobBoardLogo.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Media Bistro','https://www.mediabistro.com/jobs/','/lib/images/mediabistro-icon.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Monster.com','https://www.monster.com/','/lib/images/monster-com-logo-768x126.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('SalesGravy','https://www.salesgravy.com/JobBoard/','/lib/images/salesgravy-logo.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('SimplyHired','https://www.simplyhired.com/','/lib/image/simplyhired-logo.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Snagajob','https://www.snagajob.com/','/lib/image/snag-logo.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('StackOverflow Jobs','https://stackoverflow.com/jobs/get-started','/lib/image/stackoverflow-icon.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('Talent Zoo','http://www.talentzoo.com/','/lib/image/talentzoo-logo.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('TechCareers','https://www.techcareers.com/','/lib/image/techcareerscom-icon.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('UpWork','https://www.upwork.com/','/lib/image/upwork-icon.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('USAJOBS','https://www.usajobs.gov/','/lib/image/usajobs-icon.svg')");
            migrationBuilder.Sql(
                "INSERT INTO Agency (Name, WebSite, IconSrc) VALUES ('ZipRecruiter','https://www.ziprecruiter.com','/lib/image/ziprecruiter-blacktext.svg')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}