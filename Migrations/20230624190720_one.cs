using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DR.Migrations
{
    /// <inheritdoc />
    public partial class one : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "login",
                columns: table => new
                {
                    username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_login", x => x.username);
                });

            migrationBuilder.CreateTable(
                name: "prescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Drug1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Drug2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Drug3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Drug4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Drug5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfDoses1 = table.Column<int>(type: "int", nullable: true),
                    NumberOfDoses2 = table.Column<int>(type: "int", nullable: true),
                    NumberOfDoses3 = table.Column<int>(type: "int", nullable: true),
                    NumberOfDoses4 = table.Column<int>(type: "int", nullable: true),
                    NumberOfDoses5 = table.Column<int>(type: "int", nullable: true),
                    Manufacturer1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer5 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prescriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Receivings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameSick = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WhereToLive = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateSession = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TypeOfInspection = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: true),
                    ChronicDiseases = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receivings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "diagnosis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TheNameOfTheDisease = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdReceiving = table.Column<int>(type: "int", nullable: true),
                    ReceivingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diagnosis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_diagnosis_Receivings_ReceivingId",
                        column: x => x.ReceivingId,
                        principalTable: "Receivings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "prescriptionDDDs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPrescription = table.Column<int>(type: "int", nullable: true),
                    IdDiagnosis = table.Column<int>(type: "int", nullable: true),
                    PrescriptionId = table.Column<int>(type: "int", nullable: false),
                    DiagnosisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prescriptionDDDs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_prescriptionDDDs_diagnosis_DiagnosisId",
                        column: x => x.DiagnosisId,
                        principalTable: "diagnosis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_prescriptionDDDs_prescriptions_PrescriptionId",
                        column: x => x.PrescriptionId,
                        principalTable: "prescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_diagnosis_ReceivingId",
                table: "diagnosis",
                column: "ReceivingId");

            migrationBuilder.CreateIndex(
                name: "IX_prescriptionDDDs_DiagnosisId",
                table: "prescriptionDDDs",
                column: "DiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_prescriptionDDDs_PrescriptionId",
                table: "prescriptionDDDs",
                column: "PrescriptionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "login");

            migrationBuilder.DropTable(
                name: "prescriptionDDDs");

            migrationBuilder.DropTable(
                name: "diagnosis");

            migrationBuilder.DropTable(
                name: "prescriptions");

            migrationBuilder.DropTable(
                name: "Receivings");
        }
    }
}
