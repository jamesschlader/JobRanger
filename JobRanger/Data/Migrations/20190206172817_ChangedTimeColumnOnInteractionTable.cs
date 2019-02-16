using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class ChangedTimeColumnOnInteractionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                "TargetTime",
                "Interactions",
                "Date",
                nullable: false,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                "TargetTime",
                "Interactions",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");
        }
    }
}