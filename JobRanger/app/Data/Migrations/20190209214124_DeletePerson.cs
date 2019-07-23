using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class DeletePerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Agency_Persons_PersonId",
                "Agency");

            migrationBuilder.DropForeignKey(
                "FK_Contact_Persons_PersonId",
                "Contact");

            migrationBuilder.DropForeignKey(
                "FK_Document_Persons_PersonId",
                "Document");

            migrationBuilder.DropForeignKey(
                "FK_Document_Persons_PersonId1",
                "Document");

            migrationBuilder.DropForeignKey(
                "FK_Employer_Persons_PersonId",
                "Employer");

            migrationBuilder.DropForeignKey(
                "FK_Interactions_Persons_PersonId",
                "Interactions");

            migrationBuilder.DropForeignKey(
                "FK_Job_Persons_PersonId",
                "Job");

            migrationBuilder.DropTable(
                "Persons");

            migrationBuilder.DropIndex(
                "IX_Job_PersonId",
                "Job");

            migrationBuilder.DropIndex(
                "IX_Interactions_PersonId",
                "Interactions");

            migrationBuilder.DropIndex(
                "IX_Employer_PersonId",
                "Employer");

            migrationBuilder.DropIndex(
                "IX_Document_PersonId",
                "Document");

            migrationBuilder.DropIndex(
                "IX_Document_PersonId1",
                "Document");

            migrationBuilder.DropIndex(
                "IX_Contact_PersonId",
                "Contact");

            migrationBuilder.DropIndex(
                "IX_Agency_PersonId",
                "Agency");

            migrationBuilder.DropColumn(
                "PersonId",
                "Job");

            migrationBuilder.DropColumn(
                "PersonId",
                "Interactions");

            migrationBuilder.DropColumn(
                "PersonId",
                "Employer");

            migrationBuilder.DropColumn(
                "PersonId",
                "Document");

            migrationBuilder.DropColumn(
                "PersonId1",
                "Document");

            migrationBuilder.DropColumn(
                "PersonId",
                "Contact");

            migrationBuilder.DropColumn(
                "PersonId",
                "Agency");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                "PersonId",
                "Job",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                "PersonId",
                "Interactions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                "PersonId",
                "Employer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                "PersonId",
                "Document",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                "PersonId1",
                "Document",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                "PersonId",
                "Contact",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                "PersonId",
                "Agency",
                nullable: true);

            migrationBuilder.CreateTable(
                "Persons",
                table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
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
                        "FK_Persons_AspNetUsers_UserId1",
                        x => x.UserId1,
                        "AspNetUsers",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                "IX_Job_PersonId",
                "Job",
                "PersonId");

            migrationBuilder.CreateIndex(
                "IX_Interactions_PersonId",
                "Interactions",
                "PersonId");

            migrationBuilder.CreateIndex(
                "IX_Employer_PersonId",
                "Employer",
                "PersonId");

            migrationBuilder.CreateIndex(
                "IX_Document_PersonId",
                "Document",
                "PersonId");

            migrationBuilder.CreateIndex(
                "IX_Document_PersonId1",
                "Document",
                "PersonId1");

            migrationBuilder.CreateIndex(
                "IX_Contact_PersonId",
                "Contact",
                "PersonId");

            migrationBuilder.CreateIndex(
                "IX_Agency_PersonId",
                "Agency",
                "PersonId");

            migrationBuilder.CreateIndex(
                "IX_Persons_UserId1",
                "Persons",
                "UserId1");

            migrationBuilder.AddForeignKey(
                "FK_Agency_Persons_PersonId",
                "Agency",
                "PersonId",
                "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_Contact_Persons_PersonId",
                "Contact",
                "PersonId",
                "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_Document_Persons_PersonId",
                "Document",
                "PersonId",
                "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_Document_Persons_PersonId1",
                "Document",
                "PersonId1",
                "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_Employer_Persons_PersonId",
                "Employer",
                "PersonId",
                "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_Interactions_Persons_PersonId",
                "Interactions",
                "PersonId",
                "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_Job_Persons_PersonId",
                "Job",
                "PersonId",
                "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}