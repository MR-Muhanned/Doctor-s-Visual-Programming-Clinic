using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DR.Migrations
{
    /// <inheritdoc />
    public partial class forinki : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_diagnosis_Receivings_ReceivingId",
                table: "diagnosis");

            migrationBuilder.DropIndex(
                name: "IX_diagnosis_ReceivingId",
                table: "diagnosis");

            migrationBuilder.DropColumn(
                name: "ReceivingId",
                table: "diagnosis");

            migrationBuilder.RenameColumn(
                name: "IdReceiving",
                table: "diagnosis",
                newName: "Receiving");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Receiving",
                table: "diagnosis",
                newName: "IdReceiving");

            migrationBuilder.AddColumn<int>(
                name: "ReceivingId",
                table: "diagnosis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_diagnosis_ReceivingId",
                table: "diagnosis",
                column: "ReceivingId");

            migrationBuilder.AddForeignKey(
                name: "FK_diagnosis_Receivings_ReceivingId",
                table: "diagnosis",
                column: "ReceivingId",
                principalTable: "Receivings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
