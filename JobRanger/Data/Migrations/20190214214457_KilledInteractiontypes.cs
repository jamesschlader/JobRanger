using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class KilledInteractiontypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interactions_InteractionTypes_TypeId",
                table: "Interactions");

            migrationBuilder.DropTable(
                name: "InteractionTypes");

            migrationBuilder.DropIndex(
                name: "IX_Interactions_TypeId",
                table: "Interactions");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Interactions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Interactions",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "InteractionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InteractionTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Interactions_TypeId",
                table: "Interactions",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interactions_InteractionTypes_TypeId",
                table: "Interactions",
                column: "TypeId",
                principalTable: "InteractionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
