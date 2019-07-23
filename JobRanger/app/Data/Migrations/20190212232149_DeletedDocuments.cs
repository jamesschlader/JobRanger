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
                "FK_Agency_AspNetUsers_ApplicationUserId",
                "Agency");

            migrationBuilder.DropTable(
                "Document");

            migrationBuilder.DropIndex(
                "IX_Agency_ApplicationUserId",
                "Agency");

            migrationBuilder.DropColumn(
                "ApplicationUserId",
                "Agency");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                "ApplicationUserId",
                "Agency",
                nullable: true);

            migrationBuilder.CreateTable(
                "Document",
                table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
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
                        "FK_Document_AspNetUsers_ApplicationUserId",
                        x => x.ApplicationUserId,
                        "AspNetUsers",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                "IX_Agency_ApplicationUserId",
                "Agency",
                "ApplicationUserId");

            migrationBuilder.CreateIndex(
                "IX_Document_ApplicationUserId",
                "Document",
                "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                "FK_Agency_AspNetUsers_ApplicationUserId",
                "Agency",
                "ApplicationUserId",
                "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}