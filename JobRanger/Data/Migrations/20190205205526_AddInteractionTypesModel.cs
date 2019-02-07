using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class AddInteractionTypesModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Action");

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Action",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "InteractionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InteractionTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Action_TypeId",
                table: "Action",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Action_InteractionTypes_TypeId",
                table: "Action",
                column: "TypeId",
                principalTable: "InteractionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Action_InteractionTypes_TypeId",
                table: "Action");

            migrationBuilder.DropTable(
                name: "InteractionTypes");

            migrationBuilder.DropIndex(
                name: "IX_Action_TypeId",
                table: "Action");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Action");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Action",
                nullable: false,
                defaultValue: 0);
        }
    }
}
