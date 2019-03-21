using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicSystem.Migrations
{
    public partial class District : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Patient",
                type: "varchar(12)",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<string>(
                name: "Iin",
                table: "Patient",
                type: "varchar(12)",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "Patient",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "District",
                table: "Patient");

            migrationBuilder.AlterColumn<long>(
                name: "Phone",
                table: "Patient",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(12)",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Iin",
                table: "Patient",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(12)",
                oldNullable: true);
        }
    }
}
