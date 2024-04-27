using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EuropeanContracts.Infrastructure.Migrations
{
    public partial class LawyerAndTestUserAndTheirClaimsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0s3a2w5e-sad5-12s5-owls-psdasfas5f5n",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29c387e2-cf87-4710-9668-2faf10421c66", "AQAAAAEAACcQAAAAENjUOXzXLw3et4x6m2Y8SB6e0JN3abzhTV43bmQOUQDeFNpmOB5ClJyUOBRWRnxVTQ==", "bb02a0f4-0808-459d-a22c-69127c1c0fc5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5lk6e95e-lyj5-w25e-8w5q-9q7w8c6u3spo",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08e66b34-281b-4bab-927a-4dd178248825", "AQAAAAEAACcQAAAAEBZiMkmyhbX9+4SiPKJyE7VDN3rmk9MeH6SWR+QwMCUS53tAyrifSHbDM+DD0n6T0g==", "bf428a17-4399-44fc-b123-2d6f0b1cefb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d33qwej9-02ap-11mnl-hflp-lpszavr2s588",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd9b59d6-7bb8-4311-8f03-cc74cf32ca47", "AQAAAAEAACcQAAAAEOptVnVniyFfaEA9QMpZSlM2Cd/wUzLU8enLScIvywdG3Vyw3WuemThglEVbYTF9Ew==", "682f1056-ddcb-40e1-b1f8-90cbf2c421cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d69wrpfj-asdr-uijj-j5ff-5s8q7w4e4532",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6e52677-a0fb-4691-99c2-c72436fb8189", "AQAAAAEAACcQAAAAEEJyWvyF7JaO4thpX7zuJgNyJIJebQyP3kSa4Lhw3sdKzwfaRB95hZZYUrTT6fHu6g==", "bda27e0a-103a-47b1-b870-d0a7db63a9c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd2d2a66-rer7-y9y9-qlpq-w56a9w8s5a32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf475b7f-6f55-44c3-bd17-857525c1cc22", "AQAAAAEAACcQAAAAEHs8l0wyGl3fSD2DDN9jNEriZvcL04BAnlgxwXam3vPQDPG3vElQadvJCMQL1wXV/Q==", "edc59b7d-f45f-46f8-b1d0-cb94dfb0e7f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k21se8s5-plow-4sw4-qzp0-128fpq6zr8klo",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6995043-01a0-47fc-b3c0-4f9c1ef46063", "AQAAAAEAACcQAAAAEOY0yPYymm0t5IpSFfo47LPe3olr1Zxc2WNJnLU4OTFESE4DZK/x7DamfIgMwDoStA==", "d990969c-0b27-46f9-b912-58cc7a1efce0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k3fcll56-l458-6871-q3r9-2ve3w9a54s87",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f02396dd-93a8-414e-986b-fecf7bb1ab18", "AQAAAAEAACcQAAAAEBFKTcIVtPQLMO19HP46epJQSP9ORSOnpcLicTlvFjey2jJyaUSPA4/5LV7C8xfDEQ==", "8313e1aa-dab8-4dfc-876f-94ae5ee85d1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "QWE15t6s-hfgd-998q-mcs1-pekc249wlfhn",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7df9dae6-ad5a-4426-85b7-3fa099febc7e", "AQAAAAEAACcQAAAAEFX1V3Ng/qro+X9N3tNEwE9oPo5KGu4PEsDuE1IPn9QNziYR8na+8wRHBvt31zam5A==", "f31f6269-af3f-48af-93c3-72d1d7b88592" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "069b9834-e57d-47ca-ac9c-78b790b99a59", 0, "5e734902-5c2a-4af3-92ed-94b5862ecc9d", "testUser@mail.com", false, "Test", "Testovic", false, null, "TESTUSER@MAIL.COM", "TESTUSER@MAIL.COM", "AQAAAAEAACcQAAAAEIrZ4kddrh9iFBSd+sWzH7Zo0WrPu3bFKFb7VCdHA3zbnocDd/tW4ALUa9ZUzekwFA==", null, false, "73e4b707-994d-4be6-82de-cc2342ec7d3d", false, "testUser@mail.com" },
                    { "7717fj-aadr-keke-fefe-5s8959d8f9ds82", 0, "8d7a6962-c03f-4182-8b8a-412c85a7c5dd", "lawyer@gmail.com", false, "Advokat", "Advokatov", false, null, "LAWYER@GMAIL.COM", "LAWYER@GMAIL.COM", "AQAAAAEAACcQAAAAEDLGFWbWtEstGJNk21UfvrESLkmcgVlSxDqy/8JvAf13dklYzDYxcALJwPqZ5AFbbw==", null, false, "889ad978-9f20-4ab6-87f2-3d50a1f74669", false, "lawyer@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 27, 11, 26, 48, 614, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 27, 11, 26, 48, 614, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 27, 11, 26, 48, 614, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 27, 11, 26, 48, 614, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 17, "user:fullName", "Advokat Advokatov", "7717fj-aadr-keke-fefe-5s8959d8f9ds82" });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 18, "user:fullName", "Test Testovic", "069b9834-e57d-47ca-ac9c-78b790b99a59" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "069b9834-e57d-47ca-ac9c-78b790b99a59");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7717fj-aadr-keke-fefe-5s8959d8f9ds82");

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
    }
}
