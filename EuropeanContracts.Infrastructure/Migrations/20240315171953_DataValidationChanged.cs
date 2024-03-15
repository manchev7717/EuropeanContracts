using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EuropeanContracts.Infrastructure.Migrations
{
    public partial class DataValidationChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trailers_TransportsCompanies_OwnerId",
                table: "Trailers");

            migrationBuilder.DropForeignKey(
                name: "FK_Trucks_TransportsCompanies_OwnerId",
                table: "Trucks");

            migrationBuilder.DropIndex(
                name: "IX_Trucks_OwnerId",
                table: "Trucks");

            migrationBuilder.DropIndex(
                name: "IX_Trailers_OwnerId",
                table: "Trailers");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Trailers");

            migrationBuilder.DropColumn(
                name: "PoductName",
                table: "Offers");

            migrationBuilder.AddColumn<bool>(
                name: "HasTemperatureControl",
                table: "Trucks",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Is there temperature control");

            migrationBuilder.AddColumn<int>(
                name: "TransportCompanyId",
                table: "Trucks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Owner identifier");

            migrationBuilder.AddColumn<string>(
                name: "TruckImageURL",
                table: "Trucks",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Track image URL");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "TransportsCompanies",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Transport company phone number",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldComment: "Transport company phone number");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "TransportsCompanies",
                type: "nvarchar(450)",
                nullable: false,
                comment: "Owner identifier",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "TransportsCompanies",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                comment: "Transport company address",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Transport company address");

            migrationBuilder.AddColumn<string>(
                name: "TrailerImageURL",
                table: "Trailers",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Trailer image URL");

            migrationBuilder.AddColumn<int>(
                name: "TransportCompanyId",
                table: "Trailers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Owner identifier");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "SuppliersCompanies",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Supplier company phone number",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldComment: "Supplier company phone number");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "RecipientsCompanies",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Recipient company phone number",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldComment: "Recipient company phone number");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "RecipientsCompanies",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                comment: "Recipient company identifier",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Recipient company identifier");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "RecipientsCompanies",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                comment: "Recipient company address",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Recipient company address");

            migrationBuilder.AlterColumn<int>(
                name: "TransporterId",
                table: "Offers",
                type: "int",
                nullable: true,
                comment: "Transport company identifier",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "Offers",
                type: "int",
                nullable: false,
                comment: "Supplier identifier",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RecipientId",
                table: "Offers",
                type: "int",
                nullable: true,
                comment: "Recipient identifier",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductQuantity",
                table: "Offers",
                type: "int",
                maxLength: 2147483647,
                nullable: false,
                comment: "Product quantity in kilograms",
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 2147483647,
                oldComment: "Product quantity");

            migrationBuilder.AlterColumn<decimal>(
                name: "ProductPrice",
                table: "Offers",
                type: "decimal(18,6)",
                nullable: false,
                comment: "Product price in EURO",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)",
                oldComment: "Product price");

            migrationBuilder.AlterColumn<string>(
                name: "ProductDescription",
                table: "Offers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                comment: "Product additional description",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldComment: "Product additional description");

            migrationBuilder.AlterColumn<string>(
                name: "LoadingAddress",
                table: "Offers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                comment: "Loadring address",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Loadring address");

            migrationBuilder.AddColumn<string>(
                name: "AddressOfDestination",
                table: "Offers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                comment: "Address of destination");

            migrationBuilder.AddColumn<string>(
                name: "CountryOfDestination",
                table: "Offers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                comment: "Country of destination");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveryTime",
                table: "Offers",
                type: "datetime2",
                nullable: true,
                comment: "Time of delivery");

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "Offers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                comment: "Product name");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ActionsTypes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Name of action",
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldComment: "Name of action");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ActionsTypes",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                comment: "Action type additional description",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldComment: "Action type additional description");

            migrationBuilder.CreateIndex(
                name: "IX_Trucks_TransportCompanyId",
                table: "Trucks",
                column: "TransportCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Trailers_TransportCompanyId",
                table: "Trailers",
                column: "TransportCompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trailers_TransportsCompanies_TransportCompanyId",
                table: "Trailers",
                column: "TransportCompanyId",
                principalTable: "TransportsCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trucks_TransportsCompanies_TransportCompanyId",
                table: "Trucks",
                column: "TransportCompanyId",
                principalTable: "TransportsCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trailers_TransportsCompanies_TransportCompanyId",
                table: "Trailers");

            migrationBuilder.DropForeignKey(
                name: "FK_Trucks_TransportsCompanies_TransportCompanyId",
                table: "Trucks");

            migrationBuilder.DropIndex(
                name: "IX_Trucks_TransportCompanyId",
                table: "Trucks");

            migrationBuilder.DropIndex(
                name: "IX_Trailers_TransportCompanyId",
                table: "Trailers");

            migrationBuilder.DropColumn(
                name: "HasTemperatureControl",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "TransportCompanyId",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "TruckImageURL",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "TrailerImageURL",
                table: "Trailers");

            migrationBuilder.DropColumn(
                name: "TransportCompanyId",
                table: "Trailers");

            migrationBuilder.DropColumn(
                name: "AddressOfDestination",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "CountryOfDestination",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "DeliveryTime",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "Offers");

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Trucks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "TransportsCompanies",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                comment: "Transport company phone number",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Transport company phone number");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "TransportsCompanies",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldComment: "Owner identifier");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "TransportsCompanies",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Transport company address",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldComment: "Transport company address");

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Trailers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "SuppliersCompanies",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                comment: "Supplier company phone number",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Supplier company phone number");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "RecipientsCompanies",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                comment: "Recipient company phone number",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Recipient company phone number");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "RecipientsCompanies",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Recipient company identifier",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldComment: "Recipient company identifier");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "RecipientsCompanies",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Recipient company address",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldComment: "Recipient company address");

            migrationBuilder.AlterColumn<int>(
                name: "TransporterId",
                table: "Offers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Transport company identifier");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "Offers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Supplier identifier");

            migrationBuilder.AlterColumn<int>(
                name: "RecipientId",
                table: "Offers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Recipient identifier");

            migrationBuilder.AlterColumn<int>(
                name: "ProductQuantity",
                table: "Offers",
                type: "int",
                maxLength: 2147483647,
                nullable: false,
                comment: "Product quantity",
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 2147483647,
                oldComment: "Product quantity in kilograms");

            migrationBuilder.AlterColumn<decimal>(
                name: "ProductPrice",
                table: "Offers",
                type: "decimal(18,6)",
                nullable: false,
                comment: "Product price",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)",
                oldComment: "Product price in EURO");

            migrationBuilder.AlterColumn<string>(
                name: "ProductDescription",
                table: "Offers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                comment: "Product additional description",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldComment: "Product additional description");

            migrationBuilder.AlterColumn<string>(
                name: "LoadingAddress",
                table: "Offers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Loadring address",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldComment: "Loadring address");

            migrationBuilder.AddColumn<string>(
                name: "PoductName",
                table: "Offers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                comment: "Product name");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ActionsTypes",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                comment: "Name of action",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Name of action");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ActionsTypes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                comment: "Action type additional description",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldComment: "Action type additional description");

            migrationBuilder.CreateIndex(
                name: "IX_Trucks_OwnerId",
                table: "Trucks",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Trailers_OwnerId",
                table: "Trailers",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trailers_TransportsCompanies_OwnerId",
                table: "Trailers",
                column: "OwnerId",
                principalTable: "TransportsCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trucks_TransportsCompanies_OwnerId",
                table: "Trucks",
                column: "OwnerId",
                principalTable: "TransportsCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
