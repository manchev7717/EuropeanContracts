using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EuropeanContracts.Infrastructure.Migrations
{
    public partial class NameOnFirstSupplierChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0s3a2w5e-sad5-12s5-owls-psdasfas5f5n",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98cc59a3-89d6-4d09-b2ca-2272897d175b", "AQAAAAEAACcQAAAAEPZ7SJFNOWolYXV8Hm4MtwY5lDR/NGROLwkXXORGmrsUtouMYVAggory2uGzgI7g1g==", "26c46aad-363b-4832-83cf-47ad59b19bc1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5lk6e95e-lyj5-w25e-8w5q-9q7w8c6u3spo",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34faee56-e9d3-4f35-b4ae-fcad98ca7e1b", "AQAAAAEAACcQAAAAEChvtj269vU93e6UKqM5+l/mU6hP4lhNns8z2VYSxsQpP7P0obWFqNTvOwZIIY5lWQ==", "8e167fb9-eed0-4d98-ad83-893a8208d769" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d33qwej9-02ap-11mnl-hflp-lpszavr2s588",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4192fd53-d4ab-4c04-856e-377b2df28009", "AQAAAAEAACcQAAAAEMcm6G5TT6SoR52PqjlasYDLH2JurVj54XFBggwoWBxQteDrl5deAe0OrW6Q5WS8DA==", "90b68ada-7563-4892-a2be-deddb6e9dca7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d69wrpfj-asdr-uijj-j5ff-5s8q7w4e4532",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd9856ab-c940-4ce2-88cc-ae1129769781", "AQAAAAEAACcQAAAAEABp4dV3qmgLY3uyzK6AFZhnGwL+1OZ/Aq7qRYLdP2DhP9q+iFlILM0P0KXU2feCZQ==", "6a0581e6-3f0c-40c4-bb7a-40e7f4d4c23a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd2d2a66-rer7-y9y9-qlpq-w56a9w8s5a32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8496502f-96d7-49fb-8e09-cb9e07e5180c", "AQAAAAEAACcQAAAAEEa2eMnZYAoT2ta+G1/gUUijcm5r46Bxv7ZqZuBTn7OcjVfnZHmu5QCkOonCW1dEEg==", "e7fab72e-9e32-4014-b807-80dea66b4bba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k21se8s5-plow-4sw4-qzp0-128fpq6zr8klo",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97728e8a-1f23-4782-9494-cc8c10ec9ddc", "AQAAAAEAACcQAAAAEOt6mk7TlCJhDgCx/xJ54Ld/Y2ZyDxYbv4WbmXSjvpGcKFdlhshY9dMZBjpGPi/tpQ==", "5f224549-4e8e-480d-aea9-1971109cc956" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k3fcll56-l458-6871-q3r9-2ve3w9a54s87",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b29288c-ef6e-4e6b-afb7-593ea4e4d004", "AQAAAAEAACcQAAAAEFJ3DZu0G5eTZNBzXkNJcTjDsJS8NeMkmxAXQCnzPd7z+vKS4Tfa40ArTLcW1hx1mA==", "afcdeeed-51ed-4696-ae4e-4b26b5ae21e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "QWE15t6s-hfgd-998q-mcs1-pekc249wlfhn",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce314e74-4ec6-416f-b293-ac8e120e792b", "AQAAAAEAACcQAAAAEAA8NQE892ORYUk6y3nqOT5ZhBqr0qzTayXhx9kpWj+ThNqHaqVLpLXf0/pznTHRmg==", "95f29e49-66cd-4201-a100-a3b19c774827" });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicationDay",
                value: new DateTime(2024, 3, 27, 13, 8, 6, 422, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicationDay",
                value: new DateTime(2024, 3, 27, 13, 8, 6, 422, DateTimeKind.Local).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicationDay",
                value: new DateTime(2024, 3, 27, 13, 8, 6, 422, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "SuppliersCompanies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Smart Elinas LTD");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0s3a2w5e-sad5-12s5-owls-psdasfas5f5n",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e57a24f-ccca-485b-a51a-1d84ae86d735", "AQAAAAEAACcQAAAAEOqVxpEDjWOLQaChK52q39DJxPAIba5gWWj/Uf3uv39yzWJ1vg2rnYbLBZeeiS5lWg==", "c7a87f84-a7c1-444c-904e-ecd871fc19b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5lk6e95e-lyj5-w25e-8w5q-9q7w8c6u3spo",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53db6b78-1645-46b6-b994-168d35f33112", "AQAAAAEAACcQAAAAENaE9DHgv7AMYj2pgqUIi/aMT4re6GomQ4r1Ow15/mzjt6oEXOHaQoUcabFCTWKoYw==", "5c427bda-f961-46ce-b6b1-c37acf213679" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d33qwej9-02ap-11mnl-hflp-lpszavr2s588",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6277f7ed-5b33-450b-a393-39b9df815608", "AQAAAAEAACcQAAAAEAp+Whlm9xSt74clOGsSkIuEg5k8Atm0gR5Vlb8fXy+79Ed5X+P/RSXQENgR6BLM3g==", "3dbaaabf-4936-4236-be32-1b04c229ad06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d69wrpfj-asdr-uijj-j5ff-5s8q7w4e4532",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd1556ec-5070-4e84-937d-387480174ab7", "AQAAAAEAACcQAAAAECPFP2/P1Zu/hqGhv6+azKvVwWb4KXLWAJ7ENOtW+zgUyVMzN0THIvPbNbI4KeS/wg==", "7bdeb709-1ddc-4755-8cfd-490baa9f6740" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd2d2a66-rer7-y9y9-qlpq-w56a9w8s5a32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2b83d7a-c597-42e2-a676-b7c6c5e01699", "AQAAAAEAACcQAAAAEJZXr0oL6Rd63K7Ua6OfDOwRPaKtCsiwtBN6RwgOWcpKzQnMZaAVYWvnOifpsLbArw==", "a83b018a-422a-4c51-bd72-181c78286b06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k21se8s5-plow-4sw4-qzp0-128fpq6zr8klo",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab3624ed-aeea-4783-9a59-430181da77ad", "AQAAAAEAACcQAAAAEMnXY11owgv91hut42F5jDHHnqd62i51UnvjXd+Y3dUo001MYxdH1o9pMpwlcHIXlQ==", "59d70155-0003-47f4-8713-bc1e108298da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k3fcll56-l458-6871-q3r9-2ve3w9a54s87",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f726bac-fea6-4e35-9518-eb3a07787467", "AQAAAAEAACcQAAAAEGkxAri807IlxnEYqR2OSEFXKf6kgOg/SoBxaKKyAPkLUsL7CDejxJlcqqkZ7m8AIA==", "79c96cf7-0740-49ce-95a8-1e590b547657" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "QWE15t6s-hfgd-998q-mcs1-pekc249wlfhn",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "392dff20-f0d9-4e03-b4da-05ad40e60b7d", "AQAAAAEAACcQAAAAEAFB+oHIFsz/IyH9oA2yAxl3B2tI0V9pIcyx1wvrxIH6GRC17fndO0fWSzC6R7VrUQ==", "3eadabc0-c1fa-4b75-b3d8-ec6e82bf4746" });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicationDay",
                value: new DateTime(2024, 3, 21, 12, 19, 45, 352, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicationDay",
                value: new DateTime(2024, 3, 21, 12, 19, 45, 352, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicationDay",
                value: new DateTime(2024, 3, 21, 12, 19, 45, 352, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "SuppliersCompanies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "SmartSolutions");
        }
    }
}
