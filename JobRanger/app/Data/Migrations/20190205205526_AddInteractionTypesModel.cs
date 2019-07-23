using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class AddInteractionTypesModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "Type",
                "Action");

            migrationBuilder.AddColumn<int>(
                "TypeId",
                "Action",
                nullable: true);

            migrationBuilder.CreateTable(
                "InteractionTypes",
                table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_InteractionTypes", x => x.Id); });

            migrationBuilder.CreateIndex(
                "IX_Action_TypeId",
                "Action",
                "TypeId");

            migrationBuilder.AddForeignKey(
                "FK_Action_InteractionTypes_TypeId",
                "Action",
                "TypeId",
                "InteractionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Action_InteractionTypes_TypeId",
                "Action");

            migrationBuilder.DropTable(
                "InteractionTypes");

            migrationBuilder.DropIndex(
                "IX_Action_TypeId",
                "Action");

            migrationBuilder.DropColumn(
                "TypeId",
                "Action");

            migrationBuilder.AddColumn<int>(
                "Type",
                "Action",
                nullable: false,
                defaultValue: 0);
        }
    }
}