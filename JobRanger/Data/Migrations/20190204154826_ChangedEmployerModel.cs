using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRanger.Data.Migrations
{
    public partial class ChangedEmployerModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                "ZipCode",
                "Employer",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<string>(
                "City",
                "Employer",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Address2",
                "Employer",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Address1",
                "Employer",
                maxLength: 75,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                "ZipCode",
                "Employer",
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                "City",
                "Employer",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Address2",
                "Employer",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Address1",
                "Employer",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 75,
                oldNullable: true);
        }
    }
}