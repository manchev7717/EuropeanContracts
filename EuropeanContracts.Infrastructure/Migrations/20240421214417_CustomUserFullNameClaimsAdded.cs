using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EuropeanContracts.Infrastructure.Migrations
{
    public partial class CustomUserFullNameClaimsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "user:fullName", "Stoyan Stoyanov", "k3fcll56-l458-6871-q3r9-2ve3w9a54s87" },
                    { 2, "user:fullName", "Vasil Vasilev", "k21se8s5-plow-4sw4-qzp0-128fpq6zr8klo" },
                    { 3, "user:fullName", "Todor Todorov", "QWE15t6s-hfgd-998q-mcs1-pekc249wlfhn" },
                    { 4, "user:fullName", "Katerina Katerinova", "d33qwej9-02ap-11mnl-hflp-lpszavr2s588" },
                    { 5, "user:fullName", "Dimitаr Dimitrov", "0s3a2w5e-sad5-12s5-owls-psdasfas5f5n" },
                    { 6, "user:fullName", "Velichko Velichkov", "5lk6e95e-lyj5-w25e-8w5q-9q7w8c6u3spo" },
                    { 7, "user:fullName", "Miroslav Miroslavov", "dd2d2a66-rer7-y9y9-qlpq-w56a9w8s5a32" },
                    { 8, "user:fullName", "Daniela Danielova", "d69wrpfj-asdr-uijj-j5ff-5s8q7w4e4532" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0s3a2w5e-sad5-12s5-owls-psdasfas5f5n",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ae5fc53-6e55-4000-bae1-454ab9db171c", "AQAAAAEAACcQAAAAEH0ooHRZx4tw3R1x5X2/iMECm93V4tz7cjFsAY2CCF2eev+APJNw+fKT1vkfhWFE4A==", "297ee0b8-09f4-41c9-a965-e4bf5e30917e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5lk6e95e-lyj5-w25e-8w5q-9q7w8c6u3spo",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "637186d3-a6f4-4e7a-a25b-b550b4091ace", "AQAAAAEAACcQAAAAEEdB/7y7ZKLJRMaZ8l2rilIGNRqDxrlXbssP6uo7sXPhY9c+q0TPAdKGA0xF1Ou/ZA==", "38f2e616-663d-441c-951e-ef84687479bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d33qwej9-02ap-11mnl-hflp-lpszavr2s588",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be04c565-9480-4b18-b3da-c23574d1530d", "AQAAAAEAACcQAAAAEM/gi1O7JuD4rYVFME5iXRJOiTFQrDk62Ue7C61iUxURdv9PRn0YCL8CryO9gOSH3A==", "1fe9f2c4-1cdd-4db7-8b04-6f8302577d25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d69wrpfj-asdr-uijj-j5ff-5s8q7w4e4532",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "297f8f63-3848-41cd-885b-6ec48a11318a", "AQAAAAEAACcQAAAAEFWK4m+FBpJLRzHk161FIX11wvIwx9kJS8RJNvCQJfoz1z2DQ8qrMBrrEwYCv3Idjg==", "90e782ab-1d36-4240-88f9-7348419f402d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd2d2a66-rer7-y9y9-qlpq-w56a9w8s5a32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec7fe885-e131-4cc7-af7d-d0f05bffba12", "AQAAAAEAACcQAAAAEC9tYY34i7hbMDX70YcVR6uNi3j1hi5oBmN9JOtm5QF8SUOrcSmWFZb5qpfE/6aw5A==", "cd65bddf-38ab-44ee-912b-102ae2fc8c3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k21se8s5-plow-4sw4-qzp0-128fpq6zr8klo",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "903af152-b71d-4c25-be59-c4bf12085405", "AQAAAAEAACcQAAAAEJqr+qcivTYEQ729h44lrzuyi1Bp7uwsg19h47h0wB4UV9clUewYcN74/Uzz7ut71A==", "3a6b07d3-d9c7-44f9-97f2-8ec759c9f6f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k3fcll56-l458-6871-q3r9-2ve3w9a54s87",
                columns: new[] { "ConcurrencyStamp", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7265a9ae-28b5-468e-aeda-0436d7b00ff6", "Stoyanov", "AQAAAAEAACcQAAAAELfADnCbGhWu6K8OSJ7G+raluJBrmh3SgquwJ8R3BcIu1MZRmT1EPi9mnyAgW2PqMw==", "e7eeb83d-fd55-40c0-96a0-261b6f9da3cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "QWE15t6s-hfgd-998q-mcs1-pekc249wlfhn",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7edf612f-169a-4d21-9bd1-24e67d0c6004", "AQAAAAEAACcQAAAAEGRClkjF74K1kfmUNt9fL8pkTT8kNfQ0el7mFNDz32VFk9mDl7s92YI1FryI+aeySw==", "07d6a3ce-b265-4905-83b4-6bcc574f1af2" });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 22, 0, 44, 17, 291, DateTimeKind.Local).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 22, 0, 44, 17, 291, DateTimeKind.Local).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 22, 0, 44, 17, 291, DateTimeKind.Local).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 22, 0, 44, 17, 291, DateTimeKind.Local).AddTicks(1225));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0s3a2w5e-sad5-12s5-owls-psdasfas5f5n",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30644f77-c6be-42f2-b97c-f9abb67baa89", "AQAAAAEAACcQAAAAEKuMkRWrlH+Rlimy6xaGf0sqCFgEbSfaCUlG9u9l69ZC9y9yz66LIUQls0Mdv7n7pw==", "2efc521c-d5ba-4b87-aeab-43cd4991a233" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5lk6e95e-lyj5-w25e-8w5q-9q7w8c6u3spo",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed00b91d-8ded-49ff-978e-2191a87099bd", "AQAAAAEAACcQAAAAEALbVa40ZlkET8PiXWk838zskEjP+cGFgzBxkCuYvnXnI6trnNG7Gst4fEYFP7bUIQ==", "18d1f71f-27e7-425a-ac55-3445a6bbb854" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d33qwej9-02ap-11mnl-hflp-lpszavr2s588",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3692e6b5-5b68-473a-8cfe-5c1abd196c76", "AQAAAAEAACcQAAAAEE9Nq3DaaIjFe7Y0FowM9+ghkviCx7W+Iy1wa65cSZlbvuRnCvDka5pY8vIl/a0zhg==", "5c687641-4568-488b-ba41-88293152aab6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d69wrpfj-asdr-uijj-j5ff-5s8q7w4e4532",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af14ced7-ea4c-46d7-8977-40ddd2ce646b", "AQAAAAEAACcQAAAAEMEHxSn/P7kLvdtnWOzK7gC2OJ9Qq6b6Qq+ei7joVRsvi9FlmYUbf2IdVOhAffQE3Q==", "787cf9f9-6103-4626-80c8-005335beebdb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd2d2a66-rer7-y9y9-qlpq-w56a9w8s5a32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2aebcc8d-af7d-4776-9454-53aec7c0bc0f", "AQAAAAEAACcQAAAAEG2HPER/fwJbQ3PfKcb1mIduJZzoSjL4S64cusobQj//jOXitJnYaHa69JTxYj/F+w==", "2c501401-e4ea-4236-90c6-a16f84e68943" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k21se8s5-plow-4sw4-qzp0-128fpq6zr8klo",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46fecc2f-221b-4d50-9f75-09f9a7e556bf", "AQAAAAEAACcQAAAAEFqVuhY/X/gTg/dXEMx0eDugGbZN2C8VeL6xVRcwdvOT7UAnSX62xa5SQalVDxfBwA==", "f3be701b-f518-4f20-9ca4-78fb8dc9a7b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k3fcll56-l458-6871-q3r9-2ve3w9a54s87",
                columns: new[] { "ConcurrencyStamp", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07a7c3a9-1825-477e-a964-739685b9ee19", " Stoyanov", "AQAAAAEAACcQAAAAEIC/9Tv1pHGGx4ox4Yiq0fARyv0Z7kODHueMziAcOiMwKWq+GyBzxg2nuImV0julqg==", "f8bd36ac-ab37-44ed-b92f-6d038cfbb0bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "QWE15t6s-hfgd-998q-mcs1-pekc249wlfhn",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c020c53-49ba-4875-8421-dd7c56cbda18", "AQAAAAEAACcQAAAAELtDfDzk37chLqqZxlRY3kSGZLxueGJ8byX3keZPL80ysaYMhDTCgoX8ie/D47+w8A==", "14ed5bca-8cb5-4a72-9f83-cef385f59f7b" });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicationDay",
                value: new DateTime(2024, 4, 20, 18, 24, 36, 301, DateTimeKind.Local).AddTicks(7811));

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
    }
}
