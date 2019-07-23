using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class DropAgencyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Job_Agency_AgencyId",
                "Job");

            migrationBuilder.DropTable(
                "Agency");

            migrationBuilder.DropTable(
                "Icons");

            migrationBuilder.DropIndex(
                "IX_Job_AgencyId",
                "Job");

            migrationBuilder.DropColumn(
                "AgencyId",
                "Job");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                "AgencyId",
                "Job",
                nullable: true);

            migrationBuilder.CreateTable(
                "Agency",
                table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    IconSrc = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    WebSite = table.Column<string>(nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Agency", x => x.Id); });

            migrationBuilder.CreateTable(
                "Icons",
                table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    Source = table.Column<string>(nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_Icons", x => x.Id); });

            migrationBuilder.CreateIndex(
                "IX_Job_AgencyId",
                "Job",
                "AgencyId");

            migrationBuilder.AddForeignKey(
                "FK_Job_Agency_AgencyId",
                "Job",
                "AgencyId",
                "Agency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}