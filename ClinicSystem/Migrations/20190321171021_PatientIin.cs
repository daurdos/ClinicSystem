using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicSystem.Migrations
{
    public partial class PatientIin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PatientIin",
                table: "Visit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PatientIin",
                table: "Visit");
        }
    }
}
