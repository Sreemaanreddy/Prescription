using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Prescription.Migrations
{
    /// <inheritdoc />
    public partial class PrescriptionDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PrescriptionModel",
                columns: table => new
                {
                    PrescriptionModelId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MedicationName = table.Column<string>(type: "TEXT", nullable: false),
                    FillStatus = table.Column<string>(type: "TEXT", nullable: false),
                    Cost = table.Column<double>(type: "REAL", nullable: false),
                    RequestTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrescriptionModel", x => x.PrescriptionModelId);
                });

            migrationBuilder.InsertData(
                table: "PrescriptionModel",
                columns: new[] { "PrescriptionModelId", "Cost", "FillStatus", "MedicationName", "RequestTime" },
                values: new object[,]
                {
                    { 1, 12.5, "Pending", "Amoxicillin", new DateTime(2025, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 8.75, "Filled", "Ibuprofen", new DateTime(2025, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 20.0, "Denied", "Metformin", new DateTime(2025, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrescriptionModel");
        }
    }
}
