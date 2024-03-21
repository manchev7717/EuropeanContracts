using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EuropeanContracts.Infrastructure.Migrations
{
    public partial class UserMailAndNameNormalizedAndImagePathsChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0s3a2w5e-sad5-12s5-owls-psdasfas5f5n",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e57a24f-ccca-485b-a51a-1d84ae86d735", "FIFTHUSER@MAIL.COM", "FIFTHUSER@MAIL.COM", "AQAAAAEAACcQAAAAEOqVxpEDjWOLQaChK52q39DJxPAIba5gWWj/Uf3uv39yzWJ1vg2rnYbLBZeeiS5lWg==", "c7a87f84-a7c1-444c-904e-ecd871fc19b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5lk6e95e-lyj5-w25e-8w5q-9q7w8c6u3spo",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53db6b78-1645-46b6-b994-168d35f33112", "SIXTHUSER@MAIL.COM", "SIXTHUSER@MAIL.COM", "AQAAAAEAACcQAAAAENaE9DHgv7AMYj2pgqUIi/aMT4re6GomQ4r1Ow15/mzjt6oEXOHaQoUcabFCTWKoYw==", "5c427bda-f961-46ce-b6b1-c37acf213679" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d33qwej9-02ap-11mnl-hflp-lpszavr2s588",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6277f7ed-5b33-450b-a393-39b9df815608", "FOURTHUSER@MAIL.COM", "FOURTHUSER@MAIL.COM", "AQAAAAEAACcQAAAAEAp+Whlm9xSt74clOGsSkIuEg5k8Atm0gR5Vlb8fXy+79Ed5X+P/RSXQENgR6BLM3g==", "3dbaaabf-4936-4236-be32-1b04c229ad06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d69wrpfj-asdr-uijj-j5ff-5s8q7w4e4532",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd1556ec-5070-4e84-937d-387480174ab7", "EIGHTHUSER@MAIL.COM", "EIGHTHUSER@MAIL.COM", "AQAAAAEAACcQAAAAECPFP2/P1Zu/hqGhv6+azKvVwWb4KXLWAJ7ENOtW+zgUyVMzN0THIvPbNbI4KeS/wg==", "7bdeb709-1ddc-4755-8cfd-490baa9f6740" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd2d2a66-rer7-y9y9-qlpq-w56a9w8s5a32",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2b83d7a-c597-42e2-a676-b7c6c5e01699", "SEVENTHUSER@MAIL.COM", "SEVENTHUSER@MAIL.COM", "AQAAAAEAACcQAAAAEJZXr0oL6Rd63K7Ua6OfDOwRPaKtCsiwtBN6RwgOWcpKzQnMZaAVYWvnOifpsLbArw==", "a83b018a-422a-4c51-bd72-181c78286b06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k21se8s5-plow-4sw4-qzp0-128fpq6zr8klo",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab3624ed-aeea-4783-9a59-430181da77ad", "SECONDUSER@MAIL.COM", "SECONDUSER@MAIL.COM", "AQAAAAEAACcQAAAAEMnXY11owgv91hut42F5jDHHnqd62i51UnvjXd+Y3dUo001MYxdH1o9pMpwlcHIXlQ==", "59d70155-0003-47f4-8713-bc1e108298da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k3fcll56-l458-6871-q3r9-2ve3w9a54s87",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f726bac-fea6-4e35-9518-eb3a07787467", "FIRSTUSER@MAIL.COM", "FIRSTUSER@MAIL.COM", "AQAAAAEAACcQAAAAEGkxAri807IlxnEYqR2OSEFXKf6kgOg/SoBxaKKyAPkLUsL7CDejxJlcqqkZ7m8AIA==", "79c96cf7-0740-49ce-95a8-1e590b547657" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "QWE15t6s-hfgd-998q-mcs1-pekc249wlfhn",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "392dff20-f0d9-4e03-b4da-05ad40e60b7d", "THIRDUSER@MAIL.COM", "THIRDUSER@MAIL.COM", "AQAAAAEAACcQAAAAEAFB+oHIFsz/IyH9oA2yAxl3B2tI0V9pIcyx1wvrxIH6GRC17fndO0fWSzC6R7VrUQ==", "3eadabc0-c1fa-4b75-b3d8-ec6e82bf4746" });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ProductImageURL", "PublicationDay" },
                values: new object[] { "/Images/ProductImages/FreshPorkMeat.png", new DateTime(2024, 3, 21, 12, 19, 45, 352, DateTimeKind.Local).AddTicks(5061) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ProductImageURL", "PublicationDay" },
                values: new object[] { "/Images/ProductImages/PlasticWaste.png", new DateTime(2024, 3, 21, 12, 19, 45, 352, DateTimeKind.Local).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ProductImageURL", "PublicationDay" },
                values: new object[] { "/Images/ProductImages/ScaffoldingMaterials.png", new DateTime(2024, 3, 21, 12, 19, 45, 352, DateTimeKind.Local).AddTicks(5066) });

            migrationBuilder.UpdateData(
                table: "Trailers",
                keyColumn: "Id",
                keyValue: 1,
                column: "TrailerImageURL",
                value: "/Images/TrailerImages/Kogel.png");

            migrationBuilder.UpdateData(
                table: "Trailers",
                keyColumn: "Id",
                keyValue: 2,
                column: "TrailerImageURL",
                value: "/Images/TrailerImages/Krone.png");

            migrationBuilder.UpdateData(
                table: "Trailers",
                keyColumn: "Id",
                keyValue: 3,
                column: "TrailerImageURL",
                value: "/Images/TrailerImages/SchmitzCargobull.png");

            migrationBuilder.UpdateData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 1,
                column: "TruckImageURL",
                value: "/Images/TruckImages/DAF.png");

            migrationBuilder.UpdateData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 2,
                column: "TruckImageURL",
                value: "/Images/TruckImages/VOLVO.png");

            migrationBuilder.UpdateData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 3,
                column: "TruckImageURL",
                value: "/Images/TruckImages/SCANIA.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0s3a2w5e-sad5-12s5-owls-psdasfas5f5n",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c1e71e9-c131-4fed-a2df-d3688b835bcb", "fifthuser@mail.com", "fifthuser@mail.com", "AQAAAAEAACcQAAAAEEDhlCEW4eaTwkjOQB19ygYEquxT5icsq2sZ9GJW8jYEEzD5Z+DKcluky+U96t/lyw==", "6f72bc18-4511-4ed9-94f7-0d342513c488" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5lk6e95e-lyj5-w25e-8w5q-9q7w8c6u3spo",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57182430-2609-4219-9f3b-d94d58f756ea", "sixthuser@mail.com", "sixthuser@mail.com", "AQAAAAEAACcQAAAAEEyAB/rIgHaJ5fjpocfGo9KEWITxKaUPZv3BbaF9aYsYaktkjBiP5DcvprMC/Cx5bA==", "bae3c031-8d6b-473e-83ec-4e9202e8a884" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d33qwej9-02ap-11mnl-hflp-lpszavr2s588",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7834771d-180b-454a-a082-0c1009087c4f", "fourthuser@mail.com", "fourthuser@mail.com", "AQAAAAEAACcQAAAAEIQ2auWRgiw4HH/p+s7cbWwBUobJhmOjty072XYr32W1aJVswlJRrCOXS1WiiJydsQ==", "cdaa8c53-752c-4c61-b858-efef37e39ae2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d69wrpfj-asdr-uijj-j5ff-5s8q7w4e4532",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff4724c4-f236-4948-bad0-68244ee5872a", "eighthuser@mail.com", "eighthuser@mail.com", "AQAAAAEAACcQAAAAEG/qEHy5Wja8oMQpFV1EIsMKXMA0mZthe6hJjDkakn7OT9Gc2dqUfeOI6TMEmfNPAg==", "899620af-af17-4f44-ae7d-8cb09c667a6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd2d2a66-rer7-y9y9-qlpq-w56a9w8s5a32",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90422df1-282d-4032-a9e1-f0263825f2c7", "seventhUser@mail.com", "seventhuser@mail.com", "AQAAAAEAACcQAAAAEKXao74RMTfKyHC/ER1TaW0uHohBPUHXQN7co1T7z7GbjnILXa2oFMoBV9Dl11aj4A==", "aeb71576-6c5e-4319-84d5-518e4e044311" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k21se8s5-plow-4sw4-qzp0-128fpq6zr8klo",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bba0ea0-1aa4-4301-8915-43354207bef7", "seconduser@mail.com", "seconduser@mail.com", "AQAAAAEAACcQAAAAEJiXnBoONGexG5Ji/3FnhhLseoVbpGG9yGj6pbAhCHnBh+3O0UaL6GlZo8z1Ov7RIA==", "2bbe57bd-b5fc-41fa-ab3e-b8d7e6c8cf9b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k3fcll56-l458-6871-q3r9-2ve3w9a54s87",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "570cd4c8-bb44-45da-85cf-7f9dc31ec7f7", "firstuser@mail.com", "firstuser@mail.com", "AQAAAAEAACcQAAAAECqpn3Elw03zlbH8LTEQTF+5h5bYyW24V+AGg4UfLWmI+w660z3D+GCa1smN9O7bpw==", "51c92ccf-3f0b-4071-b0be-8c943fa66a7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "QWE15t6s-hfgd-998q-mcs1-pekc249wlfhn",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bced349-6c62-4715-a2d2-a0e4bedf995f", "thirduser@mail.com", "thirduser@mail.com", "AQAAAAEAACcQAAAAEA5+M6LgyCZnidCX7qDulb+g8HFhB4n9jwQmz1sO6mTOz3CoqvlX3k/A+gHMF/DVCg==", "6a1219f6-50be-48da-8474-40da62d55054" });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ProductImageURL", "PublicationDay" },
                values: new object[] { "~/images/ProductImages/FreshPorkMeat.png", new DateTime(2024, 3, 15, 19, 50, 50, 72, DateTimeKind.Local).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ProductImageURL", "PublicationDay" },
                values: new object[] { "~/images/ProductImages/PlasticWaste.png", new DateTime(2024, 3, 15, 19, 50, 50, 72, DateTimeKind.Local).AddTicks(3407) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ProductImageURL", "PublicationDay" },
                values: new object[] { "~/images/ProductImages/ScaffoldingMaterials.png", new DateTime(2024, 3, 15, 19, 50, 50, 72, DateTimeKind.Local).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "Trailers",
                keyColumn: "Id",
                keyValue: 1,
                column: "TrailerImageURL",
                value: "~/Images/TrailersImages/Kogel");

            migrationBuilder.UpdateData(
                table: "Trailers",
                keyColumn: "Id",
                keyValue: 2,
                column: "TrailerImageURL",
                value: "~/Images/TrailersImages/Krone");

            migrationBuilder.UpdateData(
                table: "Trailers",
                keyColumn: "Id",
                keyValue: 3,
                column: "TrailerImageURL",
                value: "~/Images/TrailersImages/SchmitzCargobull");

            migrationBuilder.UpdateData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 1,
                column: "TruckImageURL",
                value: "~/Images/TrackImages/DAF");

            migrationBuilder.UpdateData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 2,
                column: "TruckImageURL",
                value: "~/Images/TrackImages/VOLVO");

            migrationBuilder.UpdateData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 3,
                column: "TruckImageURL",
                value: "~/Images/TrackImages/SCANIA");
        }
    }
}
