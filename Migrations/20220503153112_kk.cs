using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Teledock_Web_Application.Migrations
{
    public partial class kk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LegalEntity_Ucheriditel_UcheriditelNomerId",
                table: "LegalEntity");

            migrationBuilder.DropIndex(
                name: "IX_LegalEntity_UcheriditelNomerId",
                table: "LegalEntity");

            migrationBuilder.DropColumn(
                name: "UcheriditelNomerId",
                table: "LegalEntity");

            migrationBuilder.AddColumn<int>(
                name: "LegalEntityModelid",
                table: "Ucheriditel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ucheriditel_LegalEntityModelid",
                table: "Ucheriditel",
                column: "LegalEntityModelid");

            migrationBuilder.AddForeignKey(
                name: "FK_Ucheriditel_LegalEntity_LegalEntityModelid",
                table: "Ucheriditel",
                column: "LegalEntityModelid",
                principalTable: "LegalEntity",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ucheriditel_LegalEntity_LegalEntityModelid",
                table: "Ucheriditel");

            migrationBuilder.DropIndex(
                name: "IX_Ucheriditel_LegalEntityModelid",
                table: "Ucheriditel");

            migrationBuilder.DropColumn(
                name: "LegalEntityModelid",
                table: "Ucheriditel");

            migrationBuilder.AddColumn<int>(
                name: "UcheriditelNomerId",
                table: "LegalEntity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LegalEntity_UcheriditelNomerId",
                table: "LegalEntity",
                column: "UcheriditelNomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_LegalEntity_Ucheriditel_UcheriditelNomerId",
                table: "LegalEntity",
                column: "UcheriditelNomerId",
                principalTable: "Ucheriditel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
