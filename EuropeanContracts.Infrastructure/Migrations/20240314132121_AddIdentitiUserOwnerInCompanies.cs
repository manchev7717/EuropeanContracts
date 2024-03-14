using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EuropeanContracts.Infrastructure.Migrations
{
    public partial class AddIdentitiUserOwnerInCompanies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "TransportsCompanies",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "SuppliersCompanies",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "RecipientsCompanies",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_TransportsCompanies_OwnerId",
                table: "TransportsCompanies",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_SuppliersCompanies_OwnerId",
                table: "SuppliersCompanies",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipientsCompanies_OwnerId",
                table: "RecipientsCompanies",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipientsCompanies_AspNetUsers_OwnerId",
                table: "RecipientsCompanies",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SuppliersCompanies_AspNetUsers_OwnerId",
                table: "SuppliersCompanies",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransportsCompanies_AspNetUsers_OwnerId",
                table: "TransportsCompanies",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipientsCompanies_AspNetUsers_OwnerId",
                table: "RecipientsCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_SuppliersCompanies_AspNetUsers_OwnerId",
                table: "SuppliersCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportsCompanies_AspNetUsers_OwnerId",
                table: "TransportsCompanies");

            migrationBuilder.DropIndex(
                name: "IX_TransportsCompanies_OwnerId",
                table: "TransportsCompanies");

            migrationBuilder.DropIndex(
                name: "IX_SuppliersCompanies_OwnerId",
                table: "SuppliersCompanies");

            migrationBuilder.DropIndex(
                name: "IX_RecipientsCompanies_OwnerId",
                table: "RecipientsCompanies");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "TransportsCompanies");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "SuppliersCompanies");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "RecipientsCompanies");
        }
    }
}
