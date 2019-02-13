using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class DeletedDocuments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agency_AspNetUsers_ApplicationUserId",
                table: "Agency");

            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropIndex(
                name: "IX_Agency_ApplicationUserId",
                table: "Agency");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Agency");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Agency",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    ContentSize = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    RawContent = table.Column<byte[]>(nullable: true),
                    UploadDT = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Document_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agency_ApplicationUserId",
                table: "Agency",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_ApplicationUserId",
                table: "Document",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agency_AspNetUsers_ApplicationUserId",
                table: "Agency",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
