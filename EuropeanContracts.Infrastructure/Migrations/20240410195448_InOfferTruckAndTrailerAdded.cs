using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EuropeanContracts.Infrastructure.Migrations
{
    public partial class InOfferTruckAndTrailerAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsContract",
                table: "Offers",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Is the contract concluded");

            migrationBuilder.AddColumn<int>(
                name: "TrailerId",
                table: "Offers",
                type: "int",
                nullable: true,
                comment: "Offer Trailer");

            migrationBuilder.AddColumn<int>(
                name: "TruckId",
                table: "Offers",
                type: "int",
                nullable: true,
                comment: "Offer Truck");

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

            migrationBuilder.CreateIndex(
                name: "IX_Offers_TrailerId",
                table: "Offers",
                column: "TrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_TruckId",
                table: "Offers",
                column: "TruckId");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Trailers_TrailerId",
                table: "Offers",
                column: "TrailerId",
                principalTable: "Trailers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Trucks_TruckId",
                table: "Offers",
                column: "TruckId",
                principalTable: "Trucks",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Trailers_TrailerId",
                table: "Offers");

            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Trucks_TruckId",
                table: "Offers");

            migrationBuilder.DropIndex(
                name: "IX_Offers_TrailerId",
                table: "Offers");

            migrationBuilder.DropIndex(
                name: "IX_Offers_TruckId",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "IsContract",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "TrailerId",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "TruckId",
                table: "Offers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0s3a2w5e-sad5-12s5-owls-psdasfas5f5n",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fbe9f01-467b-484a-ad66-88a36327f3ad", "AQAAAAEAACcQAAAAEDrbPIBvqJx8+9AU/lQB1WSRaPVALu/Wuc9xSURhg88p7pWDE4CZmqWZgAXPI+vOZA==", "99a4a6a2-b852-43b4-89c3-f246588d8d4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5lk6e95e-lyj5-w25e-8w5q-9q7w8c6u3spo",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a82251e-76f5-4544-9a14-dff2ddaa73cf", "AQAAAAEAACcQAAAAEHQCJaWPgpzcPZUHqy4TxYAfv85Xi7P1DqBrwi6lo5mvyZMOKt5ueZFKKlLGoKRIlQ==", "11a9dc08-35fa-4afd-a849-4046c17eb862" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d33qwej9-02ap-11mnl-hflp-lpszavr2s588",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "633acc0d-2caa-4134-bc90-e8015621e229", "AQAAAAEAACcQAAAAEA/W5jyESm+lA/ONCyV1aggm3TfPIvsfqWV4tLHOvDxZ1aMfqp94vlnjB55slQaObA==", "e5dc1041-cf6f-40f9-8638-d2b2a813f0f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d69wrpfj-asdr-uijj-j5ff-5s8q7w4e4532",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f895a5d1-f24e-4186-a79d-5a7dea10d4ef", "AQAAAAEAACcQAAAAEIp527d5Nqf4R5JwxUWkUqDJsvPpGlBi1QPVhVJIXwu+8m+vdI3btfWOQT9ZOf9Tqw==", "b34c41f3-7eed-4fef-be43-7aaa2ef80e2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd2d2a66-rer7-y9y9-qlpq-w56a9w8s5a32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e71656d7-0c1e-4843-9174-6876f3802711", "AQAAAAEAACcQAAAAEFlcs8l0S90D5kFu/eL3udM2I7PfgS+xAql7XnxhJcWZ13czRGLkRO1sy3vMvdXbnw==", "56ddbc30-2d29-44d6-8c35-d4a0f9df222c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k21se8s5-plow-4sw4-qzp0-128fpq6zr8klo",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbe20167-7524-40b0-ac75-c0631e422a35", "AQAAAAEAACcQAAAAEBrutkKLtRDoPCEeEdaEuUshL1jqQKTRNJhIz/OQdAMXywWslvKA89KxFvG5Sx8rWA==", "e0945df1-92d5-4d9c-b2e8-e48c7ffd02b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k3fcll56-l458-6871-q3r9-2ve3w9a54s87",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e01ac4ad-cc72-4814-84dd-f1f225d3c9cc", "AQAAAAEAACcQAAAAEFNZVNatHnmHMKFh0HnmJX5A9dIEI165ChOv8sZwdZZ7FQOJ1KD35nvE8Hp+HFOCog==", "fcd25a19-f1f5-473b-8bfb-b0565f5094af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "QWE15t6s-hfgd-998q-mcs1-pekc249wlfhn",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "129784b4-29ff-4ebe-9eda-e99ed2f65ba0", "AQAAAAEAACcQAAAAEL+V6GmloDztwLh2HI/65VfXXq/SMPXu/vdETID7AaPDNQ2/vT+1g1Hv9YX+2zXIsA==", "882aa5fa-0447-40a9-993f-dd7480b62777" });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 10, 21, 38, 29, 168, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 10, 21, 38, 29, 168, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 10, 21, 38, 29, 168, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 10, 21, 38, 29, 168, DateTimeKind.Local).AddTicks(2763));
        }
    }
}
