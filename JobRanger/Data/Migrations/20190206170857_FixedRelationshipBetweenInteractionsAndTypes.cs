using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class FixedRelationshipBetweenInteractionsAndTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Interactions_InteractionTypes_TypeId",
                "Interactions");

            migrationBuilder.DropIndex(
                "IX_Interactions_TypeId",
                "Interactions");

            migrationBuilder.DropColumn(
                "TypeId",
                "Interactions");

            migrationBuilder.AddColumn<int>(
                "InteractionTypesId",
                "Interactions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                "TargetTime",
                "Interactions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                "IX_Interactions_InteractionTypesId",
                "Interactions",
                "InteractionTypesId");

            migrationBuilder.AddForeignKey(
                "FK_Interactions_InteractionTypes_InteractionTypesId",
                "Interactions",
                "InteractionTypesId",
                "InteractionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Interactions_InteractionTypes_InteractionTypesId",
                "Interactions");

            migrationBuilder.DropIndex(
                "IX_Interactions_InteractionTypesId",
                "Interactions");

            migrationBuilder.DropColumn(
                "InteractionTypesId",
                "Interactions");

            migrationBuilder.DropColumn(
                "TargetTime",
                "Interactions");

            migrationBuilder.AddColumn<int>(
                "TypeId",
                "Interactions",
                nullable: true);

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