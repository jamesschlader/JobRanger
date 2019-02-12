using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class ChangedDocumentModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "RawContent",
                table: "Document",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RawContent",
                table: "Document");
        }
    }
}
