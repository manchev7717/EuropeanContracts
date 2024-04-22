using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EuropeanContracts.Infrastructure.Migrations
{
    public partial class ClaimCompanyNameAddedAndDataSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 9, "user:companyName", "Global workers", "5lk6e95e-lyj5-w25e-8w5q-9q7w8c6u3spo" },
                    { 10, "user:companyName", "LeDecale Boutique", "dd2d2a66-rer7-y9y9-qlpq-w56a9w8s5a32" },
                    { 11, "user:companyName", "SmartSolutions", "d69wrpfj-asdr-uijj-j5ff-5s8q7w4e4532" },
                    { 12, "user:companyName", "Smart Elinas LTD", "k3fcll56-l458-6871-q3r9-2ve3w9a54s87" },
                    { 13, "user:companyName", "MDY Tools", "k21se8s5-plow-4sw4-qzp0-128fpq6zr8klo" },
                    { 14, "user:companyName", "Stay Fly", "QWE15t6s-hfgd-998q-mcs1-pekc249wlfhn" },
                    { 15, "user:companyName", "NG TRANS", "d33qwej9-02ap-11mnl-hflp-lpszavr2s588" },
                    { 16, "user:companyName", "VIOREL TRANS GROUP", "0s3a2w5e-sad5-12s5-owls-psdasfas5f5n" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 16);

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7265a9ae-28b5-468e-aeda-0436d7b00ff6", "AQAAAAEAACcQAAAAELfADnCbGhWu6K8OSJ7G+raluJBrmh3SgquwJ8R3BcIu1MZRmT1EPi9mnyAgW2PqMw==", "e7eeb83d-fd55-40c0-96a0-261b6f9da3cc" });

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
    }
}
