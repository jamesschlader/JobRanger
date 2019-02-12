using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class DeletePerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agency_Persons_PersonId",
                table: "Agency");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Persons_PersonId",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_Document_Persons_PersonId",
                table: "Document");

            migrationBuilder.DropForeignKey(
                name: "FK_Document_Persons_PersonId1",
                table: "Document");

            migrationBuilder.DropForeignKey(
                name: "FK_Employer_Persons_PersonId",
                table: "Employer");

            migrationBuilder.DropForeignKey(
                name: "FK_Interactions_Persons_PersonId",
                table: "Interactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Job_Persons_PersonId",
                table: "Job");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Job_PersonId",
                table: "Job");

            migrationBuilder.DropIndex(
                name: "IX_Interactions_PersonId",
                table: "Interactions");

            migrationBuilder.DropIndex(
                name: "IX_Employer_PersonId",
                table: "Employer");

            migrationBuilder.DropIndex(
                name: "IX_Document_PersonId",
                table: "Document");

            migrationBuilder.DropIndex(
                name: "IX_Document_PersonId1",
                table: "Document");

            migrationBuilder.DropIndex(
                name: "IX_Contact_PersonId",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Agency_PersonId",
                table: "Agency");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Interactions");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Employer");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Document");

            migrationBuilder.DropColumn(
                name: "PersonId1",
                table: "Document");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Agency");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Job",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Interactions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Employer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Document",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonId1",
                table: "Document",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Contact",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Agency",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address1 = table.Column<string>(maxLength: 75, nullable: true),
                    Address2 = table.Column<string>(maxLength: 50, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<string>(nullable: false),
                    ZipCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Job_PersonId",
                table: "Job",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Interactions_PersonId",
                table: "Interactions",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Employer_PersonId",
                table: "Employer",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_PersonId",
                table: "Document",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_PersonId1",
                table: "Document",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_PersonId",
                table: "Contact",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Agency_PersonId",
                table: "Agency",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_UserId1",
                table: "Persons",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Agency_Persons_PersonId",
                table: "Agency",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Persons_PersonId",
                table: "Contact",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Document_Persons_PersonId",
                table: "Document",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Document_Persons_PersonId1",
                table: "Document",
                column: "PersonId1",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employer_Persons_PersonId",
                table: "Employer",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Interactions_Persons_PersonId",
                table: "Interactions",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Job_Persons_PersonId",
                table: "Job",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
