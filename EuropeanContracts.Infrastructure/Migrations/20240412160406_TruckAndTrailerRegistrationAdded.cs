using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EuropeanContracts.Infrastructure.Migrations
{
    public partial class TruckAndTrailerRegistrationAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RegistrationNumber",
                table: "Trailers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                comment: "Trailer registration number");

            migrationBuilder.AddColumn<string>(
                name: "RegistrationNumber",
                table: "AutoTrucks",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                comment: "Truck registration number");

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
                table: "AutoTrucks",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationNumber",
                value: "CB5758CB");

            migrationBuilder.UpdateData(
                table: "AutoTrucks",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationNumber",
                value: "IAE7551");

            migrationBuilder.UpdateData(
                table: "AutoTrucks",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationNumber",
                value: "B125VTG");

            migrationBuilder.UpdateData(
                table: "AutoTrucks",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationNumber",
                value: "W1255BCV");

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 12, 19, 4, 6, 311, DateTimeKind.Local).AddTicks(4797));

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

            migrationBuilder.UpdateData(
                table: "Trailers",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationNumber",
                value: "UT775");

            migrationBuilder.UpdateData(
                table: "Trailers",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationNumber",
                value: "IJ274MQG");

            migrationBuilder.UpdateData(
                table: "Trailers",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationNumber",
                value: "P79634");

            migrationBuilder.UpdateData(
                table: "Trailers",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationNumber",
                value: "F5011S");

            migrationBuilder.CreateIndex(
                name: "IX_Trailers_RegistrationNumber",
                table: "Trailers",
                column: "RegistrationNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AutoTrucks_RegistrationNumber",
                table: "AutoTrucks",
                column: "RegistrationNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Trailers_RegistrationNumber",
                table: "Trailers");

            migrationBuilder.DropIndex(
                name: "IX_AutoTrucks_RegistrationNumber",
                table: "AutoTrucks");

            migrationBuilder.DropColumn(
                name: "RegistrationNumber",
                table: "Trailers");

            migrationBuilder.DropColumn(
                name: "RegistrationNumber",
                table: "AutoTrucks");

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
        }
    }
}
