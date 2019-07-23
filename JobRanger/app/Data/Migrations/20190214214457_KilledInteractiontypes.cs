using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class KilledInteractiontypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Interactions_InteractionTypes_TypeId",
                "Interactions");

            migrationBuilder.DropTable(
                "InteractionTypes");

            migrationBuilder.DropIndex(
                "IX_Interactions_TypeId",
                "Interactions");

            migrationBuilder.DropColumn(
                "TypeId",
                "Interactions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                "TypeId",
                "Interactions",
                nullable: true);

            migrationBuilder.CreateTable(
                "InteractionTypes",
                table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_InteractionTypes", x => x.Id); });

            migrationBuilder.CreateIndex(
                "IX_Interactions_TypeId",
                "Interactions",
                "TypeId");

            migrationBuilder.AddForeignKey(
                "FK_Interactions_InteractionTypes_TypeId",
                "Interactions",
                "TypeId",
                "InteractionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}