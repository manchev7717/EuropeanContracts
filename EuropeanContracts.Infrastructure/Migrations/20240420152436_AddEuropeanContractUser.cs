using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EuropeanContracts.Infrastructure.Migrations
{
    public partial class AddEuropeanContractUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(77)",
                maxLength: 77,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(77)",
                maxLength: 77,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0s3a2w5e-sad5-12s5-owls-psdasfas5f5n",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30644f77-c6be-42f2-b97c-f9abb67baa89", "Dimitаr", "Dimitrov", "AQAAAAEAACcQAAAAEKuMkRWrlH+Rlimy6xaGf0sqCFgEbSfaCUlG9u9l69ZC9y9yz66LIUQls0Mdv7n7pw==", "2efc521c-d5ba-4b87-aeab-43cd4991a233" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5lk6e95e-lyj5-w25e-8w5q-9q7w8c6u3spo",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed00b91d-8ded-49ff-978e-2191a87099bd", "Velichko", "Velichkov", "AQAAAAEAACcQAAAAEALbVa40ZlkET8PiXWk838zskEjP+cGFgzBxkCuYvnXnI6trnNG7Gst4fEYFP7bUIQ==", "18d1f71f-27e7-425a-ac55-3445a6bbb854" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d33qwej9-02ap-11mnl-hflp-lpszavr2s588",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3692e6b5-5b68-473a-8cfe-5c1abd196c76", "Katerina", "Katerinova", "AQAAAAEAACcQAAAAEE9Nq3DaaIjFe7Y0FowM9+ghkviCx7W+Iy1wa65cSZlbvuRnCvDka5pY8vIl/a0zhg==", "5c687641-4568-488b-ba41-88293152aab6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d69wrpfj-asdr-uijj-j5ff-5s8q7w4e4532",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af14ced7-ea4c-46d7-8977-40ddd2ce646b", "Daniela", "Danielova", "AQAAAAEAACcQAAAAEMEHxSn/P7kLvdtnWOzK7gC2OJ9Qq6b6Qq+ei7joVRsvi9FlmYUbf2IdVOhAffQE3Q==", "787cf9f9-6103-4626-80c8-005335beebdb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd2d2a66-rer7-y9y9-qlpq-w56a9w8s5a32",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2aebcc8d-af7d-4776-9454-53aec7c0bc0f", "Miroslav", "Miroslavov", "AQAAAAEAACcQAAAAEG2HPER/fwJbQ3PfKcb1mIduJZzoSjL4S64cusobQj//jOXitJnYaHa69JTxYj/F+w==", "2c501401-e4ea-4236-90c6-a16f84e68943" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k21se8s5-plow-4sw4-qzp0-128fpq6zr8klo",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46fecc2f-221b-4d50-9f75-09f9a7e556bf", "Vasil", "Vasilev", "AQAAAAEAACcQAAAAEFqVuhY/X/gTg/dXEMx0eDugGbZN2C8VeL6xVRcwdvOT7UAnSX62xa5SQalVDxfBwA==", "f3be701b-f518-4f20-9ca4-78fb8dc9a7b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k3fcll56-l458-6871-q3r9-2ve3w9a54s87",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07a7c3a9-1825-477e-a964-739685b9ee19", "Stoyan", " Stoyanov", "AQAAAAEAACcQAAAAEIC/9Tv1pHGGx4ox4Yiq0fARyv0Z7kODHueMziAcOiMwKWq+GyBzxg2nuImV0julqg==", "f8bd36ac-ab37-44ed-b92f-6d038cfbb0bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "QWE15t6s-hfgd-998q-mcs1-pekc249wlfhn",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c020c53-49ba-4875-8421-dd7c56cbda18", "Todor", "Todorov", "AQAAAAEAACcQAAAAELtDfDzk37chLqqZxlRY3kSGZLxueGJ8byX3keZPL80ysaYMhDTCgoX8ie/D47+w8A==", "14ed5bca-8cb5-4a72-9f83-cef385f59f7b" });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PublicationDay", "RecipientId", "TrailerId", "TransporterId", "TruckId" },
                values: new object[] { new DateTime(2024, 4, 20, 18, 24, 36, 301, DateTimeKind.Local).AddTicks(7811), 1, 4, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 20, 18, 24, 36, 301, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 20, 18, 24, 36, 301, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 20, 18, 24, 36, 301, DateTimeKind.Local).AddTicks(7819));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0s3a2w5e-sad5-12s5-owls-psdasfas5f5n",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9cacf5c-6d31-4130-97a2-a60ebd36a8c1", "AQAAAAEAACcQAAAAEKZgfkMsMu2G6yhuZX/D+uh/XTe6yrCcnpdKKHUAvx4urOoBzmxytzMcufu+S+uqaA==", "bcc93bc8-0aaa-4a79-b662-9ca8029f4ed9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5lk6e95e-lyj5-w25e-8w5q-9q7w8c6u3spo",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0edc8b22-a4ae-4c40-807d-7a1a8204da2c", "AQAAAAEAACcQAAAAEIt06UIpJqljODxV53lP6hA76OP11od7OYPlm48xYXBy8s0HB7ucYP3oO9iImKizyw==", "c8057354-e019-4835-ba98-e6c48003848c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d33qwej9-02ap-11mnl-hflp-lpszavr2s588",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3348df2a-c65d-40db-9313-e177aec1ac71", "AQAAAAEAACcQAAAAEF7l5qQUP5oZz9/iao3ROPXgkZaIP+7Eqyt0IU7HVqZOmSCvUaGN3FJXUMMXDZ2cYA==", "b2c1b2f0-e489-441f-9363-50f3dc8af4e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d69wrpfj-asdr-uijj-j5ff-5s8q7w4e4532",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b02eb49-829f-4adf-ba0f-336ca5420a3e", "AQAAAAEAACcQAAAAED7W3yrK6QTgcRdZqNx9sJPkv80d7ftwyTG8FmjafQu8surT/JV/mjJMuBBQJIdBCw==", "e7a8b656-74dd-4a4f-b837-3b9b2fa01980" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd2d2a66-rer7-y9y9-qlpq-w56a9w8s5a32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3593efba-ee6c-44ae-9999-8c7aa1b77db8", "AQAAAAEAACcQAAAAEDwXIUQ/Rwc2PsYMqwIW59Qnw7mFqEILtTapjG01BdWG8zpFT8f7YtJezJr2xw5T7Q==", "9db775d9-8057-4f9f-96f3-4ce3b35d6bfb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k21se8s5-plow-4sw4-qzp0-128fpq6zr8klo",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4ca0b18-1507-447a-85a7-7ae0a9a367fa", "AQAAAAEAACcQAAAAEAltd1kYt1l+GR072mVtVyXeeiW0Eq0+AqFKINkNThi4mN470srL3sb/Jg35aR9eQQ==", "2744ab1e-6231-41b1-9850-74e3848f73df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k3fcll56-l458-6871-q3r9-2ve3w9a54s87",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b35cca3-e652-4b8a-843d-ff234867d123", "AQAAAAEAACcQAAAAEGTQEgdBggpUeKArHzJI78M/olfQjFp2urHDOuGHpxEuSMf/H4HFCdaHS9cpC/iTZA==", "d484fe20-0323-4c8b-a838-70e1b753e8db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "QWE15t6s-hfgd-998q-mcs1-pekc249wlfhn",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eaf5d364-eb19-4242-8452-8aa3fb5f33a2", "AQAAAAEAACcQAAAAEAPRg87R0blCsE7zzKOjFx8jStUCTn5dJGet0BQUeQ3l/b9mh/qAwFBI5v/6kaJFAg==", "4d983c7b-7d23-4c6f-a685-60dea4fc4837" });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PublicationDay", "RecipientId", "TrailerId", "TransporterId", "TruckId" },
                values: new object[] { new DateTime(2024, 4, 12, 19, 4, 6, 311, DateTimeKind.Local).AddTicks(4797), null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 12, 19, 4, 6, 311, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 12, 19, 4, 6, 311, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 12, 19, 4, 6, 311, DateTimeKind.Local).AddTicks(4802));
        }
    }
}
