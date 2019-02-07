using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class SeedInteractionTypesII : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("INSERT INTO InteractionTypes (Name) VALUES ('Call')");
            migrationBuilder.Sql("INSERT INTO InteractionTypes (Name) VALUES ('Write')");
            migrationBuilder.Sql("INSERT INTO InteractionTypes (Name) VALUES ('Email')");
            migrationBuilder.Sql("INSERT INTO InteractionTypes (Name) VALUES ('Visit')");
            migrationBuilder.Sql("INSERT INTO InteractionTypes (Name) VALUES ('Interview')");
            migrationBuilder.Sql("INSERT INTO InteractionTypes (Name) VALUES ('Offer')");
            migrationBuilder.Sql("INSERT INTO InteractionTypes (Name) VALUES ('Accept')");
            migrationBuilder.Sql("INSERT INTO InteractionTypes (Name) VALUES ('Decline')");
            migrationBuilder.Sql("INSERT INTO InteractionTypes (Name) VALUES ('WillFollowUp')");
            migrationBuilder.Sql("INSERT INTO InteractionTypes (Name) VALUES ('DidFollowUp')");
            migrationBuilder.Sql("INSERT INTO InteractionTypes (Name) VALUES ('RequestInfo')");
            migrationBuilder.Sql("INSERT INTO InteractionTypes (Name) VALUES ('Applied')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
