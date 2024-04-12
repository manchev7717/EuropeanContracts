using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EuropeanContracts.Infrastructure.Migrations
{
    public partial class ChangeNameOfModelFromTruckToAutoTruck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Trucks_TruckId",
                table: "Offers");

            migrationBuilder.DropTable(
                name: "Trucks");

            migrationBuilder.CreateTable(
                name: "AutoTrucks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Truck identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Truck make"),
                    Model = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Truck model"),
                    HorsePower = table.Column<int>(type: "int", maxLength: 10000, nullable: false, comment: "Truck horse power"),
                    TruckImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Track image URL"),
                    HasCargoSpace = table.Column<bool>(type: "bit", nullable: false, comment: "Is there in truck cargo space"),
                    HasTemperatureControl = table.Column<bool>(type: "bit", nullable: false, comment: "Is there temperature control"),
                    TransportCompanyId = table.Column<int>(type: "int", nullable: false, comment: "Owner identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoTrucks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AutoTrucks_TransportsCompanies_TransportCompanyId",
                        column: x => x.TransportCompanyId,
                        principalTable: "TransportsCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Track");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0s3a2w5e-sad5-12s5-owls-psdasfas5f5n",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0580544d-ac4e-43aa-ac7b-0c234b3f75d4", "AQAAAAEAACcQAAAAENl2yJsbGOsKzo5QOnCOpZQlWNvhXTCUG+zfG3EF/kkJ8LQq1FtxhB5VHV68O8vSeg==", "f149e3e1-bd5c-45dc-b30b-5f6260faf38f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5lk6e95e-lyj5-w25e-8w5q-9q7w8c6u3spo",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cb45f22-c334-450c-9125-04537d309033", "AQAAAAEAACcQAAAAEKIJqUM63ocvJN8BUBkFmaYSE5Fe21oKh4VSM9QZoOLulEUN7Ij4Z7+A7quFLLS5FA==", "00bdc0a2-38ff-4f27-b6e3-7ce13f3fb1f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d33qwej9-02ap-11mnl-hflp-lpszavr2s588",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9f62d9f-3859-4e8e-9826-591193653342", "AQAAAAEAACcQAAAAEKE5x3WGoVBKruIiw9IioznZ8tSAIkfvVXzoRnVwe+9NfM60rCfYnVB/2xCcZR5S3g==", "3740c20c-f7d3-4a1b-8ae9-205c35c94e1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d69wrpfj-asdr-uijj-j5ff-5s8q7w4e4532",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffc245ae-e9dd-4d2c-80b1-52f813472ad0", "AQAAAAEAACcQAAAAEKBJSrxQx/l8pJ3QTfre3J3SM8kcBQ0eBJ2nOM0GjGVb8COB+ahYYSqS4pTNh4bR+w==", "fc775585-c8d5-4be1-8547-805c3372d068" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd2d2a66-rer7-y9y9-qlpq-w56a9w8s5a32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00ffbe68-4674-44fe-bcc4-17a3f3ba5966", "AQAAAAEAACcQAAAAEOLLXCdyiXmTJn1FnQy4YKASGKIILTt1DRkgBWI+9qQSzIHhqCxhGbMCUoYPX1Bl6g==", "f0f7df2c-ff2f-475d-ba34-af5d3c70a51a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k21se8s5-plow-4sw4-qzp0-128fpq6zr8klo",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69c2ed87-b4d3-4278-a89b-227ef8ba688d", "AQAAAAEAACcQAAAAEIW8Glh+pAAziu8BZsqIC9ZrvASz8VJzxd2i2Y/zrN72YmNgNJ9Dt2h048t9cdxMEg==", "87576009-dc10-4177-85e6-5c75a92e40dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k3fcll56-l458-6871-q3r9-2ve3w9a54s87",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4684b6ab-313a-4456-b81a-c42383a3c523", "AQAAAAEAACcQAAAAECIz4coVblmHwqFn7zlgd99U4Ha9DhJXjMF0W8GkEKhrxaGQ2X3GqoT6vVIimPXiyg==", "515d3223-b292-478d-bb0d-d9e397161b46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "QWE15t6s-hfgd-998q-mcs1-pekc249wlfhn",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04b6f9c9-16ff-44cd-97e1-132ab7e26b10", "AQAAAAEAACcQAAAAEPI71SI+HH27vWzBPyPnJwhxMGAltR3mEz+f2npn4s/4S2KvZtuAPr6RXWxupdvuQA==", "02ddcced-0a71-4f4f-af0a-ab66d2963131" });

            migrationBuilder.InsertData(
                table: "AutoTrucks",
                columns: new[] { "Id", "HasCargoSpace", "HasTemperatureControl", "HorsePower", "Make", "Model", "TransportCompanyId", "TruckImageURL" },
                values: new object[,]
                {
                    { 1, false, false, 450, "DAF", "XG+", 1, "/Images/TruckImages/DAF.png" },
                    { 2, false, false, 500, "VOLVO", "FX", 2, "/Images/TruckImages/VOLVO.png" },
                    { 3, true, false, 510, "SCANIA", "R510", 2, "/Images/TruckImages/SCANIA.png" },
                    { 4, true, false, 450, "DAF", "XF+", 2, "/Images/TruckImages/DAF-XF-FRIGO.png" }
                });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 10, 23, 46, 47, 753, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 10, 23, 46, 47, 753, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 10, 23, 46, 47, 753, DateTimeKind.Local).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 10, 23, 46, 47, 753, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.CreateIndex(
                name: "IX_AutoTrucks_TransportCompanyId",
                table: "AutoTrucks",
                column: "TransportCompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_AutoTrucks_TruckId",
                table: "Offers",
                column: "TruckId",
                principalTable: "AutoTrucks",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_AutoTrucks_TruckId",
                table: "Offers");

            migrationBuilder.DropTable(
                name: "AutoTrucks");

            migrationBuilder.CreateTable(
                name: "Trucks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Truck identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransportCompanyId = table.Column<int>(type: "int", nullable: false, comment: "Owner identifier"),
                    HasCargoSpace = table.Column<bool>(type: "bit", nullable: false, comment: "Is there in truck cargo space"),
                    HasTemperatureControl = table.Column<bool>(type: "bit", nullable: false, comment: "Is there temperature control"),
                    HorsePower = table.Column<int>(type: "int", maxLength: 10000, nullable: false, comment: "Truck horse power"),
                    Make = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Truck make"),
                    Model = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Truck model"),
                    TruckImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Track image URL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trucks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trucks_TransportsCompanies_TransportCompanyId",
                        column: x => x.TransportCompanyId,
                        principalTable: "TransportsCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Track");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0s3a2w5e-sad5-12s5-owls-psdasfas5f5n",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac17fb56-d8b3-4177-9fe6-2cc29b7b114a", "AQAAAAEAACcQAAAAEM1il8VJ4SYUUQrxJd9c/2OKlS4s6Qb+XLsWSro2ydM24ebSlEyVp1HI/qChyNQ2NQ==", "4561b1e1-37ef-4fd3-bfe6-8640d25c856c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5lk6e95e-lyj5-w25e-8w5q-9q7w8c6u3spo",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fe59197-4b9e-428e-9a7c-cad2d4d55836", "AQAAAAEAACcQAAAAEMgCmJhfFJUooGrdBbK5za4C+2jhEJYZiAgGii4Dszj/D4/LCB6KVN6FtMkxYUwV8Q==", "0d33d141-4dd0-4821-9f64-2b3713c3fb30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d33qwej9-02ap-11mnl-hflp-lpszavr2s588",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f16f6870-bca6-4b37-9c69-58de7d20339e", "AQAAAAEAACcQAAAAEGK6dyFGO1M3bPmCVRbVTbWPncl1gqIEMl5FOGBRN0D/kL+QRJpqj5/C7If1hbw/lQ==", "d11a8cd4-83ce-4c5f-8816-c05be6bc6e2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d69wrpfj-asdr-uijj-j5ff-5s8q7w4e4532",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c33365de-ffed-4d62-99ee-bf47c63ab4c6", "AQAAAAEAACcQAAAAEKoz1jcQHXnDTQu/bJVJ4yQ6Pg15bTRwUt8HYZuSEwAK+v/zrXETJRQeXojIOO+Sxg==", "2f81db90-1c7e-4b0e-882f-8c241f17ce89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd2d2a66-rer7-y9y9-qlpq-w56a9w8s5a32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4916a03b-fcc8-4fbc-b97b-727d609fce4e", "AQAAAAEAACcQAAAAELsb2dCDPG27XsfFEgN92sj2p566XzrlpkpS3e/iehAjrqNiYMs3MWgPvLq8yzZtWQ==", "6c07f850-238c-4a75-a318-e95f87b61f2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k21se8s5-plow-4sw4-qzp0-128fpq6zr8klo",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e789ffaf-15fd-4d7f-b81c-8bab8556168e", "AQAAAAEAACcQAAAAEE22JNtkRuP2f8Z6YHsG58y8LyIlRiOx9G0zAKsX//7ZWD/zAYyBtNcZozLUhdcz8w==", "235bb861-8e49-4216-9fb8-f1a4100ced50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k3fcll56-l458-6871-q3r9-2ve3w9a54s87",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc70103a-35ee-4029-858b-4ef703c57d96", "AQAAAAEAACcQAAAAECeZPooqgow/sXzld/42MWJjqz7L2HJCBGf5XutaN308wEFXojLXjRL6gby1KW8wPA==", "9b5f0beb-ea13-427d-9995-ceeb1b9384d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "QWE15t6s-hfgd-998q-mcs1-pekc249wlfhn",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2551eb7-ab5e-4fe8-a605-1c26ec9f9927", "AQAAAAEAACcQAAAAEHQZ4TllEzXwvIN7C4VT8MKNZbz3wTw1WXhPtJIUpuP57l1atJACP1RHuZppDJ0VUw==", "f5d57920-b72a-4b23-a353-d6a87332c296" });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 10, 22, 54, 48, 38, DateTimeKind.Local).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 10, 22, 54, 48, 38, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 10, 22, 54, 48, 38, DateTimeKind.Local).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 10, 22, 54, 48, 38, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.InsertData(
                table: "Trucks",
                columns: new[] { "Id", "HasCargoSpace", "HasTemperatureControl", "HorsePower", "Make", "Model", "TransportCompanyId", "TruckImageURL" },
                values: new object[,]
                {
                    { 1, false, false, 450, "DAF", "XG+", 1, "/Images/TruckImages/DAF.png" },
                    { 2, false, false, 500, "VOLVO", "FX", 2, "/Images/TruckImages/VOLVO.png" },
                    { 3, true, false, 510, "SCANIA", "R510", 2, "/Images/TruckImages/SCANIA.png" },
                    { 4, true, false, 450, "DAF", "XF+", 2, "/Images/TruckImages/DAF-XF-FRIGO.png" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trucks_TransportCompanyId",
                table: "Trucks",
                column: "TransportCompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Trucks_TruckId",
                table: "Offers",
                column: "TruckId",
                principalTable: "Trucks",
                principalColumn: "Id");
        }
    }
}
