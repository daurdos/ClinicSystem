using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicSystem.Migrations
{
    public partial class Migr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Iin = table.Column<string>(maxLength: 12, nullable: false),
                    FName = table.Column<string>(maxLength: 30, nullable: false),
                    LName = table.Column<string>(maxLength: 30, nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    District = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visit",
                columns: table => new
                {
                    VisitId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SFName = table.Column<string>(nullable: true),
                    SLName = table.Column<string>(nullable: true),
                    Specialist = table.Column<string>(nullable: true),
                    Complaint = table.Column<string>(nullable: true),
                    Diagnosis = table.Column<string>(nullable: true),
                    VisitDate = table.Column<DateTime>(nullable: false),
                    PatientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visit", x => x.VisitId);
                    table.ForeignKey(
                        name: "FK_Visit_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Visit_PatientId",
                table: "Visit",
                column: "PatientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visit");

            migrationBuilder.DropTable(
                name: "Patient");
        }
    }
}
