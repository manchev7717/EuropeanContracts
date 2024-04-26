using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EuropeanContracts.Infrastructure.Migrations
{
    public partial class TruckWithId3IsNoCargoSpace : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0s3a2w5e-sad5-12s5-owls-psdasfas5f5n",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97e04b72-d4dd-4216-8120-ed4238723174", "AQAAAAEAACcQAAAAELaw0VabaRByzI5vYXpU5T56TsyOH1E5tQgl8aZ5R7wSpEif/dbTAZT7SD26l3MWlw==", "e23a6f3b-444f-44fd-b1a2-c0dc03d2d3a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5lk6e95e-lyj5-w25e-8w5q-9q7w8c6u3spo",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69824d3d-5aad-43da-a6d4-a4b4f0fdc311", "AQAAAAEAACcQAAAAEKlxQu5Ya20XZvpyWsNWCNQbz5UsvnG8KYAYc3j8DaEXZkJ3hNg4ehSwFLWJwIhvtA==", "9a84c7c0-f1f7-485a-b602-63a0d3aa896c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d33qwej9-02ap-11mnl-hflp-lpszavr2s588",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbe5fd7a-fdfc-4e09-ae7a-0f5d1eb60272", "AQAAAAEAACcQAAAAEGd2GbNsiQshps19ci/FOeZn3Nl7JJEcbjGZqgR1uNHKPVa8bQDr+zDJlVTYnAoRIg==", "81acf132-2976-4a1d-bc26-e62a7dce823b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d69wrpfj-asdr-uijj-j5ff-5s8q7w4e4532",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8419810a-88e5-4956-97a1-6dc14773e24c", "AQAAAAEAACcQAAAAEHWB+D20dR94asCuiNts2bhId0Xqv56yJyHFDrN8QjHjETEJLUPliYoq8hLkqQsM0g==", "543a6462-4d53-4b18-9347-ae9a4d4c933f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd2d2a66-rer7-y9y9-qlpq-w56a9w8s5a32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "015036e4-3034-470c-addc-85ef005bee10", "AQAAAAEAACcQAAAAEBwjES/Se7qPjFTy1tc9klH+YqcKo/zyPDd1Do/6QCC+C2G+3Hld0q9yN83SN1nc1w==", "53c65c96-0ceb-4ead-b278-c8508214c4d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k21se8s5-plow-4sw4-qzp0-128fpq6zr8klo",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d37bcb9-8c13-4909-8b3b-7d8aaf948f0f", "AQAAAAEAACcQAAAAEB52uO2/rDLOv1taXKlgmBje38n0Ft6g2qfCzXXVinAJ5ewbAVSoSymBx5FPtMyMIw==", "902d6c3c-3a65-44e5-8cc2-81945f4ab9b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k3fcll56-l458-6871-q3r9-2ve3w9a54s87",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95768fc3-9b2a-4718-bfd6-56c415d048de", "AQAAAAEAACcQAAAAEOFRRg8Bd2q8ddWtxcE2s6nWnQ0Ne6GZzgiI6tVFot0jnR3O2ftfo7M9VXJaGoEXww==", "4b370df1-6a9e-46d7-a5e3-de42f7f00ec8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "QWE15t6s-hfgd-998q-mcs1-pekc249wlfhn",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0648e8d0-326a-43cb-9d9f-233948db584a", "AQAAAAEAACcQAAAAEG7z1rIh0NHPv5b+2Mb9UMmj//XT8OF7aNb0AhaWl5eNEx4fWA29kGCNBqUJ0g24iw==", "6b0476d2-25bd-45bb-8ebd-a041a4140a71" });

            migrationBuilder.UpdateData(
                table: "AutoTrucks",
                keyColumn: "Id",
                keyValue: 3,
                column: "HasCargoSpace",
                value: false);

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 26, 20, 4, 16, 925, DateTimeKind.Local).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 26, 20, 4, 16, 925, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 26, 20, 4, 16, 925, DateTimeKind.Local).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 26, 20, 4, 16, 925, DateTimeKind.Local).AddTicks(9486));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0s3a2w5e-sad5-12s5-owls-psdasfas5f5n",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06234f05-d74f-4db2-b3a5-e6a33fbcd940", "AQAAAAEAACcQAAAAEKlUFJ+ql1COknfSwhGamV4mg1T6gCqH4I6UGw2t4WGON/dhgQZVVMDL3ZQT9tWWFw==", "48077bc2-e29a-4219-996a-9336bb65c32b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5lk6e95e-lyj5-w25e-8w5q-9q7w8c6u3spo",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b412a06-1beb-451a-9c6a-a3f9ede7e702", "AQAAAAEAACcQAAAAEHeyL88dqaB+Y6CcRWTsh8MmOhQe8cX4254qEctRtccUBCbPkgMRq8N5Otx6D/qErg==", "81da09df-6acc-4f48-b737-24feea855da3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d33qwej9-02ap-11mnl-hflp-lpszavr2s588",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7ed4943-9169-4479-a28d-3c9adf0bafb2", "AQAAAAEAACcQAAAAEFSdgmq1h9xekIZz/byGKA4jdgfB+JH0/w7Vi3/d2rWb17G3axjYJAAFSRgc0xCgDA==", "5b1c2e83-1ebb-4750-b19d-1301cc3d3302" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d69wrpfj-asdr-uijj-j5ff-5s8q7w4e4532",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1db80df5-6143-4b7d-b78d-5925901e9cf8", "AQAAAAEAACcQAAAAEAKPXT0Zoib7XEwjVUiF28zHx1CTYhdahr2mpFSF9Ec+dYklYlQkw/3NsaPZ3mNwEg==", "b4d6c70b-f858-410c-af43-d99c7423bddf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd2d2a66-rer7-y9y9-qlpq-w56a9w8s5a32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed0c64cd-955e-4e26-a7b8-96d46912fa94", "AQAAAAEAACcQAAAAEO8vnZRyo/jj20BZs9sps2CvnCP/exT4go+mkTd9Yfx6Vo42dC8NxNph6pE1aJQXuA==", "7d674811-5884-41a7-bf58-a37801aaacae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k21se8s5-plow-4sw4-qzp0-128fpq6zr8klo",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58cea3fc-744b-470d-a202-a006b2ee1727", "AQAAAAEAACcQAAAAEAJFN8kGAdMtYAaeXDd+8flcKdN1kUJU8YShwY/WPghuNA54yaJac2u9HAfqJREtOQ==", "ad8c3886-8dba-4fa1-acc8-147c18b9290e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k3fcll56-l458-6871-q3r9-2ve3w9a54s87",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfe3f465-2618-453b-8e27-ac84893061e3", "AQAAAAEAACcQAAAAEER4wWIgjfpLGe8o54xBE2KQe7c6txJDjBEOZkD8r59/1i3vltrpXu1Hqx8qkwiD4w==", "f325afed-e29c-40ba-b17c-8873f5a7e6eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "QWE15t6s-hfgd-998q-mcs1-pekc249wlfhn",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17f8c83b-3e0e-4617-a5b6-79da8c64e2d8", "AQAAAAEAACcQAAAAEHdJqE4hNE+STyAgJarIVoTJ8KccqYeOjElj8CU8z5VJL8GjN2Y3HMwjepVLZQ12kg==", "0be08b77-a1e3-4861-9a78-8647d0adee8e" });

            migrationBuilder.UpdateData(
                table: "AutoTrucks",
                keyColumn: "Id",
                keyValue: 3,
                column: "HasCargoSpace",
                value: true);

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 22, 18, 21, 32, 468, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 22, 18, 21, 32, 468, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 22, 18, 21, 32, 468, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 22, 18, 21, 32, 468, DateTimeKind.Local).AddTicks(663));
        }
    }
}
